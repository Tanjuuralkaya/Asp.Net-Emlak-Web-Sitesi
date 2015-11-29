<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="KullaniciDuzenle.aspx.cs" Inherits="adminpanel_KullaniciDüzenle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 700px;
        }

        .auto-style3 {
            margin-left: 40px;
        }

        .auto-style5 {
            height: 22px;
        }

        .auto-style6 {
            width: 100px;
            height: 22px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table class="auto-style1">
        <tr>
            <td>
                <%-- <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"></asp:ScriptManager>--%>
                <ajaxtoolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </ajaxtoolkit:ToolkitScriptManager>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblBilgii" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>

                <table align="left" class="auto-style2">
                    <tr>

                        <td style="width: 100px;">Kullanıcı Adı:</td>
                        <td>
                            <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Ad Soyad:</td>
                        <td>
                            <asp:TextBox ID="txtAdsoyad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Şifre:</td>
                        <td>
                            <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Şifre Tekrar: </td>
                        <td>
                            <asp:TextBox ID="txtSifre2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Görevi:</td>
                        <td>
                            <asp:DropDownList ID="ddlGorevi" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Email:</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Adres:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtAdres" runat="server" Height="74px" TextMode="MultiLine" Width="506px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td style="width: 100px;">İli:</td>
                        <td class="auto-style3" rowspan="2">


                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <table class="auto-style1">
                                        <tr>
                                            <td>
                                                <asp:DropDownList ID="dddil" runat="server" Style="width: 100px;" OnSelectedIndexChanged="dddil_SelectedIndexChanged1" AutoPostBack="True" Height="18px" Width="69px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:DropDownList ID="ddlİlcesi" runat="server" Height="18px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>

                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>

                    <tr>
                        <td style="width: 100px;">İlçesi:</td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Telefon:</td>
                        <td>
                            <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td style="width: 100px;">Telefon2:</td>
                        <td>
                            <asp:TextBox ID="txtTelefon2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Gsm:</td>     
                        <td>
                            <asp:TextBox ID="txtGsm" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Gsm2:</td>
                        <td>
                            <asp:TextBox ID="txtGsm2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Fax:</td>
                        <td>
                            <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">Cinsiyet:</td>
                        <td class="auto-style5">
                            <asp:RadioButton ID="rdbErkek" runat="server" Checked="True" GroupName="Cinsiyet" Text="Erkek" />
                            <asp:RadioButton ID="rdbBayan" runat="server" GroupName="Cinsiyet" Text="Bayan" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Doğum Tarihi:</td>
                        <td class="auto-style5">
                            <ajaxtoolkit:CalendarExtender PopupButtonID="ImageButton1" TargetControlID="txtDogum" runat="server" Format="dd/MM/yyyy" DefaultView="Years"  Enabled="True"></ajaxtoolkit:CalendarExtender>
                            <asp:TextBox ID="txtDogum" runat="server" ReadOnly="true"></asp:TextBox>
                            <asp:ImageButton ID="ImageButton1" ImageUrl="../İmage/ok1.gif" Width="25px" padding-top="5px" runat="server" />


                        </td>

                    </tr>



                    <tr>
                        <td class="auto-style6">Engelleme:</td>
                        <td class="auto-style5">
                            <asp:RadioButton ID="rdEvet" runat="server" GroupName="Engel" Text="Evet" />
                            <asp:RadioButton ID="rdHayır" runat="server" GroupName="Engel" Text="Hayır" />
                        </td>

                    </tr>



                    <tr>
                        <td style="width: 100px;">&nbsp;</td>
                        <td>
                            <asp:Button ID="btnGüncelle" runat="server" Text="Güncelle" OnClick="btnGüncelle_Click1" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>

                </table>
            </td>
        </tr>

    </table>
</asp:Content>

