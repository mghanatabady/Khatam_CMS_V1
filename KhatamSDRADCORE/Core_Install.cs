using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace khatam
{
    namespace core
    {
        namespace ConfigurationManager
        {

            public static class installation
            {
                internal static string[] allModules = { "news", "picture", "service" };

             

                public static string update()
                {

                    return khatam.core.install.update();

                   
                }




            }



        }



        public class install
        {

            public static string update()
            {

                string pathContent, pathCore, return_sql = "", return_sql2 = "";
                
                pathContent = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\content\";
                pathCore = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\";

                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "cat.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Core_sectionVal.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Core_section_option.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "setting_base.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Core_serverControlsInstance.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Core_serverControlsInstancePlacing.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Core_serverControlsInstanceVal.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "corePermissionRefRole.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "corePermissionRefUser.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "coreRole.sql") + "</br>";                
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "coreRoleRefUser.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "coreRoleSysRefUser.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "special_pages.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "users.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "Menu.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "comment.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "LogError.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_sale_terms.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_paycycle.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_prop.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_prop_defVal.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_prop_val.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_Bank_accounts.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_invoice.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_invoice_line.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_transaction.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_tag_ref_cat.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_tags.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "sbt.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathContent + "core_sendMode_Instance.sql") + "</br>";


                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_placeholder.sql") + "</br>";
                return_sql2 = return_sql2 + khatam.core.data.sql.runSqlFile(pathCore + "Core_Section.sql") + "</br>";

                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "coreRoleSys.sql") + "</br>";
                

                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "Core_serverControls.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "corePermission.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "Dictionary.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "Dictionary_Lang.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "setting_image_standard.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "Language.sql") + "</br>";               
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\usp_core_getServerControlTitle.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"update\update1.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_country.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_country_state.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_country_state_city.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_country_state_city_area.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_currency.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_sendMode.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_payMode.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + "core_units.sql") + "</br>";
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\DropPrimaryKey.sql");
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\core_tag_add.sql");
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\core_tags_update.sql");
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\invoice_updateStatus.sql");
                return_sql = return_sql + khatam.core.data.sql.runSqlFile(pathCore + @"Programmability\stored_procedures\uspGetUser.sql");

               

               
                

               //update prop all obkect
                khatam.core.UI.ObjectManager.updateAllObjectsProperty();
              return_sql =  khatam.core.UI.SectionManager.updateAllSectionProperty();

                

                return "" + installModule() ;

            
             
            }

            public static string installModule()
            {
                HttpContext context = HttpContext.Current;

                string pathContent, pathSchool, pathCore, pathForm,returnSQl="";

                pathContent = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\content\";
                pathCore = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\";
                pathSchool = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\school\";
                pathForm = HttpContext.Current.Request.PhysicalApplicationPath + @"install\Module\Sql\form\";


                if (khatam.core.License.ValidModule("article") == true) sql_send_base( pathContent  + "article.sql");

                if (khatam.core.License.ValidModule("help") == true) sql_send_base(pathContent + "help.sql");

                if (khatam.core.License.ValidModule("estate") == true)
                {
                    sql_send_base(pathContent + "estate.sql");
                    sql_send_base(pathCore + "estate_type.sql");

                }

                if (khatam.core.License.ValidModule("forms") == true)
                {
                    sql_send_base(pathContent + "fb_column_preferences.sql");
                    sql_send_base(pathContent + "fb_element_options.sql");
                    sql_send_base(pathContent + "fb_form_elements.sql");
                    sql_send_base(pathContent + "fb_forms.sql");

                    sql_send_base(pathForm + @"stored_procedures\uspGetElementOption.sql");
                    sql_send_base(pathForm + @"stored_procedures\uspGetElementOptionTable.sql");
                    sql_send_base(pathForm + @"stored_procedures\uspGetFormElement.sql");
                    sql_send_base(pathForm + @"stored_procedures\uspGetForms.sql");
                    sql_send_base(pathForm + @"stored_procedures\uspGetFormsElements.sql");

                }

                if (khatam.core.License.ValidModule("uniproj") == true)
                {
                    sql_send_base(pathContent + "uniproj_cluster.sql");
                    sql_send_base(pathContent + "uniproj_ClusterRefTeacher.sql");
                    sql_send_base(pathContent + "uniproj_project.sql");
                    sql_send_base(pathContent + "uniproj_ProjectRefStudent.sql");
                    sql_send_base(pathContent + "uniproj_EduGroupRefUsers.sql");                    
                    sql_send_base(pathContent + "uniproj_eduGroup.sql");
                    sql_send_base(pathContent + "uniproj_ClusterRefStudent.sql");                    
                 returnSQl=   sql_send_base(pathCore + "uniproj_sections.sql");
                    sql_send_base(pathCore + "uniproj_termType.sql");
                    sql_send_base(pathCore + "uniproj_year.sql");                                      
                }

                if (khatam.core.License.ValidModule("news") == true) sql_send_base(pathContent + "news.sql");

                if (khatam.core.License.ValidModule("service") == true) sql_send_base(pathContent + "service.sql");

                if (khatam.core.License.ValidModule("library") == true) sql_send_base(pathContent + "library.sql");

                if (khatam.core.License.ValidModule("link") == true) sql_send_base(pathContent + "link.sql");

                if (khatam.core.License.ValidModule("software") == true) sql_send_base(pathContent + "software.sql");

                if (khatam.core.License.ValidModule("picture") == true) sql_send_base(pathContent + "picture.sql");

                if (khatam.core.License.ValidModule("clip") == true) sql_send_base(pathContent + "clip.sql");

                if (khatam.core.License.ValidModule("domain") == true)
                {
                    sql_send_base(pathContent + "domain.sql");
                    khatam.domain.Manager.InstallDomainTree();
                    
                }

                if (khatam.core.License.ValidModule("portal") == true) sql_send_base(pathContent + "portal.sql");

                if (khatam.core.License.ValidModule("shop") == true) sql_send_base(pathContent + "shop.sql");


                if (khatam.core.License.ValidModule("host") == true)
                {
                    sql_send_base(pathContent + "host.sql");
              

                }


                if (khatam.core.License.ValidModule("darman") == true)
                {
                    sql_send_base(pathContent + "darman_card_use.sql");
                    sql_send_base(pathContent + "darman_cards.sql");
                    sql_send_base(pathContent + "darman_cards_type.sql");


                }


                khatam.core.License.ValidModule("support");

          

                if (khatam.core.License.ValidModule("school"))
                {
                    sql_send_base(pathSchool+ "school_Classroom_select.sql");
                    sql_send_base(pathSchool + "school_Classroom_select.sql");
                    sql_send_base(pathSchool + "school_class.sql");
                    sql_send_base(pathSchool + "school_Lesson.sql");
                    sql_send_base(pathSchool + "school_course_personal.sql");
                    sql_send_base(pathSchool + "school_Student_class.sql");
                    sql_send_base(pathSchool + "school_score.sql");
                    sql_send_base(pathSchool + "school_course_personal_student.sql");
                    sql_send_base(pathSchool + "school_Base.sql");
                    sql_send_base(pathSchool + "school_base_cat.sql");
                    sql_send_base(pathSchool + "school_Category.sql");
                    sql_send_base(pathSchool + "school_branch.sql");
                    sql_send_base(pathSchool + "school_form_registration_request.sql");
                    sql_send_base(pathSchool + "school_educational_place.sql");
                    sql_send_base(pathSchool + "school_year.sql");
                    sql_send_base(pathSchool + "school_Classroom_hour.sql");
                    sql_send_base(pathSchool + "school_Lesson_Present_Cat.sql");
                    sql_send_base(pathSchool + "school_Lesson_cat.sql");
                    sql_send_base(pathSchool + "school_Lesson_Present_Date_Cat.sql");
                    sql_send_base(pathSchool + "school_score_cat.sql");
                }
                return returnSQl;
            }

           public static  string sql_send_base(string filepad)
            {
              
                return khatam.core.data.sql.runSqlFile(filepad);

            }

        }


    }





}
