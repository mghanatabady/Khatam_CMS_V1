<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Year_Del.ascx.vb" Inherits="C_school_Year_Del" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 81px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 65px">
        توجه!<br />
        <span style="font-size: 9pt">امکان حذف سال مورد نظر به جهت دسته بندی ارائه دروس ذیل
            در این سال وجود ندارد،
            لطفا ابتدا از بخش ارائه واحد ابتدا &nbsp;را حذف نمایید.</span></div>
    <br />
</div>
<div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">برای حذف سال مورد نظر مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button2" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
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
            سال مورد نظر حذف گردید.</span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;" id="Div_Lessons" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="25" Width="742px">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد ارائه" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="lesson_id" HeaderText="کد درس" ReadOnly="True" SortExpression="lesson_id" />
            <asp:BoundField DataField="lesson_title" HeaderText="نام درس" SortExpression="lesson_title" />
            <asp:BoundField DataField="unit" HeaderText="تعداد واحد" SortExpression="unit" />
            <asp:BoundField DataField="class_id" HeaderText="کد کلاس" ReadOnly="True" SortExpression="class_id" />
            <asp:BoundField DataField="class_title" HeaderText="نام کلاس" SortExpression="class_title" />
            <asp:BoundField DataField="teacher_id" HeaderText="کد معلم" ReadOnly="True" SortExpression="teacher_id" />
            <asp:BoundField DataField="Teachername" HeaderText="نام معلم" SortExpression="Teachername" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT course.id, Lesson.title AS lesson_title, Lesson.id AS lesson_id, Class.id AS class_id, Class.title AS class_title, Teacher.id AS teacher_id, Teacher.Lname + ' ' + Teacher.Fname AS Teachername, Lesson.unit FROM course INNER JOIN Teacher ON course.Id_Teacher = Teacher.id INNER JOIN Lesson ON course.Id_Lesson = Lesson.id INNER JOIN Class ON course.Id_Class = Class.id WHERE (course.Id_year = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
<br />
