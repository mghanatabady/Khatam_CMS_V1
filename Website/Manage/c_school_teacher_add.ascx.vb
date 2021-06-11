Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Web.Configuration
Imports System.IO

Partial Class c_school_teacher_add
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Teacher_Check_identity() = True Then
            Teacher_Add(Me.Txt_Code.Text, Me.Txt_Fname.Text, Me.Txt_Lname.Text, Me.Txt_Password.Text, Me.Rb_PersonalPage_Enable.Checked, Me.Rb_PersonalPanel_Enable.Checked, Me.Txt_Email.Text)
            Teacher_content_Add(Me.Txt_Code.Text, Me.Txt_Fname.Text, Me.Txt_Lname.Text, "صفحه در حال بروز رسانی است", "teacher")
            create_upload_folder("school_teacher", Txt_Code.Text)
            reset_form()
            Me.MSG2.Visible = True
        Else
            Me.MSG1.Visible = True
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        redirect_list()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()
    End Sub


    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_teacher_list")
    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
    End Sub

    Function Teacher_Check_identity() As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", Me.Txt_Code.Text)
        str_sql = "SELECT  id   FROM         school_Teacher   WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Teacher_Add(ByVal id As String, ByVal Fname As String, ByVal Lname As String, ByVal password As String, ByVal page As Boolean, ByVal enable As Boolean, ByVal email As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", id)
        parameters.Add("Fname", Fname)
        parameters.Add("Lname", Lname)
        parameters.Add("password", password)
        parameters.Add("page", page)
        parameters.Add("enable", enable)
        parameters.Add("email", email)

        str_sql = "INSERT INTO school_teacher (id, Fname,Lname, password,page,enable,email)VALUES (@id, @Fname,@Lname, @password,@page,@enable,@email)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub

    Private Sub Teacher_content_Add(ByVal id As String, ByVal Fname As String, ByVal Lname As String, ByVal content As String, ByVal mode As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("idt", id)
        parameters.Add("title", Fname & " " & Lname)
        parameters.Add("page", content)
        parameters.Add("mode", mode)

        str_sql = "INSERT INTO [content] (title, [page], idt, mode) VALUES     (@title,@page,@idt,@mode)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub

    Private Sub create_upload_folder(ByVal mode As String, ByVal id_teacher As String)
        Dim path_str As String
        path_str = Server.MapPath("UPLOAD\" & mode & "\" & Me.Txt_Code.Text) ' & "\"

        Dim folder_path As New DirectoryInfo(path_str)

        If folder_path.Exists() Then
        Else
            folder_path.Create()
        End If

    End Sub


    Private Sub reset_form()
        Me.Txt_Code.Text = ""
        Me.Txt_Fname.Text = ""
        Me.Txt_Lname.Text = ""
        Me.Txt_Password.Text = ""
        Me.Txt_Email.Text = ""

    End Sub


End Class
