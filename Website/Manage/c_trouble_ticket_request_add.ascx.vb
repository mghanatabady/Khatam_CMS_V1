Imports System.IO
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Web.Configuration
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Imports Khatam_Functions

Partial Class manage_c_trouble_ticket_request_add
    Inherits System.Web.UI.UserControl




    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'persian_date_now
        Dim date_now As Date = Date.UtcNow()
        Dim persian_time_now As String = persian_time(persian_time_hours(date_now))
        Dim persian_date_now As String = PersianDate(persian_time_hours(date_now))
        Dim persian_datetime_now As String = " مورخ " & persian_date_now & " ساعت: " & persian_time_now

        'support_ticket_Add
        support_ticket_Add(Me.Session("user_id"), Me.Txt_Title.Text, "1", date_now, date_now, Me.Session("customer_orders_products_id"))

        Dim ticket_id As String = get_last_ticket_id(Me.Session("user_id"))

        ''support_ticket_Cat_Select_Add(ticket_id, Me.DropDownList4.SelectedValue)

        If Me.Txt_Page.Text = Nothing Then
            Me.Txt_Page.Text = "بدون شرح"
        End If

        support_ticket_line_add(ticket_id, html_liner(Me.Txt_Page.Text), 1, date_now)

        Dim last_ticket_line_id As String
        last_ticket_line_id = get_last_ticket_line_id(ticket_id, date_now)

        Dim i As Integer
        Dim ds As New DataSet()
        On Error GoTo 10
        ds = Me.Session("ds_file")

        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                support_ticket_file_Add(ds.Tables(0).Rows(i).Item(2).ToString & "\", Me.GridView1.Rows(i).Cells(0).Text, ticket_id, last_ticket_line_id)
            Next i
        End If
10:
        Dim domain_str As String
        domain_str = KUI.setting.setting_base.Get_Setting_base("domain", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())

        Dim ticket_body As String = ""

        ticket_body = ticket_body & " <br> "
        'ticket_body = " <div> " & ticket_body
        ticket_body = ticket_body & persian_datetime_now & " " & Me.Session("realname") & " نوشتند: "
        ticket_body = ticket_body & " <br> "
        ticket_body = ticket_body & " <br> "
        ticket_body = ticket_body & html_liner(Me.Txt_Page.Text)
        ticket_body = ticket_body & " <br> "
        ticket_body = ticket_body & " <br> "
        ticket_body = ticket_body & ticket_atacht_body("http://www." & domain_str & "/", ticket_id, last_ticket_line_id)
        ticket_body = ticket_body & " <br> "


        '#EmailSender_Support(get_customer_email(Me.Session("user_id")), domain_str & ": Support Request Ticket No: " & ticket_id, "", Me.Session("realname"), ticket_id, Me.DropDownList4.SelectedItem.Text, Me.Txt_Title.Text, persian_datetime_now, persian_datetime_now, ticket_body)



        Me.Response.Redirect("~/manage/?mode=Trouble_ticket_request_list")


    End Sub

    Function ticket_atacht_body(ByVal site As String, ByVal id_ticket As String, ByVal id_ticket_line As String) As String
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_ticket", id_ticket)
        parameters.Add("id_ticket_line", id_ticket_line)
        str_sql = "SELECT    file_path , file_name  FROM         Trouble_ticket_File   WHERE     (id_ticket = @id_ticket) AND (id_ticket_line = @id_ticket_line)"

        Dim dt As New DataTable()

        dt = DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
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
                ticket_body = ticket_body & "<a href=" & Chr(34) & url & Chr(34) & ">" & dg.Rows(i).Cells(1).Text & "</a>"
                ticket_body = ticket_body & " <br> "

            Next i
            Return ticket_body
        Else
            Return ""
        End If



    End Function




    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Me.Response.Redirect("~/manage/?mode=Trouble_ticket_request_list")

    End Sub



    Private Sub support_ticket_Add(ByVal id_customer As String, ByVal title As String, ByVal status As String, ByVal date_insert As Date, ByVal date_update As Date, ByVal id_Customer_Orders_Products As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_customer", id_customer)
        parameters.Add("title", title)
        parameters.Add("status", status)
        parameters.Add("date_insert", date_insert)
        parameters.Add("date_update", date_update)
        parameters.Add("id_Customer_Orders_Products", id_Customer_Orders_Products)

        str_sql = "INSERT INTO trouble_Ticket   (id_customer, title, status, date_insert, date_update,id_Customer_Orders_Products)   VALUES     (@id_customer,@title,@status,@date_insert,@date_update,@id_Customer_Orders_Products)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

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

    Private Sub support_ticket_Cat_Select_Add_old(ByVal item_id As String, ByVal cat_id As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)


        parameters.Add("item_id", item_id)
        parameters.Add("cat_id", cat_id)

        str_sql = "INSERT INTO Ticket_Cat_Select   (item_id, cat_id)  VALUES     (@item_id,@cat_id)"

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Function get_last_ticket_id(ByVal id_customer As String) As String

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_customer", id_customer)
        str_sql = "SELECT     TOP (1)  id    FROM         trouble_Ticket   WHERE     (id_customer = @id_customer)  ORDER BY id DESC"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)

    End Function

    Function get_last_ticket_line_id(ByVal id_ticket As String, ByVal date_insert As Date) As String

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("id_ticket", id_ticket)
        parameters.Add("date_insert", date_insert)
        str_sql = "SELECT     TOP (1) id  FROM         Trouble_Ticket_Line  WHERE     (id_ticket = @id_Ticket) AND (date_insert = @date_insert)  ORDER BY id DESC"

        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)

    End Function

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

    Private Sub support_ticket_line_add(ByVal id_customer As String, ByVal page As String, ByVal user_mode As Integer, ByVal date_insert As Date)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id_ticket", id_customer)
        parameters.Add("date_insert", date_insert)
        parameters.Add("page", page)
        parameters.Add("user_mode", user_mode)

        str_sql = "INSERT INTO Trouble_Ticket_Line  (id_ticket, date_insert, page, user_mode)     VALUES      (@id_ticket, @date_insert, @page, @user_mode)"


        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString) <> 1 Then
            'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
        End If

    End Sub

    Function html_liner(ByVal str As String)

        If str <> "" Then
            Return Replace(str, vbCrLf, "<br>")
        Else
            Return DBNull.Value
        End If

    End Function

    Private Sub EmailSender_Support(ByVal customer_email As String, ByVal subject As String, ByVal customer_company As String, ByVal realname As String, ByVal ticket_id As String, ByVal category As String, ByVal title As String, ByVal date_insert As String, ByVal date_update As String, ByVal ticket_lines As String)

        'Dim reader As StreamReader
        'Dim strFileName As String = Server.MapPath("Email_support.htm")
        Dim strFileText
        'reader = File.OpenText(strFileName)
        'While reader.Peek <> -1
        'strFileText += reader.ReadLine()
        'End While
        'reader.Close()

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
        mail.From = New MailAddress("info@yourDomain.com")

        'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

        mail.To.Add(customer_email)
        'customer_email)
        'start select mail to
        mail.Subject = subject 'TextBox2.Text
        mail.Body = strFileText
        mail.IsBodyHtml = True
        mail.BodyEncoding = System.Text.Encoding.UTF8
        Dim smtp As New SmtpClient()

        smtp.Send(mail)
        'redirect
        'Me.Response.Redirect("Default.aspx?cat=ok")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack() = False Then
            Session("ds_file") = Nothing
        End If

        ''Me.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        ' If Me.Request.QueryString() Then
    End Sub

    Function get_customer_email(ByVal customer_id As String)

        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", customer_id)


        str_sql = "SELECT     customer_email  FROM  Customers  WHERE     (id = @id)"



        Dim str As String
        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, WebConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"


    End Function

    Function file_exists(ByVal filepath As String, ByVal filename As String)

        Dim file01 As New FileInfo(filepath & filename)
        Return file01.Exists()

    End Function

    Private Sub upload(ByVal date_now As String)
        Dim path As String
        If FileUpload1.HasFile Then

            'If (FileUpload1.FileContent = "image/pjpeg") or  _
            ' (FileUpload1.FileContent = "image/pjpeg") or  _
            'Then



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



    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Me.FileUpload1.FileName <> Nothing Then


            Dim date_now_upload_path As String
            Dim date_now_date_customer_path As String

            date_now_upload_path = Server.MapPath("UPLOAD_Support\" & Int(Date.UtcNow().Date.Year) & "\" & Int(Date.UtcNow().Date.Month) & "\" & Int(Date.UtcNow().Date.Day) & "\customer_id_" & Me.Session("user_id")) ' & "\"
            date_now_date_customer_path = "UPLOAD_Support\" & Int(Date.UtcNow().Date.Year) & "\" & Int(Date.UtcNow().Date.Month) & "\" & Int(Date.UtcNow().Date.Day) & "\customer_id_" & Me.Session("user_id") ' & "\"

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

        Me.GridView1.DataSource = ds
        Me.GridView1.DataBind()



    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim ds As New DataSet()
        ds = Me.Session("ds_file")

        Dim file_del As New FileInfo(ds.Tables(0).Rows(GridView1.SelectedIndex).Item(1))
        'Dim file_del As New FileInfo(Me.GridView1.SelectedRow.Cells(1).Text)

        file_del.Delete()


        ds.Tables(0).Rows(GridView1.SelectedIndex).Delete()
        Me.Session("ds_file") = ds

        Me.GridView1.DataSource = Me.Session("ds_file")
        Me.GridView1.DataBind()

        'Me.Response.Redirect("shopcart.aspx")

    End Sub

    Function is_user_valid_for_thicket() As Boolean

        Dim sql_str As String
        sql_str = "SELECT Customer_Orders_Products.id, Customer_Orders_Products.order_id, Customer_Orders_Products.product_id, Customer_Orders_Products.quantity, Customer_Orders_Products.price_rials, Customer_Orders_Products.comments, Customer_Orders_Products.status, Customer_Orders_Products.expire_date FROM Customer_Orders_Products INNER JOIN Customer_Orders ON Customer_Orders_Products.order_id = Customer_Orders.order_id WHERE (Customer_Orders.customer_id = @customer_id) ORDER BY Customer_Orders_Products.id DESC"
        Return True

    End Function

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Response.Redirect("~/manage/?mode=Trouble_ticket_request_list")

    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        EmailSender_Support("mghanatabady@yahoo.com", "test", "شرکت", "نام و نام خانوادگی", "1", "cat", "title", "date", "dateupdate", "خط های تیکت")
    End Sub
End Class
