<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_teacher_add.ascx.vb" Inherits="c_school_teacher_add" %>
<br />
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="../images/manage/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای معلم تکراری است، لطفا کد دیگری را درج
            نمایید</span></div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="../images/manage/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt;">
    <div style="background-image: url(../images/manage/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(../images/manage/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(../images/manage/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(../images/manage/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="../images/manage/silverbar_btn_list.gif" /></div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt;">
    <div style="background-image: url(../images/manage/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left">
        <div style="float: left; background-image: url(../images/manage/form1_left_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div style="float: right; background-image: url(../images/manage/Form1_right_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div id="test" style="margin-top: 9px; float: left; background-image: url(../images/manage/Tab1_bg.gif);
            margin-left: 4px; width: 115px; height: 22px">
            <div style="float: left; background-image: url(../images/manage/Tab1_left_bg.gif); width: 2px;
                height: 22px">
            </div>
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                معلم جدید</div>
            <div style="float: right; background-image: url(../images/manage/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(../images/manage/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left">
        <div style="background-image: url(../images/manage/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="../images/manage/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 100px; height: 26px">
                <strong><span>مشخصات</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Code" runat="server" CssClass="from_txt" MaxLength="19"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Fname" runat="server" CssClass="from_txt" MaxLength="50"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Lname" runat="server" CssClass="from_txt" MaxLength="80"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Password" runat="server" CssClass="from_txt" MaxLength="30"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:RadioButton ID="Rb_PersonalPage_Enable" runat="server" Checked="True" GroupName="Personal_Page"
                        Text="فعال" />
                    /<asp:RadioButton ID="Rb_PersonalPage_Disable" runat="server" GroupName="Personal_Page"
                        Text="غیر فعال" /></div>
                <div class="from_div_title">
                    <asp:RadioButton ID="Rb_PersonalPanel_Enable" runat="server" Checked="True" GroupName="Personal_Panel"
                        Text="فعال" />
                    /<asp:RadioButton ID="Rb_PersonalPanel_Disable" runat="server" GroupName="Personal_Panel"
                        Text="غیر فعال" /></div>
                          <div class="from_div_title">
                    <asp:TextBox ID="Txt_Email" runat="server" CssClass="from_txt" MaxLength="30"></asp:TextBox></div>
                <br />
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" class="from_div_title">
                    <span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_Code"
                            ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>کد
                        معلم</span></div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Fname"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>نام</div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txt_Lname"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>نام
                    خانوادگی</div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Txt_Password"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>کلمه
                    عبور</div>
                <div class="from_div_title">
                    صفحه اختصاصی</div>
                <div class="from_div_title">
                    کنترل پنل اختصاصی</div>
                          <div class="from_div_title">
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txt_Email"
                                  ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                  ValidationGroup="Teacher_Add"></asp:RegularExpressionValidator>ایمیل</div>
                <br />
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(../images/manage/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(../images/manage/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(../images/manage/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />
            <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(../images/manage/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(../images/manage/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(../images/manage/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />