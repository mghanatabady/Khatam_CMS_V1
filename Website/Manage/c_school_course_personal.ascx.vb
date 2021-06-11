
Partial Class c_school_course_personal_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_course_personal_add")

    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "school_course_personal_del" Then
            Me.Response.Redirect("~/manage/?mode=school_course_personal_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
    End Sub
End Class
