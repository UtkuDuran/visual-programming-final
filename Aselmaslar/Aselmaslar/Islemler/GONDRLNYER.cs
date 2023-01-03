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
public class GONDRLNYERIslem
{
public static void Kaydet(GONDRLNYER p)
{
MySqlCommand cm = DBCon.KomutOlustur("insert into GONDRLNYER(AD)values (@AD)");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Guncelle(GONDRLNYER p)
{
  MySqlCommand cm = DBCon.KomutOlustur("update GONDRLNYER set AD=@AD where ID=@ID");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Parameters.AddWithValue("@ID", p.ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Sil(int ID)
{
MySqlCommand cm = DBCon.KomutOlustur("delete from GONDRLNYER where ID=@ID");
cm.Parameters.AddWithValue("@ID", ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static GONDRLNYER IdyeGoreGONDRLNYERGetir(int ID)
{
MySqlDataAdapter da = new MySqlDataAdapter("select * from GONDRLNYER where ID=@ID",DBCon.BaglantiYap());
da.SelectCommand.Parameters.AddWithValue("@ID", ID);
DataTable dt = new DataTable();
da.Fill(dt);
if (dt.Rows.Count != 0)
{
GONDRLNYER g = new GONDRLNYER();
g.ID=Convert.ToInt32(dt.Rows[0]["ID"]);
g.AD=Convert.ToString(dt.Rows[0]["AD"]);
return g;
}
else { return null; }
}


public static DataTable TumKayitlar()
{
MySqlDataAdapter da = new MySqlDataAdapter("select * from GONDRLNYER",DBCon.BaglantiYap());
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
DBCon.BaglantiYap().Open();MySqlCommand cm =  DBCon.KomutOlustur(sql);
cm.Connection.Open();
cm.ExecuteNonQuery();
}


}
}
