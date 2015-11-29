using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminpanel_GrupYonetimi : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string GrupId = "";
    string islem = "";
     
     protected void Page_Load(object sender, EventArgs e)
     {
         //SqlConnection con = klas.baglan();
         //SqlCommand cmd = new SqlCommand("SELECT GrupAdi From KullaniciGrup", con);
         //SqlDataAdapter da = new SqlDataAdapter(cmd);
         //DataSet ds = new DataSet();
         //da.Fill(ds);
         //rpGruplar.DataSource = ds;
         //rpGruplar.DataBind();
         //con.Close();

        
        //////////////////////////////////////////////////////

         //burada GrupId ye gore girilen verileri cektık
      
         GrupId = Request.QueryString["GrupId"];
         islem = Request.QueryString["islem"];
         if (islem == "sil")
         {
             klas.cmd("Delete From KullaniciGrup Where GrupId=" + GrupId);
         }

         DataTable dtGruplar = klas.GetDataTable("Select * From KullaniciGrup");
         rpGruplar.DataSource = dtGruplar;//burada getdatatable ile veri tabanımızdakinı yansıttık
         rpGruplar.DataBind();

     }
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Insert into KullaniciGrup (GrupAdi) Values(@GrupAdi)",baglanti);
        cmd.Parameters.Add("GrupAdi", txtGrupAdi.Text);
        cmd.ExecuteNonQuery();//bunla kapanıyo
        //baglanti.Close();
        Response.Redirect("GrupYonetimi.aspx");//ekleme yaptıktan sonra tekrar aynı gruba gelsın dıye yapıldı
       

    }
}