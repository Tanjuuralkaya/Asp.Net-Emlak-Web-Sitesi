<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="ilYonetimi.aspx.cs" Inherits="adminpanel_ilYonetimi" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Stil_yonetim.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 600px;
        }
        .auto-style3 {
            width: 25%;
            height: 22px;
            text-align: center;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style6 {
            width: 20%;
            height: 22px;
        }
        .auto-style7 {
            width: 25%;
            height: 22px;
            text-align: center;
            justify-content:center;
            
        }
        .auto-style8 {
            width: 16%;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 300px;
        }
        
    </style>
    <script type="text/javascript">
        function pageLoad(sender, args) {
            if (!args.get_isPartialLoad()) {
                //  add our handler to the document's
                //  keydown event
                $addHandler(document, "keydown", onKeyDown);
            }
        }

        function onKeyDown(e) {
            if (e && e.keyCode == Sys.UI.Key.esc) {
                // if the key pressed is the escape key, dismiss the dialog
                $find('ModalPopupExtender1').hide();
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" style="width:200px;" runat="server" Font-Bold="True" ForeColor="#990000" OnClick="LinkButton1_Click">İl-İlçe-Semt Ekle</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="auto-style2">
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button1" runat="server" Text="İl Düzenleme" OnClick="Button1_Click" />
                        </td>
                        <td class="auto-style3">
                            <asp:Button ID="Button2" runat="server" Text="İlçe Düzenleme" OnClick="Button2_Click" />
                        </td>
                        <td class="auto-style3">
                            <asp:Button ID="Button3" runat="server" Text="Semt Düzenleme" OnClick="Button3_Click" />
                        </td>
                        <td class="auto-style3">
                            <asp:Button ID="Button4" runat="server" Text="Mahalle Düzenleme" OnClick="Button4_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:ModalPopupExtender BackgroundCssClass="sayfaarkaplan"   CancelControlID="btnHayiril" PopupControlID="pnlilsil" TargetControlID="btnSilil" ID="ModalPopupExtender1" runat="server">

                </asp:ModalPopupExtender>
                <asp:Panel ID="pnlil" Visible ="False" runat="server">
                    <table class="auto-style2">
                    <tr>
                        <td style="width:20%;">
                            <asp:DropDownList style="width:150px;"  ID="dddil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dddil_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:TextBox ID="txtil" runat="server"></asp:TextBox>
                        </td>
                        <td style="width:10%;">
                            <asp:Button ID="btnGuncelleil" runat="server" OnClick="btnGuncelleil_Click" Text="Güncele" />
                        </td>
                        <td class="auto-style6">
                            <asp:Button Width="60px" ID="btnSilil" runat="server"  />
                            <asp:Label runat="server" Text="lblBilgisil" style="text-align:left; margin-left:10px;"></asp:Label>
                        </td>
                    </tr>
                </table>
                    <asp:Panel  Width="300" Height="80"   ID="pnlilsil" runat="server" BackColor="#33CCCC" BorderColor="#006699" BorderWidth="4px"  >

                        <table align="center" class="auto-style10">
                            <tr>
                                <td colspan="2">İli Silmek İstediğinizden Emin misiniz?</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Button ID="btnEvetil" runat="server" Text="Evet" OnClick="btnEvetil_Click" />
                                </td>
                                <td style="text-align: center">
                                    <asp:Button ID="btnHayiril" runat="server" Text="Hayır"  />
                                </td>
                            </tr>
                        </table>

                    </asp:Panel>

                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Panel ID="pnlilce" runat="server" Visible="False">
                    <table class="auto-style2">
                    <tr>
                        <td class="auto-style7">
                            <asp:DropDownList ID="ddl_ilce_il"  style="width:150px;" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_ilce_il_SelectedIndexChanged" Width="30%">
                            </asp:DropDownList>
                        </td>
                        <td  class="auto-style7">
                                <asp:DropDownList ID="ddl_ilce"  style="width:150px;" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_ilce_SelectedIndexChanged" >
                                </asp:DropDownList>
                        </td>
                        <td  class="auto-style7">
                            <asp:TextBox ID="txtilce" runat="server"></asp:TextBox>
                        </td>
                        <td style="float:left;">
                            <asp:Button ID="btnGuncelleilce" runat="server" Text="Güncelle" OnClick="btnGuncelleilce_Click" />
                        </td>
                        <td class="auto-style7">
                            &nbsp;</td>
                    </tr>
                </table>

                </asp:Panel>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style4">

                <asp:Panel ID="pnlsemt" runat="server" Visible="False">
                    <table class="auto-style2">
                    <tr>
                        <td style="width:20%;">
                            <asp:DropDownList ID="ddl_il3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_il3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:DropDownList ID="ddl_ilce_3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_ilce_3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:DropDownList ID="ddl_semt" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_semt_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:TextBox ID="txt_semt" runat="server"></asp:TextBox>
                        </td>
                        <td style="width:20%;">
                            <asp:Button ID="btnGuncelleSemt" runat="server" OnClick="btnGuncelleSemt_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>


                </asp:Panel>
                            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Panel ID="pnlMahalle" runat="server" Visible="False">

                    <table class="auto-style1">
                    <tr>
                        <td class="auto-style8">
                            <asp:DropDownList ID="ddlil4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style8">
                            <asp:DropDownList ID="ddlilce4" runat="server" AutoPostBack="True" Height="21px" OnSelectedIndexChanged="ddlilce4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style8">
                            <asp:DropDownList ID="ddlsemt4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlsemt4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style8">
                            <asp:DropDownList ID="ddlmahalle4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlmahalle4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtMahalle" runat="server" OnTextChanged="txtMahalle_TextChanged"></asp:TextBox>
                        </td>
                        <td class="auto-style9">
                            <asp:Button ID="btnMahalleGuncelle"  runat="server" Text="Güncelle" OnClick="btnMahalleGuncelle_Click" />
                        </td>
                    </tr>
                </table>
                </asp:Panel>
            </td>
        </tr>
        <tr class="auto-style4">
            <td>

                &nbsp;</td>
        </tr>
        <tr class="auto-style4">
            <td>

                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

