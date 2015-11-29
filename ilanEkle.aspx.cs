using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ilanEkle : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KullaniciId"]==null)
        {
            Response.Redirect("GirisYap.aspx");
            
        }
        if (Page.IsPostBack == false)
        {
            tur();
            ddlilanTur.Items.Insert(0, new ListItem("Seçiniz", "0"));
            islem();
            ddlislem.Items.Insert(0, new ListItem("Seçiniz", "0"));
            fiyattur();
            ddlFiyatTur.Items.Insert(0, new ListItem("Seçiniz", "0"));
            kimden();
            ddlKimden.Items.Insert(0, new ListItem("Seçiniz", "0"));
            il();
            ddlil.Items.Insert(0, new ListItem("Seçiniz", "0"));
        }
    }

    void tur()
    {
        DataTable dtTur = klas.GetDataTable("Select * from Turler Order by [TurAdi]");
        ddlilanTur.DataTextField = "TurAdi";
        ddlilanTur.DataValueField = "TurId";
        ddlilanTur.DataSource = dtTur;
        ddlilanTur.DataBind();
    }

    void alttur()
    {
        DataTable dtAltTur = klas.GetDataTable("Select * from AltTurler Where TurId=" + ddlilanTur.SelectedValue + " Order by [AltTurAdi]");
        ddlilanAltTur.DataTextField = "AltTurAdi";
        ddlilanAltTur.DataValueField = "AltTurId";
        ddlilanAltTur.DataSource = dtAltTur;
        ddlilanAltTur.DataBind();
    }

    void islem()
    {
        DataTable dtislem = klas.GetDataTable("Select * from islemler Order by [islem] asc");
        ddlislem.DataTextField = "islem";
        ddlislem.DataValueField = "islemId";
        ddlislem.DataSource = dtislem;
        ddlislem.DataBind();
    }

    void fiyattur()
    {
        DataTable dtfiyattur = klas.GetDataTable("Select * from FiyatTurler Order by [FiyatTur] asc");
        ddlFiyatTur.DataTextField = "FiyatTur";
        ddlFiyatTur.DataValueField = "FiyatTurId";
        ddlFiyatTur.DataSource = dtfiyattur;
        ddlFiyatTur.DataBind();
    }

    void kimden()
    {
        DataTable dtkimden = klas.GetDataTable("select * from Kimden order by [Kimden] asc");
        ddlKimden.DataTextField = "Kimden";
        ddlKimden.DataValueField = "KimdenId";
        ddlKimden.DataSource = dtkimden;
        ddlKimden.DataBind();

    }

    void il()
    {
        DataTable dtil = klas.GetDataTable("select * from iller order by [ilAdi] asc");
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtil;
        ddlil.DataBind();
    }

    void ilce()
    {

        DataTable dtilce = klas.GetDataTable("Select * from ilceler Where ilId=" + ddlil.SelectedValue + " Order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilce;
        ddlilce.DataBind();
    }

    void semt()
    {
        DataTable dtsemt = klas.GetDataTable("Select * from semt Where ilceId=" + ddlilce.SelectedValue + " Order by [SemtAdi]");
        ddlSemt.DataTextField = "SemtAdi";
        ddlSemt.DataValueField = "SemtId";
        ddlSemt.DataSource = dtsemt;
        ddlSemt.DataBind();
    }

    void mahalle()
    {
        DataTable dtmahalle = klas.GetDataTable("Select * from mahalle Where SemtId=" + ddlSemt.SelectedValue + " Order by [MahalleAdi]");
        ddlMahalle.DataTextField = "MahalleAdi";
        ddlMahalle.DataValueField = "MahalleId";
        ddlMahalle.DataSource = dtmahalle;
        ddlMahalle.DataBind();
    }

    protected void ddlilanTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilanAltTur.Enabled = true;
        alttur();
        ddlilanAltTur.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }
    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilce.Enabled = true;
        ilce();
        ddlilce.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }
    protected void ddlilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlSemt.Enabled = true;
        semt();
        ddlSemt.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }
    protected void ddlSemt_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlMahalle.Enabled = true;
        mahalle();
        ddlMahalle.Items.Insert(0, new ListItem("Seçiniz", "0"));
        
    }

    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        if (ddlilanTur.SelectedValue!="0")
        {
            
      
        if (ddlil.SelectedValue != "0")
        {
            if (ddlilce.SelectedValue != "0")
            {
                if (ddlSemt.SelectedValue != "0")
                {

                    string takas = "";
                    if (rdTakasEvet.Checked == true)
                    {
                        takas = "1";
                    }
                    else
                    {
                        takas = "2";
                    }

                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into ilanlar (TurId,AltTurId,islemId,FiyatTurId,Fiyat,KimdenId,KullaniciId,ilId,ilceId,SemtId,MahalleId,Baslik,Aciklama,Adres,Tarih,Takas,Onay,Vitrin,Hit) Values(@TurId,@AltTurId,@islemId,@FiyatTurId,@Fiyat,@KimdenId,@KullaniciId,@ilId,@ilceId,@SemtId,@MahalleId,@Baslik,@Aciklama,@Adres,@Tarih,@Takas,@Onay,@Vitrin,@Hit)", baglanti);
                    cmd.Parameters.Add("TurId", ddlilanTur.SelectedValue);
                    cmd.Parameters.Add("AltTurId", ddlilanAltTur.SelectedValue);
                    cmd.Parameters.Add("islemId", ddlislem.SelectedValue);
                    cmd.Parameters.Add("FiyatTurId", ddlFiyatTur.SelectedValue);
                    cmd.Parameters.Add("Fiyat", txtFiyat.Text);
                    cmd.Parameters.Add("KimdenId", ddlKimden.SelectedValue);
                    cmd.Parameters.Add("KullaniciId", Session["KullaniciId"]);
                    cmd.Parameters.Add("ilId", ddlil.SelectedValue);
                    cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);
                    cmd.Parameters.Add("SemtId", ddlSemt.SelectedValue);
                    cmd.Parameters.Add("MahalleId", ddlMahalle.SelectedValue);
                    cmd.Parameters.Add("Baslik", txtBaslik.Text);
                    cmd.Parameters.Add("Aciklama", txtAciklama.Text);
                    cmd.Parameters.Add("Adres",  txtAdres.Text);
                    cmd.Parameters.Add("Tarih", DateTime.Now.ToShortDateString());
                    cmd.Parameters.Add("Takas", takas);
                    cmd.Parameters.Add("Onay", "0");
                    cmd.Parameters.Add("Vitrin", "0");
                    cmd.Parameters.Add("Hit", "0");
                    cmd.ExecuteNonQuery();
                    Response.Redirect("ilanEkle2.aspx");
                }
                else
                {
                    ltrlHata.Text = "Lütfen Semt Seçiniz.";
                }

            }
            else
            {
                ltrlHata.Text = "Lütfen İlçe Seçiniz.";
            }
            
        }
        else
        {
            ltrlHata.Text = "Lütfen Şehir Seçiniz:";
        }

        }
        else
        {
            ltrlHata.Text = "Lütfen İlan Türünü Seçiniz";
        }
    }
    
}