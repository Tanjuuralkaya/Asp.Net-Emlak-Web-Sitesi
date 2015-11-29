<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="TCkimlik.aspx.cs" Inherits="adminpanel_TCkimlik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 600px;
    }
    .auto-style2 {
        width: 184px;
    }
    .auto-style3 {
        width: 184px;
        height: 22px;
    }
    .auto-style4 {
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table align="center" class="auto-style1">
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style2">Tc No:</td>
        <td>
            <asp:TextBox ID="txtTc" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">İsim:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Soyad:</td>
        <td>
            <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Doğum Yılı:</td>
        <td>
            <asp:TextBox ID="txtDogum" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Kullanıcı Adı.</td>
        <td>
            <asp:TextBox ID="txtKullanici" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Şifre:</td>
        <td>
            <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="btnSorgula" runat="server" Text="Sorgula" />
        </td>
    </tr>
</table>

</asp:Content>

