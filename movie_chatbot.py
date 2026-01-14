from flask import Flask, request, jsonify
import requests

API_KEY = "9f9377fd4fad792d8db55a9ad70f55aa"
BASE_URL = "https://api.themoviedb.org/3"

app = Flask(__name__)

# Biến trạng thái hội thoại
user_state = {
    "mode": None,   # "genre" hoặc "movie"
    "genre": None,
    "page": 1
}

def search_by_genre(genre_id: int, page: int = 1):
    """Tìm phim hot theo thể loại, phân trang 5 phim mỗi lần."""
    url = f"{BASE_URL}/discover/movie"
    params = {
        "api_key": API_KEY,
        "language": "vi",
        "sort_by": "popularity.desc",
        "with_genres": genre_id,
        "page": page
    }
    response = requests.get(url, params=params)
    if response.status_code != 200:
        return []
    results = response.json().get("results", [])
    return [m["title"] for m in results[:5]]

def search_movie_or_character(query: str):
    """Tìm phim theo tên phim hoặc nhân vật."""
    def fetch(lang="vi"):
        url = f"{BASE_URL}/search/movie"
        params = {
            "api_key": API_KEY,
            "query": query,
            "language": lang
        }
        response = requests.get(url, params=params)
        if response.status_code != 200:
            return []
        return response.json().get("results", [])

    results = fetch("vi")
    if not results:
        results = fetch("en")

    movies = []
    for movie in results[:3]:
        movie_id = movie.get("id")
        genres = []
        if movie_id:
            detail_url = f"{BASE_URL}/movie/{movie_id}"
            params = {"api_key": API_KEY, "language": "vi"}
            detail_resp = requests.get(detail_url, params=params)
            if detail_resp.status_code == 200:
                detail_data = detail_resp.json()
                genres = [g["name"] for g in detail_data.get("genres", [])]

        overview = movie.get("overview", "")
        if overview and len(overview) > 200:
            overview = overview[:200] + "..."

        movies.append({
            "title": movie.get("title"),
            "overview": overview,
            "genres": genres
        })
    return movies

@app.route("/ask", methods=["POST"])
def ask():
    global user_state
    data = request.json
    query = data.get("query", "").strip().lower()

    # Nếu người dùng chào
    if query in ["hi", "hello", "xin chào", "chào"]:
        user_state = {"mode": None, "genre": None, "page": 1}
        return jsonify({"answer": "👋 Chào bạn! Bạn muốn tìm theo [phim] hay [thể loại]?"})

    # Nếu người dùng chọn thể loại
    if query == "thể loại":
        user_state["mode"] = "genre"
        return jsonify({"answer": "📂 Mời bạn nhập tên thể loại (ví dụ: hành động, hài, kinh dị...)"})

    # Nếu người dùng chọn phim
    if query == "phim":
        user_state["mode"] = "movie"
        return jsonify({"answer": "🎬 Mời bạn nhập tên phim hoặc nhân vật để tìm thông tin."})

    # Nếu đang ở chế độ thể loại
    genre_map = {
        "hành động": 28,
        "phiêu lưu": 12,
        "hài": 35,
        "kinh dị": 27,
        "lãng mạn": 10749,
        "hoạt hình": 16,
    }
    if user_state["mode"] == "genre":
        if query == "thêm" and user_state["genre"]:
            user_state["page"] += 1
            movies = search_by_genre(user_state["genre"], user_state["page"])
            if not movies:
                return jsonify({"answer": "❌ Không còn phim nào nữa."})
            reply = "➕ Thêm 5 phim nữa:\n" + "\n".join(f"- {m}" for m in movies)
            return jsonify({"answer": reply})
        elif query in genre_map:
            user_state["genre"] = genre_map[query]
            user_state["page"] = 1
            movies = search_by_genre(user_state["genre"], user_state["page"])
            if not movies:
                return jsonify({"answer": f"❌ Không tìm thấy phim thể loại '{query}'."})
            reply = f"🔥 Top 5 phim hot thể loại '{query}':\n" + "\n".join(f"- {m}" for m in movies)
            reply += "\n👉 Gõ 'thêm' để xem thêm 5 phim nữa."
            return jsonify({"answer": reply})

    # Nếu đang ở chế độ phim
    if user_state["mode"] == "movie":
        movies = search_movie_or_character(query)
        if not movies:
            return jsonify({"answer": f"❌ Không tìm thấy kết quả cho '{query}'."})
        reply = f"📽️ Kết quả cho '{query}':\n"
        for m in movies:
            reply += f"- {m['title']}\n"
            if m['overview']:
                reply += f"  Tóm tắt: {m['overview']}\n"
            if m['genres']:
                reply += f"  Thể loại: {', '.join(m['genres'])}\n"
        return jsonify({"answer": reply})

    return jsonify({"answer": "❓ Xin lỗi, mình chưa hiểu. Bạn hãy nhập 'phim' hoặc 'thể loại' nhé."})

if __name__ == "__main__":
    app.run(port=5000)