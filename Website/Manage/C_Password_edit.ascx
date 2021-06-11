﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_Password_edit.ascx.cs"
    Inherits="Manage_C_Password_edit" %>

<style type="text/css">
    #tabs ul
    {
        float: right;
        width: 99%;
    }
    #tabs ul li
    {
        float: right;
    }
    
    .ui-dialog-titlebar-close {
  visibility: hidden;
}

</style>

<script type="text/javascript">
    function setDialogInCenter() {
        if (typeof ($("div.ui-dialog")[0]) == "undefined") {
            setTimeout(setDialogInCenter, 100);
        }
        else {
            //reference  http://stackoverflow.com/questions/210717/using-jquery-to-center-a-div-on-the-screen
            $("div.ui-dialog").css("position", "absolute");
            $("div.ui-dialog").css("top", (($(window).height() - $("div.ui-dialog").outerHeight()) / 2) + $(window).scrollTop() + "px");
            $("div.ui-dialog").css("left", (($(window).width() - $("div.ui-dialog").outerWidth()) / 2) + $(window).scrollLeft() + "px");
        }
    }



    $(document).ready(function() {
        // bind your jQuery events here initially 
        setDialogInCenter();
 
        });
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_endRequest(
        function () {
            setDialogInCenter();
       

            // re-bind your jQuery events here 
        }); 
</script>



               <!--   <script type="text/javascript">
                    function startStop() {     clearInterval(countdown); }​ 
                </script> -->
             
                

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

           <DotNetAge:Dialog ID="DemoDialog" runat="server" 
                Title="انتقال به صفحه ورود"  ShowModal="True" IsDraggable="False"  
               HideEffect="None" DialogIcon="Info" CloseOnEscape="False">
                <BodyTemplate><div style="padding: 30px;">
    
                عملیات تغییر رمز با موفقیت انجام شد 
                <br />
                
                 <p class="countdown"></p> 
                </div>
                
                </BodyTemplate>

               
                <Trigger Selector="" />

               
            </DotNetAge:Dialog>
          
         
          




         <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="تفییر کلمه عبور" runat="server" ID="overView" >
       
    
       
                
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
                    <div id="rows" runat="server">
                        <div class="row">
                            <div class="field">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_Password_old"
                                    ErrorMessage="کلمه عبور فعلی را درج نمایید" ValidationGroup="ChangePass">*</asp:RequiredFieldValidator>
                                کلمه عبور فعلی:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="Txt_Password_old" runat="server" CssClass="from_txt" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="field">

                        
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Password_new"
                                    ErrorMessage="کلمه عبور جدید را درج نمایید" ValidationGroup="ChangePass">*</asp:RequiredFieldValidator>
                                کلمه عبور جدید:

   
                                
                                
                                </div>
                            <div class="fieldInputArea" >
                                <asp:TextBox ID="Txt_Password_new" runat="server" CssClass="from_txt" TextMode="Password" ClientIDMode="Static"  ></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="field">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Txt_Password_new2"
                                    ControlToValidate="Txt_Password_new" EnableTheming="True" ErrorMessage="کلمه عبور جدید و تکرار کلمه عبور مشابه نیستند"
                                    ValidationGroup="ChangePass">*</asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txt_Password_new2"
                                    ErrorMessage="تکرار کلمه عبور جدید را درج نمایید" ValidationGroup="ChangePass">*</asp:RequiredFieldValidator>
                                تکرار کلمه عبور جدید:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="Txt_Password_new2" runat="server" CssClass="from_txt" TextMode="Password"></asp:TextBox>
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
				<div class="ui-state-highlight ui-corner-all" 
                    
                    style="margin-top: 20px; padding: 10 .7em 0 .7em;overflow:auto; margin-bottom: 20px;"> 
                    <div style="padding: 10px;  float:right ; direction:rtl ; text-align:justify   ; ">
                    <span class="ui-icon ui-icon-info" style="float:right;  margin-right: .3em;">
                                </span><strong>راهنما</strong>

					    <ul>
                            <li>
                                بهتر است کلمه عبور شما حداقل 8 حرف داشته باشد.</li>
                            <li>استفاده از کاراکتر هایی مانند !@#\\$%*()_+^&amp;}{:;?. کلمه عبور شما را ایمن تر می 
                                سازد.</li>
                            <li>هیچگاه برای مدت طولانی از کلمه عبور استفاده نکنید و سعی کنید هر چند ماه یکبار&nbsp; 
                                آنرا تغییر دهید.</li>
                            <li>بازیابی کلمه عبور فقط به صورت ایمیل پسورد جدید که برای شما به صورت خودکار ارسال 
                                می شود امکان پذیر است، زیرا پسورد شما به صورت رمز نگاری شده ذخیره می گردد و حتی 
                                مدیران سیستم نیز از آن آگاه نیستند. </li>
                        
                        </ul>
                

                    </div>
				</div>
			</div>

  
<br />

       
        <script type="text/javascript">
            var countdown;
            function startCount() {
                var count = 10;
                countdown = setInterval(function ()
                { $("p.countdown").html(" به صورت خودکار تا " + count + " ثانیه دیگر به صفحه ورود منتقل می شوید "); if (count < 1) { window.location = "/manage/login.aspx"; } else { count--; } }, 1000);
            } 
        
        </script>










  


  