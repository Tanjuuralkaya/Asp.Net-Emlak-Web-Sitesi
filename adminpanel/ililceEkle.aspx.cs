using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminpanel_ililceEkle : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)//burada postback kosulunu koynasam ilce ekleresem ile aıt ilId si 0 degerını alır
        {
            il();
            ddlil.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            il2();
            ddlil2.Items.Insert(0, new ListItem("Şehir Seçiniz" , "0"));
            il3();
            ddlil3.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            
        }
       

    }
    protected void btnilEkle_Click(object sender, EventArgs e)
    {
        pnlil.Visible = true;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
        pnlmahalle.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        DataRow dril = klas.GetDataRow("Select * from iller where ilAdi= '"+ txtil1.Text +"'" );//burada iller tablosuna bakacak bu tablo içindeki il adı txtil.text1 deki il adına eşit olan bir satır bulursa hemen drili doldurmus olcak.
        if (dril == null)// yani boyle bır deger yoksa asagıdakı ıslemı yap
        {
            
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into iller (ilAdi) Values(@ilAdi)", baglanti);
            cmd.Parameters.Add("ilAdi", txtil1.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");
        }
        else
        {
            lblBilgi1.Text = "Böyle Bir Şehir Bulunmaktadır."; 
        }
        
    }
    protected void btnilceEkle_Click(object sender, EventArgs e)
    {
        pnlilce.Visible = true;
        pnlil.Visible = false;
        pnlsemt.Visible = false;
        pnlmahalle.Visible = false;

    }
    void il()
    {
        //1.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
        
    }
    protected void btn_ilceekle_Click(object sender, EventArgs e)
    {
        DataRow drilce = klas.GetDataRow("Select * from ilceler where ilceAdi= '"+ txtilce.Text +"'" );//burada ilceler tablosuna bakacak bu tablo içindeki ilceAdı txtil.text1 deki ilce adına eşit olan bir satır bulursa hemen drilce doldurmus olcak.
        if (drilce == null)// yani boyle bır deger yoksa asagıdakı ıslemı yap
        {

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into ilceler (ilceAdi , ilId) Values(@ilceAdi , @ilId)", baglanti);
            cmd.Parameters.Add("ilceAdi", txtilce.Text);
            cmd.Parameters.Add("ilId", ddlil.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");
        }
        else
        {
            lblBilgi2.Text = "Böyle İlçe Bulunmaktadır"; 
        }
    }
    void il2()
    {
        //2.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddlil2.DataTextField = "ilAdi";
        ddlil2.DataValueField = "ilId";
        ddlil2.DataSource = dtiller;
        ddlil2.DataBind();

    }
    void ilce2()
    {
        //3. dropdownlıst ıcın
        // burada 2. drop dawn listte secılı olan ılın ılcelerı sıralanacak :)
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddlil2.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddlilce2.DataTextField = "ilceAdi";
        ddlilce2.DataValueField = "ilceId";
        ddlilce2.DataSource = dtilce;
        ddlilce2.DataBind();
    }
    protected void ddlil2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce2();
        ddlilce2.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));

    }
    protected void btn_semtEkle_Click(object sender, EventArgs e)
    {
        DataRow drsemt = klas.GetDataRow("Select * from semt where SemtAdi= '"+ txtSemt.Text +"'");
        if (drsemt == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into semt (SemtAdi , ilceId) Values(@SemtAdi,@ilceId)", baglanti);
            cmd.Parameters.Add("SemtAdi", txtSemt.Text);
            cmd.Parameters.Add("ilceId", ddlilce2.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");
       }
        else
        {
            lblBilgi3.Text = "Böyle Bir Semt Bulunmaktadır";
        }
        
    }
    protected void btnSemtEkle_Click(object sender, EventArgs e)
    {
        pnlsemt.Visible = true;
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlmahalle.Visible = false;
    }
    void il3()
    {
        //4.dropdownlıst ıcın

        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddlil3.DataTextField = "ilAdi";
        ddlil3.DataValueField = "ilId";
        ddlil3.DataSource = dtiller;
        ddlil3.DataBind();

    }
    void ilce3()
    {
        //5. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddlil3.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddlilce3.DataTextField = "ilceAdi";
        ddlilce3.DataValueField = "ilceId";
        ddlilce3.DataSource = dtilce;
        ddlilce3.DataBind();
    }
    void Semt()
    {
        //6. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from semt  where ilceId=" + ddlilce3.SelectedValue + " order by [SemtAdi]");//burada ise secılıoan ilcenın semtını sıralaycak
        ddlsemt3.DataTextField = "SemtAdi";
        ddlsemt3.DataValueField = "SemtId";
        ddlsemt3.DataSource = dtilce;
        ddlsemt3.DataBind();
    }

    protected void ddlil3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce3();
        ddlilce3.Items.Insert(0,new ListItem("İlçe Seçiniz","0"));
    }
    protected void ddlilce3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Semt();
        ddlsemt3.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
        
    }
    protected void btn_MahalleEkle_Click(object sender, EventArgs e)
    {
        DataRow drmahalle = klas.GetDataRow("Select * From mahalle where MahalleAdi='" + txtMahalle.Text + "'");
        if (drmahalle == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into mahalle(MahalleAdi,SemtId) Values(@MahalleAdi,@SemtId)", baglanti);
            cmd.Parameters.Add("MahalleAdi", txtMahalle.Text);
            cmd.Parameters.Add("SemtId", ddlsemt3.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");
        }
    }
    protected void btnMahalleEkle_Click(object sender, EventArgs e)
    {
        pnlmahalle.Visible = true;
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
    }
}