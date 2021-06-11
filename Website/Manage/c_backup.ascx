<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_backup.ascx.cs" Inherits="Manage_c_backup" %>

         <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="ایجاد نسخه پشتیبان" runat="server" ID="overView" >
       
    
       
                
               <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px">
                            <strong><span>ایجاد و دانلود نسخه پشتیبان:</span></strong></div>
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
               
                    <br />
                    

                            <div id="btns" 
                                                    style="padding: 10px; background-color: #f8f9fc; direction: rtl; margin-bottom: 10px; text-align: right; border-style: none;" >
           
        
               <asp:Button ID="btn_Save"  runat="server" Text="ایجاد و دانلود" 
                   onclick="btn_Save_Click" CssClass="button1"  BorderStyle="Solid"  />

                   
								         
    </div>
            

            </DotNetAge:View>
         
         <DotNetAge:View Text="بازیابی نسخه پشتیبان" runat="server" ID="View1" >
       
 
    
                      <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px">
                            <strong><span>لطفا اطلاعات درخواستی فرم زیر را تکمیل نمایید:</span></strong></div>
                    </div>

                    

                    <div id="Div1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                        margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
                        margin-top: 10px; padding-bottom: 10px; border-bottom: red 2px solid; height: 45px;
                        text-align: right; overflow: auto" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; margin-bottom: 5px; float: right;
                            width: 493px; color: red; padding-top: 5px; height: 26px">
                            توجه!<br />
                            <span style="font-size: 9pt">کلمه عبور فعلی صحیح نمی باشد لطفا مجددا سعی نمایید.</span>
                        </div>
                        <br />
                    </div>
                    <div id="Div2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                        margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
                        border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />
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
                                         فایل پشتیبان:</div>
                            <div class="fieldInputArea">
                             <asp:FileUpload ID="fuZIP"  runat="server"  />
                             <br />
                                <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
                             <br />

                            </div>
                        </div>
                      
                    </div>



                    
                            <div id="Div4" 
                                                    style="padding: 10px; background-color: #f8f9fc; direction: rtl; margin-bottom: 10px; text-align: right; border-style: none;" >
           
        
               <asp:Button ID="btn_restore"  runat="server" Text="بازیابی" 
                   onclick="btn_restore_Click" CssClass="button1"  BorderStyle="Solid"  />

                   
								         
    </div>


                             <div class="ui-widget">
				<div class="ui-state-highlight ui-corner-all" 
                    
                    style="margin-top: 20px; padding: 10 .7em 0 .7em;overflow:auto; margin-bottom: 20px;"> 
                    <div style="padding: 10px;  float:right ; direction:rtl ; text-align:justify   ; ">
                    <span class="ui-icon ui-icon-info" style="float:right;  margin-right: .3em;">
                                </span><strong>راهنما</strong>

					    <ul>
                            <li>
                                اخطار، توجه داشته باشید که با بازیابی فایل پشتیبان تمام فایل و محتوای کنونی سایت، حتی اطلاعات کاربری شما حذف و با اطلاعات نسخه پشتیبان جایگزین می گردد</li>
     
                        
                        </ul>
                

                    </div>
				</div>
			</div>

 
            </DotNetAge:View>
        </Views>
    </DotNetAge:Tabs>          
                   




        <br />






