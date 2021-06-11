
Imports System.Data
Imports System.Data.SqlClient

Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class manage_c_school_teacher_course_classroom_edit
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim pAll As Boolean = False
        Dim pTeacher As Boolean = False

        pAll = khatam.core.Security.Users.validUserPermission("school_declaration_reportCard_All")
        pTeacher = khatam.core.Security.Users.validUserPermission("school_declaration_reportCard_All")

        If ((pTeacher) Or (pAll)) Then

        Else
            Me.Response.Redirect("~/manage/?mode=msgPermisson")
        End If

        If (pAll = False) Then

            If (khatam.School.teacher.ValidClassroomSelectRelatedTeacher(Request.QueryString("id")) = False) Then
                Me.Response.Redirect("~/manage/?mode=msgPermisson")
            End If
        End If




        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()

        Me.Label1.Text = Me.Request.QueryString("id")

        If Me.IsPostBack = False Then
            Me.Label1.Text = Me.Session("school_classroom_select_id")

            Me.GridView1.DataBind()
            Me.GridView2.DataBind()

            Me.PersianDateTextBox.DateValue = Date.UtcNow()

            Me.DropDownList1.DataSource = Khatam_Functions.KUI.Database.sql.Sql_load_table("school_score_cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
            Me.DropDownList1.DataValueField = "id"
            Me.DropDownList1.DataTextField = "title"

            Me.DropDownList1.DataBind()
            Me.DropDownList1.Items.RemoveAt(0)

            '  set_rows()
            ' load_score()
        End If



        'me.Label5.Text =
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim value As String = ""
        Dim score_type_type As Integer
        Dim student_id As String

        Dim i As Integer
        Dim c_add As Integer
        c_add = 0


        For i = 0 To Me.GridView1.Rows.Count - 1


            'On Error GoTo 10
            value = CType(Me.GridView1.Rows(i).FindControl("txtScoreValue"), TextBox).Text
            student_id = Me.GridView1.Rows(i).Cells(0).Text


            If value = "" Then GoTo 10
            Score_add(value, Me.DropDownList1.SelectedValue, score_type_type, Me.Request.QueryString("id"), student_id, Me.txtTitle.Text, PersianDateTextBox.DateValue, Me.txtBaseOfScore.Text)
            c_add = c_add + 1


10:

        Next i




        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" + Me.Request.QueryString("p") + "&msg=ok&c=" & c_add)


        'Me.GridView1.DataBind()
        'Me.GridView2.DataBind()
        'Me.GridView3.DataBind()
        'set_rows()
        'load_score()
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" + Me.Request.QueryString("p"))
    End Sub



    Private Sub Score_add(ByVal value As String, ByVal score_cat_id As String, ByVal score_type_type As String, ByVal classroom_select As String, ByVal student_id As String, ByVal title As String, ByVal examDate As Date, ByVal baseOfScore As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("value", Val(value))
        parameters.Add("score_cat_id", score_cat_id)
        parameters.Add("score_type_type", score_type_type)
        parameters.Add("classroom_select", classroom_select)
        parameters.Add("student_id", student_id)
        parameters.Add("title", title)
        parameters.Add("examDate", examDate)
        parameters.Add("baseOfScore", Val(baseOfScore))

        str_sql = "INSERT INTO school_Score  " & _
        " (value, score_cat_id, score_type_type, classroom_select, student_id,title,examdate,baseOfScore) " & _
        " VALUES     (@value,@score_cat_id,@score_type_type,@classroom_select,@student_id,@title,@examdate,@baseOfScore)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub




    Function Teacher_Check_identity() As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        ' parameters.Add("id", Me.Txt_Code.Text)
        str_sql = "SELECT  id   FROM         school_Teacher   WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function


    


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" + Me.Request.QueryString("p"))


    End Sub
End Class
