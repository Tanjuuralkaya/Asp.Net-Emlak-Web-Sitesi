<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle2.aspx.cs" Inherits="ilanEkle2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!--Arsa Özellikleri Bulunmaktadır.-->
    <asp:Panel ID="pnlArsa"   Visible="false" runat="server" >
        <div class="ilan2_baslik">Arsa Genel Özellikleri</div>
        <div class="ilan2_sol">İmar Durumu:</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlimarDurumu" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>


        <div class="ilan2_sol">Kaks:</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlKaks" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Gabari:</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlGabari" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Tapu</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlTapu" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kredi Durumu</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlKredi" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>


        <div class="ilan2_sol">MetreKare</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtMetre_Arsa" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Ada No</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtAda" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Pafta No</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtPafta" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>


        <div class="ilan2_sol">Parsel No</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtParsel" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>


        <div class="ilan2_sol">Kat Karşılığı</div>
        <div class="ilan2_sag">
            <asp:RadioButton ID="rdEvet" runat="server" GroupName="Kat" Text="Evet" Checked="True" />
            <asp:RadioButton ID="rdHayir" GroupName="Kat" Text="Hayır" runat="server" />
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol"></div>
        <div class="ilan2_sag">
            <asp:Button ID="btnArsaKaydet" runat="server" Text="Kaydet" OnClick="btnArsaKaydet_Click"/>
        </div>
        <div class="temizle"></div>
        <div style="padding-top: 35px"></div>
    </asp:Panel>

<!--Bina Özellikleri Bulunmaktadır.-->
    <asp:Panel ID="pnlBina" Visible="false" runat="server">
        <div class="ilan2_baslik">Bina Genel Özellikleri</div>
        <div class="ilan2_sol">Binadaki Kat Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtKatSayisi" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kattaki Daire Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtKattakiDaire" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Isıtma Türü</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlisitma_Bina" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">MetreKare</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtMetre_Bina" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Bina Yaşı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlBinaYasi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol"></div>
        <div class="ilan2_sag">
            <asp:Button ID="btnBinaKaydet" runat="server" Text="Kaydet" OnClick="btnBinaKaydet_Click" />
        </div>
        <div class="temizle"></div>

        <div style="padding-top: 45px"></div>
    </asp:Panel>

    <!--Devremülk Özellikleri Bulunmaktadır.-->
    <asp:Panel ID="pnlDevre" Visible="false" runat="server">

        <div class="ilan2_baslik">Devremülk Genel Özellikleri</div>
        <div class="ilan2_sol">Dönemi</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlDonem" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Süresi</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlSure" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Oda Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtDevre_Oda" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol"></div>
        <div class="ilan2_sag">
            <asp:Button ID="btnDevreKaydet" runat="server" Text="Kaydet" OnClick="btnDevreKaydet_Click"/>
        </div>
        <div class="temizle"></div>
        <div style="padding-top: 45px"></div>
    </asp:Panel>
    <!--Konut Özellikleri Bulunmaktadır.-->
    <asp:Panel ID="pnlKonut" Visible="false" runat="server">

        <div class="ilan2_baslik">Konut Genel Özellikleri</div>
        <div class="ilan2_sol">Isıtma Türü</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlIsitma_Konut" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Oda Sayısı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlOda_Konut" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Banyo Sayısı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlBanyo_Konut" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Bina Yaşı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlBinaYasi_Konut" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kredi Durumu</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlKredi_Konut" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Binadaki Kat</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtBinadakiKat" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Bulunduğu Kat</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtBulundugu" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Metrekare</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtMetre_Konut" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Bina Durumu</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlDurum_Konut" runat="server">
            </asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol"></div>
        <div class="ilan2_sag">
            <asp:Button ID="btnKonutKaydet" runat="server" Text="Kaydet" OnClick="btnKonutKaydet_Click"/>
        </div>
        <div style="text-align:center;">
            <asp:Literal ID="ltrlBilgi" runat="server"></asp:Literal>
        </div>
        <div class="temizle"></div>
        <div style="padding-top: 45px"></div>
    </asp:Panel>
    <!--Turistik tesis  Özellikleri Bulunmaktadır.-->
    <asp:Panel ID="pnlTurislik" Visible="false" runat="server">

        <div class="ilan2_baslik">Turistik Tesis Genel Özellikleri</div>
        <div class="ilan2_sol">Yıldız Sayısı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlYildiz" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Oda Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtOdaSayisi" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Yatak Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtYatakSayisi" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kat Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtKat_Turistik" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Bina Yaşı</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlBinaYasi_Turistik" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Açık Alan</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtAcik" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kapalı Alan</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtKapali" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Zemin Etüdü</div>
        <div class="ilan2_sag">
            <asp:RadioButton ID="rdVar" runat="server" GroupName="Zemin" Text="Var" Checked="True" />
            <asp:RadioButton ID="rdYok" GroupName="Zemin" Text="Yok" runat="server" />
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Kredi Durumu</div>
        <div class="ilan2_sag">
            <asp:DropDownList ID="ddlKredi_Turistik" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol">Apart Sayısı</div>
        <div class="ilan2_sag">
            <asp:TextBox ID="txtApart" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div>

        <div class="ilan2_sol"></div>
        <div class="ilan2_sag">
            <asp:Button ID="btnTuristikKaydet" runat="server" Text="Kaydet" OnClick="btnTuristikKaydet_Click"/>
        </div>
        <div class="temizle"></div>
        <div style="padding-top:45px;"></div>
    </asp:Panel>
</asp:Content>

