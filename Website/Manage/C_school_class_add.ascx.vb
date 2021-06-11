
Imports System.Collections.Generic
Imports System.Web.Configuration
    Partial Class C_school_class_add
        Inherits System.Web.UI.UserControl

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click



        Class_Add(Me.DropDownList1.SelectedValue, Me.Txt_name.Text,
                  khatam.core.data.sql.getField("memo", "cname", "school_active_year", "Setting_Base"))

        reset_form()
        Me.MSG2.Visible = True

        End Sub

        Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
            redirect_list()
        End Sub

        Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
            redirect_list()
        End Sub

        Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_class")
        End Sub

        Private Sub hide_wins()
            Me.MSG1.Visible = False
            Me.MSG2.Visible = False
        End Sub

    Private Sub Class_Add(ByVal id_school_base As String, ByVal title As String, ByVal id_school_year As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_base", id_school_base)
        parameters.Add("title", title)
        parameters.Add("id_school_year", id_school_year)


        str_sql = "INSERT INTO school_Class   (id_school_base, title,id_school_year)  VALUES     (@id_school_base,@title,@id_school_year)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text,
                                       khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If

    End Sub

        Private Sub reset_form()
            Me.Txt_name.Text = ""
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()

        hide_wins()
        End Sub
    End Class
