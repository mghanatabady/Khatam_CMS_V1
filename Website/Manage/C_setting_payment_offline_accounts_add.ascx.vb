Imports Khatam_Functions
Partial Class manage_C_setting_payment_offline_accounts_add
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item_name, item_value As New ArrayList

        item_name.Add("title")
        item_value.Add(Me.Txt_name.Text)

        khatam.core.data.sql.Add(item_name, item_value, "setting_payment_offline_accounts")

    End Sub
End Class
