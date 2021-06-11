Imports System.Collections.Generic
Imports System.Web.Configuration

Partial Class C_school_Lesson_add
    Inherits System.Web.UI.UserControl

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        redirect_list()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        redirect_list()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Lesson_Check_identity() = True Then

            Lesson_Add(Me.Txt_Code.Text, Me.DDL_Category.SelectedValue, Me.Txt_Title.Text, _
            Me.Txt_Min_Pass_Value.Text, Me.DDL_year_present.SelectedValue, Me.Txt_Unit_practical_Quantity.Text, _
            Me.Txt_Unit_theoretical_Quantity.Text, Me.Txt_TeachHour_pratical_Quantity.Text, _
            Me.Txt_TeachHour_theotetical_Quantity.Text, Me.DDL_Lesson_Present_Cat_id.SelectedValue, _
            Me.DDL_Lesson_cat_id.SelectedValue, Me.DDL_Lesson_Present_Date_Cat.SelectedValue, Me.Txt_price.Text)

            reset_form()
            Me.MSG2.Visible = True
        Else
            Me.MSG1.Visible = True
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hide_wins()
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource4.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource5.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

    End Sub

    Private Sub hide_wins()
        Me.MSG1.Visible = False
        Me.MSG2.Visible = False
    End Sub

    Private Sub redirect_list()
        Me.Response.Redirect("~/manage/?mode=school_lesson")
    End Sub

    Private Sub reset_form()
        Me.Txt_Code.Text = ""
        Me.Txt_Title.Text = ""
        'Me.Txt_name.Text = ""
        'Me.Txt_unit.Text = ""
    End Sub

    Function Lesson_Check_identity() As Boolean
        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", Me.Txt_Code.Text)
        str_sql = "SELECT  id   FROM         school_lesson   WHERE     (id = @id)"

        If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Lesson_Add(ByVal id As String, ByVal category_id As String, ByVal title As String, ByVal Min_Pass_Value As String, _
    ByVal year_present As String, ByVal Unit_practical_Quantity As String, ByVal Unit_theoretical_Quantity As String, _
    ByVal TeachHour_pratical_Quantity As String, ByVal TeachHour_theotetical_Quantity As String, ByVal Lesson_Present_Cat_id As String, _
    ByVal Lesson_cat_id As String, ByVal Lesson_Present_Date_Cat_id As String, ByVal Price As String)


        Dim str_sql As String
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        parameters.Add("id", id)
        parameters.Add("category_id", category_id)
        parameters.Add("title", title)
        parameters.Add("Min_Pass_Value", Min_Pass_Value)
        parameters.Add("year_present", year_present)
        parameters.Add("Unit_practical_Quantity", Unit_practical_Quantity)
        parameters.Add("Unit_theoretical_Quantity", Unit_theoretical_Quantity)
        parameters.Add("TeachHour_pratical_Quantity", TeachHour_pratical_Quantity)
        parameters.Add("TeachHour_theotetical_Quantity", TeachHour_theotetical_Quantity)
        parameters.Add("Lesson_Present_Cat_id", Lesson_Present_Cat_id)
        parameters.Add("Lesson_cat_id", Lesson_cat_id)
        parameters.Add("Lesson_Present_Date_Cat_id", Lesson_Present_Date_Cat_id)
        parameters.Add("Price", Price)





        str_sql = "INSERT INTO school_Lesson " & _
        "              (id,category_id, title, Min_Pass_Value, year_present, Unit_practical_Quantity, Unit_theoretical_Quantity, TeachHour_pratical_Quantity, " & _
        "              TeachHour_theotetical_Quantity, Lesson_Present_Cat_id, Lesson_cat_id, Lesson_Present_Date_Cat_id, Price) " & _
        "   VALUES     (@id,@category_id,@title,@Min_Pass_Value,@year_present,@Unit_practical_Quantity,@Unit_theoretical_Quantity,@TeachHour_pratical_Quantity,@TeachHour_theotetical_Quantity,@Lesson_Present_Cat_id,@Lesson_cat_id,@Lesson_Present_Date_Cat_id,@Price) "

        If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString) <> 1 Then
            'strmsg = "Œÿ«ÌÌ œ— À»  Œ—Ìœ »ÊÃÊœ ¬„œ. ·ÿ›« »« Å‘ Ì»«‰Ì  „«” êÌ—Ìœ"
        End If


    End Sub

End Class
