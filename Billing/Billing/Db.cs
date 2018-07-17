using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace Billing
{
    class Db
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        String FName;

        //konstruktor
        public Db()
        {
            string name = @"C:\sqlite\data\data.db";
            bool czyistnieje = File.Exists(name) ? true : false;
            this.FName = name;
            if (czyistnieje)
            {
                this.sqlite_conn = new SQLiteConnection("Data Source=" + name + ";Version=3;New=False;Compress=True;");
                this.sqlite_conn.Open();
                this.sqlite_cmd = sqlite_conn.CreateCommand();
            }
            else
                return;
        }

        //konstruktor otwiera bazę istniejącą
        public Db(string name)
        {
            bool czyistnieje = File.Exists(name) ? true : false;
            this.FName = name;
            if (czyistnieje)
            {
                this.sqlite_conn = new SQLiteConnection("Data Source=" + name + ";Version=3;New=False;Compress=True;");
                this.sqlite_conn.Open();
                this.sqlite_cmd = sqlite_conn.CreateCommand();
            }
            else
                return;
        }


        //insert
        public bool commend(string com)
        {
            this.sqlite_cmd.CommandText = com;
            this.sqlite_cmd.ExecuteNonQuery();
            return true;
        }

        //query
        public SQLiteDataReader comSelect(string com)
        {
            this.sqlite_cmd.CommandText = com;
            return this.sqlite_cmd.ExecuteReader();
        }

        //close
        public bool close()
        {
            this.sqlite_conn.Close();
            return true;
        }


    }
}
