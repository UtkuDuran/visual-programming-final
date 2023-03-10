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
    public class ALICIFIRMAIslem
    {
        public static void Kaydet(ALICIFIRMA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("insert into ALICIFIRMA(AD,SORUMLU,TEL)values (@AD,@SORUMLU,@TEL)");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Parameters.AddWithValue("@SORUMLU", p.SORUMLU);
            cm.Parameters.AddWithValue("@TEL", p.TEL);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Guncelle(ALICIFIRMA p)
        {
            MySqlCommand cm = DBCon.KomutOlustur("update ALICIFIRMA set AD=@AD,SORUMLU=@SORUMLU,TEL=@TEL where ID=@ID");
            cm.Parameters.AddWithValue("@AD", p.AD);
            cm.Parameters.AddWithValue("@SORUMLU", p.SORUMLU);
            cm.Parameters.AddWithValue("@TEL", p.TEL);
            cm.Parameters.AddWithValue("@ID", p.ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Sil(int ID)
        {
            MySqlCommand cm = DBCon.KomutOlustur("delete from ALICIFIRMA where ID=@ID");
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static ALICIFIRMA IdyeGoreALICIFIRMAGetir(int ID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from ALICIFIRMA where ID=@ID", DBCon.BaglantiYap());
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                ALICIFIRMA a = new ALICIFIRMA();
                a.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                a.AD = Convert.ToString(dt.Rows[0]["AD"]);
                a.SORUMLU = Convert.ToString(dt.Rows[0]["SORUMLU"]);
                a.TEL = Convert.ToString(dt.Rows[0]["TEL"]);
                return a;
            }
            else { return null; }
        }


        public static DataTable TumKayitlar()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from ALICIFIRMA", DBCon.BaglantiYap());
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
