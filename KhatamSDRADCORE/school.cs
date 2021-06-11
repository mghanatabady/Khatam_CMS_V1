using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace khatam
{
    namespace School
    {


        public static class teacher
        {
            public static bool ValidCoursePersonalRelatedTeacher(string school_course_personalID)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                string uid = khatam.core.Security.Users.getIdByEmail(HttpContext.Current.Request.Cookies["UID"].Value.Replace("'", ""));

                //parameters.Add("userId", uid);
                //parameters.Add("classroomSelectId", classroomSelectId);
                parameters.Add("userID", uid);
                parameters.Add("personalCourse", school_course_personalID);


                str_sql = "SELECT     id   FROM         school_course_personal   WHERE     (id = @personalCourse) AND (school_teacher_id = @userID)";
                bool finded = false;




                if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                {
                    finded = true;
                }


                return finded;


            }


            public static bool ValidClassroomSelectRelatedTeacher(string classroomSelectId)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                string uid =khatam.core.Security.Users.getIdByEmail (HttpContext.Current.Request.Cookies["UID"].Value.Replace("'", ""));

                //parameters.Add("userId", uid);
                //parameters.Add("classroomSelectId", classroomSelectId);
                parameters.Add("userId", uid);
                parameters.Add("classroomSelectId", classroomSelectId );


                str_sql = "SELECT     id  FROM         school_Classroom_select   WHERE     (school_teacher_id = @userId) AND (id = @classroomSelectId)";
                bool finded = false;

               

          
                if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                {
                    finded = true;
                }

       
                return finded;


             
            }

          
          

        }
    }
}

