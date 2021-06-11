Imports Khatam_Functions

Partial Class C_School_Year_Select
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        khatam.core.data.sql.updateField("memo", Me.Request.QueryString("id"), "cname", "school_active_year", "Setting_Base",
                                         khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())

        
        Me.MSG3.Visible = False
        Me.MSG2.Visible = True

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_year")
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()

        Me.MSG3.Visible = True
    End Sub
    Private Sub hide_wins()
        Me.MSG3.Visible = False
        Me.MSG2.Visible = False
    End Sub

End Class