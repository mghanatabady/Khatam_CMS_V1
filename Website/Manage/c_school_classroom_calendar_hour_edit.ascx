<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_classroom_calendar_hour_edit.ascx.vb" Inherits="c_school_classroom_calendar_hour_edit" %>
<br />
<div id="Div1" runat="server" dir="rtl" style="border-right: #00cc00 2px solid; border-top: #00cc00 2px solid;
    margin-left: 96px; border-left: #00cc00 2px solid; width: 652px; margin-right: 10px;
    border-bottom: #00cc00 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/msg_icon/icon_info.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: #009974;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">
                <asp:Label ID="Lbl_Msg_info" runat="server"></asp:Label></span></span></div>
    <br />
</div>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با حذف این ساعت درسی علاوه بر حذف اطلاعات، &nbsp;&nbsp;نمرات
            مرتبط &nbsp;نیز حذف خواهد شد. آیا برای حذف ساعت درسی مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button5" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button6" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">برای حذف این ساعت درسی مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button4" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
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
     
        
        
                <div style="float: left; width: 71px; height: 31px" id="Div2" runat="server">
           <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" /></div>
        
         <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: left; width: 71px; height: 31px" id="Toolbar_new" runat="server">
         <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/silverbar_btn_remove.gif" /></div>
        
        
        
        
        </div>
        
        
        
        
   
       
        
        
        
        
        
        
        
        
        
        
        
        
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
                ویرایش درس</div>
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
                    <asp:DropDownList ID="DDL_Lesson" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="title" DataValueField="id" Font-Names="Tahoma" Width="265px" 
                        AppendDataBoundItems="True">
                        <asp:ListItem Value="empty">...</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        SelectCommand="SELECT id + ' ' + title AS Title, id FROM school_Lesson">
                    </asp:SqlDataSource>
                </div>
                
                               <div class="from_div_title">
                    <asp:DropDownList ID="DDL_Teacher" runat="server" Font-Names="Tahoma" Width="265px" 
                                       AppendDataBoundItems="True" DataSourceID="SqlDataSource2" 
                                       DataTextField="realname" DataValueField="id">
                        <asp:ListItem Value="Empty">...</asp:ListItem>
                    </asp:DropDownList>
                                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                       SelectCommand="SELECT DISTINCT users.id, users.lname + ' , ' + users.fname AS realname
FROM         users INNER JOIN
                      coreRoleRefUser ON users.id = coreRoleRefUser.idUser INNER JOIN
                      coreRole ON coreRoleRefUser.idRole = coreRole.id INNER JOIN
                      corePermissionRefRole ON coreRole.id = corePermissionRefRole.idRole INNER JOIN
                      corePermission ON corePermissionRefRole.idPermission = corePermission.id
WHERE     (corePermission.title = N'school_declaration_reportCard_teacher') OR
                      (corePermission.title = N'school_declaration_ClassGrade_teacher')
UNION
SELECT DISTINCT users_1.id, users_1.lname + ' , ' + users_1.fname AS realname
FROM         users AS users_1 INNER JOIN
                      corePermissionRefUser ON users_1.id = corePermissionRefUser.idUser INNER JOIN
                      corePermission AS corePermission_1 ON corePermissionRefUser.idPermission = corePermission_1.id"></asp:SqlDataSource>
                </div>
                             
          
            </div>
            <div style="margin-top: 5px; width: 320px">
        
                           
                          <div class="from_div_title">
                    نام درس</div>
                    
                                    <div class="from_div_title">
                    نام دبیر</div>
             
            
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
                ValidationGroup="Lesson_Edit" Width="42px" />
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
