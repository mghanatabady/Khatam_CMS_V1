using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_school_View_ClassGrade_linked_student : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {



        string uid = khatam.core.Security.Users.getIdByEmail(Request.Cookies["UID"].Value).Replace("'", "");

        SqlDataSource1.SelectCommand = "SELECT school_Score.id, school_Score.value, users.fname + ' ' + users.lname AS teachername,school_Lesson.id as school_lesson_id, school_Lesson.title, school_Lesson.unit,baseOfScore, school_Score.title as ExamTitle, school_Score.ExamDate ,"
 + " school_score_cat.title AS ScoreTypeTitle"
 + " FROM school_Score INNER JOIN"
 + " school_Classroom_select ON school_Score.classroom_select = school_Classroom_select.id INNER JOIN"
 + " school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id INNER JOIN"
 + " users AS users ON school_Classroom_select.school_teacher_id = users.id INNER JOIN"
 + " school_score_cat ON school_Score.score_cat_id = school_score_cat.id"
 + " WHERE (school_Score.student_id = N'" + uid + "') AND (school_Score.score_cat_id <> 0)"
 + " UNION"
 + " SELECT school_Score_1.id, school_Score_1.value, users_1.fname + ' ' + users_1.lname AS teachername,school_Lesson_1.id as school_lesson_id, school_Lesson_1.title, school_Lesson_1.unit, baseOfScore,  school_Score_1.title as ExamTitle,  school_Score_1.ExamDate,"
 + " school_score_cat_1.title AS ScoreTypeTitle"
 + " FROM school_Score AS school_Score_1 INNER JOIN"
 + " school_score_cat AS school_score_cat_1 ON school_Score_1.score_cat_id = school_score_cat_1.id INNER JOIN"
 + " school_course_personal ON school_Score_1.school_course_personal = school_course_personal.id INNER JOIN"
 + " users AS users_1 ON school_course_personal.school_teacher_id = users_1.id INNER JOIN"
 + " school_Lesson AS school_Lesson_1 ON school_course_personal.school_lesson_id = school_Lesson_1.id"
 + " WHERE (school_Score_1.student_id = N'" + uid + "') AND (school_Score_1.score_cat_id <> 0)";
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        GridView1.DataBind();

    
 

for (int i = 0; i < GridView1.Rows.Count; i++)
			{

                GridView1.Rows[i].Cells[0].Text = Persia.Number.ConvertToPersian(GridView1.Rows[i].Cells[0].Text);
                GridView1.Rows[i].Cells[3].Text = Persia.Number.ConvertToPersian(GridView1.Rows[i].Cells[3].Text);
                GridView1.Rows[i].Cells[4].Text = Persia.Number.ConvertToPersian(GridView1.Rows[i].Cells[4].Text);
                GridView1.Rows[i].Cells[5].Text = Persia.Calendar.ConvertToPersian(DateTime.Parse(GridView1.Rows[i].Cells[5].Text)).Simple ;
                     
			}
    }

}