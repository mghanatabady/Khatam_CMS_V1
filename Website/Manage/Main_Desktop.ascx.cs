using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient ;


public partial class Manage_Main_Desktop : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //main page
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "کنترل پنل";
        
        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_panel.gif";

        DataList1.DataSource = getTableIdTitle("1", Session["uid"].ToString());
        DataList1.DataBind();

        DataList2.DataSource = getTableIdTitle("2", Session["uid"].ToString());
        DataList2.DataBind();

        DataList3.DataSource = getTableIdTitle("3", Session["uid"].ToString());
        DataList3.DataBind();

        DataList4.DataSource = getTableIdTitle("4",Session["uid"].ToString());
        DataList4.DataBind();

        DataList5.DataSource = getTableIdTitle("5", Session["uid"].ToString());
        DataList5.DataBind();

        if (DataList1.Items.Count < 1)
        {
            Div_cat1.Visible = false;
            
        }

        if (DataList2.Items.Count < 1)
        {
            Div_cat2.Visible = false;
        }

        if (DataList3.Items.Count < 1)
        {
            Div_cat3.Visible = false;
        }

        if (DataList4.Items.Count < 1)
        {
            Div_cat4.Visible = false;
        }

        if (DataList5.Items.Count < 1)
        {
            Div_cat5.Visible = false;
        }


        Announcement_ph.Controls.Add(new LiteralControl("<div  style=\"padding: 10px;direction:rtl ; text-align:right  ; border: 1px solid #d6d4c5; margin-left: 10px; width: 942px;  float: right; margin-bottom: 10px; background-color:#fdfde3\">"));
        Announcement_ph.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("Announcement", "id", this.Session["uid"].ToString(), "users")));
        Announcement_ph.Controls.Add(new LiteralControl("</div>"));

        DataTable dt = new DataTable();
        dt = getRoleAnnouncementTable();

        for (int i = 0; i < dt.Rows.Count ; i++)
        {
            Announcement_ph.Controls.Add(new LiteralControl("<div  style=\"padding: 10px;direction:rtl ; text-align:right  ; border: 1px solid #d6d4c5; margin-left: 10px; width: 942px;  float: right; margin-bottom: 10px; background-color:#fdfde3\">"));
            Announcement_ph.Controls.Add(new LiteralControl(dt.Rows[i].ItemArray[0].ToString()  ));
            Announcement_ph.Controls.Add(new LiteralControl("</div>"));
        }


        if (Session["msg"] != null)
        {
            khatam.core.Drawing.windows.msg msg = new khatam.core.Drawing.windows.msg();
            msg = (khatam.core.Drawing.windows.msg)Session["msg"];
            Session["msg"] = msg ;

            //Session["msg"] = null;

            //  msg.title = "title";
            //  msg.memo = "aaa";
            //   msg.msgMode= khatam.core.Drawing.windows.msgMode.Success ;
            //   msg.rtl = true;                        
            Announcement_ph.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getMessage(msg)));
            Session["msg"] = null ;
            
        }
    }


    public  DataTable getRoleAnnouncementTable()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        parameters.Add("idUser", khatam.core.Security.Users.login().ToString());
        str_sql = "SELECT    coreRole.Announcement  FROM         coreRole INNER JOIN                        coreRoleRefUser ON coreRole.id = coreRoleRefUser.idRole  WHERE     (coreRoleRefUser.idUser = @idUser) ";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }


    public  DataTable getTableIdTitle(string IconGroup, string userId)
    {
        string str_sql;
    
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

       
        parameters.Add("user_id",  userId );
        parameters.Add("IconGroup", IconGroup );
       // str_sql = "SELECT    corePermission.id, corePermission.title , corePermission.IconPath as image" +
//" FROM         corePermissionRefUser INNER JOIN" +
//"                     corePermission ON corePermissionRefUser.idPermission = corePermission.id" +
//" WHERE     (corePermissionRefUser.idUser = @user_id) AND (corePermission.haveIcon = 1) AND (corePermission.IconGroup = @IconGroup)";

        str_sql = "SELECT     corePermission.id, corePermission.title, corePermission.IconPath AS image, Dictionary_Lang.title as title_main " +
"FROM         corePermissionRefUser INNER JOIN " +
                      "corePermission ON corePermissionRefUser.idPermission = corePermission.id INNER JOIN " +
                      "Dictionary ON corePermission.IdDictionary = Dictionary.id INNER JOIN " +
                      "Dictionary_Lang ON Dictionary.id = Dictionary_Lang.id_dictionary " +
"WHERE     (corePermissionRefUser.idUser = @user_id) AND (corePermission.haveIcon = 1) AND (corePermission.IconGroup = @IconGroup) AND (Dictionary_Lang.id_language = 1)";

        string html = "SELECT corePermission.id, corePermission.title, corePermission.IconPath AS image, Dictionary_Lang.title as title_main "
+ " FROM corePermissionRefUser INNER JOIN "
+ " corePermission ON corePermissionRefUser.idPermission = corePermission.id INNER JOIN "
+ " Dictionary ON corePermission.IdDictionary = Dictionary.id INNER JOIN "
+ " Dictionary_Lang ON Dictionary.id = Dictionary_Lang.id_dictionary "
+ " WHERE (corePermissionRefUser.idUser = @user_id) AND (corePermission.haveIcon = 1) AND (corePermission.IconGroup =  @IconGroup) AND (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") 
+ " union"
+ " SELECT corePermission.id, corePermission.title, corePermission.IconPath AS image, Dictionary_Lang.title AS title_main"
+ " FROM coreRoleRefUser INNER JOIN"
+ " corePermissionRefRole ON coreRoleRefUser.idRole = corePermissionRefRole.idRole INNER JOIN"
+ " corePermission INNER JOIN"
+ " Dictionary ON corePermission.IdDictionary = Dictionary.id INNER JOIN"
+ " Dictionary_Lang ON Dictionary.id = Dictionary_Lang.id_dictionary ON corePermissionRefRole.idPermission = corePermission.id"
+ " WHERE (corePermission.haveIcon = 1) AND (corePermission.IconGroup =  @IconGroup) AND (Dictionary_Lang.id_language = 1) AND (coreRoleRefUser.idUser = @user_id)  " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title");

      

            return DBFunctions.ExecuteReader(html, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            
    }
}