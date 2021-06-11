Imports System.Collections.Generic
Imports System.Web.Configuration
Imports Khatam_Functions

Partial Class c_school_classroom_calendar_hour_edit
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        'empty, add

        Dim Classroom_select_id As Integer

        If (Me.Request.QueryString("lesson_id") = "empty") And (Me.Request.QueryString("teacher_id") = "empty") Then
            If (Me.DDL_Lesson.SelectedValue <> "empty") And (Me.DDL_Teacher.SelectedValue <> "empty") Then


                If Classroom_select_uniq_Check_identity(Me.Request.QueryString("class_id"), Me.DDL_Lesson.SelectedValue, Me.DDL_Teacher.SelectedValue) = True Then
                    Classroom_select_id = Classroom_select_Add(Me.Request.QueryString("class_id"), Me.DDL_Lesson.SelectedValue, Me.DDL_Teacher.SelectedValue)
                Else
                    Classroom_select_id = Classroom_select_uniq(Me.Request.QueryString("class_id"), Me.DDL_Lesson.SelectedValue, Me.DDL_Teacher.SelectedValue)

                End If


                Classroom_hour_add(Classroom_select_id, Me.Request.QueryString("alarm"), Me.Request.QueryString("day"))
                Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))

            End If
        End If


        'load, edit

        If (Me.Request.QueryString("lesson_id") <> "empty") And (Me.Request.QueryString("teacher_id") <> "empty") Then


            If (Me.DDL_Lesson.SelectedValue <> "empty") And (Me.DDL_Teacher.SelectedValue <> "empty") Then

                Classroom_select_edit(Me.Request.QueryString("classroom_select"), Me.DDL_Lesson.SelectedValue, Me.DDL_Teacher.SelectedValue)
                Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))

            End If
        End If


    End Sub



    Function Classroom_select_Add(ByVal school_class_id As String, ByVal school_lesson_id As String, ByVal school_teacher_id As String) As Integer
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("school_class_id", school_class_id)
        parameters.Add("school_lesson_id", school_lesson_id)
        parameters.Add("school_teacher_id", school_teacher_id)

        str_sql = "INSERT INTO school_Classroom_select   (school_class_id, school_lesson_id, school_teacher_id)  VALUES     (@school_class_id,@school_lesson_id,@school_teacher_id) ; SELECT SCOPE_IDENTITY();"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)
        'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"

    End Function

    Private Sub Classroom_select_edit(ByVal school_classroom_select As String, ByVal school_lesson_id As String, ByVal school_teacher_id As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", school_classroom_select)
        parameters.Add("school_lesson_id", school_lesson_id)
        parameters.Add("school_teacher_id", school_teacher_id)

        str_sql = "UPDATE    school_Classroom_select     SET              school_lesson_id = @school_lesson_id, school_teacher_id = @school_teacher_id  WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If

    End Sub


    Private Sub Classroom_hour_add(ByVal id_school_Classroom_select As String, ByVal alarm_number As String, ByVal day_number As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_Classroom_select", id_school_Classroom_select)
        parameters.Add("alarm_number", alarm_number)
        parameters.Add("day_number", day_number)

        str_sql = "INSERT INTO school_Classroom_hour   (id_school_Classroom_select, alarm_number, day_number)  VALUES     (@id_school_Classroom_select,@alarm_number,@day_number); SELECT SCOPE_IDENTITY();"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If
    End Sub




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        If (Me.Request.QueryString("lesson_id") <> "empty") And (Me.Request.QueryString("teacher_id") <> "empty") Then
            If Me.Page.IsPostBack = False Then
                Me.DDL_Lesson.SelectedValue = Me.Request.QueryString("lesson_id")
                Me.DDL_Lesson.Enabled = False
                Me.DDL_Teacher.SelectedValue = Me.Request.QueryString("teacher_id")
                Me.DDL_Teacher.Enabled = False



            End If
        End If

        If (Me.Request.QueryString("lesson_id") = "empty") And (Me.Request.QueryString("teacher_id") = "empty") Then
            ImageButton3.Visible = False
            If Me.Page.IsPostBack = False Then
                Lbl_Msg_info.Text = Msg_Info_Classroom_hour()
            End If
        End If

        If Me.Page.IsPostBack = False Then
            hide_wins()
        End If

    End Sub

    Function Msg_Info_Classroom_hour() As Integer
        Dim alarm, day As String

        'Dim alarm, day, t3, t4, t5 As String

        alarm = Me.Request.QueryString("alarm")
        day = Me.Request.QueryString("alarm")


        Return 0
    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        On Error Resume Next
        'Classroom_hour_del(Me.Request.QueryString("classroom_select"), Me.Request.QueryString("alarm"), Me.Request.QueryString("day"))

        Dim count As Integer
        count = KUI.Database.sql.Sql_count("id_school_classroom_select", Me.Request.QueryString("classroom_select"), "school_Classroom_hour", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)
        Me.Button1.Text = count
        If count > 1 Then
            Me.MSG3.Visible = True
            'nothing
        Else
            Me.MSG1.Visible = True
        End If


        ' Me.Response.Redirect("Default.aspx?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))
    End Sub

    Private Sub Classroom_hour_del(ByVal id_school_classroom_select As String, ByVal alarm_number As String, ByVal day_number As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_classroom_select", id_school_classroom_select)
        parameters.Add("alarm_number", alarm_number)
        parameters.Add("day_number", day_number)


        str_sql = "DELETE FROM school_Classroom_hour  WHERE     (id_school_classroom_select = @id_school_classroom_select) AND (alarm_number = @alarm_number) AND (day_number = @day_number)"
        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If
    End Sub


    Function Classroom_hour_Check_identity(ByVal id_school_classroom_select As String) As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", ID)
        str_sql = "SELECT     id  FROM         school_Classroom_hour  "

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function


    Function Classroom_select_uniq_Check_identity(ByVal school_class_id As String, ByVal school_lesson_id As String, ByVal school_teacher_id As String) As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("school_class_id", school_class_id)
        parameters.Add("school_lesson_id", school_lesson_id)
        parameters.Add("school_teacher_id", school_teacher_id)

        str_sql = "SELECT     school_class_id, school_lesson_id, school_teacher_id    FROM         school_Classroom_select    WHERE     (school_class_id = @school_class_id) AND (school_lesson_id = @school_lesson_id) AND (school_teacher_id = @school_teacher_id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function


    Function Classroom_select_uniq(ByVal school_class_id As String, ByVal school_lesson_id As String, ByVal school_teacher_id As String) As Integer
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("school_class_id", school_class_id)
        parameters.Add("school_lesson_id", school_lesson_id)
        parameters.Add("school_teacher_id", school_teacher_id)

        str_sql = "SELECT     id    FROM         school_Classroom_select    WHERE     (school_class_id = @school_class_id) AND (school_lesson_id = @school_lesson_id) AND (school_teacher_id = @school_teacher_id)"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)

    End Function



    Private Sub Classroom_select_del(ByVal id As String)


        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", id)

        str_sql = "DELETE FROM school_Classroom_select   WHERE     (id = @id)"
        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If



    End Sub


    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Classroom_hour_del(Me.Request.QueryString("classroom_select"), Me.Request.QueryString("alarm"), Me.Request.QueryString("day"))

        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))

    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))

    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        Classroom_hour_del(Me.Request.QueryString("classroom_select"), Me.Request.QueryString("alarm"), Me.Request.QueryString("day"))

        Classroom_select_del(Me.Request.QueryString("classroom_select"))

        KUI.Database.sql.Sql_Del_Row("classroom_select", Me.Request.QueryString("classroom_select"), "school_score", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)

        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar_edit&id=" & Me.Request.QueryString("class_id"))


    End Sub


    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
        Me.MSG3.Visible = False

    End Sub


End Class
