using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;


public partial class ProfilDüzenle : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KullaniciId"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (Page.IsPostBack == false)
        {

            il();
            meslek();
            ilce();
            //ddlilce.Enabled = false;
            FileUpload fileup = (FileUpload)Master.Master.FindControl("imgResim");
            DataRow drKul = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.Meslekler.MeslekAdi FROM dbo.Kullanici INNER JOIN dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.Meslekler ON dbo.Kullanici.MeslekId = dbo.Meslekler.MeslekId where KullaniciId=" + Session["KullaniciId"]);
            txtAdSoyad.Text = drKul["Adsoyad"].ToString();
            ddlil.SelectedValue = drKul["ilId"].ToString();
            ddlilce.SelectedValue = drKul["ilceId"].ToString();
            ddlMeslek.SelectedValue = drKul["MeslekAdi"].ToString();
            txtTel.Text = drKul["Tel"].ToString();
            txtTel2.Text = drKul["Tel2"].ToString();
            txtGsm.Text = drKul["Gsm"].ToString();
            txtGsm2.Text = drKul["Gsm2"].ToString();
            txtFax.Text = drKul["Fax"].ToString();
            txtAdres.Text = drKul["Adres"].ToString();
            imgResim.ImageUrl = "KullaniciResimleri/" + drKul["Resim"].ToString();
       
        }

    }
    void il()
    {
        DataTable dtiller = klas.GetDataTable("Select * from iller " + " order by [ilAdi]");
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
    }
    void ilce()
    {
        DataTable dtilceler = klas.GetDataTable("Select * from ilceler order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }
    void ilce2()
    {
        DataTable dtilceler = klas.GetDataTable("Select * from ilceler Where ilId=" + ddlil.SelectedValue + " order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }
    void meslek()
    {
        DataTable dtMeslekler = klas.GetDataTable("Select * from Meslekler " + " order by [MeslekAdi]");
        ddlMeslek.DataTextField = "MeslekAdi";
        ddlMeslek.DataValueField = "MeslekId";
        ddlMeslek.DataSource = dtMeslekler;
        ddlMeslek.DataBind();
    }
    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce2();
        ddlilce.Items.Insert(0,new ListItem("İlçe Seçiniz","0"));
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        string resimadi = ""; string uzanti = "";
        if (fuResim.HasFile)
        {
            //eski resimler siliniyor.
            string resimadi2 = "";
            resimadi2 = klas.GetDataCell("Select Resim from Kullanici Where KullaniciId=" + Session["KullaniciId"]);
            if (resimadi2 != "ResimYok.png")//eger resim secili degilse eski resmı alcak eger secılmısse eskı resmı sılecek
            {
                if (resimadi2 != "ResimYok2.png") 
                {
                    FileInfo fiResim = new FileInfo(Server.MapPath("KullaniciResimleri/" + resimadi2));
                    fiResim.Delete();
                }
            }
            //resim yükleniyor
            DataRow drEmail = klas.GetDataRow("Select Email from Kullanici Where KullaniciId=" + Session["KullaniciId"]);
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
            resimadi = Seo.injection(drEmail["Email"].ToString()) + DateTime.Now.Day + uzanti;
            fuResim.SaveAs(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));

            int deger = 250;//resmimi ufaltacağım boyut

            Bitmap resim = new Bitmap(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));//silinecek resmimizi bitmap nesnesi yapıyoruz.
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;

                if (Genislik >= deger)//boyutlandırma burada yapılıyor.
                {
                    Oran = Genislik / Yukseklik;//yeni oranı belirliyoruz.
                    Genislik = deger; //genişlik belirlediğimiz değere ayarlanıyor.
                    Yukseklik = deger / Oran;//yeni yükseklik değeri hesaplanıyor.

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("KullaniciResimleri/" + resimadi));

                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();
                }
                else
                {
                    fuResim.SaveAs(Server.MapPath("KullaniciResimleri/" + resimadi));//eğer yüklenecek resim değer değişkeninden ufaksa direk yüklenecek.
                }

            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();
        }
        else
        {
            DataRow drResimadi = klas.GetDataRow("Select Resim from Kullanici Where KullaniciId=" + Session["KullaniciId"]);//yani else kısmında her hangı bır resım secılmedıyse o eskı olan verı tabanındakı resmı al ve tekrar yerıne koy anlamında
            resimadi = drResimadi["Resim"].ToString(); 
        }

        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update Kullanici Set Resim=@Resim, Adsoyad=@Adsoyad, ilId=@ilId, ilceId=@ilceId, MeslekId=@MeslekId, Tel=@Tel, Tel2=@Tel2, Gsm=@Gsm, Gsm2=@Gsm2, Fax=@Fax, Adres=@Adres Where KullaniciId=" + Session["KullaniciId"], baglanti);
        cmd.Parameters.Add("Resim", resimadi);
        cmd.Parameters.Add("Adsoyad", txtAdSoyad.Text);
        cmd.Parameters.Add("ilId", ddlil.SelectedValue);
        cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);
        cmd.Parameters.Add("MeslekId", ddlMeslek.SelectedValue);
        cmd.Parameters.Add("Tel", txtTel.Text);
        cmd.Parameters.Add("Tel2", txtTel2.Text);
        cmd.Parameters.Add("Gsm", txtGsm.Text);
        cmd.Parameters.Add("Gsm2", txtGsm2.Text);
        cmd.Parameters.Add("Fax", txtFax.Text);
        cmd.Parameters.Add("Adres", txtAdres.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("Profilim.aspx");
    }
}