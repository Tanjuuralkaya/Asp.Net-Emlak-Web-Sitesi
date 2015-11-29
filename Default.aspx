<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="butonlar">
   	<div  id="daire_buton">
   	  <div id="daire_icon">
            	<div id="icon_ev"><a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image1','','resim/icon_evi2.png',1)"><img src="resim/icon_evi.png" width="84" height="88" id="Image1" /></a></div>
      </div>
      <div id="daire_satilik">
      		<div class="satilik">SATILIK</div>
        	<div class="satilik">KİRALIK</div>
      </div>
    </div>
    
    <div id="isyeri_buton">
   	  <div id="isyeri_icon">
        	<div id="icon_isyeri"><a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image2','','resim/icon_is2.png',1)"><img src="resim/icon_is.png" width="80" height="84" id="Image2" /></a></div>
      </div>
      <div id="isyeri_satilik">
      	    <div class="satilik_is">SATILIK</div>
        	<div class="satilik_is">KİRALIK</div>
            <div class="satilik_is">DEVREN</div>
      </div>
    </div>
    <div id="arsa_buton">
    	<div id="arsa_icon">
        	<div id="icon_arsa"><a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image3','','resim/icon_arsaa2.png',1)"><img src="resim/icon_arsaa.png" width="80" height="84" id="Image3" /></a></div>
        </div>
        <div id="arsa_satilik">
        	<div class="satilik">SATILIK</div>
        	<div class="satilik">KİRALIK</div>
        </div>
    </div>
    <div id="otel_buton">
   	  <div id="otel_icon">
        	<div id="icon_otel"><a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image4','','resim/icon_otell2.png',1)"><img src="resim/icon_otell.png" width="80" height="84" id="Image4" /></a></div>
      </div>
      <div id="otel_satilik">
      		<div class="satilik_otel">SATILIK</div>
        	<div class="satilik_otel">KİRALIK</div>
        	<div class="satilik_otel">DEVREN</div>
      </div>
    </div>
  </div><!--butonlar bıttı-->
  <div id="vitrin_ust"></div>
  <div id="vitrin_baslik">SEÇ BEĞEN SENİN OLSUN</div>
  <div id="vitrin">
  	  	<div class="vitrin_ilan">
    		<div class="vitrin_resim">
            	<img src="vitrin/havuz kenarı bina.png" height="96"  width="146" />
            </div>	
            <div class="sat">SATILIK</div>
            <div class="fiyat">200.000 Tl</div>
            <div class="ilce">Laleler</div>
            <div class="ilce">Toplu Evler</div>
        </div>
    <div class="vitrin_ilan">
    	<div class="vitrin_resim">
            	<img src="vitrin/deniz keanrı.jpg" height="96"  width="146" />
            </div>	
            <div class="sat">SATILIK</div>
            <div class="fiyat">200.000 Tl</div>
            <div class="ilce">Laleler</div>
            <div class="ilce">Toplu Evler</div>
    </div>
    <div class="vitrin_ilan">
    	<div class="vitrin_resim">
            	<img src="vitrin/oturma slonu.png" height="96"  width="146" />
            </div>	
            <div class="sat">SATILIK</div>
            <div class="fiyat">200.000 Tl</div>
            <div class="ilce">Laleler</div>
            <div class="ilce">Toplu Evler</div>
    </div>
    <div class="vitrin_ilan">
    	<div class="vitrin_resim">
            	<img src="vitrin/bina.jpg" height="96"  width="146" />
            </div>	
            <div class="sat">SATILIK</div>
            <div class="fiyat">200.000 Tl</div>
            <div class="ilce">Laleler</div>
            <div class="ilce">Toplu Evler</div>    	
    </div>
    <div class="vitrin_ilan">
    	<div class="vitrin_resim">
            	<img src="vitrin/bina.jpg" height="96"  width="146" />
            </div>	
            <div class="sat">SATILIK</div>
            <div class="fiyat">200.000 Tl</div>
            <div class="ilce">Laleler</div>
            <div class="ilce">Toplu Evler</div>
    </div>
  </div>
</asp:Content>

