using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace khatam
{
   
  public   class fb_forms
    {

      public struct fb_form
        {
            public string returnCode;
            public string returnMessage;

            public string form_id;
            public string form_name;
            public string form_description;
            public string form_email;
            public string form_redirect;
            public string form_success_message;
            public string form_password;
            public string form_unique_ip;
            public string form_frame_height;
            public string form_has_css;
            public string form_captcha;
            public string form_active;
            public string form_review;
            public string esl_from_name;
            public string esl_from_email_address;
            public string esl_subject;
            public string esl_content;
            public string esl_plain_text;
            public string esr_from_name;
            public string esr_from_email_address;
            public string esr_subject ;
            public string esr_content;
            public string esr_plain_text;
        }

      public struct fb_form_elements
      {
          public string returnCode;
          public string returnMessage;

          public string element_id;
          public string form_id;
          public string element_title;
          public string element_guidelines;
          public string element_size;
          public string element_is_required;
          public string element_is_unique;
          public string element_is_private;
          public string element_type;
          public string element_position;
          public string element_default_value;
          public string element_constraint;
          public string element_total_child;
     
      }


      public struct fb_elements_option
      {
          public string returnCode;
          public string returnMessage;

          public string aeo_id;
          public string form_id;
          public string element_id;
          public string option_id;
          public string position;
          public string option_title;
          public string option_is_default;
          public string live;


      }

      public static DataTable getElementTable(string form_id)
      {
                 Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


          parameters.Add("form_id", form_id);
          //str_sql = "SELECT [element_id]       ,[form_id]       ,[element_title]       ,[element_guidelines]       ,[element_size]       ,[element_is_required]       ,[element_is_unique]       ,[element_is_private]       ,[element_type]       ,[element_position]       ,[element_default_value]       ,[element_constraint]       ,[element_total_child]   FROM [fb_form_elements] ";
          return DBFunctions.ExecuteReader("uspGetFormsElements", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
      }

      public static fb_form getForm(string form_id)
        {
            fb_form ci = new fb_form();
            Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            parameters.Add("form_id", form_id);

            
            DataTable dt = new DataTable();

            try
            {
                dt = DBFunctions.ExecuteReader("uspGetForms", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
            catch (Exception e)
            {
                ci.returnCode = "-1";
                ci.returnMessage = e.Message;
                return ci;
            }


            ci.form_id  = dt.Rows[0].ItemArray[0].ToString();
            ci.form_name  = dt.Rows[0].ItemArray[1].ToString();
            ci.form_description  = dt.Rows[0].ItemArray[2].ToString();
            ci.form_email  = dt.Rows[0].ItemArray[3].ToString();
            ci.form_redirect  = dt.Rows[0].ItemArray[4].ToString();
            ci.form_success_message  = dt.Rows[0].ItemArray[5].ToString();
            ci.form_password  = dt.Rows[0].ItemArray[6].ToString();
            ci.form_unique_ip  = dt.Rows[0].ItemArray[7].ToString();
            ci.form_frame_height  = dt.Rows[0].ItemArray[8].ToString();
            ci.form_has_css  = dt.Rows[0].ItemArray[9].ToString();
            ci.form_captcha  = dt.Rows[0].ItemArray[10].ToString();
            ci.form_active  = dt.Rows[0].ItemArray[11].ToString();
            ci.form_review  = dt.Rows[0].ItemArray[12].ToString();
            ci.esl_from_name  = dt.Rows[0].ItemArray[13].ToString();
            ci.esl_from_email_address  = dt.Rows[0].ItemArray[14].ToString();
            ci.esl_subject  = dt.Rows[0].ItemArray[15].ToString();
            ci.esl_content  = dt.Rows[0].ItemArray[16].ToString();
            ci.esl_plain_text  = dt.Rows[0].ItemArray[17].ToString();
            ci.esr_from_name  = dt.Rows[0].ItemArray[18].ToString();
            ci.esr_from_email_address  = dt.Rows[0].ItemArray[19].ToString();
            ci.esr_subject  = dt.Rows[0].ItemArray[20].ToString();
            ci.esr_content  = dt.Rows[0].ItemArray[21].ToString();
            ci.esr_plain_text  = dt.Rows[0].ItemArray[22].ToString();
 
   
            return ci;

            //Error Table
            // 1 right
            // -1 Database Error
            // -2 Item Not found
            // -3 Disable
            // -4 Deleted
            // -5 Not Valid
        }

      public static fb_form_elements getFormElement(string formElement_id)
      {
          fb_form_elements ci = new fb_form_elements();
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


          parameters.Add("element_id", formElement_id);


          DataTable dt = new DataTable();

          try
          {
              dt = DBFunctions.ExecuteReader("uspGetFormElement", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          }
          catch (Exception e)
          {
              ci.returnCode = "-1";
              ci.returnMessage = e.Message;
              return ci;
          }

    /*      [element_id]
      ,[form_id]
      ,[element_title]
      ,[element_guidelines]
      ,[element_size]
      ,[element_is_required]
      ,[element_is_unique]
      ,[element_is_private]
      ,[element_type]
      ,[element_position]
      ,[element_default_value]
      ,[element_constraint]
      ,[element_total_child]*/


          ci.element_id = dt.Rows[0].ItemArray[0].ToString();
          ci.form_id = dt.Rows[0].ItemArray[1].ToString();
          ci.element_title = dt.Rows[0].ItemArray[2].ToString();
          ci.element_guidelines = dt.Rows[0].ItemArray[3].ToString();
          ci.element_size = dt.Rows[0].ItemArray[4].ToString();
          ci.element_is_required = dt.Rows[0].ItemArray[5].ToString();
          ci.element_is_unique = dt.Rows[0].ItemArray[6].ToString();
          ci.element_is_private = dt.Rows[0].ItemArray[7].ToString();
          ci.element_type = dt.Rows[0].ItemArray[8].ToString();
          ci.element_position = dt.Rows[0].ItemArray[9].ToString();
          ci.element_default_value = dt.Rows[0].ItemArray[10].ToString();
          ci.element_constraint = dt.Rows[0].ItemArray[11].ToString();
          ci.element_total_child = dt.Rows[0].ItemArray[12].ToString();
  
          return ci;

          //Error Table
          // 1 right
          // -1 Database Error
          // -2 Item Not found
          // -3 Disable
          // -4 Deleted
          // -5 Not Valid
      }

      public static fb_elements_option getElementOption(string aeo_id)
      {
          fb_elements_option ci = new fb_elements_option();
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


          parameters.Add("aeo_id", aeo_id);


          DataTable dt = new DataTable();

          try
          {
              dt = DBFunctions.ExecuteReader("uspGetElementOption", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          }
          catch (Exception e)
          {
              ci.returnCode = "-1";
              ci.returnMessage = e.Message;
              return ci;
          }

   


          ci.aeo_id = dt.Rows[0].ItemArray[0].ToString();
          ci.form_id = dt.Rows[0].ItemArray[1].ToString();
          ci.element_id = dt.Rows[0].ItemArray[2].ToString();
          ci.option_id = dt.Rows[0].ItemArray[3].ToString();
          ci.position = dt.Rows[0].ItemArray[4].ToString();
          ci.option_title = dt.Rows[0].ItemArray[5].ToString();
          ci.option_is_default = dt.Rows[0].ItemArray[6].ToString();
          ci.live = dt.Rows[0].ItemArray[7].ToString();





          return ci;

          //Error Table
          // 1 right
          // -1 Database Error
          // -2 Item Not found
          // -3 Disable
          // -4 Deleted
          // -5 Not Valid
      }

      public static DataTable getElementOption_Table(string Element_id)
      {
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


          parameters.Add("element_id", Element_id);


          DataTable dt = new DataTable();

          try
          {
              dt = DBFunctions.ExecuteReader("uspGetElementOptionTable", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          }
          catch/* (Exception e)*/
          {
          
          
          }

          
          return dt;

          //Error Table
          // 1 right
          // -1 Database Error
          // -2 Item Not found
          // -3 Disable
          // -4 Deleted
          // -5 Not Valid
      }  

    }
   
}
