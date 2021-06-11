
Partial Class manage_c_school_teacher_course_classroom_list
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GridView1.DataBind()

        Try
            Dim StrMessage As String
            StrMessage = Me.Request.QueryString("msg")
            Me.Lbl_report1.Text = StrMessage
            If StrMessage = Nothing Then
                Me.Div9.Visible = False
            Else
                Me.Div9.Visible = True
            End If
        Catch ex As Exception
            Me.Div9.Visible = False
        End Try
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "add" Then
            Me.Session("school_classroom_select_id") = Me.GridView1.SelectedRow.Cells(0).Text
            Me.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_edit")
        End If

        If e.CommandName = "select" Then
            Me.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_score_list&id=" & Me.GridView1.SelectedRow.Cells(0).Text)
        End If


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Session("school_classroom_select_id") = Me.GridView1.SelectedRow.Cells(0).Text
        Me.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_edit")
    End Sub

    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        GridView1.SelectedIndex = e.CommandArgument
        If e.CommandName = "add" Then
            Me.Session("school_classroom_select_id") = Me.GridView1.SelectedRow.Cells(0).Text
            Me.Response.Redirect("~/manage/?mode=school_teacher_course_personal_classroom_edit")
        End If

        If e.CommandName = "select" Then
            Me.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_score_list&id=" & Me.GridView1.SelectedRow.Cells(0).Text)
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.SelectedIndexChanged
        ''  Me.Session("id_school_course_personal") = Me.GridView2.SelectedRow.Cells(0).Text
        '' Me.Response.Redirect("~/manage/?mode=school_teacher_course_personal_classroom_edit")
    End Sub
End Class