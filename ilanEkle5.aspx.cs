using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class ilanEkle5 : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string ilanId = ""; string AdSoyad = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ilanId = Request.QueryString["ilanId"];
        ltrlilanId.Text = ilanId;
        AdSoyad = klas.GetDataCell("Select AdSoyad from Kullanici Where KullaniciId=" + Session["KullaniciId"]);
        ltrlAdSoyad.Text = AdSoyad;
    }
}