Imports Khatam_Functions
Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class c_school_course_personal_select_scheme
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        If Me.Page.IsPostBack = False Then
            '   Me.Label1.Text = Me.GridViewschool_student.Rows(0).Cells(0).Text
            '  Me.Label2.Text = Me.GridViewschool_student.Rows(0).Cells(1).Text
            ' Me.Label3.Text = Me.GridViewschool_student.Rows(0).Cells(2).Text

            hide_wins()

        End If

        'Label1.Text= khatam.core.data.sql.getField("c_school_course_personal_select_scheme","fname"



    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim i As Integer = 0
        Dim lesson_text As String = ""


        For i = 0 To Me.GridView1.Rows.Count - 1
            If CType(Me.GridView1.Rows(i).Cells(0).FindControl("CheckBox1"), CheckBox).Checked = True Then

                Dim item_name, item_value As New ArrayList

                item_name.Add("school_student_id")
                item_value.Add(Me.Request.QueryString("id"))

                item_name.Add("school_course_personal_id")
                item_value.Add(Me.GridView1.Rows(i).Cells(1).Text)



                ''                khatam.core.data.sql.Add(item_name, item_value, "school_course_personal_student", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)




            End If
        Next i

   hide_wins()


    End Sub

    Protected Sub ImageButton_Remove_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton_Remove.Click
        Me.MSG5.Visible = True
        'Me.ImageButton_Remove.Enabled = False
        'Me.GridView_Remove.Enabled = False
    End Sub

    Private Sub hide_wins()
        Me.MSG2.Visible = False
        Me.MSG5.Visible = False
        Me.MSG6.Visible = False
        disable_unit()

    End Sub


    Private Sub disable_unit()
        Me.GridView_Remove.DataBind()
        Me.GridView1.DataBind()

        Dim i1 As Integer
        Dim i2 As Integer

        For i1 = 0 To Me.GridView1.Rows.Count - 1
            For i2 = 0 To Me.GridView_Remove.Rows.Count - 1
                If Me.GridView1.Rows(i1).Cells(1).Text = Me.GridView_Remove.Rows(i2).Cells(1).Text Then
                    CType(Me.GridView1.Rows(i1).Cells(0).FindControl("CheckBox1"), CheckBox).Enabled = False
                End If
            Next i2
        Next i1

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        hide_wins()
        'Me.ImageButton_Remove.Enabled = True
        'Me.GridView_Remove.Enabled = True
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer = 0
        Dim lesson_text As String = ""


        For i = 0 To Me.GridView_Remove.Rows.Count - 1
            If CType(Me.GridView_Remove.Rows(i).Cells(0).FindControl("CheckBox1"), CheckBox).Checked = True Then

                'Dim item_name, item_value As New ArrayList

                'item_name.Add("school_student_id")
                'item_value.Add(Me.Request.QueryString("id"))

                'item_name.Add("school_course_personal_id")
                'item_value.Add(Me.GridView1.Rows(i).Cells(1).Text)

                'KUI.Database.sql.Add(item_name, item_value, "school_course_personal_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

                'KUI.Database.sql.Sql_Del_Row("school_student_id", Me.Request.QueryString("id"), "school_course_personal_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

                school_course_personal_student_del(Me.Request.QueryString("id"), Me.GridView_Remove.Rows(i).Cells(1).Text)
                Sql_Del_student_personal_score(Me.Request.QueryString("id"), khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)


            End If
        Next i

        hide_wins()
    End Sub

    Private Sub school_course_personal_student_del(ByVal school_student_id As String, ByVal school_course_personal_id As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("school_student_id", school_student_id)
        parameters.Add("school_course_personal_id", school_course_personal_id)

        str_sql = "DELETE FROM school_course_personal_student    WHERE     (school_student_id = @school_student_id) AND (school_course_personal_id = @school_course_personal_id)"
        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub

    Public Shared Function Sql_Del_student_personal_score(ByVal id_school_student As String, ByVal ConnectionString As String) As String
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_student", id_school_student)




        str_sql = "DELETE FROM school_Score   WHERE     (NOT (school_course_personal IS NULL)) AND (student_id = @id_school_student)"



        Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)

    End Function
End Class
