Imports Khatam_Functions
Partial Class c_school_course_personal_add
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim item_name, item_value As New ArrayList

        'item_name.Add("school_educational_place_id")
        'item_value.Add(Me.DDL_educational_place_list_id.SelectedValue)

        'item_name.Add("school_teacher_id")
        'item_value.Add(Me.DDL_techer_id.SelectedValue)

        'item_name.Add("school_lesson_id")
        'item_value.Add(Me.ddl_lession_id.SelectedValue)

        'item_name.Add("school_year_id")
        'item_value.Add(khatam.core.data.sql.getField("school_course_personal_add", "memo", "cname", "school_active_year", "Setting_Base"))



        'khatam.core.data.sql.Add(item_name, item_value, "school_course_personal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)
        'Me.Response.Redirect("~/manage/?mode=school_course_personal&msg=ok")

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_course_personal")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

    End Sub
End Class
