<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_course_personal_select.ascx.vb" Inherits="c_school_course_personal_select" %>

<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  
        SelectCommand="
        
        SELECT DISTINCT users.id, users.email, users.lname + ' ,  ' + users.fname AS realname
FROM         corePermission INNER JOIN
                      corePermissionRefUser ON corePermission.id = corePermissionRefUser.idPermission INNER JOIN
                      users ON corePermissionRefUser.idUser = users.id
WHERE     (corePermission.title = N'school_View_ClassGrade_linked_student') OR
                      (corePermission.title = N'school_View_reportCard_linked_student')
UNION
SELECT DISTINCT users_1.id, users_1.email, users_1.lname + ' ,  ' + users_1.fname AS realname
FROM         coreRoleRefUser INNER JOIN
                      coreRole ON coreRoleRefUser.idRole = coreRole.id INNER JOIN
                      users AS users_1 ON coreRoleRefUser.idUser = users_1.id INNER JOIN
                      corePermissionRefRole ON coreRole.id = corePermissionRefRole.idRole INNER JOIN
                      corePermission AS corePermission_1 ON corePermissionRefRole.idPermission = corePermission_1.id
WHERE     (corePermission_1.title = N'school_View_ClassGrade_linked_student') OR
                      (corePermission_1.title = N'school_View_reportCard_linked_student')
        
        " 
        DeleteCommand="DELETE FROM [student]  WHERE [id] = @id&#13;&#10;&#13;&#10;" 
        UpdateCommand="UPDATE [student]  SET  [Enable] = @Enable WHERE [id] = @id&#13;&#10;&#13;&#10;" 
        ConnectionString="<%$ ConnectionStrings:portal1ConnectionString %>">
        <DeleteParameters>
            <asp:Parameter Name="id" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Enable" />
            <asp:Parameter Name="id" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"   BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        PageSize="50" Width="742px"
        DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="email" HeaderText="ایمیل" SortExpression="email" />
            <asp:BoundField DataField="realname" HeaderText="نام و نام خانوادگی" ReadOnly="True" 
                SortExpression="realname" />
            <asp:CommandField SelectText="انتخاب" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />

    </asp:GridView>
</div>
