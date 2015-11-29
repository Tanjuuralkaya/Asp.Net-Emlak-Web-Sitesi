using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for Metodlar
/// </summary>
/// 


public class Metodlar
{

    public Metodlar()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public SqlConnection baglan()
    {
        SqlConnection baglanti = new SqlConnection("Data Source=URALKAYA\\SQLSERVERTANJU; Database= EvBul; User Id= sa; Password=12369874");
        baglanti.Open();
        return (baglanti);

    }
    public int cmd(string sqlcumle)
    {
        SqlConnection baglan = this.baglan();
        SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
        int sonuc = 0;
        try
        {
            sonuc = sorgu.ExecuteNonQuery();
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message + "(" + sqlcumle + ")");
        }

        sorgu.Dispose();//nesneyle işimiz bıttıgınde kullanılır
        sorgu.Clone();//Clone metodu ile hedef gösterilen dizinin aynısından tüm elemanları ile beraber kopyalanır.
        baglan.Dispose();
        return (sonuc);
    }



    public DataTable GetDataTable(string sql)
    {
        SqlConnection baglanti = this.baglan();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
        DataTable dt = new DataTable();
        try
        {
            adapter.Fill(dt);
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message + " (" + sql + ")");
        }
        adapter.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return dt;
    }

    public DataRow GetDataRow(string sql)
    {
        DataTable table = GetDataTable(sql);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0];
    }

    public string GetDataCell(string sql)
    {
        DataTable table = GetDataTable(sql);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0][0].ToString();
    }
}
