Imports System.IO
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Web.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Khatam_Functions

Partial Class manage_c_Trouble_ticket_Response_item
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

        'Me.DropDownList1.SelectedValue = get_support_agent_id(Me.Request.QueryString("id"))

        


        If Me.Page.IsPostBack() = False Then
            Session("ds_file") = Nothing
        End If

        bind_grid1()

    End Sub

    Function get_support_agent_id(ByVal id_ticket As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_ticket)
        str_sql = "SELECT     id_support  FROM         trouble_ticket  WHERE     (id = @id_ticket)"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)

    End Function

    Private Sub bind_grid1()
        Me.GridView1.DataBind()
        Me.GridView2.DataBind()
        Me.GridView3.DataBind()
        Me.GridView4.DataBind()


        Dim i As Integer = 0
        For i = 0 To Me.GridView2.Rows.Count - 1
            If Me.GridView3.Rows(i).Cells(1).Text = "1" Then
                CType(Me.GridView2.Rows(i).Cells(0).FindControl("Lbl_RealName"), Label).Text = get_customer_realname(Me.Request.QueryString("id"))
            Else
                CType(Me.GridView2.Rows(i).Cells(0).FindControl("Lbl_RealName"), Label).Text = "کارشناس فنی"
            End If

            Dim persian_date As Date

            persian_date = Me.GridView3.Rows(i).Cells(2).Text

            Dim persian_time_grid As String = persian_time(persian_time_hours(persian_date))
            Dim persian_date_grid As String = PersianDate(persian_time_hours(persian_date))
            Dim persian_datetime_grid As String = " مورخ " & persian_date_grid & " ساعت: " & persian_time_grid

    


            CType(Me.GridView2.Rows(i).Cells(0).FindControl("Lbl_date"), Label).Text = persian_datetime_grid

            CType(Me.GridView2.Rows(i).Cells(0).FindControl("Lbl_link"), Label).Text = ticket_atacht_body(Request.ApplicationPath & "/", Me.Request.QueryString("id"), Me.GridView3.Rows(i).Cells(0).Text)

        Next i
    End Sub




    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=Trouble_ticket_Response_list")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.Txt_Page.Text = Nothing Then Me.Txt_Page.Text = "بدون شرح"

        If Me.GridView4.Rows.Count > 0 Then
            Dim status As Integer = 0
            If Me.CheckBox1.Checked = False Then
                status = 1
                support_ticket_status_update(Me.Request.QueryString("id"), status)
                support_ticker_note_add(status, get_customer_realname(Me.Request.QueryString("id")))


            Else
                status = 2
                support_ticket_status_update(Me.Request.QueryString("id"), status)
                support_ticker_note_close(status, get_customer_realname(Me.Request.QueryString("id")))

            End If



            Me.Txt_Page.Text = ""
            Me.MSG2.Visible = True


            Session("ds_file") = Nothing
            Dim ds As DataSet
            Me.Session("ds_file") = ds
            Me.GridView_Attach.DataSource = ds
            Me.GridView_Attach.DataBind()

            bind_grid1()

        End If
    End Sub

    Private Sub support_ticker_note_add(ByVal status As Integer, ByVal realname As String)

        Dim date_now As Date = Date.UtcNow()

        Dim persian_time_now As String = persian_time(persian_time_hours(date_now))
        Dim persian_date_now As String = PersianDate(persian_time_hours(date_now))
        Dim persian_datetime_now As String = " مورخ " & persian_date_now & " ساعت: " & persian_time_now

        Dim persian_time_insert As String = persian_time(persian_time_hours(GridView4.Rows(0).Cells(4).Text))
        Dim persian_date_insert As String = PersianDate(persian_time_hours(GridView4.Rows(0).Cells(4).Text))
        Dim persian_datetime_insert As String = " مورخ " & persian_date_insert & " ساعت: " & persian_time_insert


        support_ticket_line_add(Me.Request.QueryString("id"), html_liner(Me.Txt_Page.Text), status, 2, date_now)

        'attach file
        Dim i As Integer
        On Error GoTo 10
        Dim ds As New DataSet()
        ds = Me.Session("ds_file")
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                support_ticket_file_Add(ds.Tables(0).Rows(i).Item(2).ToString & "\", Me.GridView_Attach.Rows(i).Cells(0).Text, Me.Request.QueryString("id"), get_last_ticket_line_id(Me.Request.QueryString("id")))
            Next i
        End If
10:


        Dim ticket_body As String = ""
        i = 0
        Me.GridView2.DataBind()
        Me.GridView3.DataBind()

        Dim domain_str As String
        domain_str = KUI.setting.setting_base.Get_Setting_base("domain", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())



        For i = 0 To Me.GridView3.Rows.Count - 1
            ticket_body = ticket_body & " <br> "
            'ticket_body = " <div> " & ticket_body
            'user mode
            Dim name As String
            Dim date_final As String


            If Me.GridView3.Rows(i).Cells(1).Text = "1" Then
                name = realname
            Else
                name = "کارشناس فنی"
            End If


            Dim persian_time_update As String = persian_time(persian_time_hours(GridView3.Rows(i).Cells(2).Text))
            Dim persian_date_update As String = PersianDate(persian_time_hours(GridView3.Rows(i).Cells(2).Text))
            Dim persian_datetime_update As String = " مورخ " & persian_date_update & " ساعت: " & persian_time_update



            'end user mode


            ticket_body = ticket_body & persian_datetime_update & " " & name & " نوشتند: "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & Me.GridView3.Rows(i).Cells(4).Text
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & ticket_atacht_body("http://www." & domain_str & "/", Me.Request.QueryString("id"), Me.GridView3.Rows(i).Cells(0).Text)
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "



            'ticket_body = " </div> " & ticket_body


        Next i


        EmailSender_Support(get_customer_email(Me.Request.QueryString("id")), "Email_Response_support_update.htm", domain_str & ": Updated Support Request Ticket No: " & Me.Request.QueryString("id"), "", realname, Me.Request.QueryString("id"), "موضوع", GridView4.Rows(0).Cells(2).Text, persian_datetime_insert, persian_datetime_now, ticket_body)


    End Sub

    Private Sub support_ticket_file_Add(ByVal file_path As String, ByVal file_name As String, ByVal id_ticket As String, ByVal id_ticket_line As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("file_path", "manage\" & file_path)
        parameters.Add("file_name", file_name)
        parameters.Add("id_ticket", id_ticket)
        parameters.Add("id_ticket_line", id_ticket_line)

        str_sql = "INSERT INTO trouble_Ticket_File   (file_path,file_name, id_ticket,id_ticket_line)   VALUES     (@file_path,@file_name,@id_ticket,@id_ticket_line)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Private Sub support_ticker_note_close(ByVal status As Integer, ByVal realname As String)

        Dim date_now As Date = Date.UtcNow()

        Dim persian_time_now As String = persian_time(persian_time_hours(date_now))
        Dim persian_date_now As String = PersianDate(persian_time_hours(date_now))
        Dim persian_datetime_now As String = " مورخ " & persian_date_now & " ساعت: " & persian_time_now

        Dim persian_time_insert As String = persian_time(persian_time_hours(GridView4.Rows(0).Cells(4).Text))
        Dim persian_date_insert As String = PersianDate(persian_time_hours(GridView4.Rows(0).Cells(4).Text))
        Dim persian_datetime_insert As String = " مورخ " & persian_date_insert & " ساعت: " & persian_time_insert


        support_ticket_line_add(Me.Request.QueryString("id"), html_liner(Me.Txt_Page.Text), status, 2, date_now)

        'attach file
        On Error GoTo 20
        Dim i As Integer
        Dim ds As New DataSet()
        ds = Me.Session("ds_file")
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                support_ticket_file_Add(ds.Tables(0).Rows(i).Item(2).ToString & "\", Me.GridView_Attach.Rows(i).Cells(0).Text, Me.Request.QueryString("id"), get_last_ticket_line_id(Me.Request.QueryString("id")))
            Next i
        End If
20:

        Dim ticket_body As String = ""
        i = 0
        Me.GridView2.DataBind()
        Me.GridView3.DataBind()

        Dim domain_str As String
        domain_str = KUI.setting.setting_base.Get_Setting_base("domain", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())


        For i = 0 To Me.GridView3.Rows.Count - 1
            ticket_body = ticket_body & " <br> "
            'ticket_body = " <div> " & ticket_body
            'user mode
            Dim name As String
            Dim date_final As String


            If Me.GridView3.Rows(i).Cells(1).Text = "1" Then
                name = realname
            Else
                name = "کارشناس فنی"
            End If


            Dim persian_time_update As String = persian_time(persian_time_hours(GridView3.Rows(i).Cells(2).Text))
            Dim persian_date_update As String = PersianDate(persian_time_hours(GridView3.Rows(i).Cells(2).Text))
            Dim persian_datetime_update As String = " مورخ " & persian_date_update & " ساعت: " & persian_time_update



            'end user mode


            ticket_body = ticket_body & persian_datetime_update & " " & name & " نوشتند: "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & Me.GridView3.Rows(i).Cells(4).Text
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & ticket_atacht_body("http://www." & domain_str & "/", Me.Request.QueryString("id"), Me.GridView3.Rows(i).Cells(0).Text)
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "
            ticket_body = ticket_body & " <br> "

            'ticket_body = " </div> " & ticket_body


        Next i


        EmailSender_Support(get_customer_email(Me.Request.QueryString("id")), "Email_Response_support_close.htm", domain_str & ": Closed Support Request Ticket No: " & Me.Request.QueryString("id"), "", realname, Me.Request.QueryString("id"), "موضوع", GridView4.Rows(0).Cells(2).Text, persian_datetime_insert, persian_datetime_now, ticket_body)

    End Sub

    Private Sub support_ticket_line_add(ByVal id_ticket As String, ByVal page As String, ByVal status As String, ByVal user_mode As Integer, ByVal date_insert As Date)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_ticket)
        parameters.Add("date_insert", date_insert)
        parameters.Add("page", page)
        parameters.Add("status", status)
        parameters.Add("user_mode", user_mode)


        str_sql = "INSERT INTO Trouble_Ticket_Line  (id_ticket, date_insert, page, status,user_mode)     VALUES      (@id_ticket, @date_insert, @page, @status,@user_mode)"


        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub

    Private Sub support_ticket_status_update(ByVal id_ticket As String, ByVal status As String)
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_ticket)
        parameters.Add("status", status)

        str_sql = "UPDATE    Trouble_ticket    SET              status = @status   WHERE     (id = @id_ticket)"


        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If
    End Sub

    Function persian_time(ByVal k As Date)

        Return k.Hour & ":" & k.Minute & ":" & k.Second
    End Function


    Function persian_time_hours(ByVal k As Date)

        Dim Per As String
        Dim ps As New PersianCalendar

        Per = ps.GetMonth(k)
        If Per < 7 Then
            Return k.AddHours(4.5)
        Else
            Return k.AddHours(3.5)
        End If

    End Function

    Protected Function PersianDate(ByVal k As Date)
        Dim Per As String
        Dim ps As New PersianCalendar

        Per = ps.GetDayOfMonth(k) & "/" & ps.GetMonth(k) & "/" & ps.GetYear(k)
        Return Per
    End Function

    Function html_liner(ByVal str As String)

        If str <> "" Then
            Return Replace(str, vbCrLf, "<br>")
        Else
            Return DBNull.Value
        End If

    End Function

    Private Sub EmailSender_Support(ByVal customer_email As String, ByVal Template_File As String, ByVal Subject As String, ByVal customer_company As String, ByVal realname As String, ByVal ticket_id As String, ByVal category As String, ByVal title As String, ByVal date_insert As String, ByVal date_update As String, ByVal ticket_lines As String)
        Dim reader As StreamReader
        Dim strFileName As String = Server.MapPath(Template_File)
        Dim strFileText
        reader = File.OpenText(strFileName)
        While reader.Peek <> -1
            strFileText += reader.ReadLine()
        End While
        reader.Close()
        strFileText = Replace(strFileText, "#customer_company#", customer_company)
        strFileText = Replace(strFileText, "#realname#", realname)
        strFileText = Replace(strFileText, "#ticket_id#", ticket_id)
        strFileText = Replace(strFileText, "#category#", category)
        strFileText = Replace(strFileText, "#title#", title)
        strFileText = Replace(strFileText, "#date_insert#", date_insert)
        strFileText = Replace(strFileText, "#date_update#", date_update)
        strFileText = Replace(strFileText, "#ticket_lines#", ticket_lines)


        'Me.DIV1.InnerHtml = strFileText

        'send mail
        Dim mail As New MailMessage()
        mail.From = New MailAddress(KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

        mail.To.Add(customer_email)
        'start select mail to
        mail.Subject = Subject 'TextBox2.Text
        mail.Body = strFileText
        mail.IsBodyHtml = True
        mail.BodyEncoding = System.Text.Encoding.UTF8
        Dim smtp As New SmtpClient()
        smtp.Send(mail)
        'redirect
        'Me.Response.Redirect("Default.aspx?cat=ok")
    End Sub

    Function get_customer_realname(ByVal id_ticket As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", id_ticket)


        'str_sql = "SELECT     Customers.fname + ' ' + Customers.lname AS realname  FROM         Trouble_Ticket INNER JOIN                       Customers ON Trouble_Ticket.id = Customers.id  WHERE     (Trouble_Ticket.id = @id_ticket)"

        str_sql = "SELECT     Customers.fname + ' ' + Customers.lname AS realname  FROM         Trouble_ticket INNER JOIN   Customers ON Trouble_ticket.id_customer = Customers.id  WHERE     (Trouble_ticket.id = @id)"

        Dim str As String
        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"


    End Function

    Function get_customer_id(ByVal id_ticket As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_ticket)


        str_sql = "SELECT     id_customer   FROM         Trouble_ticket  WHERE     (id = @id_ticket)"



        Dim str As String
        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"


    End Function


    Function get_customer_email(ByVal id_ticket As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_ticket)




        str_sql = "SELECT     Customers.customer_email   FROM         Trouble_ticket  INNER JOIN    Customers ON Trouble_ticket.id_customer = Customers.id  WHERE     (Trouble_ticket.id = @id_ticket)"

        Dim str As String
        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"


    End Function

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Me.FileUpload1.FileName <> Nothing Then


            Dim date_now_upload_path As String
            Dim date_now_date_customer_path As String

            date_now_upload_path = Server.MapPath("UPLOAD_Support\" & Int(Date.UtcNow().Date.Year) & "\" & Int(Date.UtcNow().Date.Month) & "\" & Int(Date.UtcNow().Date.Day) & "\customer_id_" & get_customer_id(Me.Request.QueryString("id"))) ' & "\"
            date_now_date_customer_path = "UPLOAD_Support\" & Int(Date.UtcNow().Date.Year) & "\" & Int(Date.UtcNow().Date.Month) & "\" & Int(Date.UtcNow().Date.Day) & "\customer_id_" & get_customer_id(Me.Request.QueryString("id")) ' & "\"

            Dim folder_path As New DirectoryInfo(date_now_upload_path)

            If folder_path.Exists() Then
            Else
                folder_path.Create()
            End If

            If file_exists(date_now_upload_path & "\", FileUpload1.FileName) = True Then

                Me.Label1.Visible = True
                Me.Label1.Text = "خطا: فایلی قبلا با همین نام ثبت گردیده است"

            Else

                Me.Label1.Visible = False

                upload(date_now_upload_path & "\")
                ds_file_add(date_now_upload_path & "\" & FileUpload1.FileName, date_now_date_customer_path)

            End If

        Else
        End If
    End Sub

    Function file_exists(ByVal filepath As String, ByVal filename As String)

        Dim file01 As New FileInfo(filepath & filename)
        Return file01.Exists()

    End Function

    Private Sub upload(ByVal date_now As String)
        Dim path As String
        If FileUpload1.HasFile Then
            Try
                'path = Server.MapPath("UPLOAD_Support\" & date_now & "\")
                path = date_now
                'back to root folder
                'path = path.Replace("\cp", "")
                FileUpload1.SaveAs(path & FileUpload1.FileName)
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
                ''Me.txt_picname.Text = stringBuffer(UBound(stringBuffer))
                'showpic
                ''Me.Img_Student.ImageUrl = "StudentImages\" + FileUpload1.FileName
            Catch ex As Exception
                Label1.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            'پیام در صورت عدم انتخاب فایل
            Label1.Text = ""
        End If
    End Sub

    Protected Sub GridView_Attach_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView_Attach.SelectedIndexChanged
        Dim ds As New DataSet()
        ds = Me.Session("ds_file")

        Dim file_del As New FileInfo(ds.Tables(0).Rows(GridView_Attach.SelectedIndex).Item(1))
        'Dim file_del As New FileInfo(Me.GridView1.SelectedRow.Cells(1).Text)

        file_del.Delete()


        ds.Tables(0).Rows(GridView_Attach.SelectedIndex).Delete()
        Me.Session("ds_file") = ds

        Me.GridView_Attach.DataSource = Me.Session("ds_file")
        Me.GridView_Attach.DataBind()

        'Me.Response.Redirect("shopcart.aspx")



    End Sub
    Private Sub ds_file_add(ByVal date_now As String, ByVal date_now_date_customer_path As String)
        Dim ds As New DataSet

        Dim dsc As New DataSet
        dsc = Session("ds_file")

        On Error GoTo 10
        If dsc.Tables.Count > 0 Then
            ds = Session("ds_file")
        End If
10:

        Dim filename As New DataColumn
        filename.ColumnName = "filename"

        Dim path As New DataColumn
        path.ColumnName = "path"

        Dim customer_path As New DataColumn
        customer_path.ColumnName = "customer_path"

        'سر جدید
        Dim newrow As DataRow
        Dim newtable As New DataTable()
        'تعریف جدول جدید
        'فقط در بار اول
        If ds.Tables.Count < 1 Then
            ds.Tables.Add(newtable)


            'تعریف ستون ها در جدول
            ds.Tables(0).Columns.Add(filename)
            ds.Tables(0).Columns.Add(path)
            ds.Tables(0).Columns.Add(customer_path)


        End If


        newrow = ds.Tables(0).NewRow()

        newrow(0) = Me.FileUpload1.FileName
        newrow(1) = date_now
        newrow(2) = date_now_date_customer_path

        ds.Tables(0).Rows.Add(newrow)


        'خواندن در دیتا ست
        'در صورتی که درج ستون دیتا گرید به صورت اتوماتیک غیر فعال باشد ستون تعریف کرده
        'به جای نام ستون نام ستون درج شود در اینجا col_productname

        Me.Session("ds_file") = ds

        'Me.Label3.Text = CType(Me.GridView1.SelectedRow.FindControl("Hl_Title"), HyperLink).Text

        'Me.MSG2.Visible = True

        Me.GridView_Attach.DataSource = ds
        Me.GridView_Attach.DataBind()



    End Sub

    Function ticket_atacht_body(ByVal site As String, ByVal id_ticket As String, ByVal id_ticket_line As String) As String
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_ticket", id_ticket)
        parameters.Add("id_ticket_line", id_ticket_line)
        str_sql = "SELECT    file_path , file_name  FROM         trouble_ticket_File   WHERE     (id_ticket = @id_ticket) AND (id_ticket_line = @id_ticket_line)"

        Dim dt As New DataTable()

        dt = DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
        Dim dg As New GridView
        dg.DataSource = dt
        dg.DataBind()

        Dim ticket_body As String = ""
        Dim url As String
        Dim i As Integer
        If dg.Rows.Count > 0 Then

            For i = 0 To dg.Rows.Count - 1
                url = site & dg.Rows(i).Cells(0).Text & dg.Rows(i).Cells(1).Text

                ticket_body = ticket_body & " <br> "
                ticket_body = ticket_body & "<a href=" & Chr(34) & url.Replace("\", "/") & Chr(34) & ">" & dg.Rows(i).Cells(1).Text & "</a>"
                ticket_body = ticket_body & " <br> "

            Next i
            Return ticket_body
        Else
            Return ""
        End If



    End Function


    Function get_last_ticket_line_id(ByVal id_ticket As String) As String

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_ticket", id_ticket)
        'parameters.Add("date_insert", date_insert)
        'str_sql = "SELECT     TOP (1) id  FROM         Ticket_Line  WHERE     (id_ticket = @id_Ticket) AND (date_insert = @date_insert)  ORDER BY id DESC"
        str_sql = "SELECT     TOP (1) id  FROM         trouble_ticket_Line  WHERE     (id_ticket = @id_Ticket)  ORDER BY id DESC"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)

    End Function

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        support_ticket_agent_update(Me.Request.QueryString("id"), Me.DropDownList1.SelectedItem.Value)
    End Sub

    Private Sub support_ticket_agent_update(ByVal id_ticket As String, ByVal id_support As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_support", id_support)
        parameters.Add("id_ticket", id_ticket)
        str_sql = "UPDATE    trouble_ticket  SET     id_support = @id_support  WHERE     (id = @id_ticket)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Response.Redirect("~/manage/?mode=Trouble_ticket_Response_list")

    End Sub
End Class
