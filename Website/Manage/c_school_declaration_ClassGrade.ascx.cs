using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_c_school_declaration_ClassGrade : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string qStr = Request.QueryString["p"];

        if ((qStr == null) || (qStr == "")) this.Response.Redirect("~/manage/?mode=msgPermisson");

        bool pAll = false, pTeacher = false;
        pAll = khatam.core.Security.Users.validUserPermission("school_declaration_reportCard_All");
        pTeacher = khatam.core.Security.Users.validUserPermission("school_declaration_ClassGrade_teacher");

        if ((qStr == "teacher") && (pTeacher))
        {

        }
        else if ((qStr == "all") && (pAll))
        {

        }
        else
        {
            this.Response.Redirect("~/manage/?mode=msgPermisson");
        }

        string uid = khatam.core.Security.Users.getIdByEmail(Request.Cookies["UID"].Value).Replace("'", "");


        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        string activeYear;
        activeYear = khatam.core.data.sql.getField( "memo", "cname", "school_active_year", "Setting_Base");

        if (qStr == "all")
        {

            SqlDataSource1.SelectCommand = "SELECT     school_Class.title AS class_title, school_Lesson.title AS Lesson_title, school_Lesson.unit, school_Classroom_select.id, school_Class.id_school_year " +
            " FROM         school_Class INNER JOIN " +
            " school_Classroom_select ON school_Class.id = school_Classroom_select.school_class_id INNER JOIN " +
            " school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id " +
            " WHERE (school_class.id_school_year = " + activeYear + ") ";
            ;

            SqlDataSource2.SelectCommand = "SELECT     school_Lesson.title, school_course_personal.id AS id_school_course_personal, school_Lesson.id, school_course_personal.school_teacher_id, " +
                      " school_course_personal.school_year_id, school_Lesson.unit " +
" FROM         school_course_personal INNER JOIN " +
                      " school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id " +
" WHERE     (school_course_personal.school_year_id = " + activeYear + ")";

        
        }
        else if (qStr == "teacher")
        {

            SqlDataSource1.SelectCommand = "SELECT     school_Class.title AS class_title, school_Lesson.title AS Lesson_title, school_Lesson.unit, school_Classroom_select.id, school_Class.id_school_year " +
            " FROM         school_Class INNER JOIN " +
            " school_Classroom_select ON school_Class.id = school_Classroom_select.school_class_id INNER JOIN " +
            " school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id " +
            " WHERE   (school_Classroom_select.school_teacher_id = N'" + uid + "') AND (school_class.id_school_year = " + activeYear + ") ";
            ;

            SqlDataSource2.SelectCommand = "SELECT     school_Lesson.title, school_course_personal.id AS id_school_course_personal, school_Lesson.id, school_course_personal.school_teacher_id, " +
                      " school_course_personal.school_year_id, school_Lesson.unit " +
" FROM         school_course_personal INNER JOIN " +
                      " school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id " +
" WHERE     (school_course_personal.school_teacher_id = N'" + uid  + "') AND (school_course_personal.school_year_id = " + activeYear  + ")";
       
        }


        

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //this.Session["school_classroom_select_id"] = this.GridView1.SelectedRow.Cells[0].Text;
        this.Response.Redirect("~/manage/?mode=school_teacher_course_edit&id=" + this.GridView1.SelectedRow.Cells[0].Text);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        this.GridView1.SelectedIndex = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName == "add")
        {

            //this.Session["school_classroom_select_id"] = this.GridView1.SelectedRow.Cells[0].Text;

            this.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_edit&id=" + this.GridView1.SelectedRow.Cells[0].Text + "&p=" + this.Request.QueryString["p"]);
        }



        if (e.CommandName == "select")
        {

            this.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_score_list&id=" + this.GridView1.SelectedRow.Cells[0].Text + "&p=" + this.Request.QueryString["p"]);
        }





    }

    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName == "add")
        {

            //this.Session["school_classroom_select_id"] = this.GridView2.SelectedRow.Cells[0].Text;

            this.Response.Redirect("~/manage/?mode=school_teacher_course_personal_classroom_edit&id=" + this.GridView2.SelectedRow.Cells[0].Text +"&p=" + this.Request.QueryString["p"] );
        }



        if (e.CommandName == "select")
        {

            this.Response.Redirect("~/manage/?mode=school_teacher_course_personal_score_list&id=" + this.GridView2.SelectedRow.Cells[0].Text + "&p=" + this.Request.QueryString["p"]);
        }





    }




    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {





    }
    protected void GridView2_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView2_SelectedIndexChanged2(object sender, EventArgs e)
    {

    }
}