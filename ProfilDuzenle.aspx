<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ProfilDuzenle.aspx.cs" Inherits="ProfilDüzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <div style="width: auto; height: auto; margin-top: 12px; margin-right: 0px; margin-left: 0px;">
        <div id="profil_resim">
            <asp:Image ID="imgResim" runat="server"  Style="width: 95px; height: 109px; margin-left: 0px" />
        </div>
        <div class="profil_satir">
            <div class="profil_satir1">Resim Ekle:</div>
            <div class="profil_satir2">
                <asp:FileUpload ID="fuResim" runat="server" />
            </div>
        </div>


        <div class="profil_satir">
            <div class="profil_satir1">Ad Soyad: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtAdSoyad" runat="server"></asp:TextBox>
            </div>
        </div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="profil_satir">
                    <div class="profil_satir1">İl:</div>
                    <div class="profil_satir2">
                        <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>


                <div class="profil_satir">
                    <div class="profil_satir1">İlçe:</div>
                    <div class="profil_satir2">
                        <asp:DropDownList ID="ddlilce" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <div class="profil_satir">
            <div class="profil_satir1">Meslek: </div>
            <div class="profil_satir2">
                <asp:DropDownList ID="ddlMeslek" runat="server"></asp:DropDownList>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir1">Telefon: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir1">Telefon2: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtTel2" runat="server"></asp:TextBox>

            </div>
        </div>


        <div class="profil_satir">

            <div class="profil_satir1">Gsm: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtGsm" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir1">Gsm2: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtGsm2" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir1">Fax: </div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir3">Adres: </div>
            <div class="profil_satir4">
                <asp:TextBox ID="txtAdres" runat="server" Height="42px" TextMode="MultiLine" Width="275px"></asp:TextBox>

            </div>
        </div>

        <div class="profil_satir">

            <div class="profil_satir3">
            </div>
            <div class="profil_satir4">
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" ForeColor="#660033" BackColor="#9966FF" BorderColor="#660066" Height="30px" OnClick="btnGuncelle_Click" />

            </div>
        </div>

        <div class="profil_satir">
        </div>


    </div>

</asp:Content>

