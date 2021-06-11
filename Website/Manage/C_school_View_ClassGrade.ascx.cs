using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_school_View_ClassGrade : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Session["school_classroom_select_id"] = this.GridView1.SelectedRow.Cells[0].Text;
        this.Response.Redirect("~/manage/?mode=school_teacher_course_edit");
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        this.GridView1.SelectedIndex = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName == "add" )
        {

              this.Session["school_classroom_select_id"] = this.GridView1.SelectedRow.Cells[0].Text;

              this.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_edit");
        }
          
  

        if (e.CommandName == "select" )
        {

            this.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_score_list&id=" + this.GridView1.SelectedRow.Cells[0].Text);
        }
        
        
    


    }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName == "add" )
        {

              this.Session["school_classroom_select_id"] = this.GridView2.SelectedRow.Cells[0].Text;

              this.Response.Redirect("~/manage/?mode=school_teacher_course_personal_classroom_edit");
        }
          
  

        if (e.CommandName == "select" )
        {

           this.Response.Redirect("~/manage/?mode=school_teacher_course_classroom_score_list&id=" + this.GridView1.SelectedRow.Cells[0].Text);
          
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