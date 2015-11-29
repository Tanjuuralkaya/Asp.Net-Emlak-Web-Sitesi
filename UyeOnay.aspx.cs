using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class UyeOnay : System.Web.UI.Page
{
    //Metodlar klas = new Metodlar();
    //string x = ""; string Email = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        /////////burada kılanıcı bu sayfaya gelırken x degıskenı ıcınde sayi degıskenını getırecek////
        //try
        //{
        //    x = Request.QueryString["x"];//burada kullanıcı hem maılı gonderecek hemde sayıyı gonderecekkı
        //    Email = Request.QueryString["Email"];//verıtabanından sayıyı o maıl sayesınde kontol edeyım deıye ıkısını de aldım
        //}
        //catch (Exception)
        //{

        //}
        //DataRow drSayi = klas.GetDataRow("Select Sayi from Kullanici Where Email='" + Email + "'");
        //if (x == drSayi["Sayi"].ToString())//egerkı maılden gelen xıfadesı ıle verıtabanındakı sayı ıle aynıysa guncelleme kodlarını yaparım
        //{
        //    klas.cmd("Update Kullanici Set Onay=1 Where Email='" + Email + "'");
        //}
    }
}