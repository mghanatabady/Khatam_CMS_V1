Partial Class C_school_Student_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_student_add")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DDL_Search.SelectedValue = 0 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_student] WHERE (id LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
        If Me.DDL_Search.SelectedValue = 1 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_student] WHERE (fname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
        If Me.DDL_Search.SelectedValue = 2 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_student] WHERE (lname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
        If Me.DDL_Search.SelectedValue = 3 Then Me.SqlDataSource1.SelectCommand = "SELECT * FROM [school_student] WHERE " & _
        "(id LIKE N'%" & Me.Txt_Search.Text & "%' " & _
        "Or fname LIKE N'%" & Me.Txt_Search.Text & "%' " & _
        "Or lname LIKE N'%" & Me.Txt_Search.Text & "%')  ORDER BY [id]"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Txt_Search.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + Button1.UniqueID + "').click();return false;}} else {return true}; ")

    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "student_del" Then
            Me.Response.Redirect("~/manage/?mode=school_student_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
        If e.CommandName = "student_account" Then
            Me.Response.Redirect("~/manage/?mode=school_student_account_list&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub


    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Response.Redirect("~/manage/?mode=school_student_edit&id=" & Me.GridView1.SelectedRow.Cells(0).Text)
    End Sub
End Class
