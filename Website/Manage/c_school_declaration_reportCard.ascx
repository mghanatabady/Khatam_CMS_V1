<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_school_declaration_reportCard.ascx.cs" Inherits="Manage_c_school_declaration_reportCard" %>


<br />
<div dir="rtl"  style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify;">
    اعلام نمرات کارنامه<br />
    کلاس ها:<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="25" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  >
    </asp:SqlDataSource>
    <br />
    سایر دروس :<br />
    <br />
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" DataSourceID="SqlDataSource2" Width="742px" PageSize="25" 
        onselectedindexchanged="GridView2_SelectedIndexChanged">
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
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"  >
    </asp:SqlDataSource>
    
</div>
