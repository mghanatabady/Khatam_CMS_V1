Imports Khatam_Functions
Partial Class C_school_class_del
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_class")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim school_Classroom_select_id As String
        school_Classroom_select_id = khatam.core.data.sql.getField("id", "school_class_id", Me.Request.QueryString("id"), "school_Classroom_select")
        If school_Classroom_select_id <> Nothing Then
            KUI.Database.sql.Sql_Del_Row("classroom_select", school_Classroom_select_id, "school_score", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
            KUI.Database.sql.Sql_Del_Row("id_school_classroom_select", school_Classroom_select_id, "school_Classroom_hour", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        End If
        KUI.Database.sql.Sql_Del_Row("school_class_id", Me.Request.QueryString("id"), "school_Classroom_select", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_Class", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())

        Me.Response.Redirect("~/manage/?mode=school_class")

    End Sub
End Class
