using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using System.Security;
using System.Web.Security;

public partial class MasterPage : System.Web.UI.MasterPage
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Expires = 0;//burası ornegın bır ınternet kafede olalım gırısı yaptıgımızda gerı gelmek ısterız 
        Response.Cache.SetNoStore();//gerı gelınce sıfrem yada emaılımın gorunmesını ıstemeyız o yuzden bunu kullnabılırız
        Response.AppendHeader("Pragma", "no-cache");

        if (Request.Cookies["Cerezim"] != null)
        {
            HttpCookie yakalancerez = Request.Cookies["Cerezim"];                                  //Cookie yi yakalıyoruz.
            Session["KullaniciId"] = yakalancerez.Values["KullaniciId"];                           //burada sessionlara degerlerimiz atıyoruz
            Session["AdSoyad"] = yakalancerez.Values["AdSoyad"];
        }


        if (Session["KullaniciId"]!= null)//yani giriş yapıldıysa
        {
            pnlKulBilgi.Visible = true;
            pnlKulGiris.Visible = false;
            lblAdSoyad.Text = Session["Adsoyad"].ToString();
        }
        else
        {
            pnlKulGiris.Visible = true;
            pnlKulBilgi.Visible = false;
        }
    }
    protected void imgGiris_Click(object sender, ImageClickEventArgs e)
    {
        DataRow drMail = klas.GetDataRow("Select * from Kullanici Where Email='" + txtEmail.Text + "'");//burada mail veritabanına kayıtlı mı degilmi onun kontrolunu yapıyor
        if (drMail != null)
        {
            //DataRow drOnay = klas.GetDataRow("Select * from Kullanici Where Email='" + txtEmail.Text + "' and Onay=1");//burda kullnıcı adının girdigi e maili alcakveri tabanında arayacak bulacak bakacak o satır varsa onaylayacak 
            //if (drOnay != null)//onay bos degılse bırsey varsa ıslem yapacak
            //{
                DataRow drGiris = klas.GetDataRow("Select * from Kullanici Where Email='" + txtEmail.Text + "' and Sifre='" + txtSifre.Text + "'");
                if (drGiris != null)
                {
                    Session["KullaniciId"] = drGiris["KullaniciId"].ToString();//
                    Session["Adsoyad"] = drGiris["Adsoyad"].ToString();
                    if (chckHatirla.Checked)
                    {
                        HttpCookie cerez = new HttpCookie("Cerezim");//Cerezim isimli bir cookie oluşturuldu.
                        cerez.Values.Add("KullaniciId", drGiris["KullaniciId"].ToString());//cookie ye değer atadık.
                        cerez.Values.Add("Adsoyad", drGiris["Adsoyad"].ToString());//yukardakı lblAdSoyad da kulandım bunu
                        cerez.Expires = DateTime.Now.AddDays(30);//cookie 30 gün kullanılabilir.
                        Response.Cookies.Add(cerez);//cookie eklendi.
                    }
                    Response.Redirect(Page.Request.Url.ToString(), true);//burada kullanıcı hangı sayfada işlem yaparsa yapsın kullnıcı o sayfada gırıs yapablır dıye kullnıcı gırısı ve emaılı bulunmaktadır.
                }
                else
                    lblGirisHata.Text = "Şifreyi Hatalı Girdiniz";
            //}
            //else
            //    lblGirisHata.Text = "Üyeliğiniz Onaylanmaıstır.";
        }
        else
            lblGirisHata.Text = "Böyle Bir MAail  Adresi Sistemde Yoktur.";
    }
    protected void lbCikis_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["Cerezim"] != null)
        { Response.Cookies["Cerezim"].Expires = DateTime.Now.AddDays(-1); }  //kullnıcın sıstemını eksi bir yaparak kullnıcının sıstemınden sılmıs oluyoruz
        FormsAuthentication.SignOut();                                        //Form baglantımı kapatıyorum burada 
        Session.Abandon();                                                  //sesion silme için kullnılır
        Response.Redirect("Default.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Profilim.aspx");
    }
}
