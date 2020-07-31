using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace BuyersTerminal
{
    public class Utilities
    {
        public MySqlConnection DB { get; set; }
        public string ConnectionString { get; set; }

        //Open the connection and call it by name
        public void Open(string cs)
        {
            ConnectionString = Connection(cs);
            DB = new MySqlConnection(ConnectionString);
            DB.Open();
        }
        //Close the connection
        public void Close()
        {
            if (DB.State == ConnectionState.Open)
                DB.Close();
        }
        //Check the connection State
        public ConnectionState DBState
        {
            get
            {
                if (DB != null)
                    return DB.State;
                else
                    return ConnectionState.Closed;
            }
        }

        public string Connection(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
