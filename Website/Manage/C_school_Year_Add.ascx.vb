
Imports System.Collections.Generic
Imports System.Web.Configuration

    Partial Class C_school_Year_Add
        Inherits System.Web.UI.UserControl

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            'year_Add(Me.Txt_name.Text)
            If year_Check_identity() = True Then
                year_Add(Me.Txt_name.Text)
                reset_form()
                Me.MSG2.Visible = True
            Else
                Me.MSG1.Visible = True
            End If

        End Sub

        Function year_Check_identity() As Boolean
            Dim str_sql As String
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

            parameters.Add("year", Me.Txt_name.Text)
        str_sql = "SELECT  id   FROM         [school_year]   WHERE     (year = @year)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub reset_form()
        Me.Txt_name.Text = ""
    End Sub

    Private Sub year_Add(ByVal year As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("year", year)

        str_sql = "INSERT INTO [school_year] (year) VALUES (@year)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If
    End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            hide_wins()
        End Sub
        Private Sub hide_wins()
            Me.MSG1.Visible = False
            Me.MSG2.Visible = False
        End Sub

        Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
            Me.Response.Redirect("~/Default.aspx?mode=year_list")
        End Sub
    End Class






