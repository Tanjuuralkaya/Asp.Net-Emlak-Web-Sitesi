using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ilanEkle2 : System.Web.UI.Page
{

    Metodlar klas = new Metodlar();
    string ilanId = ""; string ilanTurId = ""; string ArsaTurId = ""; string BinaTurId = ""; string DevreTurId = ""; string KonutTurId = "";
    string isyeriDevrenTurId = ""; string isyeriSatilikTurId = ""; string TuristikTurId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
      

        if (Page.IsPostBack == false)
        {
            imarDurumu(); Kaks(); Gabari(); Tapu(); Kredi(); Binaisitma(); BinaYas(); Donem(); Sure(); isitmaKonut(); OdaKonut(); BanyoKonut();
            BinaYasKonut(); KrediKonut(); BinaDurumuKonut(); Yildiz(); BinaYasTuristik(); KrediTuristik();
        }
        if (Session["KullaniciId"] == null)
            Response.Redirect("GirisYap.aspx");
        DataRow drilan = klas.GetDataRow("Select top 1 ilanId from ilanlar Where KullaniciId=" + Session["KullaniciId"] + " Order by [ilanId] desc");//burada son kulanıcın ıdsınıne gore islem yapıp ilk kısımda olan ılanıdyı cekıyor. 
        ilanId = drilan["ilanId"].ToString();
        //şimdi bu ılana aıt tur ıd sını alacaz cunku tur ıdyı bılerek hangı ozellıge aıt oldugunu bulacagım
        ilanTurId = klas.GetDataCell("Select TurId from ilanlar where ilanId=" +ilanId);

        DataRow drArsa = klas.GetDataRow("Select * from Turler Where TurAdi='" + "Arsa" + "'");
        ArsaTurId = drArsa["TurId"].ToString();

        DataRow drBina = klas.GetDataRow("Select * from Turler Where TurAdi='" + "Bina" + "'");
        BinaTurId = drBina["TurId"].ToString();

        DataRow drDevre = klas.GetDataRow("Select * from Turler Where TurAdi='" + "Devremülk" + "'");
        DevreTurId = drDevre["TurId"].ToString();

        DataRow drKonut = klas.GetDataRow("Select * from Turler Where TurAdi='" + "Konut" + "'");
        KonutTurId = drKonut["TurId"].ToString();

        DataRow drisyeriDevren = klas.GetDataRow("Select * from Turler Where TurAdi='" + "İşyeri(Devren)" + "'");
        isyeriDevrenTurId = drisyeriDevren["TurId"].ToString();

        DataRow drisyeriSatilik = klas.GetDataRow("Select * from Turler Where TurAdi='" + "İşyeri(Satilik)" + "'");
        isyeriSatilikTurId = drisyeriSatilik["TurId"].ToString();

        DataRow drTuristik = klas.GetDataRow("Select * from Turler Where TurAdi='" + "Turistlik  Tesis" + "'");
        TuristikTurId = drTuristik["TurId"].ToString();

        if (ilanTurId == ArsaTurId)
        {
            pnlArsa.Visible = true;          
        }
        if(ilanTurId == BinaTurId)
        {
            pnlBina.Visible =  true;
        }
        if (ilanTurId == DevreTurId)
        {
            pnlDevre.Visible = true;
        }
        if (ilanTurId == KonutTurId || ilanTurId == isyeriDevrenTurId || ilanTurId == isyeriSatilikTurId)
        {
            pnlKonut.Visible = true;
        }
        if (ilanTurId == TuristikTurId)
        {
            pnlTurislik.Visible = true;
        }
    }

    void KrediTuristik()
    {
        DataTable KrediTuristik = klas.GetDataTable("Select * from Kredi");
        ddlKredi_Turistik.DataTextField = "Kredi";
        ddlKredi_Turistik.DataValueField = "KrediId";
        ddlKredi_Turistik.DataSource = KrediTuristik;
        ddlKredi_Turistik.DataBind();
    }
    void BinaYasTuristik()
    {
        DataTable BinaYasTuristik = klas.GetDataTable("Select * from BinaYasi");
        ddlBinaYasi_Turistik.DataTextField = "BinaYasi";
        ddlBinaYasi_Turistik.DataValueField = "BinaYasId";
        ddlBinaYasi_Turistik.DataSource = BinaYasTuristik;
        ddlBinaYasi_Turistik.DataBind();
    }
    void Yildiz()
    {
        DataTable Yildiz = klas.GetDataTable("Select * from Yildiz");
        ddlYildiz.DataTextField = "Yildiz";
        ddlYildiz.DataValueField = "YildizId";
        ddlYildiz.DataSource = Yildiz;
        ddlYildiz.DataBind();
    }
    void BinaDurumuKonut()
    {
        DataTable BinaDurumuKonut = klas.GetDataTable("Select * from YapiDurumu");
        ddlDurum_Konut.DataTextField = "Durum";
        ddlDurum_Konut.DataValueField = "DurumId";
        ddlDurum_Konut.DataSource = BinaDurumuKonut;
        ddlDurum_Konut.DataBind();
    }
    void KrediKonut()
    {
        DataTable KrediKonut = klas.GetDataTable("Select * from Kredi");
        ddlKredi_Konut.DataTextField = "Kredi";
        ddlKredi_Konut.DataValueField = "KrediId";
        ddlKredi_Konut.DataSource = KrediKonut;
        ddlKredi_Konut.DataBind();
    }
    void BinaYasKonut()
    {
        DataTable BinaYasKonut = klas.GetDataTable("Select * from BinaYasi");
        ddlBinaYasi_Konut.DataTextField = "BinaYasi";
        ddlBinaYasi_Konut.DataValueField = "BinaYasId";
        ddlBinaYasi_Konut.DataSource = BinaYasKonut;
        ddlBinaYasi_Konut.DataBind();
    }
    void BanyoKonut()
    {
        DataTable BanyoKonut = klas.GetDataTable("Select * from BanyoSayisi");
        ddlBanyo_Konut.DataTextField = "BanyoSayisi";
        ddlBanyo_Konut.DataValueField = "BanyoId";
        ddlBanyo_Konut.DataSource = BanyoKonut;
        ddlBanyo_Konut.DataBind();
    }
    void OdaKonut()
    {
        DataTable OdaKonut = klas.GetDataTable("Select * from OdaSayisi");
        ddlOda_Konut.DataTextField = "OdaSayisi";
        ddlOda_Konut.DataValueField = "OdaId";
        ddlOda_Konut.DataSource = OdaKonut;
        ddlOda_Konut.DataBind();
    }
    void isitmaKonut()
    {
        DataTable isitmaKonut = klas.GetDataTable("Select * from IsitmaTurler");
        ddlIsitma_Konut.DataTextField = "IsitmaTur";
        ddlIsitma_Konut.DataValueField = "IsitmaTurId";
        ddlIsitma_Konut.DataSource = isitmaKonut;
        ddlIsitma_Konut.DataBind();
    }
    void Sure()
    {
        DataTable dtSure = klas.GetDataTable("Select * from Sure");
        ddlSure.DataTextField = "Sure";
        ddlSure.DataValueField = "SureId";
        ddlSure.DataSource = dtSure;
        ddlSure.DataBind();
    }
    void Donem()
    {
        DataTable dtDonem = klas.GetDataTable("Select * from Donem");
        ddlDonem.DataTextField = "Donem";
        ddlDonem.DataValueField = "DonemId";
        ddlDonem.DataSource = dtDonem;
        ddlDonem.DataBind();
    }
    /// <summary>
    /// 
    /// </summary>
    void BinaYas()
    {
        DataTable dtBinaYas = klas.GetDataTable("Select * from BinaYasi");
        ddlBinaYasi.DataTextField = "BinaYasi";
        ddlBinaYasi.DataValueField = "BinaYasId";
        ddlBinaYasi.DataSource = dtBinaYas;
        ddlBinaYasi.DataBind();
    }
    void Binaisitma()
    {
        DataTable dtBinaisitma = klas.GetDataTable("Select * from IsitmaTurler");
        ddlisitma_Bina.DataTextField = "IsitmaTur";
        ddlisitma_Bina.DataValueField = "IsitmaTurId";
        ddlisitma_Bina.DataSource = dtBinaisitma;
        ddlisitma_Bina.DataBind();
    }
    void Kredi()
    {
        DataTable dtKredi = klas.GetDataTable("Select * from Kredi");
        ddlKredi.DataTextField = "Kredi";
        ddlKredi.DataValueField = "KrediId";
        ddlKredi.DataSource = dtKredi;
        ddlKredi.DataBind();
    }
    void Tapu()
    {
        DataTable dtTapu = klas.GetDataTable("Select * from TapuDurumu");
        ddlTapu.DataTextField = "TapuDurumu";
        ddlTapu.DataValueField = "TapuDurumuId";
        ddlTapu.DataSource = dtTapu;
        ddlTapu.DataBind();
    }
    void Gabari()
    {
        DataTable dtGabari = klas.GetDataTable("Select * from Gabari");
        ddlGabari.DataTextField = "Gabari";
        ddlGabari.DataValueField = "GabariId";
        ddlGabari.DataSource = dtGabari;
        ddlGabari.DataBind();
    }
    void Kaks()
    {
        DataTable dtKaks = klas.GetDataTable("Select * from Kaks");
        ddlKaks.DataTextField = "Kaks";
        ddlKaks.DataValueField = "KaksId";
        ddlKaks.DataSource = dtKaks;
        ddlKaks.DataBind();
    }

    void imarDurumu()
    {
        DataTable dtimar = klas.GetDataTable("Select * from imarDurumu");
        ddlimarDurumu.DataTextField = "imarDurumu";
        ddlimarDurumu.DataValueField = "imarDurumuId";
        ddlimarDurumu.DataSource = dtimar;
        ddlimarDurumu.DataBind();
    }

    protected void btnArsaKaydet_Click(object sender, EventArgs e)
    {
        string Kat = "";
        if (rdEvet.Checked)
            Kat = "1";
        else
            Kat = "0";
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into ArsaOzellikler (ilanId,imarDurumuId,KaksId,GabariId,TapuId,KrediId,Metre,Adano,Parselno,Paftano,KatKarsiligi) values(@ilanId,@imarDurumuId,@KaksId,@GabariId,@TapuId,@KrediId,@Metre,@Adano,@Parselno,@Paftano,@KatKarsiligi)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("imarDurumuId", ddlimarDurumu.SelectedValue);
        cmd.Parameters.Add("KaksId", ddlKaks.SelectedValue);
        cmd.Parameters.Add("GabariId", ddlGabari.SelectedValue);
        cmd.Parameters.Add("TapuId", ddlTapu.SelectedValue);
        cmd.Parameters.Add("KrediId", ddlKredi.SelectedValue);
        cmd.Parameters.Add("Metre", txtMetre_Arsa.Text);
        cmd.Parameters.Add("Adano", txtAda.Text);
        cmd.Parameters.Add("Parselno", txtParsel.Text);
        cmd.Parameters.Add("Paftano", txtPafta.Text);
        cmd.Parameters.Add("KatKarsiligi", Kat);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);
    }
    protected void btnBinaKaydet_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into BinaOzellikler (ilanId,KatSayisi,KattakiDaire,IsitmaTurId,Metre,BinaYasId) values(@ilanId,@KatSayisi,@KattakiDaire,@IsitmaTurId,@Metre,@BinaYasId)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("KatSayisi", txtKatSayisi.Text);
        cmd.Parameters.Add("KattakiDaire", txtKattakiDaire.Text);
        cmd.Parameters.Add("IsitmaTurId", ddlisitma_Bina.SelectedValue);
        cmd.Parameters.Add("Metre", txtMetre_Bina.Text);
        cmd.Parameters.Add("BinaYasId", ddlBinaYasi.SelectedValue);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);

    }
    protected void btnDevreKaydet_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into DevreOzellik (ilanId,DonemId,SureId,Oda) values(@ilanId,@DonemId,@SureId,@Oda)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("DonemId", ddlDonem.SelectedValue);
        cmd.Parameters.Add("SureId", ddlSure.SelectedValue);
        cmd.Parameters.Add("Oda", txtDevre_Oda.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);

    }
    protected void btnKonutKaydet_Click(object sender, EventArgs e)
    {
        int BinadakiKat; int BulunduguKat;
        if (txtBinadakiKat.Text != "" || txtBulundugu.Text != "")
        {
            BinadakiKat = Convert.ToInt32(txtBinadakiKat.Text);
            BulunduguKat = Convert.ToInt32(txtBulundugu.Text);

            if (BinadakiKat >= BulunduguKat)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("insert into KonutOzellikler (ilanId,IsitmaTurId,OdaId,BanyoId,BinaYasId,KrediId,BinadakiKat,BulunduguKat,Metre,DurumId) values(@ilanId,@IsitmaTurId,@OdaId,@BanyoId,@BinaYasId,@KrediId,@BinadakiKat,@BulunduguKat,@Metre,@DurumId)", baglanti);
                cmd.Parameters.Add("ilanId", ilanId);
                cmd.Parameters.Add("IsitmaTurId", ddlIsitma_Konut.SelectedValue);
                cmd.Parameters.Add("OdaId", ddlOda_Konut.SelectedValue);
                cmd.Parameters.Add("BanyoId", ddlBanyo_Konut.SelectedValue);
                cmd.Parameters.Add("BinaYasId", ddlBinaYasi_Konut.SelectedValue);
                cmd.Parameters.Add("KrediId", ddlKredi_Konut.SelectedValue);
                cmd.Parameters.Add("BinadakiKat", txtBinadakiKat.Text);
                cmd.Parameters.Add("BulunduguKat", txtBulundugu.Text);
                cmd.Parameters.Add("Metre", txtMetre_Konut.Text);
                cmd.Parameters.Add("DurumId", ddlDurum_Konut.SelectedValue);
                cmd.ExecuteNonQuery();
                Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);
            }
            else
                ltrlBilgi.Text = "Konutun Bulunduğu Kat Binadaki Kattan Büyük Olamaz";
        }
    }
    protected void btnTuristikKaydet_Click(object sender, EventArgs e)
    {
        string zemin = "";
        if (rdVar.Checked)
            zemin = "1";
        else
            zemin = "0";
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into TesisOzellikler (ilanId,YildizId,OdaSayisi,YatakSayisi,KatSayisi,BinaYasId,AcikAlan,KapaliAlan,ZeminEtudu,KrediId,ApartSayisi) values(@ilanId,@YildizId,@OdaSayisi,@YatakSayisi,@KatSayisi,@BinaYasId,@AcikAlan,@KapaliAlan,@ZeminEtudu,@KrediId,@ApartSayisi)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("YildizId", ddlYildiz.SelectedValue);
        cmd.Parameters.Add("OdaSayisi", txtOdaSayisi.Text);
        cmd.Parameters.Add("YatakSayisi", txtYatakSayisi.Text);
        cmd.Parameters.Add("KatSayisi", txtKat_Turistik.Text);
        cmd.Parameters.Add("BinaYasId", ddlBinaYasi_Turistik.SelectedValue);
        cmd.Parameters.Add("AcikAlan", txtAcik.Text);
        cmd.Parameters.Add("KapaliAlan", txtKapali.Text);
        cmd.Parameters.Add("ZeminEtudu", zemin);
        cmd.Parameters.Add("KrediId", ddlKredi_Turistik.SelectedValue);
        cmd.Parameters.Add("ApartSayisi", txtApart.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);

    }
}