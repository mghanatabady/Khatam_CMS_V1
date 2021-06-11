Imports Khatam_Functions
Partial Class C_school_Student_Del
    Inherits System.Web.UI.UserControl

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_student_list")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            hide_wins()
        End If
        Me.MSG3.Visible = True
    End Sub
    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
        Me.MSG3.Visible = False
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        KUI.Database.sql.Sql_Del_Row("student_id", Me.Request.QueryString("id"), "school_Score", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
        KUI.Database.sql.Sql_Del_Row("id_school_student", Me.Request.QueryString("id"), "school_Student_class", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
        KUI.Database.sql.Sql_Del_Row("school_student_id", Me.Request.QueryString("id"), "school_course_personal_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_Student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

        Me.Response.Redirect("~/manage/?mode=school_student_list")

    End Sub
End Class
