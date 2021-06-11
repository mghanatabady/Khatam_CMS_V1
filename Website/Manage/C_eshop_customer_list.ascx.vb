
Partial Class C_shop_customer_list
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DDL_Search.SelectedValue = 0 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [student] WHERE (ids LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [ids]"
        If Me.DDL_Search.SelectedValue = 1 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [student] WHERE (Fname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [ids]"
        If Me.DDL_Search.SelectedValue = 2 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [student] WHERE (Lname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [ids]"
        If Me.DDL_Search.SelectedValue = 3 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [student] WHERE (shsh LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [ids]"
        If Me.DDL_Search.SelectedValue = 4 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [student] WHERE " & _
        "(ids LIKE N'%" & Me.Txt_Search.Text & "%' " & _
        "Or Fname LIKE N'%" & Me.Txt_Search.Text & "%' " & _
        "Or Lname LIKE N'%" & Me.Txt_Search.Text & "%' " & _
        "Or shsh LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [ids]"
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim i As Integer
        i = Me.GridView1.SelectedIndex
        Me.Response.Redirect(Me.Request.PathInfo + "Default.aspx?mode=shop_customer_item&id=" + Me.GridView1.Rows(i).Cells(0).Text)
    End Sub
End Class
