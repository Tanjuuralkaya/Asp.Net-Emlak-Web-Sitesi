using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class adminpanel_Login : System.Web.UI.Page
{
    Metodlar klas = new Metodlar(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        TextKullaniciAdi.Text = "";
        TextSifre.Text = "";

    }
    protected void btnGiriş_Click(object sender, EventArgs e)
    {
        

      // DataRow dt = klas.GetDataRow("Select * From Kullanici Where KullaniciAdi = '" + Seo.injection(txtKullaniciAdiii.Text)  "' " );
        //DataRow dt = klas.GetDataRow("Select * from Kullanici where KullaniciAdi = '" + txtKullaniciAdiii.Text+ "' and Sifre = '" + txtSifre.Text +"'");
        DataRow dt = klas.GetDataRow("Select * From Kullanici Where KullaniciAdi ='"+TextKullaniciAdi.Text+"' and Sifre='"+TextSifre.Text+"'");
        Console.WriteLine(TextKullaniciAdi.Text.ToString());
        if (dt != null)
        {
            Session["KullaniciId"] = dt["KullaniciId"].ToString(); 
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblBilgi.Text = "Kullanıcı Adı ve Şifre Hatalı";
            TextKullaniciAdi.Text = "";
            TextSifre.Text = "";

        }
    }
}