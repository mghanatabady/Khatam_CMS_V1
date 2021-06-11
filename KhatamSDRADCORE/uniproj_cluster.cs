using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace khatam
{
    namespace uniproj
    {
       public  class cluster
        {

           public int cluster_id;


            public int uniSection;

            public string uniSection_title; 

            public int year_id;

            public string year_title; 

            public int termType;

            public string  termType_Title;

            public int EduGroupId;

            public string  EduGroup_Title;
           
            public int uniGroupUserId;

            public string uniGroupUserFname;

            public  string uniGroupUserLname;

            public int uniGroupTeacherCode;
 

            public int  capacity;



         


            public void AddCluster()
            {
            }
            public void UpdateCluster()
            {

            }
       

            public void DeleteCluster()
            {
                throw new System.NotImplementedException();
            }

            public void GetClusters()
            {
                throw new System.NotImplementedException();
            }

            public void GetChildProjects()
            {
                throw new System.NotImplementedException();
            }

            public void GetUsedCapacity()
            {
                throw new System.NotImplementedException();
            }


            public void GetCluster()
            {
               
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                parameters.Add("id", cluster_id );                

                DataTable dt = new DataTable();

               // string sql_str;

               // sql_str= " SELECT      id,uniSection, year_id, termType, EduGroupId, uniGroupUserId, uniGroupUserFname, uniGroupUserLname, uniGroupTeacherCode, capacity " +
               // " FROM         uniproj_cluster WHERE     (id = @id) ";

                string sql_str="SELECT uniproj_cluster.id, uniproj_cluster.uniSection, uniproj_cluster.year_id, uniproj_cluster.termType, uniproj_cluster.EduGroupId, uniproj_cluster.uniGroupUserId, "
+" uniproj_cluster.uniGroupUserFname, uniproj_cluster.uniGroupUserLname, uniproj_cluster.uniGroupTeacherCode, uniproj_cluster.capacity, "
+" uniproj_sections.title AS uniSection_title, uniproj_year.title AS year_title, uniproj_termType.title AS termType_Title, uniproj_eduGroup.title AS EduGroup_Title"
+" FROM uniproj_cluster INNER JOIN"
+" uniproj_sections ON uniproj_cluster.uniSection = uniproj_sections.id INNER JOIN"
+" uniproj_year ON uniproj_cluster.year_id = uniproj_year.id INNER JOIN"
+" uniproj_termType ON uniproj_cluster.termType = uniproj_termType.id INNER JOIN"
+" uniproj_eduGroup ON uniproj_cluster.EduGroupId = uniproj_eduGroup.id   WHERE     (uniproj_cluster.id = @id)";

                
                dt = DBFunctions.ExecuteReader(sql_str , parameters, System.Data.CommandType.Text , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


                cluster_id=int.Parse( dt.Rows[0].ItemArray[0].ToString());
                uniSection=int.Parse(  dt.Rows[0].ItemArray[1].ToString());
                year_id=int.Parse(  dt.Rows[0].ItemArray[2].ToString());
                termType=int.Parse(  dt.Rows[0].ItemArray[3].ToString());
                EduGroupId=int.Parse(  dt.Rows[0].ItemArray[4].ToString());
                uniGroupUserId=int.Parse(  dt.Rows[0].ItemArray[5].ToString());
                uniGroupUserFname=  dt.Rows[0].ItemArray[6].ToString();
                uniGroupUserLname=  dt.Rows[0].ItemArray[7].ToString();
                uniGroupTeacherCode=int.Parse(  dt.Rows[0].ItemArray[8].ToString());
                capacity=int.Parse(  dt.Rows[0].ItemArray[9].ToString());
                uniSection_title = dt.Rows[0].ItemArray[10].ToString();
                year_title = dt.Rows[0].ItemArray[11].ToString();
                termType_Title = dt.Rows[0].ItemArray[12].ToString();
                EduGroup_Title = dt.Rows[0].ItemArray[13].ToString();
 
         

              

            }

            public void UpdateUniTeacherProjLimit()
            {
                throw new System.NotImplementedException();
            }

            public bool  CheckIdentity()
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("uniSection", uniSection);
                parameters.Add("year_id", year_id);
                parameters.Add("termType", termType);
                parameters.Add("EduGroupId", EduGroupId);

                str_sql = "SELECT  *   FROM    uniproj_cluster    WHERE     (uniSection = @uniSection) AND (year_id = @year_id) AND (termType = @termType) AND (EduGroupId = @EduGroupId)";

                if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) == null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static string CountTeacherUsedProject(string uniTeacherUserId, string clusterId)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                parameters.Add("uniTeacherUserId", uniTeacherUserId);
                parameters.Add("clusterId", clusterId);



                str_sql = ("SELECT     COUNT(id) AS Expr1   FROM         uniproj_project   WHERE     (uniTeacherUserId = @uniTeacherUserId) AND (clusterId = @clusterId)");
                return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            }

            public static int GetUsedCapacityWithoutTeacher(string uniTeacherUserId, string clusterId)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                parameters.Add("uniTeacherId", uniTeacherUserId);
                parameters.Add("clusterId", clusterId);



                str_sql = ("SELECT  COALESCE(SUM(capacity),0)   AS Expr1   FROM         uniproj_ClusterRefTeacher    WHERE     (cluster_id = @clusterId) AND (uniTeacherId <> @uniTeacherId)");
                return  int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString());
            }
        }


       public  class project
       {
       

           
           

           public  string GetVerficationState(int stateId)
            {
                string str_state="-1";
                switch (stateId)
	                {
                   case  1:
                       str_state = "در انتظار تایید";
                    break ;
                   case  2:
                        str_state = "تایید شده";    
                    break ;
                   case  3:
                        str_state = "عدم تایید";    
                    break ;
                    
	                }
                return str_state;
            }

   
           

            public  int CountTeacherUsedProject(string uniTeacherUserId, string clusterId)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                parameters.Add("uniTeacherUserId", uniTeacherUserId );
                parameters.Add("clusterId", clusterId  );



                str_sql = ("SELECT     COUNT(id) AS Expr1   FROM         uniproj_project   WHERE     (uniTeacherUserId = @uniTeacherUserId) AND (clusterId = @clusterId)");
                return int.Parse( DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString());
            }
       }
        
    }
}
