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
public class URUNIslem
{
public static void Kaydet(URUN p)
{
MySqlCommand cm = DBCon.KomutOlustur("insert into URUN(AD,GRUP_ID)values (@AD,@GRUP_ID)");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Parameters.AddWithValue("@GRUP_ID", p.GRUP_ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Guncelle(URUN p)
{
MySqlCommand cm = DBCon.KomutOlustur("update URUN set AD=@AD,GRUP_ID=@GRUP_ID where ID=@ID");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Parameters.AddWithValue("@GRUP_ID", p.GRUP_ID);
cm.Parameters.AddWithValue("@ID", p.ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Sil(int ID)
{
MySqlCommand cm = DBCon.KomutOlustur("delete from URUN where ID=@ID");
cm.Parameters.AddWithValue("@ID", ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static URUN IdyeGoreURUNGetir(int ID)
{
MySqlDataAdapter da = new MySqlDataAdapter("select * from URUN where ID=@ID",DBCon.BaglantiYap());
da.SelectCommand.Parameters.AddWithValue("@ID", ID);
DataTable dt = new DataTable();
da.Fill(dt);
if (dt.Rows.Count != 0)
{
URUN u = new URUN();
u.ID=Convert.ToInt32(dt.Rows[0]["ID"]);
u.AD=Convert.ToString(dt.Rows[0]["AD"]);
u.GRUP_ID=Convert.ToInt32(dt.Rows[0]["GRUP_ID"]);
return u;
}
else { return null; }
}


public static DataTable TumKayitlar()
{
MySqlDataAdapter da = new MySqlDataAdapter("select * from URUN", DBCon.BaglantiYap());
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
