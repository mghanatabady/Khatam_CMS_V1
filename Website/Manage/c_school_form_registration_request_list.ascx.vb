
Partial Class c_school_form_registration_request_list
    Inherits System.Web.UI.UserControl

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Response.Redirect("~/manage/?mode=school_form_registration_request_item&id=" & Me.GridView1.SelectedRow.Cells(0).Text)
    End Sub
End Class
