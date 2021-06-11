
Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class C_school_base_add
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_base")

    End Sub



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        category_Add(Me.DropDownList1.SelectedValue, Me.DropDownList2.SelectedValue)

        Me.MSG2.Visible = True
        reset_form()

    End Sub


    Private Sub category_Add(ByVal id_school_category As String, ByVal year_number As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_category", id_school_category)
        parameters.Add("year_number", year_number)

        str_sql = "INSERT INTO school_Base    (id_school_category, year_number)   VALUES     (@id_school_category,@year_number)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text,
                                       khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If
    End Sub

    Private Sub reset_form()
        'Me.Txt_.Text = ""
        'Me.Txt_Category_title.Text = ""
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()
        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()
        Me.SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()

    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_base")
    End Sub
End Class