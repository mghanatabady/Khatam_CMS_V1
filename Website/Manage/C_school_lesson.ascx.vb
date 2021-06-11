Partial Class C_school_Lesson_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_Lesson_add")
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "school_Lesson_del" Then
            Me.Response.Redirect("~/manage/?mode=school_Lesson_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Response.Redirect("~/manage/?mode=school_Lesson_edit&id=" & Me.GridView1.SelectedRow.Cells(0).Text)
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DDL_Search.SelectedValue = 0 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_lesson] WHERE (id LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
        If Me.DDL_Search.SelectedValue = 1 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_lesson] WHERE (title LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
        If Me.DDL_Search.SelectedValue = 2 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_lesson] WHERE (id LIKE N'%" & Me.Txt_Search.Text & "%' Or title LIKE N'%" & Me.Txt_Search.Text & "%'  )  ORDER BY [id]"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()
    End Sub
End Class
