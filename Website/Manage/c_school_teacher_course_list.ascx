<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_teacher_course_list.ascx.vb" Inherits="c_school_teacher_course_list" %>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify;">
    کلاس ها:<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="25">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="lesson_title" HeaderText="نام درس" SortExpression="lesson_title" />
            <asp:BoundField DataField="class_title" HeaderText="کلاس" SortExpression="class_title" />
            <asp:BoundField DataField="unit" HeaderText="تعداد واحد" SortExpression="unit" />
            <asp:CommandField SelectText="انتخاب" ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <EmptyDataTemplate>
            هیچ درسی برای ویرایش یافت نگردید.
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:portal1ConnectionString2 %>"  SelectCommand="SELECT     school_Class.title AS class_title, school_Lesson.title AS Lesson_title, school_Lesson.unit, school_Classroom_select.id, school_Class.id_school_year
FROM         school_Class INNER JOIN
                      school_Classroom_select ON school_Class.id = school_Classroom_select.school_class_id INNER JOIN
                      school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id">
    </asp:SqlDataSource>
    <br />
    سایر دروس :<br />
    <br />
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource2" Width="742px" PageSize="25">
        <Columns>
            <asp:BoundField DataField="id_school_course_personal" HeaderText="کد ارائه" InsertVisible="False"
                ReadOnly="True" SortExpression="school_teacher_id" />
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title" />
            <asp:BoundField DataField="unit" HeaderText="تعداد واحد" SortExpression="unit" />
            <asp:CommandField SelectText="انتخاب" ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <EmptyDataTemplate>
            هیچ درسی برای ویرایش یافت نگردید.
        </EmptyDataTemplate>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:portal1ConnectionString2 %>"  SelectCommand="SELECT school_Lesson.title, school_course_personal.id AS id_school_course_personal, school_Lesson.id, school_course_personal.school_teacher_id, school_course_personal.school_year_id, school_Lesson.unit FROM school_course_personal INNER JOIN school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id WHERE (school_course_personal.school_teacher_id = @school_teacher_id) AND (school_course_personal.school_year_id = @school_year_id)">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="school_teacher_id" SessionField="user_id" />
            <asp:SessionParameter Name="school_year_id" SessionField="year_active" />
        </SelectParameters>
    </asp:SqlDataSource>
    
</div>
