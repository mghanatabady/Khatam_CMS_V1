Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class C_school_Student_Add
    Inherits System.Web.UI.UserControl
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        upload_pic()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        hide_wins()

        Dim birthday As Date
        Try
            birthday = Persia.Calendar.ConvertToGregorian(Me.txt_year.Text, Me.DropDownList2_month.SelectedValue, Me.DropDownList1_day.SelectedValue, Persia.DateType.Persian)
        Catch ex As Exception
            birthday = Persia.Calendar.ConvertToGregorian(1300, 1, 1, Persia.DateType.Persian)
        End Try

        If student_Check_identity() = True Then
            'student_Add(Me.Txt_Code.Text, Me.DDL_school_base_id.SelectedValue, Me.DDL_class_id.SelectedValue, Me.txt_national_code.Text, _
            student_Add(Me.Txt_Code.Text, Me.DDL_school_base_id.SelectedValue, Me.txt_national_code.Text, _
             Me.Txt_Fname.Text, Me.Txt_Lname.Text, Me.Txt_fathername.Text, Me.Txt_shsh.Text, _
             Me.Txt_shsh_sn.Text, Me.Txt_shregplace.Text, birthday, Me.Txt_password.Text, _
             Me.Txt_ppassword.Text, Me.Rb_status_Enable.Checked, _
             Me.Txt_Tel.Text, Me.Txt_mobile.Text, Me.Txt_pmobile.Text, Me.Txt_Email.Text, Me.Txt_pEmail.Text, _
            Me.Txt_Address.Text, Me.Txt_postal_code.Text, Me.txt_picname.Text, 1, 1, 0)

            Me.MSG2.Visible = True
        Else
            Me.MSG1.Visible = True
        End If


    End Sub

    Function student_Check_identity() As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", Me.txt_national_code.Text)
        str_sql = "SELECT  id   FROM         school_student   WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function

    'student_Add(Me.Txt_Code.Text, Me.DDL_school_base_id.SelectedValue, Me.DDL_class_id.SelectedValue, Me.txt_national_code.Text, _
    Private Sub student_Add(ByVal id As String, ByVal base_id As String, ByVal national_code As String, _
ByVal Fname As String, ByVal Lname As String, _
ByVal fathername As String, ByVal shsh As String, ByVal shsh_sn As String, ByVal shregplace As String, _
ByVal birthday As Date, ByVal Password As String, ByVal ppassword As String, _
ByVal enable As String, ByVal tel As String, ByVal mobile As String, ByVal pmobile As String, _
ByVal Email As String, ByVal pEmail As String, ByVal Address As String, ByVal postal_code As String, _
ByVal Pic As String, ByVal Vazife_status As String, ByVal marriage_status As String, ByVal Average_guidance_school As String)


        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", id)
        'parameters.Add("school_class_id", class_id)
        parameters.Add("school_base_id", base_id)
        parameters.Add("national_code", national_code)
        parameters.Add("Fname", Fname)
        parameters.Add("Lname", Lname)
        parameters.Add("fathername", fathername)
        parameters.Add("shsh", shsh)
        parameters.Add("shsh_sn", shsh_sn)
        parameters.Add("shregplace", shregplace)
        parameters.Add("birthday", birthday)
        parameters.Add("password", Password)
        parameters.Add("ppassword", ppassword)
        parameters.Add("enable", enable)
        parameters.Add("tel", tel)
        parameters.Add("Mobile", mobile)
        parameters.Add("pMobile", pmobile)
        parameters.Add("Email", Email)
        parameters.Add("pemail", pEmail)
        parameters.Add("Address", Address)
        parameters.Add("postal_code", postal_code)
        parameters.Add("pic", Pic)
        parameters.Add("Vazife_status", Vazife_status)
        parameters.Add("marriage_status", marriage_status)
        parameters.Add("Average_guidance_school", Average_guidance_school)




        'str_sql = "INSERT INTO Student    (id, Fname, Lname, password, ppassword, enable, Mobile, pMobile, Email, pemail, pic, groupid)    VALUES     (@id,@Fname,@Lname,@password,@ppassword,@enable,@Mobile,@pMobile,@Email,@pemail,@pic, @groupid)"

        str_sql = " INSERT INTO school_Student   " & _
                      " (id, school_base_id, national_code, Fname, Lname, fathername, shsh, shsh_sn, shregplace, birthday, ppassword, password,  tel, Mobile, pMobile, pic, Email, pemail, enable, Address, postal_code,Vazife_status,marriage_status,Average_guidance_school)" & _
        " VALUES     (@id,@school_base_id,@national_code,@Fname,@Lname,@fathername,@shsh,@shsh_sn,@shregplace,@birthday,@ppassword,@password,@tel,@Mobile,@pMobile,@pic,@Email,@pemail,@enable,@Address,@postal_code,@Vazife_status,@marriage_status,@Average_guidance_school)"

        '             " (id, school_base_id,school_class_id, national_code, Fname, Lname, fathername, shsh, shsh_sn, shregplace, birthday, ppassword, password,  tel, Mobile, pMobile, pic, Email, pemail, enable, Address, postal_code,Vazife_status,marriage_status,Average_guidance_school)" & _
        '" VALUES     (@id,@school_base_id,@school_class_id,@national_code,@Fname,@Lname,@fathername,@shsh,@shsh_sn,@shregplace,@birthday,@ppassword,@password,@tel,@Mobile,@pMobile,@pic,@Email,@pemail,@enable,@Address,@postal_code,@Vazife_status,@marriage_status,@Average_guidance_school)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub


    Private Sub reset_form()
        Me.txt_national_code.Text = ""
        Me.Txt_Fname.Text = ""
        Me.Txt_Lname.Text = ""
        Me.Txt_password.Text = ""
        Me.Txt_ppassword.Text = ""
        Me.Txt_mobile.Text = ""
        Me.Txt_pmobile.Text = ""
        Me.Txt_Email.Text = ""
        Me.Txt_pEmail.Text = ""
        Me.txt_picname.Text = ""
    End Sub



    Private Sub selectunit_group_auto(ByVal std_no As String, ByVal group_id As String, ByVal Id_year As String)
        'get lesson of group
        Dim parameters_select_group As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters_select_group.Add("id_group", group_id)
        parameters_select_group.Add("Id_year", Id_year)
        Dim str_sql As String
        Dim dt As New DataTable
        str_sql = "SELECT     id_course   FROM  Select_Group  WHERE  (id_group = @id_group) AND (Id_year = @Id_year)"

        dt = DBFunctions.ExecuteReader(str_sql, parameters_select_group, CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
        'insert to student
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim parameters_insert_unit As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Dim str_sql_ins As String
            parameters_insert_unit.Add("id_course", dt.Rows(i).Item(0))
            parameters_insert_unit.Add("id_student", std_no)
            parameters_insert_unit.Add("Id_year", year_active)
            str_sql_ins = "INSERT INTO [select] (id_course, id_student, Id_year) VALUES (@id_course , @id_student , @Id_year)"

            DBFunctions.ExecuteNonQuery(str_sql_ins, parameters_insert_unit, CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
        Next i
        selectunit_selected(std_no, Id_year)

    End Sub

    Private Sub selectunit_selected(ByVal std_no As String, ByVal Id_year As String)
        Dim dt As DataTable
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_student", std_no)
        parameters.Add("Id_year", Id_year)

        Dim str_sql As String
        str_sql = "SELECT   course.id as id_course ,  Lesson.id, Lesson.title, Lesson.unit, [select].id_student, [select].Id_year   FROM         Lesson INNER JOIN    Student INNER JOIN " & _
        "                      [select] ON Student.id = [select].id_student INNER JOIN    course ON [select].id_course = course.id ON Lesson.id = course.Id_Lesson " & _
        " WHERE     ([select].id_student = @id_student) AND ([select].Id_year = @Id_year) "
        dt = DBFunctions.ExecuteReader(str_sql, parameters, CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

        'GridView2.DataSource = dt
        'GridView2.DataBind()
        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_student_list")
    End Sub
    Private Sub hide_wins()
        'Me.upfolder.Visible = False
        'Me.Toolbar_new.Visible = False
        'Me.DIV_SelectUnit.Visible = False
        'Me.Div4.Visible = False
        Me.MSG2.Visible = False
    End Sub
    Private Sub upload_pic()
        Dim path As String
        If FileUpload1.HasFile Then
            Try
                path = Server.MapPath("upload\StudentImage\")
                'back to root folder
                'path = path.Replace("\cp", "")
                FileUpload1.SaveAs(path & _
                FileUpload1.FileName)
                Label1.Text = "ارسال موفقیت آمیز تصویر <br> " & _
                "File name: " & _
                FileUpload1.PostedFile.FileName & "<br>" & _
                "File Size: " & _
                FileUpload1.PostedFile.ContentLength & " kb<br>" & _
                "Content type: " & _
                FileUpload1.PostedFile.ContentType

                'hide & show
                'Me.FileUpload1.Visible = False
                'Me.Button2.Visible = False
                'split file name
                Dim stringBuffer() As String
                stringBuffer = Split(Me.FileUpload1.PostedFile.FileName, "\")
                Me.txt_picname.Text = stringBuffer(UBound(stringBuffer))
                'showpic
                Me.Img_Student.ImageUrl = "upload\StudentImage\" + FileUpload1.FileName
            Catch ex As Exception
                Label1.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            'پیام در صورت عدم انتخاب فایل
            Label1.Text = ""
        End If

    End Sub

    Function year_active() As Integer
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        Return DBFunctions.ExecuteScaler("SELECT     year_active  FROM         School_setting", parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

    End Function

    Protected Sub Button2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=school_student_list")

    End Sub
End Class
