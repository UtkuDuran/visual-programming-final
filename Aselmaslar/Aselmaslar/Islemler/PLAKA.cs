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
    public class PLAKAIslem
    {
        public static void Kaydet(PLAKA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("insert into PLAKA(AD,TASYCFRM_ID)values (@AD,@TASYCFRM_ID)");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Guncelle(PLAKA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("update PLAKA set AD=@AD,TASYCFRM_ID=@TASYCFRM_ID where ID=@ID");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Parameters.AddWithValue("@ID", p.ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Sil(int ID)
        {
            MySqlCommand cm = DBCon.KomutOlustur("delete from PLAKA where ID=@ID");
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static PLAKA IdyeGorePLAKAGetir(int ID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from PLAKA where ID=@ID", DBCon.BaglantiYap());
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                PLAKA p = new PLAKA();
                p.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                p.AD = Convert.ToString(dt.Rows[0]["AD"]);
                p.TASYCFRM_ID = Convert.ToInt32(dt.Rows[0]["TASYCFRM_ID"]);
                return p;
            }
            else { return null; }
        }


        public static DataTable TumKayitlar()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from PLAKA", DBCon.BaglantiYap());
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
