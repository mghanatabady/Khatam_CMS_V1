<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_teacher_course_personal_edit.ascx.vb" Inherits="C_school_teacher_course_personal_edit" %>
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
                            <asp:DropDownList id="DropDownList1" runat="server" Font-Names="Tahoma" AutoPostBack="True">
                        <asp:ListItem Value="1">نمره مستمر نوبت اول</asp:ListItem>
                        <asp:ListItem Value="2">نمره پایانی نوبت اول</asp:ListItem>
                        <asp:ListItem Value="3">نمره مستمر نوبت دوم</asp:ListItem>
                        <asp:ListItem Value="4">نمره پایانی نوبت دوم</asp:ListItem>
                        <asp:ListItem Value="5">نمره شهریور</asp:ListItem>
                    </asp:DropDownList></div>
                <div class="from_div_title">
                    &nbsp;</div>
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
                    
                    اعلام نمرات
                </div>
            </div>
            <div style="width: 720px; text-align: justify;" dir="rtl">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
                    Width="720px">
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
                        <asp:TemplateField HeaderText="نمره مستمر نوبت اول">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="sc1m" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px" Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت اول">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="sc1p" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px"  Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره مستمر نوبت دوم">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="sc2m" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px"  Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت دوم">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="sc2p" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px"  Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره شهریور">
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemTemplate>
                                <asp:TextBox ID="scsh" runat="server" Font-Size="10pt" MaxLength="5"
                                    Width="36px"  Font-Names="Tahoma"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        دانش آموزی برای این کلاس یافت نشد
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" >
                </asp:SqlDataSource>
                <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="id" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="Fname" HeaderText="Fname" SortExpression="Fname" />
                        <asp:BoundField DataField="Lname" HeaderText="Lname" SortExpression="Lname" />
                    </Columns>
                </asp:GridView>
                &nbsp;
                <br />
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    DataSourceID="SqlDataSource3" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="student_id" HeaderText="student_id" SortExpression="student_id" />
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" />
                        <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
                        <asp:BoundField DataField="score_cat_id" HeaderText="score_cat_id" SortExpression="score_cat_id" />
                        <asp:BoundField DataField="score_type_type" HeaderText="score_type_type" SortExpression="score_type_type" />
                        <asp:BoundField DataField="school_course_personal" HeaderText="school_course_personal"
                            SortExpression="school_course_personal" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server"  
                    >
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
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />
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