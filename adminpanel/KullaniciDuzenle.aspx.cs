using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class adminpanel_KullaniciDüzenle : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string KullaniciId = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        KullaniciId = Request.QueryString["KullaniciId"];

        if (Page.IsPostBack == false)
        {

            DataRow drKullanici = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId where dbo.Kullanici.KullaniciId =" +KullaniciId);
            txtKullaniciAdi.Text = drKullanici["KullaniciAdi"].ToString();
            txtAdsoyad.Text = drKullanici["Adsoyad"].ToString();
            txtSifre.Text = drKullanici["Sifre"].ToString();
            txtEmail.Text = drKullanici["Email"].ToString();
            txtGsm.Text = drKullanici["Gsm"].ToString();
            txtGsm2.Text = drKullanici["Gsm2"].ToString();
            txtFax.Text = drKullanici["Fax"].ToString();
            txtTelefon.Text = drKullanici["Tel"].ToString();
            txtTelefon2.Text = drKullanici["Tel2"].ToString();
            txtDogum.Text = drKullanici["Dogum"].ToString();
            


            il();
            dddil.SelectedValue = drKullanici["ilId"].ToString();//burada selected valu e ıle secili olanı anlamına gelmektedır
            ilce();
            ddlİlcesi.SelectedValue = drKullanici["ilceId"].ToString();
            Gorev();
            ddlGorevi.SelectedValue = drKullanici["GrupId"].ToString();
            if (drKullanici["Cinsiyet"].ToString() == "Erkek")
            {
                rdbErkek.Checked = true;
            }
            else
            {
                rdbBayan.Checked = true;
            }

            if (drKullanici["Engel"].ToString() == "1")
            {
                rdEvet.Checked = true;
            }
            else
            {
                rdHayır.Checked = true;
            }
        }
        
    }
    void il()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");        
        dddil.DataTextField = "ilAdi";
        dddil.DataValueField = "ilId";
        dddil.DataSource = dtiller;
        dddil.DataBind();
    }
    void ilce()
    {
        //burada kullanıcının ilcesını cekerken yapaıyoruz
        DataRow drKullanici = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId where dbo.Kullanici.KullaniciId =" + KullaniciId); 
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + drKullanici["ilId"].ToString() + " order by [ilceAdi] ");//burada ilidsi bellı olan tum tüm ilceleri ceksın dedım::)
        ddlİlcesi.DataTextField = "ilceAdi";
        ddlİlcesi.DataValueField = "ilceId";
        ddlİlcesi.DataSource = dtilce;
        ddlİlcesi.DataBind();
    }

    void ilce2()
    {
        //burada hangı il secılmıssse bunun ilceeleri sıralancak dropdownlist ilcemızde :) 
        DataRow drKullanici = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.KullaniciGrup.GrupAdi FROM dbo.Kullanici INNER JOIN dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.KullaniciGrup ON dbo.Kullanici.GrupId = dbo.KullaniciGrup.GrupId where dbo.Kullanici.KullaniciId =" + KullaniciId);
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + dddil.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddlİlcesi.DataTextField = "ilceAdi";
        ddlİlcesi.DataValueField = "ilceId";
        ddlİlcesi.DataSource = dtilce;  
        ddlİlcesi.DataBind();
    }

    void Gorev()
    {

        DataTable dtGorevi = klas.GetDataTable("Select * From KullaniciGrup");
        ddlGorevi.DataTextField = "GrupAdi";
        ddlGorevi.DataValueField = "GrupId";
        ddlGorevi.DataSource = dtGorevi;
        ddlGorevi.DataBind();
    }
    


    protected void dddil_SelectedIndexChanged1(object sender, EventArgs e)
    {
         ilce2();
    }
    protected void btnGüncelle_Click1(object sender, EventArgs e)
    {
        string cinsiyet ="";
        string engel = "";
        if (rdbErkek.Checked==true)
	    {
            cinsiyet="Erkek";		 
	    }   
        else
	    {
            cinsiyet="Bayan";
	    }

        if (rdEvet.Checked)
        {
            engel = "0"; 
        }
        else
        {
            engel = "1";
        }
        DataRow drkul = klas.GetDataRow("Select * from Kullanici Where KullaniciId ="+KullaniciId);// 
        DataRow drKullanici = klas.GetDataRow("Select * From Kullanici Where KullaniciAdi='" +txtKullaniciAdi.Text + "' and KullaniciAdi!='" + drkul["KullaniciAdi"].ToString() +"'");//burada birkullanıcıAdi ile aynı ısım varmı varsa kaale almasın esıt degılse o zaaman hata mesajı versın
        if (drKullanici == null)//Yani boyle bir satır yoksa 
        {
            DataRow drEmail = klas.GetDataRow("Select * From Kullanici Where Email ='" + txtEmail.Text + "' and Email!='" + drkul["Email"].ToString() + "'");
            if (drEmail == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update Kullanici Set GrupId=@GrupId,ilId=@ilId, ilceId=@ilceId,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Adsoyad=@Adsoyad,Email=@Email,Adres=@Adres,Tel=@Tel,Tel2=@Tel2,Gsm=@Gsm,Gsm2=@Gsm2,Fax=@Fax,Cinsiyet =@Cinsiyet, Dogum =@Dogum, Engel =@Engel  where KullaniciId =" + KullaniciId, baglanti);
                cmd.Parameters.Add("GrupId", ddlGorevi.SelectedValue);
                cmd.Parameters.Add("ilId", dddil.SelectedValue);
                cmd.Parameters.Add("ilceId", ddlİlcesi.SelectedValue);
                cmd.Parameters.Add("KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.Add("Sifre", txtSifre.Text); 
                cmd.Parameters.Add("Adsoyad", txtAdsoyad.Text);
                cmd.Parameters.Add("Email", txtEmail.Text);
                cmd.Parameters.Add("Adres", txtAdres.Text);
                cmd.Parameters.Add("Tel", txtTelefon.Text);
                cmd.Parameters.Add("Tel2", txtTelefon2.Text);
                cmd.Parameters.Add("Gsm", txtGsm.Text);
                cmd.Parameters.Add("Gsm2", txtGsm2.Text);
                cmd.Parameters.Add("Fax", txtFax.Text);
                cmd.Parameters.Add("Cinsiyet",cinsiyet);
                cmd.Parameters.Add("Dogum",txtDogum.Text);
                cmd.Parameters.Add("Engel",engel);
                cmd.ExecuteNonQuery();
                Response.Redirect("AdminYonetimi.aspx");
            }
            else
            {
                lblBilgii.Text = "Bu Email Kullanılmaktadır.";
            }
        }
        else
        {
            lblBilgii.Text = "Böyle Kullanıcı Bulunmaktadır.";
        }
        
    }
 
}