<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_School_Classroom_Calendar_edit.ascx.vb" Inherits="C_School_Classroom_Calendar_edit" %>
<br />
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای معلم تکراری است، لطفا کد دیگری را درج
            نمایید</span></div>
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
            <span style="font-size: 9pt">مقادیر مورد نظر شما ثبت گردید.</span></span></div>
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
                برنامه کلاسی</div>
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
            <div  class="from_div_maintitle ">
                <strong><span>تنظیم برنامه</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div Class="from_div_title">
                    <asp:Label ID="LbL_Class_id" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                    
                               <div Class="from_div_title">
                    <asp:Label ID="Lbl_Class_title" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                    
               <div Class="from_div_title">
                    <asp:Label ID="Lbl_base_year" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                <div Class="from_div_title">
                    &nbsp;</div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" Class="from_div_title">
                   کد
                        کلاس</div>
                        
                             <div dir="rtl" Class="from_div_title">
                  عنوان</div>
                  
                     <div dir="rtl" Class="from_div_title">
                  پایه</div>
            </div>
            <div style="width: 720px; text-align: justify;" dir="rtl">
                <table>
                    <tr>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                        </td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            زنگ اول</td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            زنگ دوم</td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            زنگ سوم</td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            زنگ چهارم</td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            زنگ پنجم</td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; text-align: center;">
                            شنبه</td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            <asp:HyperLink ID="d1a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d1a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            <asp:HyperLink ID="d1a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d1a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            <asp:HyperLink ID="d1a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d1a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            <asp:HyperLink ID="d1a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d1a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; height: 40px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid;">
                            <asp:HyperLink ID="d1a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d1a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 40px; text-align: center;">
                            یکشنبه</td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d2a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d2a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d2a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d2a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d2a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d2a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d2a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d2a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d2a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d2a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 40px; text-align: center;">
                            دوشنبه</td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d3a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d3a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d3a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d3a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d3a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d3a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d3a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d3a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d3a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d3a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 40px; text-align: center;">
                            سه شنبه</td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d4a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d4a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d4a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d4a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d4a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d4a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d4a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d4a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d4a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d4a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 40px; text-align: center;">
                            چهارشنبه</td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d5a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d5a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d5a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d5a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d5a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d5a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d5a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d5a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d5a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d5a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 40px; text-align: center;">
                            پنجشنبه</td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d6a1" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d6a1" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d6a2" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d6a2" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d6a3" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d6a3" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d6a4" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d6a4" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                        <td style="width: 100px; border-right: black 1px solid; padding-right: 5px; border-top: black 1px solid; padding-left: 5px; padding-bottom: 5px; border-left: black 1px solid; padding-top: 5px; border-bottom: black 1px solid; height: 40px;">
                            <asp:HyperLink ID="d6a5" runat="server" Font-Size="10pt">HyperLink</asp:HyperLink><br />
                            <asp:HyperLink ID="school_teacher_d6a5" runat="server" Font-Size="8pt">HyperLink</asp:HyperLink></td>
                    </tr>
                </table>
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    DataSourceID="SqlDataSource1" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" />
                        <asp:BoundField DataField="school_Class_id" HeaderText="school_Class_id" SortExpression="school_Class_id" />
                        <asp:BoundField DataField="school_Lesson_id" HeaderText="school_Lesson_id" SortExpression="school_Lesson_id" />
                        <asp:BoundField DataField="school_teacher_id" HeaderText="school_teacher_id" SortExpression="school_teacher_id" />
                        <asp:BoundField DataField="alarm_number" HeaderText="alarm_number" SortExpression="alarm_number" />
                        <asp:BoundField DataField="day_number" HeaderText="day_number" SortExpression="day_number" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                        <asp:BoundField DataField="realname" HeaderText="realname" SortExpression="realname" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    SelectCommand="
                    SELECT     school_Classroom_select.id, school_Classroom_select.school_class_id, school_Classroom_select.school_lesson_id, school_Classroom_select.school_teacher_id, 
                      school_Classroom_hour.alarm_number, school_Classroom_hour.day_number, school_Lesson.title, users.lname + ' , ' + users.fname AS realname
FROM         school_Classroom_hour INNER JOIN
                      school_Classroom_select ON school_Classroom_hour.id_school_classroom_select = school_Classroom_select.id INNER JOIN
                      school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id INNER JOIN
                      users ON school_Classroom_select.school_teacher_id = users.id
WHERE     (school_Classroom_select.school_class_id = @school_Class_id)
ORDER BY school_Classroom_hour.day_number, school_Classroom_hour.alarm_number
                    
                    ">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="school_Class_id" QueryStringField="id" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView_Detail" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    DataSourceID="SqlDataSource2" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                        <asp:BoundField DataField="school_base_year" HeaderText="school_base_year" SortExpression="school_base_year" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    SelectCommand="SELECT school_Class.id, school_Class.title, school_base_cat.title AS school_base_year FROM school_Class INNER JOIN school_base ON school_Class.id_school_base = school_base.id INNER JOIN school_base_cat ON school_base.year_number = school_base_cat.id WHERE (school_Class.id = @id)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="id" QueryStringField="id" />
                    </SelectParameters>
                </asp:SqlDataSource>
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
            <asp:Button ID="Btn_ok" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="school_teacher_Add" Width="42px" Visible="False" />
            <asp:Button ID="Btn_Cancel" runat="server" Font-Names="Tahoma" Height="24px" Text="بازگشت"
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
&nbsp;
