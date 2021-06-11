<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_darman_cards_add.ascx.cs" Inherits="Manage_c_darman_cards_add" %>
                 
                 
  
<br />
                 
                    <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="درخواست صدور کارت جدید" runat="server" ID="overView" >
       
    
       
                <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto; margin-bottom:10px">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image11" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px ; color:#494949">
                            <strong><span>لطفا اطلاعات فرم زیر را با دقت کامل کنید:</span></strong></div>
                    </div>
                       <div style="width: 954px;" id="Div_Main" runat="server">

                        

                                <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                       اطلاعات پایه
                    </div>
                    <div id="rows2" runat="server">

                                                    <div class="row">
                            <div class="field">
                                  نوع کارت </div>
                            <div class="fieldInputArea">
                            <asp:DropDownList ID="ddl_darman_cards_type" runat="server" CssClass="txtBox">
                                                        

                                                                </asp:DropDownList>
                            </div>
                        </div>


                        <div class="row" >
                            <div class="field">نام 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txt_fname" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد نام ضروری است"></asp:RequiredFieldValidator>
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_fname" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" >
                            <div class="field">نام خانوادگی 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txt_lname" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد نام خانوادگی ضروری است"></asp:RequiredFieldValidator>
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_lname" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" >
                            <div class="field">کد ملی 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txt_iranNationalCode" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد کد ملی ضروری است"></asp:RequiredFieldValidator>

                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_iranNationalCode" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                         <div class="row" >
                            <div class="field">نام پدر 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txt_fatherName" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد نام پدر ضروری است"></asp:RequiredFieldValidator>
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_fatherName" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                       <div class="row" >
                            <div class="field">تاریخ تولد
                          


                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txt_birthday" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد تاریخ تولد ضروری است"></asp:RequiredFieldValidator>
                                  </div>

                                 

                            <div class="fieldInputArea"  >
                            <pcal:PersianDatePickup ID="txt_birthday" CssClass="txt_dialog_medium_ltr"  MaxLength="149" runat="server" ></pcal:PersianDatePickup>

                                              
                            </div>
                        </div>


                        <div class="row" >
                            <div class="field">شماره شناسنامه 
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txt_shsh" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد شماره شناسنامه ضروری است"></asp:RequiredFieldValidator>

                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_shsh" runat="server"  CssClass="txt_dialog_medium_ltr" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row" >
                            <div class="field">محل صدور 
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txt_shMahalSodor" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد محل صدور ضروری است"></asp:RequiredFieldValidator>
                            
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_shMahalSodor" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row" >
                            <div class="field">تلفن ثابت <a href="#" class="tooltipA" onmouseover="return tooltip('همراه با کد شهر');" onmouseout="return hideTip();" onClick="return false;">[?]</a>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txt_tel" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد تلفن ثابت ضروری است"></asp:RequiredFieldValidator>

                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_tel" runat="server" CssClass="txt_dialog_medium_ltr" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row" >
                            <div class="field">تلفن همراه <a href="#" class="tooltipA" onmouseover="return tooltip('به صورت 11 رقمی مانند : 09127710277');" onmouseout="return hideTip();" onClick="return false;">[?]</a>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="txt_mobile" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد تلفن همراه ضروری است"></asp:RequiredFieldValidator>

                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="txt_mobile" runat="server" CssClass="txt_dialog_medium_ltr" MaxLength="149" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row">
                            <div class="field">
                                  نشانی
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="txt_address" runat="server" ValidationGroup="aaa" Text="*" ErrorMessage="درج فیلد نشانی ضروری است"></asp:RequiredFieldValidator>                                                   
                                  
                                  </div>
                            <div class="fieldInputArea">
                                  <asp:TextBox ID="txt_address" runat="server" CssClass="txt_dialog_medium_rtl" MaxLength="149" Width="250px"></asp:TextBox>                                    
                            </div>
                        </div>
                        
                    
             




                 


                                                              <div class="row">
                            <div class="field">
                                  تصویر<a href="#" class="tooltipA" onmouseover="return tooltip('تصویر پرسنلی با زمینه سفید و حداکثر حجم 200 کیلوبایت با پسوند jpg');" onmouseout="return hideTip();" onClick="return false;">[?]</a></div>
                            <div class="fieldInputArea">                                               
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                            </div>
                        </div>


                                  <div id="divValidationArea" class="row" runat="server" visible="false" >
                            <div class="field">
                                  تایید</div>
                            <div class="fieldInputArea">
                                <asp:CheckBox ID="chk__Valid_Enable" runat="server" />
                              
                            </div>
                        </div>

                    

                        
                    </div>

     
     <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="aaa" runat="server" />
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>



                    </div>


                                    

            </DotNetAge:View>
 
         
        </Views>
    </DotNetAge:Tabs>          
                   
                    <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" ClientIDMode="Static" runat="server" BorderStyle="Solid" 
                    CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="aaa"  />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف"  />



            </div>



        <br />
<asp:Label ID="Label1" runat="server"></asp:Label>
<br />



        <br />
<br />
<br />
<br />
<br />



        <br />
           