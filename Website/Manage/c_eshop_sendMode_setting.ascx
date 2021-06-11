<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_eshop_sendMode_setting.ascx.cs" Inherits="Manage_c_shop_sendMode_setting" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

           
          
         
          




         <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="" runat="server" ID="overView" >
       
    
       
                
               <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px">
                            <strong><span>لطفا اطلاعات درخواستی فرم زیر را تکمیل نمایید:</span></strong></div>
                    </div>
                    <div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                        margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
                        margin-top: 10px; padding-bottom: 10px; border-bottom: red 2px solid; height: 45px;
                        text-align: right; overflow: auto" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; margin-bottom: 5px; float: right;
                            width: 493px; color: red; padding-top: 5px; height: 26px">
                            توجه!<br />
                            <span style="font-size: 9pt">کلمه عبور فعلی صحیح نمی باشد لطفا مجددا سعی نمایید.</span>
                        </div>
                        <br />
                    </div>
                    <div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                        margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
                        border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">عملیات موفقیت آمیز<br />
                                <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                        <br />
                    </div>
                    <div id="rows_mode2" runat="server">
                        <div class="row">
                            <div class="field">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_iranmcMaxOrderPrice"
                                    ErrorMessage="حداکثر مبلغ سفارش را درج نمایید" ValidationGroup="ChangePass">*</asp:RequiredFieldValidator>
                                حداکثر مبلغ سفارش ریال</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="Txt_iranmcMaxOrderPrice" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                        <div id="rows_mode3" runat="server">
                        <div class="row">
                            <div class="field">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_iranmcMaxOrderPrice"
                                    ErrorMessage="حداکثر مبلغ سفارش را درج نمایید" ValidationGroup="ChangePass">*</asp:RequiredFieldValidator>
                               مبلغ ارسال با آژانس تا ترمینال هر 50 کیلو</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="Txt_sendmode2_by_agent_per502kg" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                    <br />
                    <div>
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" DisplayMode="List"
                            HeaderText="لطفا به موارد زیر توجه کنید:" ValidationGroup="ChangePass" />
                    </div>

            </DotNetAge:View>
         
        </Views>
    </DotNetAge:Tabs>
     
            <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" runat="server" BorderStyle="Solid" CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="ChangePass" />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف" />
                            
            </div>

           


    </ContentTemplate>
</asp:UpdatePanel>


  <div class="ui-widget">
			</div>