using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            // Application.Run(new FormMainUser());
            // Application.Run(new FormMainAdmin());
            //Application.Run(new Boss());
            //  Application.Run(new SeatSelectionForm());
            // Application.Run(new Staff());
           // Application.Run(new Chatbot());


        }
    }
}
