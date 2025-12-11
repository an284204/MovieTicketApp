from flask import Flask, request, jsonify
import requests

API_KEY = "9f9377fd4fad792d8db55a9ad70f55aa"
BASE_URL = "https://api.themoviedb.org/3"

app = Flask(__name__)

def search_movie_or_character(query: str):
    """
    Tìm phim liên quan đến tên phim hoặc nhân vật bằng TMDb API.
    Ưu tiên tiếng Việt, fallback sang tiếng Anh nếu không có.
    """
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

    # Thử tiếng Việt trước
    results = fetch("vi")
    if not results:  # fallback sang tiếng Anh
        results = fetch("en")

    movies = []
    for movie in results[:3]:  # giới hạn 3 kết quả
        movie_id = movie.get("id")
        genres = []

        # Gọi API chi tiết phim để lấy thể loại
        if movie_id:
            detail_url = f"{BASE_URL}/movie/{movie_id}"
            params = {"api_key": API_KEY, "language": "vi"}
            detail_resp = requests.get(detail_url, params=params)
            if detail_resp.status_code == 200:
                detail_data = detail_resp.json()
                genres = [g["name"] for g in detail_data.get("genres", [])]

        movies.append({
            "title": movie.get("title"),
            "overview": movie.get("overview"),
            "genres": genres
        })
    return movies

@app.route("/ask", methods=["POST"])
def ask():
    data = request.json
    query = data.get("query", "")
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

if __name__ == "__main__":
    app.run(port=5000)