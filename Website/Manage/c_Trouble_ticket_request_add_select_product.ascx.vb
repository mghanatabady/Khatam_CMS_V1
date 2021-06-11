
Partial Class manage_c_Trouble_ticket_request_add_select_product
    Inherits System.Web.UI.UserControl



    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "select" Then
            Me.Session("customer_orders_products_id") = Me.GridView1.SelectedRow.Cells(0).Text
            Me.Response.Redirect("~/manage/Default.aspx?mode=Trouble_ticket_request_add")
        End If

 
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
