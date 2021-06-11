
Partial Class c_school_form_registration_request_list2
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim i As Integer
        i = Me.GridView1.SelectedIndex
        Me.Response.Redirect(Me.Request.PathInfo + "Default.aspx?mode=school_form_registration_request_item2&id=" + Me.GridView1.Rows(i).Cells(0).Text)
    End Sub
End Class
