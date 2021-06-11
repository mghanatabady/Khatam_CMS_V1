
Partial Class C_school_Educational_place_list
    Inherits System.Web.UI.UserControl

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        'school_Educational_place_del
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "school_Educational_place_del" Then
            Me.Response.Redirect("~/Default.aspx?mode=school_Educational_place_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

    End Sub
End Class
