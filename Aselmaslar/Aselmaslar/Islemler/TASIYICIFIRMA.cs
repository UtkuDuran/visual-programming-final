using System;
using System.Collections.Generic;
using System.Text;
using Aselmaslar.Nesneler;
using Aselmaslar.Saglayici;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Aselmaslar.Islemler
{
    public class TASIYICIFIRMAIslem
    {
        public static void Kaydet(TASIYICIFIRMA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("insert into TASIYICIFIRMA(AD)values (@AD)");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Guncelle(TASIYICIFIRMA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("update TASIYICIFIRMA set AD=@AD where ID=@ID");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Parameters.AddWithValue("@ID", p.ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Sil(int ID)
        {
            MySqlCommand cm = DBCon.KomutOlustur("delete from TASIYICIFIRMA where ID=@ID");
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static TASIYICIFIRMA IdyeGoreTASIYICIFIRMAGetir(int ID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from TASIYICIFIRMA where ID=@ID", DBCon.BaglantiYap());
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                TASIYICIFIRMA t = new TASIYICIFIRMA();
                t.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                t.AD = Convert.ToString(dt.Rows[0]["AD"]);
                return t;
            }
            else { return null; }
        }


        public static DataTable TumKayitlar()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from TASIYICIFIRMA", DBCon.BaglantiYap());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable VeriKumesi(string sql)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, DBCon.BaglantiYap());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static void KomutIslet(string sql)
        {
            DBCon.BaglantiYap().Open(); MySqlCommand cm = DBCon.KomutOlustur(sql);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
        }


    }
}
