<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="adminpanel_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 400px;
        }
        .auto-style3 {
            width: 106px;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body style="background-image: url('../İmage/bg_butonlar.gif'); background-repeat: repeat;background-color:#9FE6FE;">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td style="text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 16px; font-weight: bold; color: #FF0066;">Giriş Paneli</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <table align="center" class="auto-style2" style="border: medium double #3399FF">
                        <tr>
                            <td  style="justify-content:center; text-align: center;" colspan="2" class="auto-style4" >
                                <asp:Label ID="lblBilgi" runat="server" font-size="Larger" ForeColor="#660033"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Kullanıcı Adı :</td>
                            <td>
                                <asp:TextBox ID="TextKullaniciAdi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Şifre :</td>
                            <td>
                                <asp:TextBox ID="TextSifre" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnGiriş" runat="server" Text="Giriş" OnClick="btnGiriş_Click" Width="52px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
