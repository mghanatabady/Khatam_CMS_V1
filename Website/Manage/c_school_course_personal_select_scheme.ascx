﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_course_personal_select_scheme.ascx.vb" Inherits="c_school_course_personal_select_scheme"  %>
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px" id="DIV3" runat="server" visible="false">
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
            <div style="margin-top: 2px; font-size: 9pt; float: left; width: 100px; height: 20px;
                text-align: center">
                انتخاب واحد</div>
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
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 250px; height: 26px">
                <strong><span>مشخصات دانش آموز</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div class="from_div_title">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
                <div class="from_div_title">
                    <asp:Label ID="Label2" runat="server"></asp:Label></div>
                <div class="from_div_title">
                    <asp:Label ID="Label3" runat="server"></asp:Label></div>
                &nbsp;&nbsp;
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" class="from_div_title">
                    <span>شماره دانش آموزی</span></div>
                <div class="from_div_title">
                    نام</div>
                <div class="from_div_title">
                    نام خانوادگی</div>
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
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <DIV style="MARGIN-TOP: 4px; FONT-SIZE: 9pt; HEIGHT: 18px; float: left;" >
            لیست دروس انتخابی این دانش آموز</div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton_Remove" runat="server" ImageUrl="~/images/silverbar_btn_remove.gif" /></div>
</div>
&nbsp;<div id="MSG5" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با حذف واحد نمرات مرتبط نیز حذف می گردد. آیا برای
            حذف واحد
            مطمئن هستید؟<br />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" Text="هزینه اخذ گردیده برای این واحد ها باز پرداخت شود" Visible="False" /><br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button2" runat="server"
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
            واحد های مورد نظر حذف گردید</span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;"><asp:GridView ID="GridView_Remove" runat="server" AllowPaging="True" AllowSorting="True"
       AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource3" Width="742px" PageSize="150">
    <FooterStyle BackColor="#F1F3FA" />
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="id" HeaderText="کد ارائه" InsertVisible="False" SortExpression="id" />
        <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title" />
        <asp:BoundField DataField="lesson_id" HeaderText="کد درس" SortExpression="lesson_id" />
        <asp:BoundField DataField="realname" HeaderText="نام معلم" SortExpression="realname" />
    </Columns>
    <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    <EmptyDataTemplate>
        <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; margin-left: 70px;
            border-left: red 2px solid; width: 652px; margin-right: 10px; border-bottom: red 2px solid;
            height: 45px; text-align: right">
            <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
            <div style="padding-right: 5px; margin-top: 5px; float: right; width: 560px; color: red;
                padding-top: 5px; height: 26px">
                توجه!<br />
                هیچ موردی برای نمایش یافت نشد.</div>
            <br />
        </div>
    </EmptyDataTemplate>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server"  SelectCommand="SELECT     school_Lesson.title, school_Lesson.id AS lesson_id, school_course_personal.id, users.lname + ' , ' + users.fname AS realname
FROM         school_course_personal INNER JOIN
                      school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id INNER JOIN
                      school_course_personal_student ON school_course_personal.id = school_course_personal_student.school_course_personal_id INNER JOIN
                      users ON school_course_personal.school_teacher_id = users.id
WHERE     (school_course_personal_student.school_student_id = @school_student_id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="school_student_id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
</div><div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <DIV style="MARGIN-TOP: 4px; FONT-SIZE: 9pt; HEIGHT: 18px; float: left;" >
            واحد های درسی</DIV>
   
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_add.gif" /></div>
</div>
<br />
<div style="margin-left: 10px; width: 742px; margin-right: 10px; height: 100px" id="DIV1" runat="server" visible="false">
    <div title="window">
        <div>
            <div style="background-image: url(images/win1_bg.gif); width: 316px; background-repeat: repeat-x;
                height: 25px; text-align: left">
                <div style="float: left; background-image: url(images/win1_left_bg.gif); width: 11px;
                    height: 25px">
                </div>
                <div style="float: right; background-image: url(images/win1_right_bg.gif); width: 2px;
                    height: 25px">
                </div>
                <div id="Div2" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                    padding-top: 1px">
                    جستجو
                </div>
            </div>
            <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                <div dir="rtl" style="margin: 6px 9px 3px 10px; width: 295px; text-align: left">
                    <div style="width: 295px">
                        <strong>عبارت:</strong>
                        <asp:TextBox ID="Txt_Search" runat="server" Font-Names="Tahoma" Font-Size="10pt"
                            Width="127px"></asp:TextBox>&nbsp;<asp:DropDownList ID="DDL_Search" runat="server"
                                Font-Names="Tahoma" Font-Size="10pt" Width="100px">
                                <asp:ListItem Value="0">کد درس</asp:ListItem>
                                <asp:ListItem Value="1">کد کلاس</asp:ListItem>
                                <asp:ListItem Value="2">کد کلاس</asp:ListItem>
                                <asp:ListItem Value="3">کد معلم</asp:ListItem>
                                <asp:ListItem Selected="True">نام درس</asp:ListItem>
                                <asp:ListItem>واحد</asp:ListItem>
                                <asp:ListItem>همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div id="MSG6" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            واحد های مورد نظر اضافه گردید</span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="150">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id" HeaderText="کد ارائه" InsertVisible="False" SortExpression="id" />
            <asp:BoundField DataField="lesson_id" HeaderText="کد درس" SortExpression="lesson_id" />
            <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title" />
            <asp:BoundField DataField="realname" HeaderText="نام معلم" SortExpression="realname" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  SelectCommand="
    
    SELECT     school_course_personal.id, school_Lesson.title, school_Lesson.id AS lesson_id, users.lname + ' , ' + users.fname AS realname
FROM         school_course_personal INNER JOIN
                      school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id INNER JOIN
                      users ON school_course_personal.school_teacher_id = users.id  
    ">
    </asp:SqlDataSource>
    <br />
</div>
