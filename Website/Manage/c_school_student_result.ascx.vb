
Partial Class c_school_student_result
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GridView_Result.DataBind()
        Me.GridView1.DataBind()
        Me.GridView2.DataBind()
        load_score()

        Me.GridView_Result2.DataBind()
        Me.GridView11.DataBind()
        Me.GridView22.DataBind()
        load_score2()
    End Sub

    Private Sub load_score2hhh()



        Dim i As Integer
        For i = 0 To Me.GridView_Result.Rows.Count - 1

            'Lesson Title
            'CType(Me.GridView_Result.Rows(i).FindControl("Lbl_Lesson_name"), Label).Text = Me.GridView2.Rows(i).Cells(0).Text







        Next i

    End Sub


    Private Sub load_score()

        Dim i, j As Integer
        For i = 0 To Me.GridView_Result.Rows.Count - 1
            'Lesson Title
            'CType(Me.GridView_Result.Rows(i).FindControl("Lbl_Lesson_name"), Label).Text = Me.GridView2.Rows(i).Cells(1).Text



            For j = 0 To Me.GridView2.Rows.Count - 1

                If Me.GridView2.Rows(j).Cells(0).Text = Me.GridView1.Rows(i).Cells(0).Text Then
                    Select Case Me.GridView2.Rows(j).Cells(2).Text
                        Case 1
                            CType(Me.GridView_Result.Rows(i).FindControl("sc1m"), Label).Text = Me.GridView2.Rows(j).Cells(1).Text
                        Case 2
                            CType(Me.GridView_Result.Rows(i).FindControl("sc1p"), Label).Text = Me.GridView2.Rows(j).Cells(1).Text
                        Case 3
                            CType(Me.GridView_Result.Rows(i).FindControl("sc2m"), Label).Text = Me.GridView2.Rows(j).Cells(1).Text
                        Case 4
                            CType(Me.GridView_Result.Rows(i).FindControl("sc2p"), Label).Text = Me.GridView2.Rows(j).Cells(1).Text
                        Case 5
                            CType(Me.GridView_Result.Rows(i).FindControl("scsh"), Label).Text = Me.GridView2.Rows(j).Cells(1).Text
                    End Select

                End If

            Next j


        Next i







    End Sub

    Private Sub load_score2()

        Dim i, j As Integer
        For i = 0 To Me.GridView_Result2.Rows.Count - 1
            'Lesson Title
            'CType(Me.GridView_Result.Rows(i).FindControl("Lbl_Lesson_name"), Label).Text = Me.GridView2.Rows(i).Cells(1).Text



            For j = 0 To Me.GridView22.Rows.Count - 1

                If Me.GridView22.Rows(j).Cells(0).Text = Me.GridView11.Rows(i).Cells(0).Text Then
                    Select Case Me.GridView22.Rows(j).Cells(2).Text
                        Case 1
                            CType(Me.GridView_Result2.Rows(i).FindControl("sc1m"), Label).Text = Me.GridView22.Rows(j).Cells(1).Text
                        Case 2
                            CType(Me.GridView_Result2.Rows(i).FindControl("sc1p"), Label).Text = Me.GridView22.Rows(j).Cells(1).Text
                        Case 3
                            CType(Me.GridView_Result2.Rows(i).FindControl("sc2m"), Label).Text = Me.GridView22.Rows(j).Cells(1).Text
                        Case 4
                            CType(Me.GridView_Result2.Rows(i).FindControl("sc2p"), Label).Text = Me.GridView22.Rows(j).Cells(1).Text
                        Case 5
                            CType(Me.GridView_Result2.Rows(i).FindControl("scsh"), Label).Text = Me.GridView22.Rows(j).Cells(1).Text
                    End Select

                End If

            Next j


        Next i







    End Sub



End Class