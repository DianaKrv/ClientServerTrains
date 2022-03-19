using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLClass.conn = new MySql.Data.MySqlClient.MySqlConnection();
            SQLClass.conn.ConnectionString =
                "Server=localhost;Database=test;port=3306;User Id=root";
            SQLClass.conn.Open();
            Application.Run(new MainForm());

            SQLClass.conn.Close();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static string Login = "Mikki";
    }
}
