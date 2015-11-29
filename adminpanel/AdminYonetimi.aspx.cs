using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminpanel_AdminYonetimi : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string aranacakk = "";
    string islem = "";
    string KullaniciId;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            aranacakk = Request.QueryString["aranacak"];
            islem = Request.QueryString["islem"];
            KullaniciId = Request.QueryString["KullaniciId"];
        }
        catch (Exception)
        {
        }
        if (islem == "sil")
        {
            klas.cmd("Delete From Kullanici Where KullaniciId=" +KullaniciId);
            Response.Redirect("AdminYonetimi.aspx");
            
        }


        if (aranacakk!=null )// burada ara butonuna tıklanınca veri tabanımızdakı verılerı cekecek
        {
            DataTable dtAra = klas.GetDataTable("SELECT dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId where  Adsoyad like '%"+ aranacakk +"%' or KullaniciAdi like '%"+ aranacakk +"%' " );

            dlAra.DataSource = dtAra;
            dlAra.DataBind();
            if (dtAra.Rows.Count > 0)
            {
                lblAra.Text = Convert.ToString(dtAra.Rows.Count) + " Adet Kullanıcı Var";
                dlAra.Visible = true;
            }
            else
            {
                lblAra.Text = " Kimse bulunamadı";
                dlAra.Visible = false;  
            }
        }
       

    }
    protected void btnYonetici_Click(object sender, EventArgs e)
    {
        DataRow drKullanci = klas.GetDataRow("Select GrupId From KullaniciGrup where GrupAdi='"+ "Yönetici" + "'" );
        DataTable dtKullanici = klas.GetDataTable("SELECT dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId  where  dbo.KullaniciGrup.GrupId= '" + drKullanci["GrupId"].ToString() + "'");
        dlKullanici.DataSource = dtKullanici;
        dlKullanici.DataBind();
        if (dtKullanici.Rows.Count == 0)
        {
            dlKullanici.Visible = false;
        }
        else
        {
            dlKullanici.Visible = true;
        }
        
    }
    protected void btnYardimci_Click(object sender, EventArgs e)
    {
        DataRow drKullanci = klas.GetDataRow("Select GrupId From KullaniciGrup where GrupAdi='" + "Yardımcı Yönetici" + "'");
        DataTable dtKullanici = klas.GetDataTable("SELECT dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId  where  dbo.KullaniciGrup.GrupId= '" + drKullanci["GrupId"].ToString() + "'");
        dlKullanici.DataSource = dtKullanici;
        dlKullanici.DataBind();
        if (dtKullanici.Rows.Count == 0)
        {
            dlKullanici.Visible = false;
        }
        else
        {
            dlKullanici.Visible = true;
        }

    }
    protected void btnEmlakcı_Click(object sender, EventArgs e)
    {
        DataRow drKullanci = klas.GetDataRow("Select GrupId From KullaniciGrup where GrupAdi='" + "Emlakçılar" + "'");
        DataTable dtKullanici = klas.GetDataTable("SELECT dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId  where  dbo.KullaniciGrup.GrupId= '" + drKullanci["GrupId"].ToString() + "'");
        dlKullanici.DataSource = dtKullanici;
        dlKullanici.DataBind();
        if (dtKullanici.Rows.Count == 0)
        {
            dlKullanici.Visible = false;
        }
        else
        {
            dlKullanici.Visible = true;
        }
    }

    protected void btnKullanicilar_Click(object sender, EventArgs e)
    {
        DataRow drKullanci = klas.GetDataRow("Select GrupId From KullaniciGrup where GrupAdi='" + "Kullanıcılar" + "'");
        DataTable dtKullanici = klas.GetDataTable("SELECT dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId  where  dbo.KullaniciGrup.GrupId= '" + drKullanci["GrupId"].ToString() + "'");
        dlKullanici.DataSource = dtKullanici;
        dlKullanici.DataBind();
        if (dtKullanici.Rows.Count == 0)
        {
            dlKullanici.Visible = false;
        }
        else
        {
            dlKullanici.Visible = true;
        }
    }
    protected void btnSon_Click(object sender, EventArgs e)
    {
        DataTable dtKullanici = klas.GetDataTable("SELECT Top 10 dbo.Kullanici.*, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId ");
        dlKullanici.DataSource = dtKullanici;
        dlKullanici.DataBind();
        if (dtKullanici.Rows.Count == 0)
        {
            dlKullanici.Visible = false;
        }
        else
        {
            dlKullanici.Visible = true;
        }
    }
    protected void btnAra_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminYonetimi.aspx?aranacak="+Seo.injection(txtAra.Text));//burada tmızleyıp lacak ıcındekı degerı aranacak a atacak 
    }
}