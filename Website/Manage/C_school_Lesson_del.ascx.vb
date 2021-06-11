Imports Khatam_Functions
Imports System.IO

Partial Class C_school_Lesson_del
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        Me.GridView1.DataBind()
        Me.GridView2.DataBind()

        'If Me.Page.IsPostBack = False Then
        hide_wins()
        'End If

        Dim Delete_possible As Boolean
        If (Me.GridView1.Rows.Count < 1) And (Me.GridView2.Rows.Count < 1) Then Delete_possible = True

        If Delete_possible Then
            Me.MSG1.Visible = False
            Me.MSG3.Visible = True
        Else
            Me.MSG1.Visible = True
            Me.MSG3.Visible = False
        End If

    End Sub


    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
        Me.MSG3.Visible = False

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()
    End Sub

    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_lesson")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        KUI.Database.sql.Sql_Del_Row("id", Me.Request.QueryString("id"), "school_lesson", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)


        del_upload_folder("school_lesson", Me.Request.QueryString("id"))

        redirect_list()
    End Sub

    Private Sub del_upload_folder(ByVal mode As String, ByVal id_teacher As String)
        Dim path_str As String
        path_str = Server.MapPath("UPLOAD\" & mode & "\" & Me.Request.QueryString("id")) ' & "\"

        Dim folder_path As New DirectoryInfo(path_str)

        If folder_path.Exists() Then folder_path.Delete()

    End Sub


End Class
