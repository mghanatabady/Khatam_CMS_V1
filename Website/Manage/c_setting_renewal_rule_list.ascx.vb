
Partial Class manage_c_setting_renewal_rule_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim type As String = Me.Request.QueryString("type")
        Dim id As String = Me.Request.QueryString("id")
        Me.Response.Redirect("~/manage/?mode=setting_renewal_rule_add&type=" & type & "&id=" & id)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
