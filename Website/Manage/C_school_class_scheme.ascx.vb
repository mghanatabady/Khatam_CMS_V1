
Partial Class C_school_class_scheme_list
    Inherits System.Web.UI.UserControl



    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Response.Redirect("~/manage/?mode=school_class_scheme_add&id=" & Me.GridView1.SelectedRow.Cells(0).Text)

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''       SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        ''      SqlDataSource1.SelectCommand = "SELECT school_branch.title AS school_branch_title, school_Category.title AS school_Category_title, school_base_cat.title AS school_base_cat_title, school_Class.title AS school_Class_title, school_Class.id FROM school_Class INNER JOIN school_Base ON school_Class.id_school_base = school_Base.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id WHERE (school_Class.id_school_year = " + khatam.core.data.sql.getField("classAddgetactiveYear", "memo", "cname", "school_active_year", "Setting_Base") + ")"
    End Sub
End Class
