using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;




namespace Aselmaslar.Saglayici
{
    public class DBCon
    {
        public static MySql.Data.MySqlClient.MySqlConnection BaglantiYap()
        {
            return new MySqlConnection(@"Data Source=DB.db");
        }
        public static MySqlCommand KomutOlustur(string cmd)
        {
            return string.IsNullOrEmpty(cmd) ? null : new MySqlCommand(cmd, BaglantiYap());
        }
    }
}
