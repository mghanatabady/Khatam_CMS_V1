Imports Khatam_Functions
Partial Class manage_c_payment_sbt_list
    Inherits System.Web.UI.UserControl

    Protected Sub GridView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DataBound
        Dim i As Integer
        For i = 0 To Me.GridView1.Rows.Count - 1
            Try
                Me.GridView1.Rows(i).Cells(2).Text = KUI.DateTimeKUI.Convert_Date.Global_To_Persian(Me.GridView1.Rows(i).Cells(2).Text)
            Catch ex As Exception

            End Try

        Next i
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "select" Then
            Me.Response.Redirect("~/manage/?mode=Customer_Orders_Products_list&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If

        If e.CommandName = "edit" Then
            Me.Response.Redirect("~/manage/?mode=Customer_Orders_edit&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If

        If e.CommandName = "del" Then
            Me.Response.Redirect("~/manage/?mode=Customer_Orders_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=customer_orders_add")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub
End Class
