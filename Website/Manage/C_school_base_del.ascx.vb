Imports Khatam_Functions
Partial Class C_school_base_del
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()



        If Me.IsPostBack = False Then
            hide_wins()
        End If

        Dim del1, del2 As Boolean

        Me.GridView1.DataBind()
        If Me.GridView1.Rows.Count > 0 Then
            Me.MSG1.Visible = True
        Else
            del1 = True

        End If


       
        If del1 = True And del2 = True Then
            Me.MSG3.Visible = True
        End If

    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
        Me.MSG3.Visible = False


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_base")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        Me.Response.Redirect("~/manage/?mode=school_base")

    End Sub
End Class
