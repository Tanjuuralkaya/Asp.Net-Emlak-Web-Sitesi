using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ilanEkle3 : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string ilanId = ""; string ilanTurId = ""; string ArsaTurId = ""; string BinaTurId = ""; string DevreTurId = ""; string KonutTurId = "";
    string isyeriDevrenTurId = ""; string isyeriSatilikTurId = ""; string TuristikTurId = ""; string ilanAltTurId = ""; string ResAltTurId = "";
    string ApartAltTurId = ""; string PansiyonAltTurId = ""; string KampAltTurId = "";
    protected void Page_Load(object sender, EventArgs e)
    {



        ilanId = Request.QueryString["ilanId"];


        ilanTurId = klas.GetDataCell("Select TurId from ilanlar where ilanId=" + ilanId);

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

        ilanAltTurId = klas.GetDataCell("Select AltTurId from ilanlar where ilanId=" + ilanId);

        DataRow drResAltTurId = klas.GetDataRow("Select * from AltTurler Where AltTurAdi='" + "Residence" + "'");
        ResAltTurId = drResAltTurId["AltTurId"].ToString();

        DataRow drApartAltTurId = klas.GetDataRow("Select * from AltTurler Where AltTurAdi='" + "Apart Otel" + "'");
        ApartAltTurId = drApartAltTurId["AltTurId"].ToString();

        DataRow drPansiyonAltTurId = klas.GetDataRow("Select * from AltTurler Where AltTurAdi='" + "Pansiyon" + "'");
        PansiyonAltTurId = drPansiyonAltTurId["AltTurId"].ToString();

        DataRow drKampAltTurId = klas.GetDataRow("Select * from AltTurler Where AltTurAdi='" + "Kamp Yeri" + "'");
        KampAltTurId = drKampAltTurId["AltTurId"].ToString();

        if (Page.IsPostBack == false)
        {
            Aktivite(); AltYapi(); BanyoOzellikler(); BinaDetay(); Dis(); ic(); KampDetay(); Manzara(); Cephe(); Muhit(); Mutfak();
            OdaOzellik(); OdaTipi(); Ortak(); Parsel(); TesisDetay(); Ulasim(); Yeme(); ResidenceOzellikler(); ResidenceSosyal(); KonutTipi();
        }

        if (ilanTurId == ArsaTurId)
        {
            pnlAltYapi.Visible = true;
            pnlMuhit.Visible = true;
            pnlParsel.Visible = true;
            pnlUlasim.Visible = true;
        }
        if (ilanTurId == BinaTurId)
        {
            pnlBinaDetay.Visible = true;
            pnlCephe.Visible = true;
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }
        if (ilanTurId == DevreTurId)
        {
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }
        if (ilanTurId == isyeriDevrenTurId || ilanTurId == isyeriSatilikTurId)
        {
            pnlCephe.Visible = true;
            pnlDisOzellik.Visible = true;
            pnlicOzellik.Visible = true;
            pnlManzara.Visible = true;
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }
        if (ilanTurId == KonutTurId)
        {
            if (ilanAltTurId == ResAltTurId)
            {
                pnlCephe.Visible = true;
                pnlicOzellik.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlResidenceOzellikler.Visible = true;
                pnlResidenceSosyal.Visible = true;
            }
            else
            {
                pnlCephe.Visible = true;
                pnlicOzellik.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlDisOzellik.Visible = true;
                pnlKonutTipi.Visible = true;
            }
        }
        if (ilanTurId == TuristikTurId)
        {
            if (ilanAltTurId == ApartAltTurId || ilanAltTurId == PansiyonAltTurId)
            {
                pnlBanyo.Visible = true;
                pnlAktivite.Visible = true;
                pnlMuhit.Visible = true;
                pnlMutfak.Visible = true;
                pnlOdaOzellik.Visible = true;
                pnlOdaTipi.Visible = true;
                pnlOrtak.Visible = true;
                pnlYeme.Visible = true;
            }
            else if (ilanAltTurId == KampAltTurId)
            {
                pnlAktivite.Visible = true;
                pnlKampDetay.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlYeme.Visible = true;
            }
            else
            {
                pnlBanyo.Visible = true;
                pnlAktivite.Visible = true;
                pnlMuhit.Visible = true;
                pnlMutfak.Visible = true;
                pnlOdaOzellik.Visible = true;
                pnlOdaTipi.Visible = true;
                pnlTesisDetay.Visible = true;
                pnlYeme.Visible = true;
            }
        }



    }

    void Aktivite()
    {
        DataTable dtAktivite = klas.GetDataTable("Select * from Aktiviteler");
        chckAktivite.DataTextField = "Aktivite";
        chckAktivite.DataValueField = "AktiviteId";
        chckAktivite.DataSource = dtAktivite;
        chckAktivite.DataBind();
       
    }

    void AltYapi()
    {
        DataTable dtAltYapi = klas.GetDataTable("Select * from AltYapi");
        chckAltYapi.DataTextField = "AltYapi";
        chckAltYapi.DataValueField = "AltYapiId";
        chckAltYapi.DataSource = dtAltYapi;
        chckAltYapi.DataBind();
    }
    void KonutTipi()
    {
        DataTable dtKonutTipi = klas.GetDataTable("Select * from KonutTipi");
        chckKonutTipi.DataTextField = "KonutTipi";
        chckKonutTipi.DataValueField = "KonutTipiId";
        chckKonutTipi.DataSource = dtKonutTipi;
        chckKonutTipi.DataBind();
    }
    void ResidenceOzellikler()
    {
        DataTable dtResidenceOzellikler = klas.GetDataTable("Select * from ResidenceOzellikler");
        chckResidenceOzellikler.DataTextField = "ResidenceOzellik";
        chckResidenceOzellikler.DataValueField = "ResidenceOzellikId";
        chckResidenceOzellikler.DataSource = dtResidenceOzellikler;
        chckResidenceOzellikler.DataBind();
    }
    void ResidenceSosyal()
    {
        DataTable dtResidenceSosyal = klas.GetDataTable("Select * from ResidenceSosyal");
        chckResidenceSosyal.DataTextField = "ResidenceSosyal";
        chckResidenceSosyal.DataValueField = "ResidenceSosyalId";
        chckResidenceSosyal.DataSource = dtResidenceSosyal;
        chckResidenceSosyal.DataBind();
    }
    void BanyoOzellikler()
    {
        DataTable dtBanyoOzellikler = klas.GetDataTable("Select * from BanyoOzellikler");
        chckBanyoOzellikler.DataTextField = "BanyoOzellik";
        chckBanyoOzellikler.DataValueField = "BanyoOzellikId";
        chckBanyoOzellikler.DataSource = dtBanyoOzellikler;
        chckBanyoOzellikler.DataBind();
    }

    void BinaDetay()
    {
        DataTable dtBinaDetay = klas.GetDataTable("Select * from BinaDetay");
        chckBinaDetay.DataTextField = "BinaDetay";
        chckBinaDetay.DataValueField = "BinaDetayId";
        chckBinaDetay.DataSource = dtBinaDetay;
        chckBinaDetay.DataBind();
    }
    void Cephe()
    {
        DataTable dtCephe = klas.GetDataTable("Select * from Cephe");
        chckCephe.DataTextField = "Cephe";
        chckCephe.DataValueField = "CepheId";
        chckCephe.DataSource = dtCephe;
        chckCephe.DataBind();
    }
    void Dis()
    {
        DataTable dtDis = klas.GetDataTable("Select * from DisOzellikler");
        chckDis.DataTextField = "DisOzellik";
        chckDis.DataValueField = "DisOzellikId";
        chckDis.DataSource = dtDis;
        chckDis.DataBind();
    }
    void ic()
    {
        DataTable dtic = klas.GetDataTable("Select * from icOzellikler");
        chckic.DataTextField = "icOzellik";
        chckic.DataValueField = "icOzellikId";
        chckic.DataSource = dtic;
        chckic.DataBind();
    }
    void KampDetay()
    {
        DataTable dtKampDetay = klas.GetDataTable("Select * from KampDetay");
        chckKampDetay.DataTextField = "KampDetay";
        chckKampDetay.DataValueField = "KampDetayId";
        chckKampDetay.DataSource = dtKampDetay;
        chckKampDetay.DataBind();
    }
    void Manzara()
    {
        DataTable dtManzara = klas.GetDataTable("Select * from Manzara");
        chckManzara.DataTextField = "Manzara";
        chckManzara.DataValueField = "ManzaraId";
        chckManzara.DataSource = dtManzara;
        chckManzara.DataBind();
    }
    void Muhit()
    {
        DataTable dtMuhit = klas.GetDataTable("Select * from Muhit");
        chckMuhit.DataTextField = "Muhit";
        chckMuhit.DataValueField = "MuhitId";
        chckMuhit.DataSource = dtMuhit;
        chckMuhit.DataBind();
    }
    void Mutfak()
    {
        DataTable dtMutfak = klas.GetDataTable("Select * from Mutfak");
        chckMutfak.DataTextField = "Mutfak";
        chckMutfak.DataValueField = "MutfakId";
        chckMutfak.DataSource = dtMutfak;
        chckMutfak.DataBind();
    }
    void OdaOzellik()
    {
        DataTable dtOdaOzellik = klas.GetDataTable("Select * from OdaOzellikler");
        chckOdaOzellik.DataTextField = "OdaOzellik";
        chckOdaOzellik.DataValueField = "OdaOzellikId";
        chckOdaOzellik.DataSource = dtOdaOzellik;
        chckOdaOzellik.DataBind();
    }
    void OdaTipi()
    {
        DataTable dtOdaTipi = klas.GetDataTable("Select * from OdaTipi");
        chckOdaTipi.DataTextField = "OdaTipi";
        chckOdaTipi.DataValueField = "OdaTipiId";
        chckOdaTipi.DataSource = dtOdaTipi;
        chckOdaTipi.DataBind();
    }
    void Ortak()
    {
        DataTable dtOrtak = klas.GetDataTable("Select * from Ortak");
        chckOrtak.DataTextField = "Ortak";
        chckOrtak.DataValueField = "OrtakId";
        chckOrtak.DataSource = dtOrtak;
        chckOrtak.DataBind();
    }
    void Parsel()
    {
        DataTable dtParsel = klas.GetDataTable("Select * from ParselDurumu");
        chckParsel.DataTextField = "ParselDurumu";
        chckParsel.DataValueField = "ParselDurumuId";
        chckParsel.DataSource = dtParsel;
        chckParsel.DataBind();
    }
    void TesisDetay()
    {
        DataTable dtTesisDetay = klas.GetDataTable("Select * from TesisDetay");
        chckTesisDetay.DataTextField = "TesisDetay";
        chckTesisDetay.DataValueField = "TesisDetayId";
        chckTesisDetay.DataSource = dtTesisDetay;
        chckTesisDetay.DataBind();
    }
    void Ulasim()
    {
        DataTable dtUlasim = klas.GetDataTable("Select * from Ulasim");
        chckUlasim.DataTextField = "Ulasim";
        chckUlasim.DataValueField = "UlasimId";
        chckUlasim.DataSource = dtUlasim;
        chckUlasim.DataBind();
    }
    void Yeme()
    {
        DataTable dtYeme = klas.GetDataTable("Select * from Yeme");
        chckYeme.DataTextField = "Yeme";
        chckYeme.DataValueField = "YemeId";
        chckYeme.DataSource = dtYeme;
        chckYeme.DataBind();
    }
    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        //Aktiviteler kaydediliyor        
        if (chckAktivite.Items.Count > 0)
        {
            for (int i = 0; i < chckAktivite.Items.Count; i++)
            {
                if (chckAktivite.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliAktiviteler (ilanId,AktiviteId) values(@ilanId,@AktiviteId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("AktiviteId", chckAktivite.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Altyapı kaydediliyor 
        if (chckAltYapi.Items.Count > 0)
        {
            for (int i = 0; i < chckAltYapi.Items.Count; i++)
            {
                if (chckAltYapi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliAltYapi (ilanId,AltYapiId) values(@ilanId,@AltYapiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("AltYapiId", chckAltYapi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Banyo Özellikleri kaydediliyor 
        if (chckBanyoOzellikler.Items.Count > 0)
        {
            for (int i = 0; i < chckBanyoOzellikler.Items.Count; i++)
            {
                if (chckBanyoOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliBanyoOzellikler (ilanId,BanyoOzellikId) values(@ilanId,@BanyoOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("BanyoOzellikId", chckBanyoOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Bina Detayları kaydediliyor 
        if (chckBinaDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckBinaDetay.Items.Count; i++)
            {
                if (chckBinaDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliBinaDetay (ilanId,BinaDetayId) values(@ilanId,@BinaDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("BinaDetayId", chckBinaDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Cephe kaydediliyor 
        if (chckCephe.Items.Count > 0)
        {
            for (int i = 0; i < chckCephe.Items.Count; i++)
            {
                if (chckCephe.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliCephe (ilanId,CepheId) values(@ilanId,@CepheId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("CepheId", chckCephe.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Dış Özellikler kaydediliyor 
        if (chckDis.Items.Count > 0)
        {
            for (int i = 0; i < chckDis.Items.Count; i++)
            {
                if (chckDis.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliDisOzellikler (ilanId,DisOzellikId) values(@ilanId,@DisOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("DisOzellikId", chckDis.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //İç Özellikler kaydediliyor 
        if (chckic.Items.Count > 0)
        {
            for (int i = 0; i < chckic.Items.Count; i++)
            {
                if (chckic.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliicOzellikler (ilanId,icOzellikId) values(@ilanId,@icOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("icOzellikId", chckic.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Kamp Detayları kaydediliyor 
        if (chckKampDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckKampDetay.Items.Count; i++)
            {
                if (chckKampDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliKampDetay (ilanId,KampDetayId) values(@ilanId,@KampDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("KampDetayId", chckKampDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Manzara kaydediliyor 
        if (chckManzara.Items.Count > 0)
        {
            for (int i = 0; i < chckManzara.Items.Count; i++)
            {
                if (chckManzara.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliManzara (ilanId,ManzaraId) values(@ilanId,@ManzaraId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ManzaraId", chckManzara.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Manzara kaydediliyor 
        if (chckMuhit.Items.Count > 0)
        {
            for (int i = 0; i < chckMuhit.Items.Count; i++)
            {
                if (chckMuhit.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliMuhit (ilanId,MuhitId) values(@ilanId,@MuhitId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("MuhitId", chckMuhit.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Mutfak Özellikleri kaydediliyor 
        if (chckMutfak.Items.Count > 0)
        {
            for (int i = 0; i < chckMutfak.Items.Count; i++)
            {
                if (chckMutfak.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliMutfak (ilanId,MutfakId) values(@ilanId,@MutfakId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("MutfakId", chckMutfak.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Oda Özellikleri kaydediliyor 
        if (chckOdaOzellik.Items.Count > 0)
        {
            for (int i = 0; i < chckOdaOzellik.Items.Count; i++)
            {
                if (chckOdaOzellik.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliOdaOzellikler (ilanId,OdaOzellikId) values(@ilanId,@OdaOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OdaOzellikId", chckOdaOzellik.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Oda Tipi kaydediliyor 
        if (chckOdaTipi.Items.Count > 0)
        {
            for (int i = 0; i < chckOdaTipi.Items.Count; i++)
            {
                if (chckOdaTipi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliOdaTipi (ilanId,OdaTipiId) values(@ilanId,@OdaTipiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OdaTipiId", chckOdaTipi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Ortak Kullanım Alanları kaydediliyor 
        if (chckOrtak.Items.Count > 0)
        {
            for (int i = 0; i < chckOrtak.Items.Count; i++)
            {
                if (chckOrtak.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliOrtak (ilanId,OrtakId) values(@ilanId,@OrtakId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OrtakId", chckOrtak.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Parsel Durumu kaydediliyor 
        if (chckParsel.Items.Count > 0)
        {
            for (int i = 0; i < chckParsel.Items.Count; i++)
            {
                if (chckParsel.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliParselDurumu (ilanId,ParselDurumuId) values(@ilanId,@ParselDurumuId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ParselDurumuId", chckParsel.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Tesis Detayları kaydediliyor 
        if (chckTesisDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckTesisDetay.Items.Count; i++)
            {
                if (chckTesisDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliTesisDetay (ilanId,TesisDetayId) values(@ilanId,@TesisDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("TesisDetayId", chckTesisDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Ulaşım Olanakları kaydediliyor 
        if (chckUlasim.Items.Count > 0)
        {
            for (int i = 0; i < chckUlasim.Items.Count; i++)
            {
                if (chckUlasim.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliUlasim (ilanId,UlasimId) values(@ilanId,@UlasimId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("UlasimId", chckUlasim.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Yeme İçme Olanakları kaydediliyor 
        if (chckYeme.Items.Count > 0)
        {
            for (int i = 0; i < chckYeme.Items.Count; i++)
            {
                if (chckYeme.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliYeme (ilanId,YemeId) values(@ilanId,@YemeId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("YemeId", chckYeme.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Residence Özellikler kaydediliyor 
        if (chckResidenceOzellikler.Items.Count > 0)
        {
            for (int i = 0; i < chckResidenceOzellikler.Items.Count; i++)
            {
                if (chckResidenceOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliResidenceOzellikler (ilanId,ResidenceOzellikId) values(@ilanId,@ResidenceOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ResidenceOzellikId", chckResidenceOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Residence Sosyal Olanaklar kaydediliyor 
        if (chckResidenceSosyal.Items.Count > 0)
        {
            for (int i = 0; i < chckResidenceSosyal.Items.Count; i++)
            {
                if (chckResidenceSosyal.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliResidenceSosyal (ilanId,ResidenceSosyalId) values(@ilanId,@ResidenceSosyalId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ResidenceSosyalId", chckResidenceSosyal.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Konut Tipi kaydediliyor 
        if (chckKonutTipi.Items.Count > 0)
        {
            for (int i = 0; i < chckKonutTipi.Items.Count; i++)
            {
                if (chckKonutTipi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("insert into SeciliKonutTipi (ilanId,KonutTipiId) values(@ilanId,@KonutTipiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("KonutTipiId", chckKonutTipi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        Response.Redirect("ilanEkle4.aspx?ilanId=" +ilanId);
    }
}