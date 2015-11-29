<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="UyeOl.aspx.cs" Inherits="UyeOl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; color: #660033; text-align: center">
        <asp:Label ID="lblBilgi" runat="server" Text=""></asp:Label>
    </div>   
     <div class="Uyeol_satir"> </div>
    
    <div class="Uyeol_satir">

     <div class="uyeol_sol">Üyelik Türü:</div>
    <div class="uyeol_orta">
       
        <asp:RadioButton ID="rdKullanici" runat="server" Checked="True" GroupName="Uyelik" Text="Kullanıcı" />
        <asp:RadioButton ID="rdEmlakci" runat="server" GroupName="Uyelik" Text="Emlakçı" />
       
     </div>
    <div class="uyeol_sag">
       
     </div>
   </div> <!-- uyeol_satir bitti-->



    <div class="Uyeol_satir">

     <div class="uyeol_sol">Email:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtEmail"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" CssClass="hata_mesaj" Visible="False">Email Adresiniz Uygun Değil...</asp:RegularExpressionValidator>
     </div>
   </div>

     <!-- uyeol_satir bitti-->
         <div class="Uyeol_satir">
     <div class="uyeol_sol">Şifre</div>
             <div class="uyeol_orta">
                 <asp:TextBox ID="txtSifre"  runat="server" Width="152px" TextMode="Password"></asp:TextBox>
             </div>
             <div class="uyeol_sag">                 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSifre" CssClass="hata_mesaj">Lütfen Şifreyi Giriniz</asp:RequiredFieldValidator>
            </div>
   </div>
     <!-- uyeol_satir bitti-->

         <div class="Uyeol_satir">
     <div class="uyeol_sol">Şifre(Tekrar):</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtSifre2"  runat="server" Width="152px" TextMode="Password"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtSifre" ControlToValidate="txtSifre2" CssClass="hata_mesaj">Şifreler Yanlış Girildi</asp:CompareValidator>
     </div>
   </div><!-- uyeol_satir bitti-->

             <div class="Uyeol_satir">
     <div class="uyeol_sol">Ad Soyad:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtAdSoyad"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdSoyad" CssClass="hata_mesaj" Text="Lütfen Ad Soyad Giriniz."></asp:RequiredFieldValidator>
     </div>
   </div><!-- uyeol_satir bitti-->

             <div class="Uyeol_satir">
     <div class="uyeol_sol">Gsm:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtGsm"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

            <div class="Uyeol_satir">
     <div class="uyeol_sol">Gsm2:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtGsm2"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->
             <div class="Uyeol_satir">
     <div class="uyeol_sol">Telefon:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtTel"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

     <div class="Uyeol_satir">
     <div class="uyeol_sol">Telefon2:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtTel2"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

        <div class="Uyeol_satir">
     <div class="uyeol_sol">Fax:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtFax"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->


              <div class="Uyeol_satir">
     <div class="uyeol_sol">Meslek:</div>
    <div class="uyeol_orta">
        <asp:DropDownList ID="ddlMeslek" runat="server">
        </asp:DropDownList>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

              <div class="Uyeol_satir">
     <div class="uyeol_sol">Cinsiyet:</div>
    <div class="uyeol_orta">
        <asp:RadioButton ID="rdErkek" runat="server" Text="Erkek" Checked="True" />
        <asp:RadioButton ID="rdBayan" runat="server" Text="Bayan" />
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="Uyeol_satir">
     <div class="uyeol_sol">İl:</div>
    <div class="uyeol_orta">
        <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged1">
        </asp:DropDownList>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

              <div class="Uyeol_satir">
     <div class="uyeol_sol">İlçe:</div>
    <div class="uyeol_orta">
        <asp:DropDownList ID="ddlilce" runat="server">
        </asp:DropDownList>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->
            
        </ContentTemplate>
    </asp:UpdatePanel>

              <div class="Uyeol_satir">
     <div class="uyeol_sol">Doğum Tarihi:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtDogum"  runat="server" Width="152px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

                  <div class="Uyeol_satir">
     <div class="uyeol_sol">Resim:</div>
    <div class="uyeol_orta">
        <asp:FileUpload ID="fuResim" runat="server" />
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->

               <div class="Uyeol_satir2">
     <div class="uyeol_sol">
         <br />
         <br />
         <br />
         Adres:</div>
    <div class="uyeol_orta">
        <asp:TextBox ID="txtAdres"  runat="server" Width="200px" TextMode="MultiLine" Height="110px"></asp:TextBox>
     </div>
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->


    

        <div class="Uyeol_satir">
     <div class="uyeol_sol"></div>
    <div class="uyeol_orta">
     </div>
        <asp:Button ID="btnKaydet" runat="server" Text="Gönder" OnClick="btnKaydet_Click1" />
    <div class="uyeol_sag">
     </div>
   </div><!-- uyeol_satir bitti-->
</asp:Content>

