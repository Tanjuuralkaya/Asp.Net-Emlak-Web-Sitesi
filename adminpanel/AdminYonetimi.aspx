<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="AdminYonetimi.aspx.cs" Inherits="adminpanel_AdminYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 300px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <table align="left" class="auto-style2">
                    <tr>
                        <td Width="40%">Kullnıcı Adı:</td>
                        <td>
                            <asp:TextBox ID="txtAra" runat="server" Width="147px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnAra" runat="server" Text="Ara" Width="73px" OnClick="btnAra_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblAra" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td aria-selected="undefined">
                <asp:DataList ID="dlAra" runat="server" Width="100%" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1" style="font-size: 17px">
                            <tr>
                                <td style="width:30%;">Kullanıcı Adı</td>
                                <td style="width:30%;">Ad Soyad</td>
                                <td style="width:30%;">Görevi </td>
                                <td style="width:10%;">Düznele</td>
                                <td style="width:10%;">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1" style="font-size: 17px">
                            <tr>
                                <td style="width:30%;" ><%#Eval("KullaniciAdi") %></td>
                                <td style="width:30%;"><%#Eval("AdSoyad") %></td>
                                <td style="width:30%;"><%#Eval("GrupAdi") %></td>
                                <td style="width:10%;">
                                    <a href="KullaniciDuzenle.aspx?KullaniciId=<%#Eval("KullaniciId ") %>" ><img style="border:0px; height:20px;" src="../İmage/duzenlee.png" /></a>

                                </td>
                                <td style="width:10%;">
                                   <a href="AdminYonetimi.aspx?KullaniciId=<%#Eval("KullaniciId")%>&islem=sil "> <img  style="border:0px; height:20px;" src="../İmage/siil2.png" /></a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                  
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                  
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td  style="width:16%; margin-left: 40px;">
                            <asp:Button ID="btnYonetici" runat="server" Text="Yöneticiler" Width="97px" OnClick="btnYonetici_Click" />
                        </td>
                        <td style="width:16%;">
                            <asp:Button ID="btnYardimci" runat="server" Text="Yardımcı Yönetici" Width="117px" OnClick="btnYardimci_Click" style="margin-left: 39px" />
                        </td>
                        <td style="width:16%;">
                            <asp:Button ID="btnEmlakcı" runat="server" Text="Emlakçılar" OnClick="btnEmlakcı_Click" style="margin-left: 43px" />
                        </td>
                        <td style="width:16%;">&nbsp;
                            <asp:Button ID="btnKullanicilar" runat="server" Text="Kullanıcılar" Width="77px" OnClick="btnKullanicilar_Click" style="margin-left: 20px" />
                       </td>
                        <td style="width:16%;">
                            <asp:Button ID="btnSon" runat="server" Text="Son 10 üye" OnClick="btnSon_Click" style="margin-left: 33px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlKullanici" runat="server" Width="100%" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1" style="font-size: 17px">
                            <tr>
                                <td style="width:30%;">Kullanıcı Adı</td>
                                <td style="width:30%;">Ad Soyad</td>
                                <td style="width:30%;">Görevi </td>
                                <td style="width:10%;">Düznele</td>
                                <td style="width:10%;">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1" style="font-size: 17px">
                            <tr>
                                <td style="width:30%;" ><%#Eval("KullaniciAdi") %></td>
                                <td style="width:30%;"><%#Eval("AdSoyad") %></td>
                                <td style="width:30%;"><%#Eval("GrupAdi") %></td>
                                <td style="width:10%;">
                                    <a href="KullaniciDuzenle.aspx?KullaniciId=<%#Eval("KullaniciId")%>"><img style="border:0px; height:20px;" src="../İmage/duzenlee.png" /></a>
                                    <!-- kullaniciId yi gondererek kullanıcı duzenle sayfasına gıttı.-->
                                </td>
                                <td style="width:10%;">
                                    <a href="AdminYonetimi?KullaniciId=<%#Eval("KullaniciId")%>&islem=sil "><img  style="border:0px; height:20px;" src="../İmage/siil2.png" /></a>
                                    <!-- kullaniciId yi gondererek admın yonetım sayfasına gıttı.-->
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                  
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                  
                </asp:DataList>
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

