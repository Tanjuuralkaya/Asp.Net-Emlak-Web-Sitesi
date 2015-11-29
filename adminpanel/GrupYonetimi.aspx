<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="GrupYonetimi.aspx.cs" Inherits="adminpanel_GrupYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
            width: 70%;
        }
        .auto-style5 {
            width: 600px;
        }
        .auto-style6 {
            height: 22px;
            width: 20%;
        }
        .auto-style7 {
            width: 20%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2" style="width:80%">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" style="font-weight:bold;">Grup Adı :</td>
            <td class="auto-style4" style="width:80%">
                <asp:TextBox ID="txtGrupAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" style="width:60px" OnClick="btnEkle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <table align="center"  class="auto-style5">
        <asp:Repeater ID="rpGruplar" runat="server">
            <ItemTemplate>
         <tr>
            <td style="width:60%"><%#Eval("GrupAdi") %></td>
            <td style="width:20%; text-align:center;">Düzenle
                <a href="GrupGuncelle.aspx?GrupId=<%#Eval("GrupId") %>"><img style="width:15px;height:15px;border:0px;" src="../İmage/duzenlee.png" /></a></td>
            <td style="width:20%; text-align:center;">Sil   
                 <a href="GrupYonetimi.aspx?GrupId=<%#Eval("GrupId") %>&islem=sil"><img style="width:15px; height:15px; border:0px; " src="../İmage/siil2.png" /></a>

            </td>
        </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>

</asp:Content>

