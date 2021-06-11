using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_school_teacher_course_personal_score_list : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {


        bool pAll = false, pTeacher = false;

        pAll = khatam.core.Security.Users.validUserPermission("school_declaration_reportCard_All");
        pTeacher = khatam.core.Security.Users.validUserPermission("school_declaration_reportCard_All");

        if ((pTeacher) || (pAll))
        {
        }
        else
        {
            this.Response.Redirect("~/manage/?mode=msgPermisson");
        }

        if (pAll == false)
        {
            if (khatam.School.teacher.ValidCoursePersonalRelatedTeacher(Request.QueryString["id"]) == false)
                this.Response.Redirect("~/manage/?mode=msgPermisson");

        }



        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        /*    Dictionary<string, object> parameters = new Dictionary<string, object>();

       string sqlCommand;
       sqlCommand = "SELECT     school_Score.id, school_Score.value, school_Score.score_type_type, school_Score.classroom_select, school_Score.school_course_personal,   school_Score.ExamDate, school_Score.baseOfScore, school_score_cat.title, school_Student.Fname, school_Student.Lname, school_Score.student_id  FROM         school_Score INNER JOIN                        school_score_cat ON school_Score.score_cat_id = school_score_cat.id INNER JOIN                       school_Student ON school_Score.student_id = school_Student.id  ";

       string conStr;
       conStr = WebConfigurationManager.ConnectionStrings["Khatam_site"].ConnectionString;

       // this.Label1.Text = DBFunctions.ExecuteScaler(sqlCommand, parameters, System.Data.CommandType.Text,conStr    ).ToString();
       this.GridView1.DataSource = DBFunctions.ExecuteReader(sqlCommand, parameters, System.Data.CommandType.Text, conStr);
       this.GridView1.DataBind(); */

        //this.SqlDataSource1.SelectCommand = "SELECT     school_Score.id, school_Score.value, school_Score.score_type_type, school_Score.classroom_select, school_Score.school_course_personal,   school_Score.ExamDate, school_Score.baseOfScore, school_score_cat.title, school_Student.Fname, school_Student.Lname, school_Score.student_id  FROM         school_Score INNER JOIN                        school_score_cat ON school_Score.score_cat_id = school_score_cat.id INNER JOIN                       school_Student ON school_Score.student_id = school_Student.id  ";

        //        this.SqlDataSource1.SelectCommand = "SELECT     school_Score.id, school_Score.value, school_Score.score_type_type, school_Score.classroom_select, school_Score.school_course_personal,  " +
        //                    " school_Score.ExamDate, school_Score.baseOfScore, school_score_cat.title, school_Score.student_id, users.id AS student_id, users.fname, users.lname " +
        //" FROM         school_Score INNER JOIN " +
        //                    " school_score_cat ON school_Score.score_cat_id = school_score_cat.id INNER JOIN " +
        //                  " users ON school_Score.student_id = users.id ";// +
        //" WHERE     (school_Score.score_type_type = 0) AND (school_Score.school_course_personal = " + this.Request.QueryString["id"].Replace("'","") + ")";


    }






    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        DateTime dateTimeFirst;


         for (int i = 0; i < this.GridView1.Rows.Count ; i++)
         {
        
                  dateTimeFirst = DateTime.Parse( this.GridView1.Rows[i].Cells[5].Text);
        
         this.GridView1.Rows[i].Cells[5].Text = Persia.Calendar.ConvertToPersian(dateTimeFirst).Simple;
             this.GridView1.Rows[i].Cells[6].Text = Persia.Number.ConvertToPersian(this.GridView1.Rows[i].Cells[6].Text);
           this.GridView1.Rows[i].Cells[7].Text = Persia.Number.ConvertToPersian(this.GridView1.Rows[i].Cells[7].Text);
             this.GridView1.Rows[i].Cells[1].Text = Persia.Number.ConvertToPersian(this.GridView1.Rows[i].Cells[1].Text);
           this.GridView1.Rows[i].Cells[0].Text = Persia.Number.ConvertToPersian(this.GridView1.Rows[i].Cells[0].Text);
     


        
         
         }

    }





    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=" + this.Request.QueryString["p"]);
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}