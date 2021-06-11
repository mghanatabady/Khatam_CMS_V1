
Partial Class c_school_course_personal_select
    Inherits System.Web.UI.UserControl

   

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
    End Sub


    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.SelectedIndexChanged
        Me.Response.Redirect("~/manage/?mode=school_course_personal_select_scheme&id=" & Me.GridView2.SelectedRow.Cells(0).Text)

    End Sub
End Class
