
Partial Class c_school_agentscore_course_list
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Session("school_classroom_select_id") = Me.GridView1.SelectedRow.Cells(0).Text
        Me.Response.Redirect("~/default.aspx?mode=school_teacher_course_edit")
    End Sub

    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.SelectedIndexChanged
        Me.Session("id_school_course_personal") = Me.GridView2.SelectedRow.Cells(0).Text
        Me.Response.Redirect("~/default.aspx?mode=school_teacher_course_personal_edit")
    End Sub
End Class
