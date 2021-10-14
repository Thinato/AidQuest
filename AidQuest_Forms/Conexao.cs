using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AidQuest_Forms
{
    class Conexao
    {
        public SQLiteConnection connection;
        public Conexao()
        {
            connection = new SQLiteConnection("Data Source=AidQuest.db");

        }
        public void Connect()
        {
            connection.Open();
        }
        public void Disconnect()
        {
            connection.Close();
        }
    }
}
