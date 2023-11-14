using Microsoft.VisualBasic.Logging;

namespace MemoTest
{
    static class Program
    {
        public static int Difficulty; // 0 is Easy difficulty, while 1 is hard difficulty
        public static int Category;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Controladores.Conexion.OpenConnection();
            new Menu().ShowDialog();
           
            if(Difficulty == 0)
            {
                Application.Run(new Game());
            }
            else
            {
                Application.Run(new GameHard());
            }
            // Originally, we hade made only one panel, but it bugged out so much that we found it better to just do 2 because of the time we had left
            
            Controladores.Conexion.CloseConnection();
        }
    }
}