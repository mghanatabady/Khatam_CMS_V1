Imports Khatam_Functions
Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class c_school_course_personal_del
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      

    End Sub


    Private Sub hide_wins()

        Me.MSG3.Visible = False

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()
    End Sub

    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_course_personal")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        KUI.Database.sql.Sql_Del_Row("school_course_personal", Me.Request.QueryString("id"), "school_score", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)
        KUI.Database.sql.Sql_Del_Row("school_course_personal_id", Me.Request.QueryString("id"), "school_course_personal_student", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)
        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_course_personal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)


        redirect_list()
    End Sub



End Class
