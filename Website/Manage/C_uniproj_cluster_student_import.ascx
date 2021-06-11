<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_uniproj_cluster_student_import.ascx.cs" Inherits="Manage_C_uniproj_cluster_student_import" %>
     <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
                   
         <DotNetAge:View Text="Import لیست دانشجویان" runat="server" ID="View1" >
       
 
    
                      <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px">
                            <strong><span>لطفا اطلاعات درخواستی فرم زیر را تکمیل نمایید:</span></strong></div>
                    </div>

                    

                    <div id="msgDublicate" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                        margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
                        margin-top: 10px; padding-bottom: 10px; border-bottom: red 2px solid;
                        text-align: right; overflow: auto" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; ">
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; margin-bottom: 5px; float: right;
                            width: 493px; color: red; padding-top: 5px; height: 26px">
                            توجه! عملیات ناموفق<br />
                            <span style="font-size: 9pt">
                                <asp:Label ID="lbl_msgDublicate" runat="server" Text=""></asp:Label></span>
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
                            <div class="field" dir="rtl" >
                                       فایل xlsx</div>
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
           
        
               <asp:Button ID="btn_restore"  runat="server" Text="تایید" 
                   onclick="btn_restore_Click" CssClass="button1"  BorderStyle="Solid"  />

                   
								         
    </div>



 
            </DotNetAge:View>
        </Views>
    </DotNetAge:Tabs>          
                   




        <br />
