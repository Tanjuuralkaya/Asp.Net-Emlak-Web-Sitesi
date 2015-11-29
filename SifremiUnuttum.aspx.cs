using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

public partial class SifremiUnuttum : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {
        //DataRow drKul = klas.GetDataRow("Select * from Kullanici Where Email='" + txtEmail.Text + "'");
        //if (drKul != null)//yani veri tabanında bole bır e maıl varsa bunu yap anlamında
        //{
        //    MailMessage msg = new MailMessage();//yeni bir mail nesnesi Oluşturuldu.
        //    msg.IsBodyHtml = true; //mail içeriğinde html etiketleri kullanılsın mı?
        //    msg.To.Add(txtEmail.Text);//Kime mail gönderilecek.
        //    msg.From = new MailAddress("www.facebook.com/tanju.uralkaya", "www.facebook.com/tanju.uralkaya", System.Text.Encoding.UTF8);//mail kimden geliyor, hangi ifade görünsün?
        //    msg.Subject = "Kullanıcı Bilgileri Hatırlatma Maili";//mailin konusu
        //    msg.Body = "Şifreniz:" + drKul["Sifre"].ToString() + "<br> Giriş İçin <a href='default.aspx'>Tıklayın</a>";//mailin içeriği
        //    SmtpClient smp = new SmtpClient();
        //    smp.Credentials = new NetworkCredential("www.facebook.com/tanju.uralkaya", "elbistan");//kullanıcı adı şifre
        //    smp.Port = 587;
        //    smp.Host = "smtp.gmail.com";//gmail üzerinden gönderiliyor.
        //    smp.EnableSsl = true;
        //    smp.Send(msg);//msg isimli mail gönderiliyor.

        //    lblEmail.Text = "Bilgileriniz Mail Adresinize Gönderilmiştir.";
        //}
        //else
        //    lblEmail.Text = "Sitemizde Bu Mail Adresi Kayıtlı Değildir.";

    }
}