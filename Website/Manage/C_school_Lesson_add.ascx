﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Lesson_add.ascx.vb" Inherits="C_school_Lesson_add" %>
<br />
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای درس تکراری است، لطفا کد دیگری را درج
            نمایید</span></div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" /></div>
</div>
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left">
        <div style="float: left; background-image: url(images/form1_left_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div id="test" style="margin-top: 9px; float: left; background-image: url(images/Tab1_bg.gif);
            margin-left: 4px; width: 115px; height: 22px">
            <div style="float: left; background-image: url(images/Tab1_left_bg.gif); width: 2px;
                height: 22px">
            </div>
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                درس جدید</div>
            <div style="float: right; background-image: url(images/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 150px; height: 26px">
                <strong><span>مشخصات درس</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                                <div class="from_div_title">
                    <asp:DropDownList ID="DDL_Category" runat="server" DataSourceID="SqlDataSource2" DataTextField="title" DataValueField="id" Font-Names="Tahoma" Width="165px" AppendDataBoundItems="True">
                    </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        SelectCommand="SELECT [id], [title] FROM [school_Category]"></asp:SqlDataSource>
                                </div>
                    
                    
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Code" runat="server" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
               <asp:TextBox ID="Txt_Title" runat="server" CssClass="from_txt"></asp:TextBox>
                </div>
                
                                  <div class="from_div_title">
                                      <asp:TextBox ID="Txt_Min_Pass_Value" runat="server" CssClass="from_txt" Width="50px" Text="10"></asp:TextBox>
                </div>
                
                    <div class="from_div_title">
                        <asp:DropDownList ID="DDL_year_present" runat="server" CssClass="from_txt" DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="id" Width="165px">
                        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            SelectCommand="SELECT [id], [title] FROM [school_base_cat]"></asp:SqlDataSource>
                    
                    
                    </div>
                    <div class="from_div_title">
                                      <asp:TextBox ID="Txt_Unit_practical_Quantity" runat="server" CssClass="from_txt" Width="50px" Text="0"></asp:TextBox>
                </div>
                
                       <div class="from_div_title">
                                      <asp:TextBox ID="Txt_Unit_theoretical_Quantity" runat="server" CssClass="from_txt" Width="50px" Text="0"></asp:TextBox>
                </div>
                             <div class="from_div_title">
                                      <asp:TextBox ID="Txt_TeachHour_pratical_Quantity" runat="server" CssClass="from_txt" Width="50px" Text="0"></asp:TextBox>
                </div>
                
                                <div class="from_div_title">
                                      <asp:TextBox ID="Txt_TeachHour_theotetical_Quantity" runat="server" CssClass="from_txt" Width="50px" Text="0"></asp:TextBox>
                </div>
                
                        <div class="from_div_title">
                        <asp:DropDownList ID="DDL_Lesson_Present_Cat_id" runat="server" CssClass="from_txt" DataSourceID="SqlDataSource3" DataTextField="title" DataValueField="id" Width="165px">
                        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                            SelectCommand="SELECT [id], [title] FROM [school_Lesson_Present_Cat]"></asp:SqlDataSource>
                    
                    
                    </div>
                    
                            <div class="from_div_title">
                        <asp:DropDownList ID="DDL_Lesson_cat_id" runat="server" CssClass="from_txt" DataSourceID="SqlDataSource4" DataTextField="title" DataValueField="id" Width="165px">
                        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                            SelectCommand="SELECT [id], [title] FROM [school_Lesson_cat]"></asp:SqlDataSource>
                    
                    
                    </div>
                    
                            <div class="from_div_title">
                        <asp:DropDownList ID="DDL_Lesson_Present_Date_Cat" runat="server" CssClass="from_txt" DataSourceID="SqlDataSource5" DataTextField="title" DataValueField="id" Width="165px">
                        </asp:DropDownList> 
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                            SelectCommand="SELECT [id], [title] FROM [school_Lesson_Present_Date_Cat]"></asp:SqlDataSource>
                    
                    
                    </div>
                    
                                       <div class="from_div_title">
                                      <asp:TextBox ID="Txt_price" runat="server" CssClass="from_txt"  Text="0"></asp:TextBox>
                </div>
                
                
                
                
          
            </div>
            <div style="margin-top: 5px; width: 320px">
               
                           <div class="from_div_title">
                    نام رشته</div>
               <div dir="rtl" class="from_div_title">
                    <span class="from_div_title">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_Code"
                            ErrorMessage="*" ValidationGroup="school_lesson_add"></asp:RequiredFieldValidator>کد
                        درس</span></div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Title"
                        ErrorMessage="*" ValidationGroup="school_lesson_add"></asp:RequiredFieldValidator>نام درس</div>
                          <div class="from_div_title">
                    حد نصاب نمره قبولی</div>
                    
                         <div class="from_div_title">
                    سال ارائه</div>
                    
                         <div class="from_div_title">
                    تعداد واحد عملی</div>
                    
                         <div class="from_div_title">
                    تعداد واحد نظری</div>
                    
                         <div class="from_div_title">
                    ساعت تدریس عملی</div>
                    
                         <div class="from_div_title">
                    ساعت تدریس نظری</div>
                    
                         <div class="from_div_title">
                    نحوه ارائه</div>
                    
                         <div class="from_div_title">
                    نوع درس</div>
                    
                         <div class="from_div_title">
                    زمان ارائه درس</div>
                    
                             <div class="from_div_title">
                    تعرفه ریالی</div>
                    
                    
                    
                    
                    
            
                    
                                    <div class="from_div_title">
                </div>
            
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="school_lesson_add" Width="42px" />
            <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />
