Imports Khatam_Functions
Partial Class C_school_Category_Del
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()


        If Me.IsPostBack = False Then
            hide_wins()
        End If

        Me.GridView1.DataBind()
        If Me.GridView1.Rows.Count > 0 Then
            Me.MSG1.Visible = True
        Else
            Me.MSG3.Visible = True

        End If

    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
        Me.MSG3.Visible = False


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_category")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_category",
                                     khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        Me.Response.Redirect("~/manage/?mode=school_category")

    End Sub
End Class
