using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminpanel_ilYonetimi : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            il();
            dddil.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            ilce_il();
            ddl_ilce_il.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));

            il3();
            ddl_il3.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            ilce3();
            ddl_ilce_3.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
            Semt();
            ddl_semt.Items.Insert(0, new ListItem("Semt Seçiniz", "0"));


            il4();
            ddlil4.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            ilce4();
            ddlilce4.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
            Semt4();
            ddlsemt4.Items.Insert(0, new ListItem("Semt Seçiniz", "0"));
            Mahalle4();
            ddlmahalle4.Items.Insert(0, new ListItem("Mahalle Seçiniz", "0"));

        }
    }
    void il()
    {
        //1.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        dddil.DataTextField = "ilAdi";
        dddil.DataValueField = "ilId";
        dddil.DataSource = dtiller;
        dddil.DataBind();
    }
    void ilce_il()
    {
        //2. dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  iller ddl_ilce_il icin sehir cektikk
        ddl_ilce_il.DataTextField = "ilAdi";
        ddl_ilce_il.DataValueField = "ilId";
        ddl_ilce_il.DataSource = dtiller;
        ddl_ilce_il.DataBind();
    }

    protected void dddil_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        txtil.Text = dddil.SelectedItem.Text;
    }
    protected void btnGuncelleil_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update iller set ilAdi =@ilAdi where ilId =" +dddil.SelectedValue , baglanti);
        cmd.Parameters.Add("ilAdi",txtil.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        pnlil.Visible = true;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
        pnlsemt.Visible = false;
    }

    void ddlilce()
    {
        //3. dropdownlıst ıcın
       // burada birinci drop dawn listte secılı olan ılın ılcelerı sıralanacak :)
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddl_ilce_il.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddl_ilce.DataTextField = "ilceAdi";
        ddl_ilce.DataValueField = "ilceId";
        ddl_ilce.DataSource = dtilce;
        ddl_ilce.DataBind();
    }

    void il3()
    {
        //4.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddl_il3.DataTextField = "ilAdi";
        ddl_il3.DataValueField = "ilId";
        ddl_il3.DataSource = dtiller;
        ddl_il3.DataBind();
    }

    void ilce3()
    {
        //5. dropdownlıst ıcın
        
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddl_il3.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddl_ilce_3.DataTextField = "ilceAdi";
        ddl_ilce_3.DataValueField = "ilceId";
        ddl_ilce_3.DataSource = dtilce;
        ddl_ilce_3.DataBind();
    }
    void Semt()
    {
        //6. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from semt  where ilceId=" + ddl_ilce_3.SelectedValue + " order by [SemtAdi]");//burada ise secılıoan ilcenın semtını sıralaycak
        ddl_semt.DataTextField = "SemtAdi";
        ddl_semt.DataValueField = "SemtId";
        ddl_semt.DataSource = dtilce;
        ddl_semt.DataBind();
    }
  

    void il4()
    {
        //7.dropdownlıst ıcın
        DataTable dtiller = klas.GetDataTable("Select * From iller" + " order by [ilAdi] ");
        //bizim  illere adlı tobladakı databasemızdeki alanı cekecek
        ddlil4.DataTextField = "ilAdi";
        ddlil4.DataValueField = "ilId";
        ddlil4.DataSource = dtiller;
        ddlil4.DataBind();
    }

    void ilce4()
    {
        //8. dropdownlıst ıcın
        //burada secılı olan ıle gore secım yapıyoruz...
        DataTable dtilce = klas.GetDataTable("Select * from ilceler where ilId=" + ddlil4.SelectedValue + " order by [ilceAdi]");//burada ise secili olan ilin ıdsınegore ilceleri listeleyecek
        ddlilce4.DataTextField = "ilceAdi";
        ddlilce4.DataValueField = "ilceId";
        ddlilce4.DataSource = dtilce;
        ddlilce4.DataBind();
    }

    void Semt4()
    {
        //9. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from semt  where ilceId=" + ddlilce4.SelectedValue + " order by [SemtAdi]");//burada ise secılıoan ilcenın semtını sıralaycak
        ddlsemt4.DataTextField = "SemtAdi";
        ddlsemt4.DataValueField = "SemtId";
        ddlsemt4.DataSource = dtilce;
        ddlsemt4.DataBind();
    }

    void Mahalle4()
    {
        //10. dropdownlıst ıcın

        DataTable dtilce = klas.GetDataTable("Select * from mahalle where SemtId=" + ddlsemt4.SelectedValue + " order by [MahalleAdi]");//burada ise secılıoan ilcenın semtını sıralaycak
        ddlmahalle4.DataTextField = "MahalleAdi";
        ddlmahalle4.DataValueField = "MahalleId";
        ddlmahalle4.DataSource = dtilce;
        ddlmahalle4.DataBind();
    }
    protected void ddl_ilce_il_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilce();
       // ddl_ilce.Enabled = true;//aspde enablesını false yaprtım ıl secılınce ılceler dropdown lıstesı sıralancak
        ddl_ilce.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
    }
    protected void ddl_ilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtilce.Text = ddl_ilce.SelectedItem.Text;
    }
    protected void btnGuncelleilce_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update ilceler set ilceAdi =@ilceAdi where ilceId =" + ddl_ilce.SelectedValue, baglanti);
        cmd.Parameters.Add("ilceAdi", txtilce.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        pnlilce.Visible = true;
        pnlil.Visible = false;
        pnlsemt.Visible = false;
        pnlsemt.Visible = false;
    }
    protected void ddl_il3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce3();
        ddl_ilce_3.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
    }
    protected void ddl_ilce_3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Semt();
        ddl_semt.Items.Insert(0, new ListItem("Semt Seçiniz", "0"));
    }
    protected void ddl_semt_SelectedIndexChanged(object sender, EventArgs e)
    {
        txt_semt.Text = ddl_semt.SelectedItem.Text; 
    }
    protected void btnGuncelleSemt_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update semt set SemtAdi =@SemtAdi where SemtId =" + ddl_semt.SelectedValue, baglanti);
        cmd.Parameters.Add("SemtAdi", txt_semt.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        pnlsemt.Visible = true;
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlMahalle.Visible = false;
    }
    protected void ddlil4_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce4();
        ddlilce4.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));

    }
    protected void ddlilce4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Semt4();
        ddlsemt4.Items.Insert(0, new ListItem("Semt Seçiniz", "0"));

    }

    protected void ddlsemt4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Mahalle4();
        ddlmahalle4.Items.Insert(0,new ListItem("Mahalle Seçiniz","0"));
    }
    protected void ddlmahalle4_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMahalle.Text = ddlmahalle4.SelectedItem.Text;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        pnlMahalle.Visible = true;
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
    }
    protected void btnMahalleGuncelle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update mahalle set MahalleAdi =@MahalleAdi where MahalleId=" + ddlmahalle4.SelectedValue, baglanti);
        cmd.Parameters.Add("MahalleAdi", txtMahalle.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ililceEkle.aspx");
    }
   
    protected void txtMahalle_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnEvetil_Click(object sender, EventArgs e)
    {
        if (dddil.SelectedItem.Text != "Şehir Seçiniz")
        {
            klas.cmd("Delete From iller where ilId=" + dddil.SelectedValue + "");
            Response.Redirect("ilYonetimi.aspx");
            
        }

       
    }

  
}