<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_school_teacher_course_classroom_score_list.ascx.cs" Inherits="manage_c_school_teacher_course_classroom_score_list" %>
<br />
<div id="DIV10" runat="server" dir="rtl" 
    style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px" 
    visible="true">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x; height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px; height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px; width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px; height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/images/silverbar_btn_list.gif" onclick="ImageButton1_Click" />
    </div>
</div>
<br />
<br />
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    &nbsp;<asp:GridView ID="GridView1" 
        runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" 
        Width="742px" 

          OnDataBound="GridView1_DataBound"
               DataSourceID="SqlDataSource1"  >
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد نمره" ReadOnly="True" 
                SortExpression="id">
                <ItemStyle HorizontalAlign="Right" Width="75px" />
            </asp:BoundField>
            <asp:BoundField DataField="student_id" 
                HeaderText="شماره دانش آموزی" SortExpression="student_id" 
                ReadOnly="True" />
            <asp:BoundField DataField="Fname" HeaderText="نام" ReadOnly="True" SortExpression="Fname">
                <ItemStyle HorizontalAlign="Right" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="Lname" HeaderText="نام خانوادگی" ReadOnly="True" SortExpression="Lname">
                <ItemStyle HorizontalAlign="Right" Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="عنوان آزمون" 
                SortExpression="title" ReadOnly="True" />
            <asp:BoundField DataField="ExamDate" HeaderText="تاریخ امتحان" 
                SortExpression="ExamDate" ReadOnly="True" />
            <asp:BoundField DataField="baseOfScore" HeaderText="پایه نمره" 
                SortExpression="baseOfScore" ReadOnly="True" />
            <asp:BoundField DataField="value" HeaderText="نمره" SortExpression="value" />
            <asp:ButtonField CommandName="student_account" Text="تراکنش مالی" Visible="False" />
            <asp:CommandField SelectText="ویرایش" ShowSelectButton="True" Visible="False" 
                ShowDeleteButton="True" >
                <ItemStyle Width="50px" />
            </asp:CommandField>
            <asp:ButtonField CommandName="del" Text="حذف" Visible="False" >
                <ItemStyle Width="50px" />
            </asp:ButtonField>
            <asp:CommandField ShowDeleteButton="True" DeleteText="حذف"  />
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
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
     SelectCommand="SELECT school_Score.id, school_Score.value, school_Score.score_type_type, school_Score.school_course_personal, school_Score.classroom_select, school_Score.ExamDate, school_Score.baseOfScore, school_score_cat.title, school_Score.student_id, users.id AS student_id, users.fname, users.lname FROM school_Score INNER JOIN school_score_cat ON school_Score.score_cat_id = school_score_cat.id INNER JOIN users ON school_Score.student_id = users.id WHERE (school_Score.score_type_type = 0) AND (school_Score.classroom_select = @id)" 
        DeleteCommand="DELETE FROM [school_Score]  WHERE [id] = @id;" 
        UpdateCommand="UPDATE school_Score SET value = @value FROM school_Score INNER JOIN school_score_cat ON school_Score.score_cat_id = school_score_cat.id INNER JOIN users ON school_Score.student_id = users.id WHERE (school_Score.score_type_type = 0) AND (school_Score.classroom_select = @id)" 
        onselecting="SqlDataSource1_Selecting" 
        ConnectionString="<%$ ConnectionStrings:portal1ConnectionString %>">
        <DeleteParameters>
            <asp:Parameter Name="id" />
        </DeleteParameters>
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="value" />
            <asp:Parameter Name="id" />
        </UpdateParameters>
    </asp:SqlDataSource>
</div>
