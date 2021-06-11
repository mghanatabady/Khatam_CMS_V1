<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_settings.ascx.cs" Inherits="Manage_C_shop_settings" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

           
          
         
          




         <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="تنظیمات فروشگاه" runat="server" ID="overView" >
       
    
       
                
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

                               <div id="Div3" runat="server">
                        <div class="row">
                            <div class="field">
                              ارسال sms در  هنگام درج سفارش جدید
                                </div>
                            <div class="fieldInputArea">
                               <asp:CheckBox ID="chk_sendSmsToSaleManager" OnCheckedChanged="chkbox_sms_CheckedChanged" AutoPostBack="true" runat="server" />    
                            </div>
                        </div>
                        
                    </div>

                    <div id="rows_saleManagerCellPhone" runat="server">
                        <div class="row">
                            <div class="field">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txt_saleManagerCellPhone"
                                 runat="server" ErrorMessage="لطفا شماره موبایل مدیر فروش را در قالب 11 عدد به صورت 09127710277 درج نمایید"  Text="*" ValidationGroup="shop_setting" ValidationExpression="\d{11}"  ></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"   Text="*" ValidationGroup="shop_setting" ControlToValidate="txt_saleManagerCellPhone" runat="server" ErrorMessage="لطفا فیلد شماره موبایل مدیر فروش را تکمیل نمایید."></asp:RequiredFieldValidator>

                                موبایل مدیر فروش<a href="#" class="tooltipA" onmouseover="return tooltip('در صورت درج سفارش جدید برای این شماره موبایل sms ارسال می شود.');" onmouseout="return hideTip();" onClick="return false;">[?]</a></div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_saleManagerCellPhone" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                        <div id="rows_mode3" runat="server">
                        <div class="row">
                            <div class="field">
                                  ایمیل مدیر فروش</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_saleManagerEmail" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>


                                                  <div id="Div4" runat="server">
                        <div class="row">
                            <div class="field">
                              ارسال sms در  هنگام درج تراکنش آفلاین
                                </div>
                            <div class="fieldInputArea">
                               <asp:CheckBox ID="chk_sendSmsToTransManager" OnCheckedChanged="chkbox_sms_trans_CheckedChanged" AutoPostBack="true" runat="server" />    
                            </div>
                        </div>
                        
                    </div>


                                     <div id="rows_transManagerCellPhone" runat="server">
                        <div class="row">
                            <div class="field"> 
                            
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txt_transManagerCellPhone"
                                 runat="server" ErrorMessage="لطفا شماره موبایل مدیر فروش را در قالب 11 عدد به صورت 09127710277 درج نمایید"  Text="*" ValidationGroup="shop_setting" ValidationExpression="\d{11}"  ></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"   Text="*" ValidationGroup="shop_setting" ControlToValidate="txt_transManagerCellPhone" runat="server" ErrorMessage="لطفا فیلد شماره موبایل مدیر فروش را تکمیل نمایید."></asp:RequiredFieldValidator>

                                                          
                                موبایل تایید کننده تراکنش آفلاین</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_transManagerCellPhone" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                        <div id="Div2" runat="server">
                        <div class="row">
                            <div class="field">
                                ایمیل تایید کننده تراکنش آفلاین</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_transManagerEmail" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                    <div id="Div1" runat="server">
                        <div class="row">
                            <div class="field"> 
                                زمان اعتبار پیش فاکتور</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_invoice_exp" runat="server"  CssClass="from_txt">
                                <asp:ListItem Text="24 ساعت" Value="24"></asp:ListItem>
                                <asp:ListItem Text="48 ساعت" Value="48"></asp:ListItem>
                                <asp:ListItem Text="72 ساعت" Value="72"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        
                    </div>


                    <br />
                    <div>
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" DisplayMode="List"
                            HeaderText="لطفا به موارد زیر توجه کنید:" ValidationGroup="shop_setting" />
                    </div>

            </DotNetAge:View>
         
        </Views>
    </DotNetAge:Tabs>
     
            <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" runat="server" BorderStyle="Solid" CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="shop_setting" style="margin-right: 1px" />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف" />
                            
            </div>

           


    </ContentTemplate>
</asp:UpdatePanel>


  <div class="ui-widget">
			</div>
