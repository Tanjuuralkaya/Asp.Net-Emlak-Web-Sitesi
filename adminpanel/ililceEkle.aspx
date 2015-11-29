<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="ililceEkle.aspx.cs" Inherits="adminpanel_ililceEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 500px;
        }
        .auto-style3 {
            height: 22px;
            width:25%;
            
        }
        .auto-style4 {
            width: 18px;
        }
        .auto-style5 {
            width: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td style="width:25%">
                            <asp:Button ID="btnilEkle" runat="server" Text="İl Ekle" OnClick="btnilEkle_Click" />
                        </td>
                        <td style="width:25%">
                            <asp:Button ID="btnilceEkle" runat="server" Text="İlçe Ekle" Height="26px" OnClick="btnilceEkle_Click" />
                        </td>
                        <td style="width:25%">
                            <asp:Button ID="btnSemtEkle" runat="server" Text="Semt Ekle" OnClick="btnSemtEkle_Click" style="height: 26px" />
                        </td>
                        <td style="width:25%">
                            <asp:Button ID="btnMahalleEkle" runat="server" Text="Mahalle Ekle" OnClick="btnMahalleEkle_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlil"  runat="server" Visible="False">
                     <table class="auto-style2">
                    <tr>
                        <td style="width:150px;">
                            <asp:TextBox ID="txtil1" runat="server"></asp:TextBox>
                        </td>
                        <td style="width:100px;">
                            <asp:Button ID="btn_ilEkle" runat="server" Text="İl Ekle" OnClick="Button2_Click" />
                        </td>
                        <td style="width:250px;">
                            <asp:Label ID="lblBilgi1" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>


                </asp:Panel>
               
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlilce" runat="server" Visible="False">
                     <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:DropDownList ID="ddlil" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtilce" runat="server"></asp:TextBox>
                        </td>
                        <td  style="width:10%;">
                            <asp:Button ID="btn_ilceekle" runat="server" Text="Ekle" OnClick="btn_ilceekle_Click" style="height: 26px" />
                        </td>
                        <td style="width:35px;">
                            <asp:Label ID="lblBilgi2" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>

                </asp:Panel>
               
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlsemt" runat="server" Visible="False">
                    <table class="auto-style1">
                    <tr>
                        <td style="width:20%;"> 
                            <asp:DropDownList ID="ddlil2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil2_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:DropDownList ID="ddlilce2" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td style="width:15%">
                            <asp:TextBox ID="txtSemt" runat="server"></asp:TextBox>
                        </td>
                        <td style="width:10%;">
                            <asp:Button ID="btn_semtEkle" runat="server" Text="Ekle" OnClick="btn_semtEkle_Click" />
                        </td>
                        <td style="width:35%;">
                            <asp:Label ID="lblBilgi3" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
                
            </td>
        </tr>
        <tr>
            <td>

                <asp:Panel ID="pnlmahalle" runat="server" Visible="false">
                     <table class="auto-style1">
                    <tr>
                        <td style="width:15%;">
                            <asp:DropDownList ID="ddlil3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:15%;">
                            <asp:DropDownList ID="ddlilce3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlilce3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width:15%;">
                            <asp:DropDownList ID="ddlsemt3" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td style="width:20%;">
                            <asp:TextBox ID="txtMahalle" runat="server"></asp:TextBox>
                        </td>
                        <td style="width:10%;">
                            <asp:Button ID="btn_MahalleEkle" runat="server" Text="Ekle" OnClick="btn_MahalleEkle_Click" />
                        </td>
                        <td>
                            <asp:Label ID="lblBilgi4" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>               
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

