using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_c_update : System.Web.UI.UserControl
{
    public string strMsgSqlReturn;


    protected void Button1_Click(object sender, EventArgs e)
    {
        solve_db_cat_order_id();
     Label1.Text=    khatam.core.ConfigurationManager.installation.update ();

     if (khatam.core.License.ValidModule("host") == true)
     {
       


     }

  //Label1.Text = Label1.Text + " " +  khatam.core.install.installModule();


     DataTable dt = new DataTable();

     dt = khatam.core.data.sql.getTable("Core_serverControlsInstance");

     int length = dt.Rows.Count;

     for (int i = 0; i < length; i++)
     {
         Update_dic(dt.Rows[i].ItemArray[1].ToString(), dt.Rows[i].ItemArray[0].ToString());
     }

    }


    string sql_send_base(string filepad, bool return_have_error)
    {
          return Khatam_Functions.KUI.Database.sql.SQL_Run_TSql_File(filepad, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString(), 600, true).ToString();
        
    }


    void update1()
    {
        int i;
        DataTable dt = new DataTable();
        dt = Khatam_Functions.KUI.Database.sql.Sql_load_table("setting_section", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        string id_old;
        string class_old;
        id_old = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("doc_id", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        class_old = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("doc_class", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        for (i = 0; (i
                    <= (dt.Rows.Count - 1)); i++)
        {
            if ((dt.Rows[i].ItemArray[2].ToString() == ""))
            {
                Khatam_Functions.KUI.Database.sql.Sql_update_field("yuig", "yui-g", "id", dt.Rows[i].ItemArray[0].ToString(), "setting_section", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
            if ((dt.Rows[i].ItemArray[3].ToString() == ""))
            {
                Khatam_Functions.KUI.Database.sql.Sql_update_field("yui_id", id_old, "id", dt.Rows[i].ItemArray[0].ToString(), "setting_section", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
            if ((dt.Rows[i].ItemArray[4].ToString() == ""))
            {
                Khatam_Functions.KUI.Database.sql.Sql_update_field("yui_class", class_old, "id", dt.Rows[i].ItemArray[0].ToString(), "setting_section", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
        }
    }


    string  solve_db_cat_order_id()
    {
        string str_sql;
        
        
        Dictionary<string, object> parameters = new Dictionary<string, object>();


        
       str_sql = str_sql = "UPDATE    Cat  SET              orderid = CAST(REPLACE(REPLACE(sortid, '#.1.', ''), 'A', '') AS int)  WHERE     (height = 2) AND (orderid <> CAST(REPLACE(REPLACE(sortid, '#.1.', ''), 'A', '') AS int)) ";
        DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        return "0";
    }

    string  noPhoto()
    {
       string str_sql;
        
        Dictionary<string,object> parameters = new Dictionary<string,object>();
        
        str_sql = "UPDATE    news    set     Image = N'no_photo.jpg' WHERE     (image IS NULL)";
        DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        
        return "0";
    }





   void   Update_dic(string  ServerControlId , string  InstanceId){

       switch (ServerControlId)
       {
           case "3":
               khatam.core.UI.WebControls.Menu scm = new khatam.core.UI.WebControls.Menu();
               scm.addInstanceProperty(InstanceId);               
               break;
           case "8":
               khatam.core.UI.WebControls.contentWin cw = new khatam.core.UI.WebControls.contentWin();
               cw.addInstanceProperty(InstanceId);
               break;

           case "12":
               khatam.core.UI.WebControls.contentList col = new khatam.core.UI.WebControls.contentList();
               col.addInstanceProperty(InstanceId );
               break;

           case "13":
               khatam.core.UI.WebControls.contentPaging cp = new khatam.core.UI.WebControls.contentPaging();
               cp.addInstanceProperty(InstanceId);
               break;

           case "14":
               khatam.core.UI.WebControls.contentItemWin ciw = new khatam.core.UI.WebControls.contentItemWin();
               ciw.addInstanceProperty(InstanceId);
               break;

           case "15":
               khatam.core.UI.WebControls.loginWin  lw = new khatam.core.UI.WebControls.loginWin();
               lw.addInstanceProperty(InstanceId);
               break;

     
           case "18":
               khatam.core.UI.WebControls.shopCart  sc = new khatam.core.UI.WebControls.shopCart();
               sc.addInstanceProperty(InstanceId);
               break;

           case "19":
               khatam.core.UI.WebControls.seacrhWin sew = new khatam.core.UI.WebControls.seacrhWin();
               sew.addInstanceProperty(InstanceId);
               break;
           case "20":
               khatam.core.UI.WebControls.membrshipWin mew = new khatam.core.UI.WebControls.membrshipWin();
               mew.addInstanceProperty(InstanceId);
               break;
           default:
               break;

       }


    }
 
   protected void Page_Load(object sender, EventArgs e)
   {
       //main page
       Label c = (Label)this.Parent.FindControl("lblMainTitle");
       c.Text = "بروز رسانی";

       Image d = (Image)this.Parent.FindControl("imgMainTitle");
       d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/update.gif";

       Literal l = (Literal)this.Parent.FindControl("Literal1");
       l.Text = " > <span style=\" color: #808080\">";
       l.Text = l.Text + " بروز رسانی";
       l.Text = l.Text + "</span> ";

       if (khatam.core.ConfigurationManager.License.demo == true)
       {
           Button1.Enabled = false;
           Button1.ToolTip = "در نسخه دمو این امکان وجود ندارد";
 
       }
       
       //Label2.Text=
                  

       // "This Licences Saled for:" +
       // "<br /> domain: " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
       // "<br /> IP: " + khatam.core.ConfigurationManager.License.hostip +
           //"<br /> DatabaseServer: " + khatam.core.ConfigurationManager.License. +
           //"<br /> Catalog:" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
           //"<br /> Dbuser: <br />" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
       // "<br /> From Date:" + khatam.core.ConfigurationManager.License.BeginTime +
       // "<br /> ExpireDate:" + khatam.core.ConfigurationManager.License.ExpireTime +
       // "<br /> UserLimit:" + khatam.core.ConfigurationManager.License.userLimit +
      //  "<br />Extended Module:" + khatam.core.ConfigurationManager.License.getModule(); ;
   }
}