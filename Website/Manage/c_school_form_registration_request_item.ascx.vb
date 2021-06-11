
Partial Class manage_c_school_form_registration_request_item
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_form_registration_request_list")
    End Sub
End Class
