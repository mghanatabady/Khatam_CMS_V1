

<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_teacher_course_classroom_edit.ascx.vb" Inherits="manage_c_school_teacher_course_classroom_edit" %>
<%@ Register Assembly="PersianDateControls 2.0" Namespace="PersianDateControls" TagPrefix="pdc" %>
<link href="../Content/StyleSheet_calender.css" rel="stylesheet" type="text/css" />

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
</div><div id="Div9" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 96px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 78px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">
                <asp:Label ID="Lbl_report1" runat="server"></asp:Label><br />
                <asp:Label ID="Lbl_report2" runat="server"></asp:Label><br />
                <asp:Label ID="Lbl_report3" runat="server"></asp:Label></span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px" id="DIV10" runat="server" visible="true">
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
                اعلام نمرات</div>
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
            <div class="from_div_maintitle ">
                <strong><span>مشخصات درس</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div class="from_div_title" id="DIV8" runat="server" visible="true">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                <div class="from_div_title" id="DIV7" runat="server" visible="false">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>&nbsp;</div><div class="from_div_title" id="DIV6" runat="server" visible="false">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                <div class="from_div_title" id="DIV5" runat="server" visible="false">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>&nbsp;</div>
                <div class="from_div_title">
                            <asp:DropDownList id="DropDownList1" runat="server" Font-Names="Tahoma" 
                                Width="165px">
                    </asp:DropDownList></div>
                <div class="from_div_title">
                <asp:TextBox runat="server"  id="txtTitle" CssClass="from_txt" >امتحان کلاسی</asp:TextBox>
                    &nbsp;</div>

                         <div class="from_div_title">
                             <pdc:PersianDateTextBox ID="PersianDateTextBox" runat="server" DefaultDate="1363/10/22"
            IconUrl="~/themeCP/Bitrix/CssImage/Element/Calendar.gif" SetDefaultDateOnEvent="OnDoubleClick"
            Width="130px"></pdc:PersianDateTextBox>
        <pdc:PersianDateScriptManager ID="PersianDateScriptManager" runat="server" CalendarCSS="PickerCalendarCSS"
            CalendarDayWidth="50" FooterCSS="PickerFooterCSS" ForbidenCSS="PickerForbidenCSS"
            ForbidenDates="[0,11,22],[0,12,29],[0,0,13]" ForbidenWeekDays="5,6" FrameCSS="PickerCSS"
            HeaderCSS="PickerHeaderCSS" SelectedCSS="PickerSelectedCSS" WeekDayCSS="PickerWeekDayCSS"
            WorkDayCSS="PickerWorkDayCSS">
        </pdc:PersianDateScriptManager>
                </div>
                           <div class="from_div_title">
                                   <asp:TextBox runat="server"  id="txtBaseOfScore" CssClass="from_txt" 
                                       Width="49px" >20</asp:TextBox>
</div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" class="from_div_title" id="DIV4" runat="server" visible="true">
                   کد ارائه</div>
                <div class="from_div_title" id="DIV3" runat="server" visible="false">
                    کد
                    کلاس</div>
                <div class="from_div_title" id="DIV2" runat="server" visible="false">
                    نام
                    درس</div>
                <div class="from_div_title" id="DIV1" runat="server" visible="false">
                        تعداد
                        واحد
                </div>
                <div class="from_div_title">
                    
                    نوع آزمون
                </div>

                                    <div class="from_div_title">
                    
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtTitle" ErrorMessage="RequiredFieldValidator" 
                                            ValidationGroup="f1">*</asp:RequiredFieldValidator>
                    
                    عنوان
                </div>
                                <div class="from_div_title">
                    
        <pdc:PersianDateValidator ID="PersianDateValidator1" runat="server" 
            ControlToValidate="PersianDateTextBox" ValidationGroup="f1"></pdc:PersianDateValidator>
                    
                    تاریخ آزمون
                </div>
                            <div class="from_div_title">
                    
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtBaseOfScore" ErrorMessage="RequiredFieldValidator" 
                                    ValidationGroup="f1">*</asp:RequiredFieldValidator>
                    
                    پایه نمره
                </div>
            </div>
            <div style="width: 720px; text-align: justify;" dir="rtl">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                    Width="720px" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="شماره دانش آموزی" SortExpression="id">
                            <HeaderStyle Font-Size="9pt" />
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="نام و نام خانوادگی">
                            <ItemStyle Width="150px" />
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("realname") %>' ToolTip='<%# Eval("id") %>' Font-Size="9pt"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Size="9pt" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="txtScoreValue" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px" Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        دانش آموزشی یافت نشد
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    
                    SelectCommand="SELECT DISTINCT users.id, users.email, users.fname + ' , ' + users.lname AS realname FROM school_Student_class INNER JOIN school_Classroom_select ON school_Student_class.id_school_class = school_Classroom_select.school_class_id INNER JOIN school_Class ON school_Student_class.id_school_class = school_Class.id INNER JOIN users ON school_Student_class.id_school_student = users.id">
                </asp:SqlDataSource>
                <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="id" DataSourceID="SqlDataSource1" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="realname" HeaderText="realname" 
                            SortExpression="realname" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
            
                <br />
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
                ValidationGroup="f1" Width="42px" />
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