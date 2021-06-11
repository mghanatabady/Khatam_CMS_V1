
Imports System.Data
Imports System.Data.SqlClient

Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class manage_C_school_teacher_course_personal_classroom_edit
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        Me.Label1.Text = Request.QueryString("id")


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


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim value As String = ""
        Dim score_type_type As Integer
        Dim student_id As String

        Dim i, j As Integer
        Dim c_add, c_del, c_edit As Integer
        c_add = c_del = c_edit = 0


        For i = 0 To Me.GridView1.Rows.Count - 1


            value = CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).Text
            score_type_type = 0


            student_id = Me.GridView1.Rows(i).Cells(0).Text



            If value = "" Then GoTo 10
            Score_add(value, DropDownList1.SelectedValue, score_type_type, Me.Request.QueryString("id"), student_id)

            c_add = c_add + 1

10:

        Next i
        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" & Request.QueryString("p") & "&msg=ok&c=" & c_add)


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        'set_rows()
    End Sub

    Private Sub old_score_set_fro()
        Dim scoreitemi As Integer
        For scoreitemi = 0 To Me.GridView1.Rows.Count - 1
            Dim MyConnection As SqlConnection
            Dim MyCommand As SqlCommand
            Dim MyAdapter As SqlDataAdapter
            Dim MyTable As DataTable = New DataTable()



            MyConnection = New SqlConnection()
            MyConnection.ConnectionString = _
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()
            MyCommand = New SqlCommand()

            'Find Control sc1m
            'Dim m1txt As New TextBox
            'm1txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m1"), TextBox)

            'Dim m2txt As New TextBox
            'm2txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m2"), TextBox)

            'Dim m3txt As New TextBox
            'm3txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m3"), TextBox)

            'Dim m4txt As New TextBox
            'm4txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m4"), TextBox)

            'Dim m5txt As New TextBox
            'm5txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m5"), TextBox)

            'Dim m6txt As New TextBox
            'm6txt = CType(Me.GridView1.Rows(scoreitemi).FindControl("m6"), TextBox)

            Dim sc1mtxt As New TextBox
            sc1mtxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("sc1m"), TextBox)

            Dim sc1ptxt As New TextBox
            sc1ptxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("sc1p"), TextBox)

            Dim sc2mtxt As New TextBox
            sc2mtxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("sc2m"), TextBox)

            Dim sc2ptxt As New TextBox
            sc2ptxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("sc2p"), TextBox)

            Dim scshtxt As New TextBox
            scshtxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("scsh"), TextBox)

            'end find control
            ''''''''''''''''''''''''''''''''''
            Dim sc1mv As String

            If sc1mtxt.Text = "" Then
                sc1mv = "null"
            ElseIf sc1mtxt.Text > 20 Then
                sc1mv = "20"
            ElseIf sc1mtxt.Text < 0 Then
                sc1mv = "0"
            Else
                sc1mv = sc1mtxt.Text
            End If
            ''''''''''''''''''''''''''''''''''
            Dim sc1pv As String

            If sc1ptxt.Text = "" Then
                sc1pv = "null"
            ElseIf sc1ptxt.Text > 20 Then
                sc1pv = "20"
            ElseIf sc1ptxt.Text < 0 Then
                sc1pv = "0"
            Else
                sc1pv = sc1ptxt.Text
            End If
            ''''''''''''''''''''''''''''''
            Dim sc2mv As String

            If sc2mtxt.Text = "" Then
                sc2mv = "null"
            ElseIf sc2mtxt.Text > 20 Then
                sc2mv = "20"
            ElseIf sc2mtxt.Text < 0 Then
                sc2mv = "0"
            Else
                sc2mv = sc2mtxt.Text
            End If
            ''''''''''''''''''''''''''''''''''
            Dim sc2pv As String

            If sc2ptxt.Text = "" Then
                sc2pv = "null"
            ElseIf sc2ptxt.Text > 20 Then
                sc2pv = "20"
            ElseIf sc2ptxt.Text < 0 Then
                sc2pv = "0"
            Else
                sc2pv = sc2ptxt.Text
            End If
            '''''''''''''''''''''''''''''''''
            Dim scshv As String

            If scshtxt.Text = "" Then
                scshv = "null"
            ElseIf scshtxt.Text > 20 Then
                scshv = "20"
            ElseIf scshtxt.Text < 0 Then
                scshv = "0"
            Else
                scshv = scshtxt.Text
            End If


            '''''MyCommand.CommandText = "UPDATE [select] SET m1 = " & m1v & ", m2 = " & m2v & ", m3 = " & m3v & ", m4 = " & m4v & ", m5 = " & m5v & ", m6 = " & m6v & ", sc1m = " & sc1mv & ", sc1p = " & sc1pv & ", sc2m = " & sc2mv & ", sc2p = " & sc2pv & ", scsh = " & scshv & " WHERE (id_student = N'" & Me.GridView3.Rows(scoreitemi).Cells(0).Text & "') AND (id_course = N'" & Me.GridView3.Rows(scoreitemi).Cells(1).Text & "')"
            MyCommand.CommandType = CommandType.Text
            MyCommand.Connection = MyConnection

            'parameters
            'Find Control sc1m
            ''  Dim sc1mtxt As New TextBox
            ' '  sc1mtxt = CType(Me.GridView1.Rows(scoreitemi).FindControl("sc1m"), TextBox)
            '   ' Me.Label1.Text = sc1mtxt.Text
            'end find control



            'title = New SqlParameter()
            ' title.ParameterName = "@title"
            ' title.Direction = ParameterDirection.Input
            'title.Value = Me.TextBox1.Text


            'ContactParam = New SqlParameter()
            'ContactParam.ParameterName = "@CONTACT"
            'ContactParam.SqlDbType = SqlDbType.VarChar
            'ContactParam.Size = 15
            'ContactParam.Direction = ParameterDirection.Input
            'ContactParam.Value = "Maria Anders"
            '  MyCommand.Parameters.Add(title)
            '    MyCommand.Parameters.Add(smalltxt)
            '   MyCommand.Parameters.Add(text)
            '   MyCommand.Parameters.Add(datenews)

            'end parameters
            MyAdapter = New SqlDataAdapter()
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(MyTable)
            '  GridView2.DataSource = MyTable.DefaultView
            '  GridView2.DataBind()
            MyAdapter.Dispose()
            MyCommand.Dispose()
            MyConnection.Dispose()
        Next scoreitemi
        '   Me.GridView2.Rows(0).Cells(0).TemplateControl.Controls.TemplateField()
        Me.GridView1.DataBind()
        ''Me.GridView3.DataBind()
        'Me.Label1.Visible = True
        set_rows()
        Me.MSG2.Visible = True
        ' Me.HyperLink1.Visible = True
    End Sub

    Private Sub set_rows()



        Dim i As Integer
        For i = 0 To Me.GridView1.Rows.Count - 1


            CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).Enabled = False
            CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).BackColor = Drawing.Color.Transparent
            CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).BorderStyle = BorderStyle.None

            CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).Enabled = False
            CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).BackColor = Drawing.Color.Transparent
            CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).BorderStyle = BorderStyle.None

            CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).Enabled = False
            CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).BackColor = Drawing.Color.Transparent
            CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).BorderStyle = BorderStyle.None

            CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).Enabled = False
            CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).BackColor = Drawing.Color.Transparent
            CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).BorderStyle = BorderStyle.None

            CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).Enabled = False
            CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).BackColor = Drawing.Color.Transparent
            CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).BorderStyle = BorderStyle.None

            Select Case Me.DropDownList1.SelectedValue

                Case 1
                    CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).Enabled = True
                    CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).BackColor = Drawing.Color.White
                    CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).BorderStyle = BorderStyle.NotSet
                Case 2
                    CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).Enabled = True
                    CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).BackColor = Drawing.Color.White
                    CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).BorderStyle = BorderStyle.NotSet
                Case 3
                    CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).Enabled = True
                    CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).BackColor = Drawing.Color.White
                    CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).BorderStyle = BorderStyle.NotSet
                Case 4
                    CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).Enabled = True
                    CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).BackColor = Drawing.Color.White
                    CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).BorderStyle = BorderStyle.NotSet
                Case 5
                    CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).Enabled = True
                    CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).BackColor = Drawing.Color.White
                    CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).BorderStyle = BorderStyle.NotSet

            End Select

        Next i

    End Sub

    Private Sub load_score()



        Dim i, j As Integer
        For i = 0 To Me.GridView2.Rows.Count - 1


            For j = 0 To Me.GridView3.Rows.Count - 1

                If Me.GridView3.Rows(j).Cells(0).Text = Me.GridView2.Rows(i).Cells(0).Text Then

                    Select Case Me.GridView3.Rows(j).Cells(4).Text
                        Case 1
                            CType(Me.GridView1.Rows(i).FindControl("sc1m"), TextBox).Text = Me.GridView3.Rows(j).Cells(2).Text
                        Case 2
                            CType(Me.GridView1.Rows(i).FindControl("sc1p"), TextBox).Text = Me.GridView3.Rows(j).Cells(2).Text
                        Case 3
                            CType(Me.GridView1.Rows(i).FindControl("sc2m"), TextBox).Text = Me.GridView3.Rows(j).Cells(2).Text
                        Case 4
                            CType(Me.GridView1.Rows(i).FindControl("sc2p"), TextBox).Text = Me.GridView3.Rows(j).Cells(2).Text
                        Case 5
                            CType(Me.GridView1.Rows(i).FindControl("scsh"), TextBox).Text = Me.GridView3.Rows(j).Cells(2).Text

                    End Select



                End If

            Next j

        Next i

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" & Request.QueryString("p"))
    End Sub



    Private Sub Score_add(ByVal value As String, ByVal score_cat_id As String, ByVal score_type_type As String, ByVal classroom_select As String, ByVal student_id As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("value", Val(value))
        parameters.Add("score_cat_id", score_cat_id)
        parameters.Add("score_type_type", score_type_type)
        parameters.Add("school_course_personal", classroom_select)
        parameters.Add("student_id", student_id)
        parameters.Add("title", txtTitle.Text)
        parameters.Add("examdate", PersianDateTextBox.DateValue)
        parameters.Add("baseofscore", txtBaseOfScore.Text)

        str_sql = "INSERT INTO school_Score  " & _
        " (value, score_cat_id, score_type_type, school_course_personal, student_id,examdate,title,baseofscore) " & _
        " VALUES     (@value,@score_cat_id,@score_type_type,@school_course_personal,@student_id,@examdate,@title,@baseofscore)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Private Sub Score_update(ByVal value As String, ByVal score_type_type As String, ByVal classroom_select As String, ByVal student_id As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("value", Val(value))

        parameters.Add("score_type_type", score_type_type)
        parameters.Add("school_course_personal", classroom_select)
        parameters.Add("student_id", student_id)

        str_sql = "UPDATE    school_Score   SET              value = @value   WHERE    " & _
        "      (score_type_type = @score_type_type) AND (school_course_personal = @school_course_personal) AND (student_id = @student_id)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Private Sub Score_delete(ByVal score_type_type As String, ByVal classroom_select As String, ByVal student_id As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("score_type_type", score_type_type)
        parameters.Add("school_course_personal", classroom_select)
        parameters.Add("student_id", student_id)

        str_sql = "DELETE FROM school_Score  " & _
        "      WHERE     (score_type_type = @score_type_type) AND (school_course_personal = @school_course_personal) AND (student_id = @student_id)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub


    Function Teacher_Check_identity() As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        ' parameters.Add("id", Me.Txt_Code.Text)
        str_sql = "SELECT  id   FROM         school_Teacher   WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function


    Function score_Check_identity(ByVal score_type_type As String, ByVal classroom_select As String, ByVal student_id As String) As Boolean
        Dim i As Integer

        For i = 0 To Me.GridView3.Rows.Count - 1


            If (score_type_type = Me.GridView3.Rows(i).Cells(4).Text) And _
            (classroom_select = Me.GridView3.Rows(i).Cells(5).Text) And _
            (student_id = Me.GridView3.Rows(i).Cells(0).Text) _
            Then

                Return False
                GoTo 20


            End If

        Next i
        Return True

20:
    End Function


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" & Request.QueryString("p"))
    End Sub

    Protected Sub SqlDataSource3_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource3.Selecting

    End Sub
End Class
