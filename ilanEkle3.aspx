<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle3.aspx.cs" Inherits="ilanEkle3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

 
    <asp:Panel Visible="false" ID="pnlAktivite" runat="server">
        <div class="AyrOzellik_Baslik">Aktiviteler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckAktivite" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlAltYapi" runat="server">
        <div class="AyrOzellik_Baslik">Alt Yapı</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckAltYapi" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlBanyo" runat="server">
        <div class="AyrOzellik_Baslik">Banyo Özellikler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckBanyoOzellikler" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlBinaDetay" runat="server">
        <div class="AyrOzellik_Baslik">Bina Detay</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckBinaDetay" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlCephe" runat="server">
        <div class="AyrOzellik_Baslik">Cephe</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckCephe" runat="server" RepeatColumns="7">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlDisOzellik" runat="server">
        <div class="AyrOzellik_Baslik">Dış Özellikler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckDis" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlicOzellik" runat="server">
        <div class="AyrOzellik_Baslik">İç Özellikler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckic" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlKampDetay" runat="server">
        <div class="AyrOzellik_Baslik">Kamp Detay</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckKampDetay" runat="server" RepeatColumns="4">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlManzara" runat="server">
        <div class="AyrOzellik_Baslik">Manzara</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckManzara" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlMuhit" runat="server">
        <div class="AyrOzellik_Baslik">Muhit</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckMuhit" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlMutfak" runat="server">
        <div class="AyrOzellik_Baslik">Mutfak</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckMutfak" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlOdaOzellik" runat="server">
        <div class="AyrOzellik_Baslik">Oda Özellikler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckOdaOzellik" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>
    
    <asp:Panel Visible="false" ID="pnlOdaTipi" runat="server">
        <div class="AyrOzellik_Baslik">Oda Tipi</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckOdaTipi" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlOrtak" runat="server">
        <div class="AyrOzellik_Baslik">Ortak Kullanım Alanları</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckOrtak" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlParsel" runat="server">
        <div class="AyrOzellik_Baslik">Parsel Durumu</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckParsel" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlTesisDetay" runat="server">
        <div class="AyrOzellik_Baslik">Tesis Detay</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckTesisDetay" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlUlasim" runat="server">
        <div class="AyrOzellik_Baslik">Ulaşım</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckUlasim" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlYeme" runat="server">
        <div class="AyrOzellik_Baslik">Yeme İçme Olanakları</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckYeme" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlResidenceOzellikler" runat="server">
        <div class="AyrOzellik_Baslik">Residence Özellikler</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckResidenceOzellikler" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlResidenceSosyal" runat="server">
        <div class="AyrOzellik_Baslik">Residence Sosyal Olanaklar</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckResidenceSosyal" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlKonutTipi" runat="server">
        <div class="AyrOzellik_Baslik">Konut Tipi</div>
        <div class="AyrOzellik">
            <asp:CheckBoxList ID="chckKonutTipi" runat="server" RepeatColumns="5">
            </asp:CheckBoxList>
        </div>
    </asp:Panel>

    <div style="text-align: center; padding-top: 10px;">
        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
        <div style="padding-top:75px;"></div>
    </div>



</asp:Content>

