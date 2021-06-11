Imports System.Collections.Generic
Imports System.Web.Configuration


Partial Class C_school_Category_Add
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_category")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Txt_Category_title.Text <> "" Then
            category_Add(Me.DropDownList1.SelectedValue, Me.Txt_Category_title.Text)
            Me.MSG2.Visible = True
            reset_form()
        End If
    End Sub


    Private Sub category_Add(ByVal id_branch As String, ByVal title As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_branch", id_branch)
        parameters.Add("title", title)

        str_sql = "INSERT INTO school_Category   (id_school_branch, title)   VALUES     (@id_school_branch,@title)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If
    End Sub

    Private Sub reset_form()
        'Me.Txt_.Text = ""
        Me.Txt_Category_title.Text = ""
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()
        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()
    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/")
    End Sub
End Class
