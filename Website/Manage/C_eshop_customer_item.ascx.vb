
Partial Class C_shop_customer_item
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/default.aspx?mode=shop_customer_list")
    End Sub
End Class
