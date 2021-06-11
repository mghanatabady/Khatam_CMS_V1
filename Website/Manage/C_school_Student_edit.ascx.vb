Imports Khatam_Functions
Imports System.Globalization

Partial Class C_school_Student_edit
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim page, enable As Boolean


        If Me.IsPostBack = False Then

            hide_wins()

            Me.Txt_Code.Text = khatam.core.data.sql.getField("school_Student_edit", "id", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Try
                Me.DDL_school_base_id.SelectedValue = khatam.core.data.sql.getField("school_Student_edit", "school_base_id", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try
            Me.Txt_Fname.Text = khatam.core.data.sql.getField("school_Student_edit", "fname", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Me.Txt_Lname.Text = khatam.core.data.sql.getField("school_Student_edit", "lname", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Try
                Me.txt_national_code.Text = khatam.core.data.sql.getField("school_Student_edit", "national_code", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try


            Try
                Me.Txt_fathername.Text = khatam.core.data.sql.getField("school_Student_edit", "fathername", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)


            Catch ex As Exception

            End Try


            Try
                Me.Txt_shsh.Text = khatam.core.data.sql.getField("school_Student_edit", "shsh", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_shsh_sn.Text = khatam.core.data.sql.getField("school_Student_edit", "shsh_sn", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_shregplace.Text = khatam.core.data.sql.getField("school_Student_edit", "shregplace", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            'date

            Dim k As Date

            Try
                k = khatam.core.data.sql.getField("school_Student_edit", "birthday", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Catch ex As Exception
                k = Date.UtcNow()
            End Try

            If k.Month < 7 Then
                k = k.AddHours(4.5)
            Else
                k = k.AddHours(3.5)
            End If

            Dim ps As New PersianCalendar

            Me.DropDownList1_day.SelectedValue = Int(ps.GetDayOfMonth(k))
            Me.DropDownList2_month.SelectedValue = Int(ps.GetMonth(k))
            Me.txt_year.Text = ps.GetYear(k)

            Me.Txt_password.Text = khatam.core.data.sql.getField("school_Student_edit", "password", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Me.Txt_ppassword.Text = khatam.core.data.sql.getField("school_Student_edit", "ppassword", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            'enable()
            Dim status_Enable As Boolean
            Try
                status_Enable = khatam.core.data.sql.getField("school_Student_edit", "enable", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            If status_Enable Then
                Me.Rb_status_Enable.Checked = True
                Me.Rb_status_Disable.Checked = False
            Else
                Me.Rb_status_Enable.Checked = False
                Me.Rb_status_Disable.Checked = True
            End If


            Try
                Me.Txt_Tel.Text = khatam.core.data.sql.getField("school_Student_edit", "Tel", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try


            Try
                Me.Txt_mobile.Text = khatam.core.data.sql.getField("school_Student_edit", "mobile", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try


            Try
                Me.Txt_pmobile.Text = khatam.core.data.sql.getField("school_Student_edit", "pmobile", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try


            Try
                Me.Txt_mobile.Text = khatam.core.data.sql.getField("school_Student_edit", "mobile", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_Email.Text = khatam.core.data.sql.getField("school_Student_edit", "Email", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_pEmail.Text = khatam.core.data.sql.getField("school_Student_edit", "pEmail", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_Address.Text = khatam.core.data.sql.getField("school_Student_edit", "Address", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try

            Try
                Me.Txt_postal_code.Text = khatam.core.data.sql.getField("school_Student_edit", "postal_code", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception

            End Try



            Try
                Me.txt_picname.Text = khatam.core.data.sql.getField("school_Student_edit", "pic", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                Me.Img_now.ImageUrl = "upload\studentimage\" & khatam.core.data.sql.getField("school_Student_edit", "pic", "id", Me.Request.QueryString("id"), "school_student", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception
                Me.txt_picname.Text = ""
            End Try


            'Me.Txt_Lname.Text = khatam.core.data.sql.getField("lname", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            'Me.Txt_password.Text = khatam.core.data.sql.getField("password", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            'page = khatam.core.data.sql.getField("page", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            'enable = khatam.core.data.sql.getField("enable", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            'If enable Then
            'Me.Rb_PersonalPanel_Enable.Checked = True
            'Me.Rb_PersonalPanel_Disable.Checked = False
            'Else
            '   Me.Rb_PersonalPanel_Enable.Checked = False
            '  Me.Rb_PersonalPanel_Disable.Checked = True
            'End If

            '   If page Then
            'Me.Rb_PersonalPage_Enable.Checked = True
            'Me.Rb_PersonalPage_Disable.Checked = False
            'Else
            '   Me.Rb_PersonalPage_Enable.Checked = False
            '  Me.Rb_PersonalPage_Disable.Checked = True
            ' End If

            'Me.Txt_Email.Text = khatam.core.data.sql.getField("email", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)



        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        upload_pic()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item_name, item_value As New ArrayList


        item_name.Add("school_base_id")
        item_value.Add(Me.DDL_school_base_id.SelectedValue)

        item_name.Add("fname")
        item_value.Add(Me.Txt_Fname.Text)

        item_name.Add("lname")
        item_value.Add(Me.Txt_Lname.Text)

        item_name.Add("national_code")
        item_value.Add(Me.txt_national_code.Text)

        item_name.Add("shsh")
        item_value.Add(Me.Txt_shsh.Text)

        item_name.Add("shsh_sn")
        item_value.Add(Me.Txt_shsh_sn.Text)

        item_name.Add("shregplace")
        item_value.Add(Me.Txt_shregplace.Text)


        item_name.Add("birthday")
        Dim date_event As Date
        Try
            date_event = Persia.Calendar.ConvertToGregorian(Me.txt_year.Text, Me.DropDownList2_month.SelectedValue, Me.DropDownList1_day.SelectedValue, Persia.DateType.Persian)

        Catch ex As Exception
            date_event = Persia.Calendar.ConvertToGregorian(1300, 1, 1, Persia.DateType.Persian)

        End Try
        item_value.Add(date_event)

        item_name.Add("password")
        item_value.Add(Me.Txt_password.Text)

        item_name.Add("ppassword")
        item_value.Add(Me.Txt_ppassword.Text)

        item_name.Add("enable")
        item_value.Add(Me.Rb_status_Enable.Checked)

        item_name.Add("tel")
        item_value.Add(Me.Txt_Tel.Text)

        item_name.Add("mobile")
        item_value.Add(Me.Txt_mobile.Text)

        item_name.Add("pmobile")
        item_value.Add(Me.Txt_pmobile.Text)

        item_name.Add("Email")
        item_value.Add(Me.Txt_Email.Text)

        item_name.Add("pEmail")
        item_value.Add(Me.Txt_pEmail.Text)

        item_name.Add("Address")
        item_value.Add(Me.Txt_Address.Text)

        item_name.Add("postal_code")
        item_value.Add(Me.Txt_postal_code.Text)

        item_name.Add("pic")
        item_value.Add(Me.txt_picname.Text)


        khatam.core.data.sql.update(item_name, item_value, "school_student", "id", Me.Request.QueryString("id"))

        Me.MSG2.Visible = True
    End Sub

    Private Sub hide_wins()
        Me.MSG2.Visible = False
    End Sub

    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_student_list")
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        redirect_list()
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
                Me.Img_new.ImageUrl = "upload\StudentImage\" + FileUpload1.FileName
            Catch ex As Exception
                Label1.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            'پیام در صورت عدم انتخاب فایل
            Label1.Text = ""
        End If

    End Sub

    Protected Sub Button2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()

    End Sub
End Class


