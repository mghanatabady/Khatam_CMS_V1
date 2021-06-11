
Partial Class C_school_class_list
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_class_add")

    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        'school_class_del
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "school_class_del" Then
            Me.Response.Redirect("~/manage/?mode=school_class_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        'SqlDataSource1.SelectCommand = _
        '"SELECT school_branch.title AS school_branch_title, school_Category.title AS school_Category_title, school_base_cat.title AS school_Base_cat_title, school_Class.title AS school_Class_title, school_Class.id FROM school_Class INNER JOIN school_Base ON school_Class.id_school_base = school_Base.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id WHERE (school_Class.id_school_year = N'" +
        'khatam.core.data.sql.getField("classAddgetactiveYear", "memo", "cname", "school_active_year", "Setting_Base") + "')"
        ''   SqlDataSource1.SelectCommand = "SELECT school_branch.title AS school_branch_title, school_Category.title AS school_Category_title, school_base_cat.title AS school_Base_cat_title, school_Class.title AS school_Class_title, school_Class.id FROM school_Class INNER JOIN school_Base ON school_Class.id_school_base = school_Base.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id WHERE (school_Class.id_school_year = " +
        ''     khatam.core.data.sql.getField("classAddgetactiveYear", "memo", "cname", "school_active_year", "Setting_Base") + ")"
        

    End Sub
End Class
