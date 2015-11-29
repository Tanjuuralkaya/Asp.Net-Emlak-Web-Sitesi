<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle.aspx.cs" Inherits="ilanEkle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <div class="ilan_hata">
        <asp:Literal ID="ltrlHata" runat="server"></asp:Literal>
    </div>


       <div class="ayir">
      <div class="satir_1">İlan Türü:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlilanTur" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlilanTur_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
           </div>


      <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">İlanın Alt Türü:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlilanAltTur" runat="server" Enabled="False"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>
       </ContentTemplate>
    </asp:UpdatePanel>

       <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">İlan Başlığı:</div>
    <div class="satir_2">
        <asp:TextBox ID="txtBaslik" runat="server" Width="170px"></asp:TextBox>
        <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" TargetControlID="txtBaslik" WatermarkText="Lütfen İlan Başlığını Giriniz" WatermarkCssClass="water" runat="server">

        </asp:TextBoxWatermarkExtender>
    </div>
    <div class="satir_3"></div>
      </div>

          <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">İşleminiz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlislem" runat="server"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>



            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Fiyat Türünüz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlFiyatTur" runat="server"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Fiyatınız: </div>
    <div class="satir_2">
        <asp:TextBox ID="txtFiyat" runat="server"></asp:TextBox>

        <asp:filteredtextboxextender TargetControlID="txtFiyat" FilterType="Numbers" ID="filteredtextboxextender1" runat="server">
            
        </asp:filteredtextboxextender>
    </div>
    <div class="satir_3"></div>
      </div>

         <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Kimden</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlKimden" runat="server"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">İl Seçiniz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">İlçeyi Seçiniz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlilce" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlilce_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Semti Seçiniz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlSemt" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlSemt_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Mahalleyi Seçiniz:</div>
    <div class="satir_2">
        <asp:DropDownList ID="ddlMahalle" runat="server" Enabled="False"></asp:DropDownList>
    </div>
    <div class="satir_3"></div>
      </div>

            
        </ContentTemplate>
    </asp:UpdatePanel>

            <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1">Takas İşlemi mi?</div>
    <div class="satir_2">
        <asp:RadioButton ID="rdTakasEvet" runat="server" Text="Evet" GroupName="takas" />
        <asp:RadioButton ID="rdTakasHayir" runat="server" Text="Hayır"  Checked="True" GroupName="takas" />
    </div>
    <div class="satir_3"></div>
      </div>
    <br />

    <div class="ayir2">
    <div class="temizle"></div>
      <div class="satir_5">
          Açıklama:</div>
    <div class="satir_4">
        <asp:TextBox ID="txtAciklama" runat="server" TextMode="MultiLine" Height="102px" Width="213px"></asp:TextBox>
    </div>
    <div class="satir_6"></div>
      </div>

        <div class="ayir2">
    <div class="temizle"></div>
      <div class="satir_5">
          Adres:</div>
    <div class="satir_4">
        <asp:TextBox ID="txtAdres" runat="server" Height="100px" TextMode="MultiLine" Width="210px"></asp:TextBox>
    </div>
    <div class="satir_6"></div>
      </div>

      <div class="ayir">   
    <div class="temizle"></div>
      <div class="satir_1"></div>
    <div class="satir_2">       
        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click"  />
    </div>
    <div class="satir_3"></div>
      </div>

    <br />
    <br />
    <br />
    <br />
    <br />


    <div class="profil_satir">   
        </div>



    
</asp:Content>

