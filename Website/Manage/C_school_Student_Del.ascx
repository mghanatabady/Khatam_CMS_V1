<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Student_Del.ascx.vb" Inherits="C_school_Student_Del" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 81px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 65px">
        توجه!<br />
        <span style="font-size: 9pt">امکان حذف معلم مورد نظر به جهت ارائه دروس ذیل وجود ندارد،
            لطفا ابتدا با ویرایش درس ارائه شده (یا تغییر برنامه کلاسی) معلم را تغییر دهید و یا دروس ذیل را حذف نمایید.</span></div>
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
        <span style="font-size: 9pt">با حذف دانش آموز تمامی اطلاعات مرتبط (نمرات) &nbsp;نیز حذف خواهد شد. آیا برای
            حذف مطمئن هستید؟<br />
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
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px" id="Div_Lessons" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" PageSize="50" Width="742px" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد کلاس" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="school_Class_title" HeaderText="عنوان کلاس" SortExpression="school_Class_title" />
            <asp:BoundField DataField="school_branch_title" HeaderText="مقطع / شاخه" SortExpression="school_branch_title" />
            <asp:BoundField DataField="school_Category_title" HeaderText="رشته" SortExpression="school_Category_title" />
            <asp:BoundField DataField="school_base_cat_title" HeaderText="پایه" SortExpression="school_base_cat_title" />
            <asp:BoundField DataField="school_lesson_id" HeaderText="کد درس" SortExpression="school_lesson_id" />
            <asp:BoundField DataField="school_lesson_title" HeaderText="عنوان درس" SortExpression="school_lesson_title" />
        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT school_branch.title AS school_branch_title, school_Category.title AS school_Category_title, school_base_cat.title AS school_base_cat_title, school_Class.title AS school_Class_title, school_Class.id, school_Lesson.id AS school_lesson_id, school_Lesson.title AS school_lesson_title, school_Classroom_select.school_teacher_id FROM school_Lesson INNER JOIN school_Classroom_select ON school_Lesson.id = school_Classroom_select.school_lesson_id INNER JOIN school_Class INNER JOIN school_Base ON school_Class.id_school_base = school_Base.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id ON school_Classroom_select.school_class_id = school_Class.id WHERE (school_Classroom_select.school_teacher_id = @school_teacher_id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="school_teacher_id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" PageSize="50" Width="742px" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد ارائه" InsertVisible="False" ReadOnly="True"
                SortExpression="id">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="school_lesson_id" HeaderText="کد درس" ReadOnly="True"
                SortExpression="school_lesson_id">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title">
                <ItemStyle Width="300px" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT school_course_personal.school_teacher_id, school_Lesson.id AS school_lesson_id, school_Lesson.title, school_course_personal.id FROM school_Lesson INNER JOIN school_course_personal ON school_Lesson.id = school_course_personal.school_lesson_id WHERE (school_course_personal.school_teacher_id = @school_teacher_id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="school_teacher_id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
<br />