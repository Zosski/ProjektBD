using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projekt_BazyDanych
{
    class Mysql
    {
        public Mysql(string server, string db, string user, string password)
        {
            serwer = server;
            Nazwa_Bazy = db;
            uName = user;
            pass = password;
            polaczenie = new MySqlConnection();
        }

        public void SetNewConnectionString(string server, string db, string user, string password)
        {
            serwer = server;
            Nazwa_Bazy = db;
            uName = user;
            pass = password;
        }

        public string serwer = String.Empty;
        public string Nazwa_Bazy = String.Empty;

        private string uName = null;
        public string Uzytkownik
        {
            set { uName = value; }
        }

        private string pass = null;
        public string Haslo
        {
            set { pass = value; }
        }

        private MySqlConnection polaczenie = null;
        public MySqlConnection Polaczenie
        {
            get { return polaczenie; }
        }

        public MySqlCommand Query(string zapytanie)
        {
            if (polaczenie.State == ConnectionState.Open)
            {
                MySqlCommand query = new MySqlCommand(zapytanie, polaczenie);
                return query;
            }
            
            return null;
        }

        public ConnectionState Polacz()
        {
            if (Polaczenie == null || Polaczenie.State == ConnectionState.Closed)
            {
                if (String.IsNullOrEmpty(Nazwa_Bazy) || String.IsNullOrEmpty(uName) || String.IsNullOrEmpty(pass))
                    return ConnectionState.Broken;
                polaczenie.ConnectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", serwer, Nazwa_Bazy, uName, pass);
                try
                {
                    polaczenie.Open();
                }
                catch(MySqlException ex)
                {
                    throw ex;
                }
                return polaczenie.State;
            }
            return polaczenie.State;
        }

        public ConnectionState Rozlacz()
        {
            polaczenie.Close();
            return polaczenie.State;
        }

    }
}