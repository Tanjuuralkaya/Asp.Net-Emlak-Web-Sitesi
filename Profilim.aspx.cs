using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Profilim : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KullaniciId"] == null)
        {
            Response.Redirect("Default.aspx");
                        
        }
        else
        {
            LinkButton lblProfil = (LinkButton)Master.Master.FindControl("lbProfil");//master.master dememım sebebı ben profılıme gıdeyım lınkbutonunu ana masterdan sonra masterpage2 de acmıstım o yuzden ıkı tane dedım ıkıncı masteda oldugu ıcın
            lblProfil.Visible = false;//profılımı duzenle sayfasına gıderken profıme gıdeyım yazısını gostermeyecek

            DataRow drKul = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.Meslekler.MeslekAdi FROM dbo.Kullanici INNER JOIN dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.Meslekler ON dbo.Kullanici.MeslekId = dbo.Meslekler.MeslekId where KullaniciId="+Session["KullaniciId"]);
            lblAdSoyad.Text = drKul["Adsoyad"].ToString();
            lblil.Text = drKul["ilAdi"].ToString();
            lblilce.Text = drKul["ilceAdi"].ToString();
            lblMeslek.Text = drKul["MeslekAdi"].ToString();
            lblEmail.Text = drKul["Email"].ToString();




            if (drKul["Tel"].ToString() != null && drKul["Tel"].ToString() != "")
            {
                lblTel.Text = drKul["Tel"].ToString();
            }
            else
            {
                lblTel.Text = "Telefonu Yoktur";
            }

            if (drKul["Tel2"].ToString() != null && drKul["Tel2"].ToString() != "")
            {
                lblTel2.Text = drKul["Tel2"].ToString();
            }
            else
            {
                lblTel2.Text = "Telefon Yoktur";
            }

            if (drKul["Gsm"].ToString() != null && drKul["Gsm"].ToString() != "")
            {
                lblGsm.Text = drKul["Gsm"].ToString();
            }
            else
            {
                lblGsm.Text = "Boyle Gsm Yoktur.";
            }

            if (drKul["Gsm2"].ToString() != null && drKul["Gsm2"].ToString() != "")
            {
                lblGsm2.Text = drKul["Gsm2"].ToString();
            }
            else
            {
                lblGsm2.Text = "Boyle Gsm Yoktur.";
            }


            if (drKul["Fax"].ToString() != null && drKul["Fax"].ToString() != "")
            {
                lblFax.Text = drKul["Fax"].ToString();
            }
            else
            {
                lblFax.Text = "Boyle Fax Yoktur.";
            }

            if (drKul["Adres"].ToString() != null && drKul["Adres"].ToString() != "")
            {
                lblAdres.Text = drKul["Adres"].ToString();
            }
            else
            {
                lblAdres.Text = "Boyle Adres Yoktur.";
            }
            if (drKul["Resim"].ToString() != null && drKul["Resim"].ToString() != "")
            {
                ltrlResim.Text = drKul["Resim"].ToString();
            }
            else
            {
                ltrlResim.Text = "Resim yok";
            }
        }

    }
    protected void btnDuzenle_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProfilDuzenle.aspx");
    }
}