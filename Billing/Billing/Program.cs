using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Billing
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin login = new FrmLogin();

            /*
            SQLiteConnection m_dbConnection;
            string path = @"C:\sqlite\data\data.db";
            m_dbConnection = new SQLiteConnection("Data Source=" + path + "; Version=3;");
            m_dbConnection.Open();
            string sql = "select count(0) as name from teachers";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name: " + reader["name"]);
            }*/

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmSearch(login.userId, login.username));
            }
            
        }
    }
}
