<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle4.aspx.cs" Inherits="ilanEkle4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Panel ID="pnl_vitrin_a" runat="server">
        <div class="resim_baslik">Vitrin Resminizi Yükleyin</div>
        <div class="res_fu">
            <asp:FileUpload ID="fuVitrin" runat="server" />
        </div>
        <div class="res_btn">
            <asp:Button ID="btn_vitrin" runat="server" Text="Yükle" OnClick="btn_vitrin_Click" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_vitrin_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">Vitrin Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgVitrin" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res2_a" runat="server" Visible="False">
        <div class="temizle"></div>
        <div class="resim_baslik">2. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuiki" runat="server" />
        </div>
        <div>
            <asp:Button ID="btniki" runat="server" Text="Yükle" OnClick="btniki_Click" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res2_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">2. Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgRes2" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res3_a" runat="server" Visible="False">
        <div class="temizle"></div>
        <div class="resim_baslik">3. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuUc" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnUc" runat="server" Text="Yükle" OnClick="btnUc_Click" />
        </div>
    </asp:Panel>
    <asp:Panel ID="pnl_res3_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">3. Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgRes3" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res4_a" runat="server" Visible="False">
        <div class="temizle"></div>
        <div class="resim_baslik">4. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuDort" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnDort" runat="server" Text="Yükle" OnClick="btnDort_Click" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res4_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">4. Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgRes4" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res5_a" runat="server" Visible="False">
        <div class="temizle"></div>
        <div class="resim_baslik">5. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuBes" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnBes" runat="server" Text="Yükle" OnClick="btnBes_Click" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res5_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">5. Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgRes5" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_res6_a" runat="server" Visible="False">
        <div class="temizle"></div>
        <div class="resim_baslik">6. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuAlti" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnAlti" runat="server" Text="Yükle" OnClick="btnAlti_Click" />
        </div>
    </asp:Panel>
    <asp:Panel ID="pnl_res6_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">6. Resminiz</div>
            <div class="resim_yuklenen">
                <asp:Image ID="imgRes6" runat="server" Height="90px" Width="90px" />
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_son" runat="server">
        <div class="temizle"></div>
        <div style="font-family: Arial, Helvetica, sans-serif; color: #333333; font-size: 13px; padding-top: 10px;">İşleminizi tamamlamak için Aşağıdaki butona tıklayın.</div>
        <div style="padding-left: 200px; padding-top: 10px;">
            <asp:Button ID="btnDevam"
                runat="server" Text="Devam" OnClick="btnDevam_Click" />
        </div>
    </asp:Panel>

</asp:Content>

