<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_baseSetting.ascx.cs" Inherits="Manage_c_baseSetting" %>







         <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="تنظیمات پابه" runat="server" ID="overView" >
       
    
       
                
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

                          

                        <div id="Div2" runat="server">
                        <div class="row">
                            <div class="field">
                                 عنوان: Persian فارسی</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txtTitleFa" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                    <div id="Div1" runat="server">
                        <div class="row">
                            <div class="field">
                                 عنوان: English</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txtTitleEn" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                  <div id="Div3" runat="server">
                        <div class="row">
                            <div class="field">
                                 عنوان: Arabic العربی</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txtTitleAR" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                  <div id="Div4" runat="server">
                        <div class="row">
                            <div class="field">
                                 عنوان: German</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txtTitleDE" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

            

                 <div id="Div6" runat="server">
                        <div class="row">
                            <div class="field">
                                 تلفن</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_tel" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                 <div id="Div7" runat="server">
                        <div class="row">
                            <div class="field">
                                 ایمیل</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_email" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

               <div id="Div8" runat="server">
                        <div class="row">
                            <div class="field">
                                 موبایل</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_cellphone" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                  <div id="Div9" runat="server">
                        <div class="row">
                            <div class="field">
                                 آدرس</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_address" runat="server" CssClass="Element_TextBox_medium" TextMode="MultiLine"  ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                 <div id="Div10" runat="server">
                        <div class="row">
                            <div class="field">
                                 نمابر</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_fax" runat="server" CssClass="from_txt" ></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>

                         <div id="Div5" runat="server">
                        <div class="row">
                            <div class="field"  >
                            لوگو
                            <br />
                            <br />


                            </div>
                            <div class="fieldInputArea">
                                <asp:Image ID="img_logo" runat="server" />                  
                                
                            </div>
                        <div class="row">

                            <div class="field"  >
                            <br /><br /> <br /> 
                            </div>
                            
                            <div class="fieldInputArea">
                            <script type ="text/javascript">
                         var validFilesTypes = [ "gif", "png", "jpg", "jpeg"];

                         function ValidateFile(oSrc, args) {
                                var file = document.getElementById("FileUpload1");
                                var path = file.value;
                                var ext = path.substring(path.lastIndexOf(".") + 1, path.length).toLowerCase();
                                var isValidFile = false;
                                    for (var i = 0; i < validFilesTypes.length; i++) {
                                        if (ext == validFilesTypes[i]) {
                                            isValidFile = true;
                                            break;
                                        }
                                    }
                                args.IsValid =isValidFile; 
                          }
                          </script>

                                <asp:FileUpload ID="FileUpload1" ClientIDMode="Static"  runat="server" />
                                <asp:CustomValidator ID="CustomValidator1" runat="server"
                                 ErrorMessage="نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,gif,png,jpeg"
                                  Text="*"  ControlToValidate="FileUpload1" ValidationGroup="base_setting"  ClientValidationFunction="ValidateFile"></asp:CustomValidator>
                                        
                                    

                            </div>
                            </div> 


                        </div>
                        
                    </div> 

                    <br />
                    <div>
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" DisplayMode="List"
                            HeaderText="لطفا به موارد زیر توجه کنید:" ValidationGroup="base_setting" />
                        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <asp:Literal ID="LiteralUpload" runat="server" ></asp:Literal>
                    </div>

            </DotNetAge:View>
         
        </Views>
    </DotNetAge:Tabs>
     
            <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" runat="server" BorderStyle="Solid" CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="base_setting" style="margin-right: 1px" />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف" />
                            
            </div>

           



  <div class="ui-widget">
			</div>

       
                                                 
                                                 
       
  
  
  

        

        