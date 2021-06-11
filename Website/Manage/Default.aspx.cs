
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO.Compression;

public partial class Manage_Default : System.Web.UI.Page
{



    protected void Page_PreInit(object sender, EventArgs e)
    {

        this.Title = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) + " || کنترل پنل ";
       // this.Label2.Text = khatam.core.ConfigurationManager.License.demoNo;

        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);

        Shinkansen.Web.UI.WebControls.CssInclude css2 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css2.Path = "~/core/css/flick/jquery-ui-1.8.20.custom.css";
        StaticResourceManager1.Css.Add(css2);

        

    }

    protected void Page_Load(object sender, EventArgs e)
    {


        if (khatam.core.ConfigurationManager.License.demo)
        {
            ltr_demo.Text = khatam.core.UI.SectionManager.demoBarHtml();
            ltl_status_script.Text = khatam.core.UI.SectionManager.demoFooterScript();
          
        }

        this.hl_brand1.Text = khatam.core.ConfigurationManager.Cp.brandTitle("fa-IR");
        this.Hl_brand_support.NavigateUrl = khatam.core.ConfigurationManager.Cp.supportUrl();
        this.hl_brand1.NavigateUrl = khatam.core.ConfigurationManager.Cp.brandUrl();


       


        Login_proccess();
        
        
        //redirect path if needed
        if (this.Request.QueryString["mode"] == "redirect")
        {
            path_redirect(this.Request.QueryString["autolink"]);
        }
        

        Control TempControl = new Control();

        string mode = "";
        string cat_type;

        mode = this.Request.QueryString["mode"];


        switch (mode)
        {
            case (null):
                TempControl = LoadControl("main_desktop.ascx");
                break;
            case ("main"):
                TempControl = LoadControl("main_desktop.ascx");
                break;

            case "school_student":
                this.Response.Redirect("~/manage/?mode=ManagerUsers&p=student");
                break;
            case "school_teacher":
                this.Response.Redirect("~/manage/?mode=ManagerUsers&p=teacher");
                break;
            case "school_Parent":
                this.Response.Redirect("~/manage/?mode=ManagerUsers&p=parent");
                break;
            case "school_declaration_reportCard_teacher":
                this.Response.Redirect("~/manage/?mode=school_declaration_reportCard&p=teacher");
                break;
            case "school_declaration_reportCard_All":
                this.Response.Redirect("~/manage/?mode=school_declaration_reportCard&p=all");
                break;                
            case "school_declaration_ClassGrade_teacher":
                this.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=teacher");
                break;
            case "school_declaration_ClassGrade_All":
                this.Response.Redirect("~/manage/?mode=school_declaration_ClassGrade&p=all");
                break;
            case "ArticleExplorer":
                TempControl = LoadControl("C_Folder.ascx");

                //If Me.Request.QueryString("cat_type") <> Nothing Then
                //   cat_type = Me.Request.QueryString("cat_type")
                //Else
                //    cat_type = khatam.core.data.sql.getField("type_content", "id", Me.Request.QueryString("cat"), "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
                //End If
                //webcontrol_validator = KUI.security.users.webcontrol_validator(Me.Session("user_id"), Session("id_user_cat"), cat_type, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
                break;
            case "email":

                this.Response.Redirect(Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("WebmailURL", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
                break;
            case "webstats":
                this.Response.Redirect(Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("webstat", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));


                break;
            case "logout":

                HttpCookie objuid, objpid, objtopbar;
                objuid = Request.Cookies["UID"];
                objpid = Request.Cookies["PID"];
                objtopbar = Request.Cookies["topbar"];



                if (objuid == null)
                {
                    //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                }
                else
                {
                    objuid.Expires = DateTime.UtcNow.AddDays(-60);
                    this.Response.Cookies.Add(objuid);
                    //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                }


                if (objpid == null)
                {
                    //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                }
                else
                {
                    objpid.Expires = DateTime.UtcNow.AddDays(-60);
                    this.Response.Cookies.Add(objpid);
                    //  this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                }

                if (objtopbar == null)
                {
                    // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                }
                else
                {
                    objtopbar.Expires = DateTime.UtcNow.AddDays(-60);
                    this.Response.Cookies.Add(objtopbar);
                    // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                }



                HttpCookie aCookie = new HttpCookie("lastVisit");

                aCookie.Value = DateTime.UtcNow.ToString();
                aCookie.Expires = DateTime.UtcNow.AddDays(-60);
                Response.Cookies.Add(aCookie);
                this.Session["State"] = false;
                this.Session.Abandon();
                this.Response.Redirect("~/manage/login.aspx");

                break;
            case "folder":
                

                    if (this.Request.QueryString["cat_type"]!= null)
                    {

                        if (khatam.core.Security.Users.validUserPermission(this.Request.QueryString["cat_type"]))
                        {
                            TempControl = LoadControl("C_" + this.Request.QueryString["mode"] + ".ascx");
                        }
                        else
                        {
                            TempControl = LoadControl("C_MSG_Access_denied.ascx");
                        }
                    }
                
                    if (this.Request.QueryString["cat"] != null)
                    {
                        string type_content = khatam.core.data.sql.getField("type_content", "id", this.Request.QueryString["cat"], "cat");
                        if (khatam.core.Security.Users.validUserPermission(type_content))
                        {
                            TempControl = LoadControl("C_" + this.Request.QueryString["mode"] + ".ascx");
                        }
                        else
                        {
                            TempControl = LoadControl("C_MSG_Access_denied.ascx");
                        }
                    }
               
               

                break;

            case "page_edit":

                

                if (this.Request.QueryString["id"] !=null) 
                    // khatam.core.Security.Users.validUserPermission(this.Request.QueryString["type"]))
                {
                    string type_content = khatam.core.data.sql.getField("type_content", "id", this.Request.QueryString["id"], "cat");
                    if (khatam.core.Security.Users.validUserPermission(type_content))
                    {
                        TempControl = LoadControl("C_" + this.Request.QueryString["mode"] + ".ascx");
                    }
                    else
                    {
                        TempControl = LoadControl("C_MSG_Access_denied.ascx");
                    }

                }
                else
                {
                    TempControl = LoadControl("C_MSG_Access_denied.ascx");
                }
            
                break;

            default:

                //if (khatam.core.Security.Users.validUserPermission(this.Request.QueryString["mode"]))
               // {
                TempControl = LoadControl("C_" + this.Request.QueryString["mode"] + ".ascx");
               /* }
                else 
                {
               TempControl = LoadControl("C_MSG_Access_denied.ascx");
               }*/
               break;



        }


        PlaceHolder1.Controls.Add(TempControl);

       string userEmail = khatam.core.Security.Users.getEmail(Session["uid"].ToString());
       string userRealName = khatam.core.Security.Users.getRealName(Session["uid"].ToString());

       ph_userInfo.Controls.Add(new LiteralControl("کاربر گرامی: " +   userRealName ));
        ph_userInfo.Controls.Add(new LiteralControl("<br />"));
        ph_userInfo.Controls.Add(new LiteralControl( userEmail  ));


    }

    public void Login_proccess()
    {
        int loginResult = khatam.core.Security.Users.login();

        if (loginResult > 0)
        {
            Session["uid"] = loginResult; 
         
            DataTable dt = new DataTable();
            dt = Khatam_Functions.KUI.Database.sql.Sql_Get_Col("idPermission", "idUser", loginResult.ToString(), "corePermissionRefUser", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        for (int i = 0; i < dt.Rows.Count; i++)
            {
                switch (dt.Rows[i].ItemArray[0].ToString())
                {
                    case "1":
                        this.AccessVisualContentManager_div.Visible = true;
                        break;
                    case "2":
                        AccessLayoutManager_div.Visible = true;
                        break;
                    default:
                        break;
                }


            }


        }
        else 
        {
            this.Response.Redirect("~/manage/login.aspx");
        }

    }




    void path_redirect(string autolink)
    {
        String str_default_file_name;


        str_default_file_name = "~/manage/";
        int i;
        i = 1;
        switch (autolink)
        {




            //, "service", "article", "news", "book", "speciallink", "software", "library", "link", "shop", "special_pages", "special_items", "menu", "picture", "mobile", "template", "help", "car", "clip", "domain", "portal", "script", "picture", "research_project", "host", "research_project", "sample_exam":

            case ("article"):
            case ("news"):
            case ("special_pages"):
            case ("picture"):
            case ("service"):
            case ("shop"):
            case ("software"):
            case ("help"):
            case ("portal"):
            case ("car"):
            case ("host"):
            case ("library"):
            case ("clip"):
            case ("Link"):
            case ("domain"):
            case ("estate"):



            case ("menu"):

                Session["cat_type"] = autolink;
                this.Response.Redirect(str_default_file_name + "?mode=folder&cat_type=" + autolink);

                break;






            default:

                this.Response.Redirect(str_default_file_name + "?mode=" + autolink);
                break;
        }





        //       Session("cat_type") = autolink
        //       Me.Response.Redirect(str_default_file_name & "?mode=folder&cat_type=" & autolink)
        //   Case "newsletter"
        //     Me.Response.Redirect(str_default_file_name & "?mode=newsletter")
        //         Case "shop_order"
        //           Me.Response.Redirect(str_default_file_name & "?mode=shop_order_list")
        //     Case "file_manager"
        //       Me.Response.Redirect("http://www.net2ftp.com/")
        // Case "page_list"
        //                Me.Response.Redirect("~/manage/?mode=page_list")
        //          Case "change_password"
        //            Me.Response.Redirect(str_default_file_name & "?mode=password_edit")
        //          'pilot school
        //    Case "email"
        //      Me.Response.Redirect(Get_Setting_base("WebmailURL", 0, 0))
        //Case "webstats"
        //                Me.Response.Redirect(Get_Setting_base("webstat", 0, 0))
        //
        //     Case "reseller"
        //       Me.Response.Redirect("http://cp.khatam.com/reseller")

        // Case "page_edit_teacher"
        //   Me.Response.Redirect("~/manage/?mode=page_edit")

        //Case "Customer_user_help_list"
        //  Me.Response.Redirect("~/help.aspx")
        //      Case Else
        //        Me.Response.Redirect(str_default_file_name & "?mode=" & autolink)
        //     End Select


    }




}