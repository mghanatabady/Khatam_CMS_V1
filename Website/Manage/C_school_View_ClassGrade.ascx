<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_school_View_ClassGrade.ascx.cs" Inherits="Manage_C_school_View_ClassGrade" %>
نمایش نمرات کلاسی<br />
<div id="Div9" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 96px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 78px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">
                <asp:Label ID="Lbl_report1" runat="server"></asp:Label></span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify;">
    کلاس ها:<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" 
        PageSize="25" onselectedindexchanged="GridView1_SelectedIndexChanged1" OnRowCommand="GridView1_RowCommand"  >
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="lesson_title" HeaderText="نام درس" SortExpression="lesson_title" />
            <asp:BoundField DataField="class_title" HeaderText="کلاس" SortExpression="class_title" />
            <asp:BoundField DataField="unit" HeaderText="تعداد واحد" SortExpression="unit" />
            <asp:ButtonField CommandName="add" Text="درج نمرات جدید" />
            <asp:ButtonField CommandName="select" Text="نمایش نمرات کلاسی" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <EmptyDataTemplate>
            هیچ درسی برای ویرایش یافت نگردید.
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  ConnectionString="<%$ ConnectionStrings:portal1ConnectionString2 %>"  
    SelectCommand="SELECT     school_Class.title AS class_title, school_Lesson.title AS Lesson_title, school_Lesson.unit, school_Classroom_select.id, school_Class.id_school_year
FROM         school_Class INNER JOIN
                      school_Classroom_select ON school_Class.id = school_Classroom_select.school_class_id INNER JOIN
                      school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id">
    </asp:SqlDataSource>
    <br />
    سایر دروس :<br />
    <br />
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" DataSourceID="SqlDataSource2" Width="742px" 
        PageSize="25" onselectedindexchanged="GridView2_SelectedIndexChanged2" OnRowCommand="GridView2_RowCommand"
        >
        <Columns>
            <asp:BoundField DataField="id_school_course_personal" HeaderText="کد ارائه" InsertVisible="False"
                ReadOnly="True" SortExpression="school_teacher_id" />
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title" />
            <asp:BoundField DataField="unit" HeaderText="تعداد واحد" SortExpression="unit" />
            <asp:ButtonField CommandName="add" Text="درج نمره جدید" />

        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <EmptyDataTemplate>
            هیچ درسی برای ویرایش یافت نگردید.
        </EmptyDataTemplate>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"  ConnectionString="<%$ ConnectionStrings:portal1ConnectionString2 %>" 
     
        SelectCommand="SELECT school_Lesson.title, school_course_personal.id AS id_school_course_personal, school_Lesson.id, school_course_personal.school_teacher_id, school_course_personal.school_year_id, school_Lesson.unit FROM school_course_personal INNER JOIN school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id">
    </asp:SqlDataSource>
    
</div>

