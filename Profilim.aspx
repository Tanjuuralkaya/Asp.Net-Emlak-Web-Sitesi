<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Profilim.aspx.cs" Inherits="Profilim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server" >

    <div id="profil_butonlar">
        <ul>
            <li> <asp:LinkButton ID="lbkulBilgi" runat="server" BackColor="#3399FF">Bilgilerim</asp:LinkButton> </li>
            <li>
                <asp:LinkButton ID="lbMesajlari" runat="server" BackColor="#3399FF">İlanlarım</asp:LinkButton> </li>
            <li> <asp:LinkButton ID="lbİlanlarim" runat="server" BackColor="#3399FF">Mesajlarım</asp:LinkButton>  </li>
            
        </ul>
    </div>
        
    <div  style="width: 711px; height: 634px; margin-top: 12px; margin-right:0px; margin-left:0px; " >
        <div id="profil_resim"><img src='KullaniciResimleri/<asp:Literal ID="ltrlResim" runat="server"></asp:Literal>' style="width: 95px; height: 109px; margin-left: 0px"/> </div>
     
      
        <div id="profil_adsoyad">
    <asp:Label ID="lblAdSoyad" runat="server"></asp:Label>  
            
    </div>


        <div id="profil_il">
    <asp:Label ID="lblil" runat="server"></asp:Label> -  
    <asp:Label ID="lblilce" runat="server"></asp:Label>
    </div>

        <div class="profil_satir">
            
            <div class="profil_satir1">Meslek: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblMeslek" runat="server" ></asp:Label></div>              
        </div>

            <div class="profil_satir">
                
            <div class="profil_satir1">Email: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblEmail" runat="server" ></asp:Label></div>               
        </div>

            <div class="profil_satir">
               
            <div class="profil_satir1">Telefon: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblTel" runat="server"></asp:Label>
                </div>               
        </div>

            <div class="profil_satir">
                
            <div class="profil_satir1">Telefon2: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblTel2" runat="server"></asp:Label>
                </div>               
        </div>


            <div class="profil_satir">
                
            <div class="profil_satir1">Gsm: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblGsm" runat="server"></asp:Label>
                </div>               
        </div>

         <div class="profil_satir">
               
            <div class="profil_satir1">Gsm2: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblGsm2" runat="server"></asp:Label>
                </div>               
        </div>

         <div class="profil_satir">
                
            <div class="profil_satir1">Fax: </div>
            <div class="profil_satir2">
                <asp:Label ID="lblFax" runat="server"></asp:Label>
                </div>               
        </div>

         <div class="profil_satir">
               
            <div class="profil_satir3">Adres: </div>
            <div class="profil_satir4">
                <asp:Label ID="lblAdres" runat="server"></asp:Label>
                </div>               
        </div>

        <div class="profil_satir">
    <asp:Button ID="btnDuzenle" runat="server" Text="Profili Düzenle" ForeColor="#660033" BackColor="#9966FF" BorderColor="#660066" Height="30px" OnClick="btnDuzenle_Click"/>
        </div>
    
      
    </div>

    <div id="Mesajlarim" style="width: 711px"></div>
    <div id="İlanlarim" style="width: 711px"></div>
</asp:Content>

