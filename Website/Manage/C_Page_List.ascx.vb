
Partial Class C_Page_List
    Inherits System.Web.UI.UserControl

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        'Me.Session("backurl") = Me.Page.Request.Url.OriginalString
        Me.Response.Redirect("Default.aspx?mode=page_edit&type=content&id=" & Me.GridView1.SelectedRow.Cells(0).Text & "&burl=" & Me.Page.Request.Url.OriginalString)
    End Sub
End Class
