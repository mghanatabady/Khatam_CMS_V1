
Partial Class c_school_teacher_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_teacher_add")
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "school_teacher_del" Then
            Me.Response.Redirect("~/manage/?mode=school_teacher_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If

        If e.CommandName = "school_teacher_edit" Then
            Me.Response.Redirect("~/manage/?mode=school_teacher_edit&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If

        If e.CommandName = "school_teacher_flight_hours_list" Then
            Me.Response.Redirect("~/manage/?mode=school_teacher_flight_hours_list&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DDL_Search.SelectedValue = 0 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_teacher] WHERE (id LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [Lname]"
        If Me.DDL_Search.SelectedValue = 1 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_teacher] WHERE (Fname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [Lname]"
        If Me.DDL_Search.SelectedValue = 2 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_teacher] WHERE (Lname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [Lname]"
        If Me.DDL_Search.SelectedValue = 3 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_teacher] WHERE (Email LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [Lname]"
        If Me.DDL_Search.SelectedValue = 4 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_teacher] WHERE (id LIKE N'%" & Me.Txt_Search.Text & "%' Or Fname LIKE N'%" & Me.Txt_Search.Text & "%' OR Lname LIKE N'%" & Me.Txt_Search.Text & "%' OR Email LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [Lname]"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
