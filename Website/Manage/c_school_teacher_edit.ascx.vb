Imports Khatam_Functions
Partial Class c_school_teacher_edit
    Inherits System.Web.UI.UserControl

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item_name, item_value As New ArrayList



        item_name.Add("fname")
        item_value.Add(Me.Txt_Fname.Text)

        item_name.Add("lname")
        item_value.Add(Me.Txt_Lname.Text)

        item_name.Add("password")
        item_value.Add(Me.Txt_Password.Text)

        item_name.Add("enable")
        item_value.Add(Me.Rb_PersonalPanel_Enable.Checked)

        item_name.Add("page")
        item_value.Add(Me.Rb_PersonalPage_Enable.Checked)

        item_name.Add("email")
        item_value.Add(Me.Txt_Email.Text)

        KUI.Database.sql.Sql_update_field("title", Me.Txt_Fname.Text & " " & Me.Txt_Lname.Text, "idt", Me.Request.QueryString("id"), "content", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        khatam.core.data.sql.update(item_name, item_value, "school_teacher", "id", Me.Request.QueryString("id"))


        Me.MSG2.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim page, enable As Boolean

        If Me.IsPostBack = False Then

            hide_wins()

            Me.Txt_Code.Text = khatam.core.data.sql.getField("teacherEdit", "id", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)



            Me.Txt_Fname.Text = khatam.core.data.sql.getField("teacherEdit", "fname", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Me.Txt_Lname.Text = khatam.core.data.sql.getField("teacherEdit", "lname", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            Me.Txt_Password.Text = khatam.core.data.sql.getField("teacherEdit", "password", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            page = khatam.core.data.sql.getField("teacherEdit", "page", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
            enable = khatam.core.data.sql.getField("teacherEdit", "enable", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            If enable Then
                Me.Rb_PersonalPanel_Enable.Checked = True
                Me.Rb_PersonalPanel_Disable.Checked = False
            Else
                Me.Rb_PersonalPanel_Enable.Checked = False
                Me.Rb_PersonalPanel_Disable.Checked = True
            End If

            If page Then
                Me.Rb_PersonalPage_Enable.Checked = True
                Me.Rb_PersonalPage_Disable.Checked = False
            Else
                Me.Rb_PersonalPage_Enable.Checked = False
                Me.Rb_PersonalPage_Disable.Checked = True
            End If


            Try
                Me.Txt_Email.Text = khatam.core.data.sql.getField("teacherEdit", "email", "id", Me.Request.QueryString("id"), "school_teacher", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)

            Catch ex As Exception
                Me.Txt_Email.Text = ""
            End Try


        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        redirect_list()
    End Sub

    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_teacher_list")
    End Sub

    Private Sub hide_wins()
        Me.MSG2.Visible = False
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()
    End Sub
End Class
