
Partial Class C_School_Classroom_Calendar_edit
    Inherits System.Web.UI.UserControl



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString

        Me.GridView1.DataBind()
        Me.GridView_Detail.DataBind()
        Dim r, c As Integer
        Dim hl1_ctrl As String

        For r = 1 To 6
            For c = 1 To 5

                hl1_ctrl = "d" & r & "a" & c
                'hl1_ctrl = "d" & c & "a"

                Dim i As Integer

                For i = 0 To Me.GridView1.Rows.Count - 1
                    If (Me.GridView1.Rows(i).Cells(4).Text = c) And (Me.GridView1.Rows(i).Cells(5).Text = r) Then

                        CType(Me.FindControl(hl1_ctrl), HyperLink).Text = Me.GridView1.Rows(i).Cells(6).Text
                        CType(Me.FindControl(hl1_ctrl), HyperLink).NavigateUrl = "Default.aspx?mode=school_classroom_calendar_hour_edit&alarm=" & c & "&day=" & r & _
                        "&lesson_id=" & Me.GridView1.Rows(i).Cells(2).Text & "&teacher_id=" & Me.GridView1.Rows(i).Cells(3).Text & "&class_id=" & Me.Request.QueryString("id") _
                        & "&classroom_select=" & Me.GridView1.Rows(i).Cells(0).Text


                        CType(Me.FindControl("school_teacher_" & hl1_ctrl), HyperLink).Text = Me.GridView1.Rows(i).Cells(7).Text


                    End If

                Next i







            Next c
        Next r
        GridView_Detail.DataBind()
        fill_empty_hours()
        fill_form()




    End Sub

    Protected Sub Btn_ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_ok.Click

    End Sub

    Private Sub fill_empty_hours()
        Dim r, c As Integer
        Dim hl1_ctrl As String


        For r = 1 To 6
            For c = 1 To 5


                hl1_ctrl = "d" & r & "a" & c

                If (CType(Me.FindControl(hl1_ctrl), HyperLink).Text = "HyperLink") And (CType(Me.FindControl("school_teacher_" & hl1_ctrl), HyperLink).Text = "HyperLink") Then

                    CType(Me.FindControl(hl1_ctrl), HyperLink).Text = " آزاد " 'Me.GridView1.Rows(i).Cells(6).Text
                    CType(Me.FindControl(hl1_ctrl), HyperLink).NavigateUrl = "~/manage/?mode=school_classroom_calendar_hour_edit&alarm=" & c & "&day=" & r & "&lesson_id=empty&teacher_id=empty&class_id=" & Me.Request.QueryString("id")
                    CType(Me.FindControl("school_teacher_" & hl1_ctrl), HyperLink).Text = " " 'Me.GridView1.Rows(i).Cells(9).Text
                End If

            Next c
        Next r
    End Sub

    Private Sub fill_form()
        Me.LbL_Class_id.Text = Me.GridView_Detail.Rows(0).Cells(0).Text
        Me.Lbl_Class_title.Text = Me.GridView_Detail.Rows(0).Cells(1).Text
        Me.Lbl_Base_year.Text = Me.GridView_Detail.Rows(0).Cells(2).Text

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar")
    End Sub

    Protected Sub Btn_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Response.Redirect("~/manage/?mode=school_classroom_calendar")
    End Sub


End Class
