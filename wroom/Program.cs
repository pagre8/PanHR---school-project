using System;
using System.Windows.Forms;

namespace wroom
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Logowanie logowanie = new Logowanie();

            Application.Run(logowanie);

            if(!logowanie.logged) return;               
            

            Pracownicy pracownicy = new Pracownicy();

            Application.Run(pracownicy);
        }
    }
}
