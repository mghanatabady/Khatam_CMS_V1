Imports System.Collections.Generic
Imports System.Web.Configuration
Imports Khatam_Functions
Imports System.Data

Partial Class C_school_class_scheme_add
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString



        'GridView1.DataSource = 

        If Me.IsPostBack = False Then
            hide_wins()
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        If Me.Page.IsCallback = False Then
            Dim i As Integer
            'Dim year As String = year_active()
            Dim lesson_text As String = ""


            For i = 0 To Me.GridView1.Rows.Count - 1
                If CType(Me.GridView1.Rows(i).Cells(0).FindControl("CheckBox1"), CheckBox).Checked = True Then
                    'selectUnitPersonal(Int(Me.GridView1.Rows(i).Cells(1).Text), Me.Request.QueryString("ids"), year)
                    ''lesson_text = "هزینه اخذ واحد با کد ارائه " + Me.GridView1.Rows(i).Cells(1).Text + " درس " + Me.GridView1.Rows(i).Cells(3).Text
                    'update_student_class(Me.GridView1.Rows(i).Cells(1).Text, Me.Request.QueryString("id"))
                    'selectUnitPersonal_Accounting(lesson_text, Int(Me.GridView1.Rows(i).Cells(9).Text), Me.Request.QueryString("ids"), year)


                    Dim item_name, item_value As New ArrayList

                    item_name.Add("id_school_student")
                    item_value.Add(Me.GridView1.Rows(i).Cells(1).Text)

                    item_name.Add("id_school_class")
                    item_value.Add(Me.Request.QueryString("id"))


                    khatam.core.data.sql.Add(item_name, item_value, "school_Student_class")




                End If
            Next i

            Me.GridView1.DataBind()
            Me.GridView_Remove.DataBind()
        End If
        'set visual items
        ''Me.MSG6.Visible = True
        ''Me.GridView_Remove.Enabled = True
        'fill_grids()
        'disable_unit()

    End Sub


    Private Sub update_student_class(ByVal id As String, ByVal class_id As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("id", id)
        parameters.Add("class_id", class_id)
        str_sql = "UPDATE    school_Student    SET    class_id = @class_id    WHERE     (id = @id)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub


    Protected Sub ImageButton_Remove_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton_Remove.Click
        Me.MSG5.Visible = True



    End Sub

    Public Shared Function Sql_Del_student_class(ByVal id_school_student As String, ByVal id_school_class As String, ByVal ConnectionString As String) As String
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_student", id_school_student)
        parameters.Add("id_school_class", id_school_class)



        str_sql = "DELETE FROM school_Student_class   WHERE     (id_school_student = @id_school_student) AND (id_school_class = @id_school_class)"



        Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)

    End Function

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Public Shared Function Sql_Del_student_class_score(ByVal id_school_student As String, ByVal ConnectionString As String) As String
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_school_student", id_school_student)




        str_sql = "DELETE FROM school_Score   WHERE     (NOT (classroom_select IS NULL)) AND (student_id = @id_school_student)"



        Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)

    End Function

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        'Dim year As String = year_active()
        Dim lesson_text As String = ""

        For i = 0 To Me.GridView_Remove.Rows.Count - 1
            If CType(Me.GridView_Remove.Rows(i).Cells(0).FindControl("CheckBox1"), CheckBox).Checked = True Then
                'selectUnitPersonal(Int(Me.GridView1.Rows(i).Cells(1).Text), Me.Request.QueryString("ids"), year)
                ''lesson_text = "هزینه اخذ واحد با کد ارائه " + Me.GridView1.Rows(i).Cells(1).Text + " درس " + Me.GridView1.Rows(i).Cells(3).Text
                'update_student_class(Me.GridView_Remove.Rows(i).Cells(1).Text, "99999")

                Sql_Del_student_class(Me.GridView_Remove.Rows(i).Cells(1).Text, Me.Request.QueryString("id"), khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)

                Sql_Del_student_class_score(Me.GridView_Remove.Rows(i).Cells(1).Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString)

                'del score



                'selectUnitPersonal_Accounting(lesson_text, Int(Me.GridView1.Rows(i).Cells(9).Text), Me.Request.QueryString("ids"), year)
            End If
        Next i

        Me.GridView1.DataBind()
        Me.GridView_Remove.DataBind()

        hide_wins()
    End Sub

    Private Sub hide_wins()
        Me.MSG2.Visible = False
        Me.MSG5.Visible = False
        Me.MSG6.Visible = False

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        hide_wins()
    End Sub
End Class
