Imports Khatam_Functions
Partial Class manage_setting_renewal_rule_add
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item_name, item_value As New ArrayList

        item_name.Add("product_type")
        item_value.Add(Me.Txt_type.Text)

        item_name.Add("product_type_id")
        item_value.Add(Me.Txt_Code.Text)

        item_name.Add("title")
        item_value.Add(Me.Txt_title.Text)

        item_name.Add("Year")
        item_value.Add(Me.DDL_year.SelectedValue)

        item_name.Add("price_rls")
        item_value.Add(Me.Txt_Value.Text)

        

        'item_name.Add("id_setting_placeholder")
        'item_value.Add(Me.DropDownList1.SelectedValue)

        'item_name.Add("id_setting_component")
        'item_value.Add(Me.Txt_id_component.Text)

        '"INSERT INTO Setting_placeholder_ref_section_ref_component   (id_setting_section, id_setting_placeholder, id_setting_component)   VALUES     (@id_setting_section,@id_setting_placeholder,@id_setting_component)"

        khatam.core.data.sql.Add(item_name, item_value, "setting_renewal_rule")

        back_url()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Txt_Code.Text = Me.Request.QueryString("id")
        Me.Txt_type.Text = Me.Request.QueryString("type")
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        back_url()
    End Sub

    Sub back_url()
        Dim type As String = Me.Request.QueryString("type")
        Dim id As String = Me.Request.QueryString("id")
        Me.Response.Redirect("~/manage/?mode=setting_renewal_rule_list&type=" & type & "&id=" & id)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        back_url()
    End Sub
End Class
