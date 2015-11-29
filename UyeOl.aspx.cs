using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

public partial class UyeOl : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    int sayi; int sayi2;
   

    protected void Page_Load(object sender, EventArgs e)
    {
        Random sayi2 = new Random();
        sayi = sayi2.Next();
        if (Page.IsPostBack == false)
        {
            il();
            ddlil.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            meslek();
            ddlMeslek.Items.Insert(0, new ListItem("Meslek Seçiniz","0"));
            
        }

    }
    void il()
    {
        //2.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
    }
    void ilce()
    {
        //3. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddlil.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilce;
        ddlilce.DataBind();
    }
    void meslek()
    {
        //1. dropdownlıst ıcın
        DataTable dtMeslekler = klas.GetDataTable("Select * from Meslekler " + " order by [MeslekAdi]");
        ddlMeslek.DataTextField = "MeslekAdi";
        ddlMeslek.DataValueField = "MeslekId";
        ddlMeslek.DataSource = dtMeslekler;
        ddlMeslek.DataBind();
    }

    protected void ddlil_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlil.SelectedItem.Text != "Şehir Seçiniz")
        {
            ilce();
            ddlilce.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
        }
    }
    protected void btnKaydet_Click1(object sender, EventArgs e)
    {
        string cinsiyet = ""; string resimadi = ""; string grupid = ""; string uzanti = "";
        if (rdErkek.Checked == true)
        {
            cinsiyet = "Erkek";
        }
        else
	    {
            cinsiyet = "Bayan";
	    }
        ///////////////////////////////burada kullanıcı grup id sıne gore atama yapıldı radıobutonlardan/////////////////////
        if (rdKullanici.Checked == true)
        {
            grupid = klas.GetDataCell("Select GrupId from KullaniciGrup Where GrupAdi='" + "Kullanıcı" + "'");
        }
        else
        {
            grupid = klas.GetDataCell("Select GrupId from KullaniciGrup Where GrupAdi='" + "Emlakçı" + "'");
        }
        ///////////////////burada veritabanına resim gonderme işlemi yapıldı//////////////

        if (fuResim.HasFile)
        {
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);//burda uzantıyı alıyoruz
            resimadi = Seo.injection(txtEmail.Text) + DateTime.Now.Day + uzanti;// burada resimadini alıyoruz hangı gun eklemıs o sekılde alıp uzantıyı eklıyoruz.
            fuResim.SaveAs(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));//kullaniciresimleri adlı dosya olusturdum ve burada depolanıyor sonra bunları daha sonra sılecez

            int deger = 250;//resmimi ufaltacağım boyut

            Bitmap resim = new Bitmap(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));//silinecek resmimizi bitmap nesnesi yapıyoruz.
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;

                if (Genislik >= deger)//boyutlandırma burada yapılıyor. yani resmin genıslıgı 250 den buyukse bu ıslemlerı yapacak
                {
                    Oran = Genislik / Yukseklik;//yeni oaranı burada belırılıyoz                   
                    Genislik = deger; //genişlik belirlediğimiz değere ayarlanıyor.
                    Yukseklik = deger / Oran;//yeni yükseklik değeri hesaplanıyor.

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));//burada yenıden boyutlandırma yaptım
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);//bitmap nesnesını olustrudum /yanı yenı olusan resmı yenı degerlere donusturuyom boyut olarak oonuda son rasım olrak belırledım 
                    SonResim.Save(Server.MapPath("KullaniciResimleri/" + resimadi));//resmin adını ve nereye kaydecegımı bbelırledım

                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();
                }
                else
                {
                    fuResim.SaveAs(Server.MapPath("KullaniciResimleri/" + resimadi));//eğer yüklenecek resim değer değişkeninden ufaksa direk yüklenecek.
                }

            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));//ilk olusturdugum silinecej artı uzanti ifadesini vererek resmi tanımladım
            fisilinecek.Delete();// bu işem ile de ilk olusturdugum gecıcı resmımı siliyorum
        }
        else
        {
            if (rdErkek.Checked)
                resimadi = "ResimYok.png";
            else
                resimadi = "ResimYok2.png";
        }
  


        DataRow drMail = klas.GetDataRow("Select * from Kullanici Where Email='" + Seo.injection(txtEmail.Text) + "'");//ekleme yaptıgımızdan dolayı boyle bır email varmı yok mu kontrol ederek işlemeri yapıyoruz
        //yani bu emaılde kullnıcı yoksa ekleme ıslemlerını yapsın anlamında kullanılır. yai kontrol edıyo var olup olmadıgını
        if (drMail == null)//bos ıse yanı yoksa asagıdakı ıslemlerı yap
        {
           
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into Kullanici (Email, Sifre,Adsoyad,Gsm,Gsm2,Tel,Tel2,Fax,MeslekId,Cinsiyet,ilId,ilceId,Dogum,Resim,Adres,GrupId,Sayi) Values(@Email,@Sifre,@Adsoyad,@Gsm,@Gsm2,@Tel,@Tel2,@Fax,@MeslekId,@Cinsiyet,@ilId,@ilceId,@Dogum,@Resim,@Adres,@GrupId,@Sayi)", baglanti);
            cmd.Parameters.Add("Email", Seo.injection(txtEmail.Text));
            cmd.Parameters.Add("Sifre", Seo.injection(txtSifre.Text));
            //cmd.Parameters.Add("KullaniciAdi");
            cmd.Parameters.Add("Adsoyad", txtAdSoyad.Text);
            cmd.Parameters.Add("Gsm", txtGsm.Text);
            cmd.Parameters.Add("Gsm2", txtGsm2.Text);
            cmd.Parameters.Add("Tel", txtTel.Text);
            cmd.Parameters.Add("Tel2", txtTel2.Text);
            cmd.Parameters.Add("Fax", txtFax.Text);
            cmd.Parameters.Add("MeslekId", ddlMeslek.SelectedValue);
            cmd.Parameters.Add("Cinsiyet", cinsiyet);
            cmd.Parameters.Add("ilId", ddlil.SelectedValue);
            cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);
            cmd.Parameters.Add("Dogum", txtDogum.Text);
            cmd.Parameters.Add("Resim", resimadi);
            cmd.Parameters.Add("Adres", txtAdres.Text);
            cmd.Parameters.Add("GrupId", grupid);
            cmd.Parameters.Add("Sayi", sayi);
            cmd.ExecuteNonQuery();
           // Response.Redirect("UyeTamam.aspx?Email=" + txtEmail.Text);
            Response.Redirect("UyeTamam.aspx?Adsoyad="+txtAdSoyad.Text);
        }
        else
        {
            lblBilgi.Text = "Böyle Kullanıcı Bulunmaktadır";
        }
     }
}