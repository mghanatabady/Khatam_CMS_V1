using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;



public partial class Manage_c_folder : System.Web.UI.UserControl
{

    public  string idCat;
    public  string type_content;
    public  int HeightCat;
    public  int rows;

    //permisson
    public bool  PcatType ; 
    public bool  AccessALL=false ; 
  
    public bool insert  = false;
    public bool FolderInsert  = false;
    public bool FolderEdit  = false;
    public bool FolderMove = false;
    public bool FolderCopy  = false;
    public bool FolderDelete = false;
    public bool PMove  = false;
    public bool PCopy  = false;
    public bool ValidationALL  = false;
    public bool ValidationOwn = false;
    public int UserId =0 ;
    public bool VirtualDelete = false;
    public bool RealDelete = false;

    public bool folderCheckBox = false;
    public bool fileCheckBox = false;
    public bool Edit = false;
    public bool UnDelete = false;




    
    protected void Page_Load(object sender, EventArgs e)
    {


        if (khatam.core.ConfigurationManager.License.demo)
        {
            
            Button1.ToolTip = "در نسخه دمو این امکان غیر فعال است";
            Button1.Enabled = false;


            btnFileAdd.Enabled = false;
            btnFileAdd.ToolTip = "در نسخه دمو این امکان غیر فعال است";

            btnFolderRename.Enabled = false;
            btnFolderRename.ToolTip = "در نسخه دمو این امکان غیر فعال است";
            
            btnMove.Enabled = false;
            btnMove.ToolTip = "در نسخه دمو این امکان غیر فعال است";

            BtnVirtualDel.Enabled = false;
            BtnVirtualDel.ToolTip = "در نسخه دمو این امکان غیر فعال است";

            btnDel.Enabled = false;
            btnDel.ToolTip = "در نسخه دمو این امکان غیر فعال است";
            
            btnUnDel.Enabled = false;
            btnUnDel.ToolTip = "در نسخه دمو این امکان غیر فعال است";


        }

      
           try
            {
                type_content = this.Request.QueryString["cat_type"];
            }
            catch
            {

            }
                  
                if (type_content != null)
                {
                    idCat = khatam.core.data.sql.getField( "id", "type_content", type_content, "height", "2", "cat");
                  

                }
                else
                {

                    idCat = this.Request.QueryString["cat"];
                    type_content = khatam.core.data.sql.getField( "type_content", "id", idCat, "cat");
                }
        

            //~~~~{ permission }~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~} 
            DataTable dt1 = new DataTable();



            UserId = int.Parse(khatam.core.Security.Users.login().ToString());



            dt1 = khatam.core.Security.Users.getUserPermissionIdTitle(UserId.ToString());


         

            for (int jj = 0; jj < dt1.Rows.Count; jj++)
            {

                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content)
                {
                    PcatType = true;

                }


          

                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "AccessALL") AccessALL = true;
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Insert") insert = true;
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderInsert") FolderInsert = true;
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderEdit") FolderEdit = true;
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderMove") FolderMove = true;//*folder
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderDelete") FolderDelete = true;//*folder
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Move") PMove = true;//*file
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "VirtualDelete") VirtualDelete = true; //file
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "RealDelete") RealDelete = true; //file
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Edit") Edit = true; //file
                if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "UnDelete") UnDelete = true; //file



            }




       

       
       

        if ((FolderMove == true) || (FolderDelete == true) || (RealDelete == true))
        {
            folderCheckBox = true;
        }

        if ((PMove == true) || (VirtualDelete == true) || (RealDelete == true))
        {
            fileCheckBox = true;
        }
        




        if (this.Page.IsPostBack == false)
        {
            
    
            bindFolder();
            hideWins();
            
        }

    

        //~~~~{ functions }~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~}
        Agent_Smith();

       }

    void Agent_Smith()
    {

        
       if (PcatType == false) this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=MSG_Access_denied");
        this.imgBtnAdd.Visible = insert;
        this.ImgBtn_Newfolder.Visible = FolderInsert;
        if ((PMove == true) || (FolderMove == true))
        {
            this.btnMove.Visible  = true;
        }
            else
        {
            this.btnMove.Visible  = false ;
        }
        //this.GridFolder.Columns[0].Visible = false;// FolderEdit;

        if ((PMove == true) || (FolderMove == true))
        {
            this.ImgBtnMove.Visible = true;
        }
        else
        {
            this.ImgBtnMove.Visible = false ;

        }

        if ((RealDelete == true) || (FolderDelete==true ))
        {
            this.Img_Btn_Del.Visible = true;

        }

        
        this.Img_Btn_DelVirtual.Visible  = VirtualDelete ;

        this.Img_Btn_UnDel.Visible = UnDelete;

        if ( type_content=="estate")
        {
            ImgBtn_Newfolder.Visible = false;
        }

    }

    public static string getContentTypeCatId(string field_target, string field_where, string field_where_value, string table)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        parameters.Add("field_where_value", field_where_value);
        str_sql = ("SELECT  "
                    + (field_target + ("   FROM  "
                    + (table + ("   WHERE     ("
                    + (field_where + " = @field_where_value)"))))));
        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString();
    }

    
    void hideWins()
    {
        this.msgAddFile.Visible = false;
        this.msgAddFolder.Visible = false;
        this.msgMove.Visible = false;
        this.msgRenameFolder.Visible = false;
        this.MsgOK.Visible = false;
        this.MsgDel.Visible = false;
        this.MsgDelVirtual.Visible = false;
        this.MsgUnDel.Visible = false;

    }



    protected void OtreeView_SelectedNodeChanged(object sender, EventArgs e)
    {
        //OtreeView.SelectedNode 
        idCat = OtreeView.SelectedValue;

        bindFolder();
        

    }


    public void bindFolder()
    {
        string weArehere;
        weArehere = khatam.core.explorer.generateUrl_link(idCat);
        

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = weArehere ;

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/ICON_CONTENT.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + weArehere;
        l.Text = l.Text + "</span> ";

        Label1.Text = weArehere;
        //******BEGIN Hide rename and checkbox of folders when path is first node
        int HeightCat;
  
        HeightCat = int.Parse(khatam.core.data.sql.getField("height", "id", idCat, "cat"));
  
        if (HeightCat < 3)
        {
            this.GridFolder.Columns[0].Visible = false  ;
            this.GridFolder.Columns[3].Visible = false ;

        }
      else
    {
            this.GridFolder.Columns[0].Visible = folderCheckBox ;
            this.GridFolder.Columns[3].Visible = FolderEdit;
        }
        //******END Hide rename and checkbox of folders when path is first node


       TreeNodeBinding OtreeNodeBinding = new TreeNodeBinding();
        OtreeNodeBinding.TextField = "title";
      OtreeNodeBinding.ValueField = "id";
    OtreeView.CssClass = "TreeCat";
      XmlDataSource OXmlDataSource = new XmlDataSource();
        
        OXmlDataSource.Data = khatam.core.explorer.getContentXmlTree( type_content , "فارسی");
      OXmlDataSource.EnableCaching = false;
        OtreeView.DataBindings.Add(OtreeNodeBinding);
        OtreeView.NodeIndent = 5;
        OtreeView.Font.Size = FontUnit.Point(9);
        OtreeView.DataSource = OXmlDataSource;
  
             OtreeView.DataBind();



string sortid = "";
        sortid = khatam.core.data.sql.getField( "sortid", "id", idCat, "cat");

        int Results;
      string contentTable = type_content ;


        //#sortId
     

        Results = khatam.core.explorer.TableItemCount(contentTable, sortid, AccessALL  , RealDelete, UserId.ToString() );
        
      int pageQ;
        int pageSize = int.Parse(DropDownList1.SelectedValue);

      pageQ = Results / pageSize + (Results % pageSize > 0 ? 1 : 0);
       
     //query strings
        int page;
                
      page = int.Parse(this.lblPage.Text);
        
        if (page < 1) page = 1;
      if (page > pageQ) page = pageQ;
       
        lblPage.Text = page.ToString();
                
      int fRow;
    int lRow;
  fRow = page * pageSize;
                
        lRow = page * pageSize;
      fRow = (lRow - pageSize) + 1;
        
        int lPage;
      if ((Results % pageSize) == 0)
    {
           lPage = Results / pageSize;
     }
   else
        {
          lPage = Results / pageSize + 1;
    }


        DataTable dt = new DataTable();

       UserId  = int.Parse(khatam.core.Security.Users.login().ToString());

      dt = khatam.core.explorer.getFilePage(sortid, contentTable, fRow, lRow, AccessALL,RealDelete   , UserId.ToString() );
        
    GV_File.DataSource = dt;
        GV_File.DataBind();

        this.GV_File.Columns[0].Visible = fileCheckBox;
      this.GV_File.Columns[3].Visible =Edit ;

       DataTable dt2 = new DataTable();
      dt2 = khatam.core.explorer.getFolder("bindFolder", sortid);
        GridFolder.DataSource = dt2;
        GridFolder.DataBind();

  

    }

    public void bindFolder_Backup()
    {


        Label1.Text = khatam.core.explorer.generateUrl(idCat);
        //******BEGIN Hide rename and checkbox of folders when path is first node
        int HeightCat;

        HeightCat = int.Parse(khatam.core.data.sql.getField( "height", "id", idCat, "cat"));

        if (HeightCat < 3)
        {
            this.GridFolder.Columns[0].Visible = false;
            this.GridFolder.Columns[3].Visible = false;

        }
        else
        {
            this.GridFolder.Columns[0].Visible = folderCheckBox;
            this.GridFolder.Columns[3].Visible = FolderEdit;
        }
        //******END Hide rename and checkbox of folders when path is first node


        TreeNodeBinding OtreeNodeBinding = new TreeNodeBinding();
        OtreeNodeBinding.TextField = "title";
        OtreeNodeBinding.ValueField = "id";
        OtreeView.CssClass = "TreeCat";
        XmlDataSource OXmlDataSource = new XmlDataSource();

        OXmlDataSource.Data = khatam.core.explorer.getContentXmlTree(type_content, "فارسی");
        OXmlDataSource.EnableCaching = false;
        OtreeView.DataBindings.Add(OtreeNodeBinding);
        OtreeView.NodeIndent = 5;
        OtreeView.Font.Size = FontUnit.Point(9);
        OtreeView.DataSource = OXmlDataSource;
        OtreeView.DataBind();



        string sortid = "";
        sortid = khatam.core.data.sql.getField( "sortid", "id", idCat, "cat");

        int Results;
        string contentTable = type_content;


        //#sortId


        Results = khatam.core.explorer.TableItemCount(contentTable, sortid, AccessALL, RealDelete, UserId.ToString());

        int pageQ;
        int pageSize = int.Parse(DropDownList1.SelectedValue);

        pageQ = Results / pageSize + (Results % pageSize > 0 ? 1 : 0);

        //query strings
        int page;

        page = int.Parse(this.lblPage.Text);

        if (page < 1) page = 1;
        if (page > pageQ) page = pageQ;

        lblPage.Text = page.ToString();

        int fRow;
        int lRow;
        fRow = page * pageSize;

        lRow = page * pageSize;
        fRow = (lRow - pageSize) + 1;

        int lPage;
        if ((Results % pageSize) == 0)
        {
            lPage = Results / pageSize;
        }
        else
        {
            lPage = Results / pageSize + 1;
        }


        DataTable dt = new DataTable();

        UserId = int.Parse(khatam.core.Security.Users.login().ToString());

        dt = khatam.core.explorer.getFilePage(sortid, contentTable, fRow, lRow, AccessALL, RealDelete, UserId.ToString());

        GV_File.DataSource = dt;
        GV_File.DataBind();

        this.GV_File.Columns[0].Visible = fileCheckBox;
        this.GV_File.Columns[3].Visible = Edit;

        DataTable dt2 = new DataTable();
        dt2 = khatam.core.explorer.getFolder("bindFolder", sortid);
        GridFolder.DataSource = dt2;
        GridFolder.DataBind();



    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindFolder();
    }
    protected void btn_next_Click(object sender, ImageClickEventArgs e)
    {
        lblPage.Text = (int.Parse(lblPage.Text) + 1).ToString();
        bindFolder();
    }
    protected void btn_back_Click(object sender, ImageClickEventArgs e)
    {
        lblPage.Text = (int.Parse(lblPage.Text) - 1).ToString();
        bindFolder();
    }
    protected void btn_first_Click(object sender, ImageClickEventArgs e)
    {
        lblPage.Text = "1";
        bindFolder();
    }
    protected void btn_end_Click(object sender, ImageClickEventArgs e)
    {
        lblPage.Text = "100000";
        bindFolder();
    }
    protected void btnFileAdd_Click(object sender, EventArgs e)
    {


        int height;
        height = int.Parse(khatam.core.data.sql.getField( "height", "id", DDL_ADDfilecat.SelectedValue, "cat"));

        string sortidCurrent;
        sortidCurrent = khatam.core.data.sql.getField( "sortid", "id", DDL_ADDfilecat.SelectedValue, "cat");

        int orderid = 1;

        try
        {
            orderid = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
        }
        catch
        {

        }

        string sortchar;
        if ((orderid.ToString().Length > 1))
        {
            sortchar = ((char)((63 + orderid.ToString().Length))).ToString();
        }
        else
        {
            sortchar = "";
        }



        string sortid;
        sortid = khatam.core.explorer.getSortId(height, int.Parse(DDL_ADDfilecat.SelectedValue), sortidCurrent);


        int pidCurrent;
        pidCurrent = int.Parse(khatam.core.data.sql.getField( "pid", "id", DDL_ADDfilecat.SelectedValue, "cat"));




        

        if (insert == true)
        {
            khatam.core.explorer.fileAdd(orderid, this.txtNewFileName.Text, int.Parse(DDL_ADDfilecat.SelectedValue), sortid + "." + sortchar + orderid, height + 1, 2, type_content  , khatam.core.explorer.contentInsert(txtNewFileName.Text, type_content ).ToString(), khatam.core.Security.Users.login().ToString());
            idCat = DDL_ADDfilecat.SelectedValue;
        }


        bindFolder();
        hideWins();

        
    }

    protected void ImgBtnMove_Click(object sender, EventArgs e)
    {
        hideWins();

        DataTable dt = new DataTable();
        dt = khatam.core.explorer.getFolderType(type_content );
        DDL_Move.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem a = new ListItem();
            a.Text = khatam.core.explorer.generateUrl(dt.Rows[i].ItemArray[0].ToString());
            a.Value = dt.Rows[i].ItemArray[0].ToString();
            this.DDL_Move.Items.Add(a);
        }

        this.msgMove.Visible = true;
    }
    protected void btnFolderAdd_Click(object sender, EventArgs e)
    {
        int height;
        height = int.Parse(khatam.core.data.sql.getField( "height", "id", DDL_ADDFolderCat.SelectedValue, "cat"));

        string sortidCurrent;
        sortidCurrent = khatam.core.data.sql.getField( "sortid", "id", DDL_ADDFolderCat.SelectedValue, "cat");

        int orderid = 1;

        try
        {
            orderid = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
        }
        catch
        {

        }

        string sortchar;
        if ((orderid.ToString().Length > 1))
        {
            sortchar = ((char)((63 + orderid.ToString().Length))).ToString();
        }
        else
        {
            sortchar = "";
        }



           string sortid;
           sortid = khatam.core.explorer.getSortId(height, int.Parse(DDL_ADDFolderCat.SelectedValue), sortidCurrent);


           int pidCurrent;
           pidCurrent = int.Parse(khatam.core.data.sql.getField( "pid", "id", DDL_ADDFolderCat.SelectedValue, "cat"));



           UserId = int.Parse(khatam.core.Security.Users.login().ToString());


       
        if (FolderInsert == true)
        {
        //  idCat = khatam.core.explorer.fileAdd(orderid, this.txtNewFolderName.Text, int.Parse(DDL_ADDFolderCat.SelectedValue), sortid + "." + sortchar + orderid, height + 1, 1,type_content,  "0", UserId.ToString() );
          khatam.core.explorer.fileAdd(orderid, this.txtNewFolderName.Text, int.Parse(DDL_ADDFolderCat.SelectedValue), sortid + "." + sortchar + orderid, height + 1, 1, type_content, "0", UserId.ToString());
        }


        bindFolder();
        hideWins();
    }
    protected void Img_Btn_Del_Click(object sender, ImageClickEventArgs e)
    {
        hideWins();
        MsgDel.Visible = true;
    }


    protected void btnDel_Click(object sender, EventArgs e)
    {

        if (RealDelete == true)     fileDel();

        if (FolderDelete == true)
        {
            folderDelContentTree(type_content);
            folderDelCatTree(type_content);
        }

        hideWins();
        bindFolder();

    }



    public string fileDel()
    {


        string id_content, cat_id;


        for (int i = 0; i < this.GV_File.Rows.Count; i++)
        {


            if (((CheckBox)(this.GV_File.Rows[i].Cells[0].FindControl("CheckBox1"))).Checked == true)
            {

                cat_id = this.GV_File.Rows[i].Cells[1].Text;
                id_content = khatam.core.data.sql.getField( "id_content", "id", cat_id, "cat");

                //del contet
                khatam.core.data.sql.Sql_Del_Row("id", id_content, type_content , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                //del cat
                khatam.core.data.sql.Sql_Del_Row("id", cat_id, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


            }


        }

        return "true";

    }


    public string folderDelContentTree(string content_type)
{
     string  sort_id ;
        
        
           for (int i = 0; i < this.GridFolder.Rows.Count; i++)
        {

            if (((CheckBox)(this.GridFolder.Rows[i].Cells[0].FindControl("CheckBox2"))).Checked == true)
            {


               sort_id = khatam.core.data.sql.getField("sortid","id",this.GridFolder.Rows[i].Cells[1].Text ,"cat");


               if (sort_id.Contains("#") == false) return "0";
               if (sort_id.Length  < 8) return "0";

                
                
                  string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    str_sql = "DELETE FROM " + content_type + "    FROM         " + content_type +
                    "  INNER JOIN  cat On  " + content_type + ".id =  Cat.id_content     WHERE     (Cat.sortid LIKE N'%" +
                    sort_id + "%') AND  (Cat.type_content = N'"+  content_type + "') AND  (cat.type = 2)";


                    DBFunctions.ExecuteNonQuery(str_sql, parameters,System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            
            }
           }

        

            return "0";


}


    

    public string folderDelCatTree(string content_type)
{

         string  sort_id ;
        
        
           for (int i = 0; i < this.GridFolder.Rows.Count; i++)
        {

            if (((CheckBox)(this.GridFolder.Rows[i].Cells[0].FindControl("CheckBox2"))).Checked == true)
            {


               sort_id = khatam.core.data.sql.getField("sortid","id",this.GridFolder.Rows[i].Cells[1].Text ,"cat");


               if (sort_id.Contains("#") == false) return "0";
               if (sort_id.Length  < 8) return "0";

                
                
                  string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    str_sql = "DELETE FROM Cat   WHERE     (sortid like N'%" + sort_id + "%') AND  (type_content = N'" + content_type + "')";



                    DBFunctions.ExecuteNonQuery(str_sql, parameters,System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            
            }
           }

            return "0";

        
    }

    protected void GridFolder_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        this.GridFolder.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        rows = this.GridFolder.SelectedIndex;
        if (e.CommandName == "rename_cmd")
        {
            hideWins();
            this.msgRenameFolder.Visible = true;
            //  txtFolderRename.Text= khatam.core.data.sql.getField("cname", idCat ,this.GridFolder.Rows[rows ].Cells[1].Text  ,"cat");

            txtFolderRename.Text = khatam.core.data.sql.getField( "cname", "id", this.GridFolder.Rows[rows].Cells[1].Text, "cat");
            // Txt_Folderrename.Text = Me.GridFolder_mirror.Rows(rows).Cells(2).Text
        }
    }
    protected void GridFolder_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnFolderRename_Click(object sender, EventArgs e)
    {
        if (FolderEdit == true)
        {
            khatam.core.data.sql.updateField("cname", txtFolderRename.Text, "id", GridFolder.Rows[GridFolder.SelectedIndex].Cells[1].Text, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
        bindFolder();
        hideWins();
    }

    protected void ImgBtn_Newfolder_Click(object sender, EventArgs e)
    {
        hideWins();

        DataTable dt = new DataTable();
        dt = khatam.core.explorer.getFolderType(type_content );
        DDL_ADDFolderCat.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem a = new ListItem();
            a.Text = khatam.core.explorer.generateUrl(dt.Rows[i].ItemArray[0].ToString());
            a.Value = dt.Rows[i].ItemArray[0].ToString();
            this.DDL_ADDFolderCat.Items.Add(a);
        }

        this.msgAddFolder.Visible = true;
    }

    protected void btnMove_Click(object sender, EventArgs e)
    {
        int height;
        height = int.Parse(khatam.core.data.sql.getField( "height", "id", DDL_Move.SelectedValue, "cat"));

        string sortidCurrent;
        sortidCurrent = khatam.core.data.sql.getField( "sortid", "id", DDL_Move.SelectedValue, "cat");


        if (PMove == true)
        {

            for (int i = this.GV_File.Rows.Count - 1; i >= 0; i--)
            {


                if (((CheckBox)(this.GV_File.Rows[i].Cells[0].FindControl("CheckBox1"))).Checked == true)
                {


                    int orderid = 1;

                    try
                    {
                        orderid = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
                    }
                    catch
                    {


                    }

                    string sortchar = "";
                    if ((orderid.ToString().Length > 1))
                    {
                        sortchar = ((char)((63 + orderid.ToString().Length))).ToString();
                    }
                    else
                    {
                        sortchar = "";
                    }



                    string sortid = "";
                    sortid = khatam.core.explorer.getSortId(height, int.Parse(DDL_Move.SelectedValue), sortidCurrent);

                    UserId = int.Parse(khatam.core.Security.Users.login().ToString());





                    khatam.core.explorer.fileMove(this.GV_File.Rows[i].Cells[1].Text, orderid, int.Parse(DDL_Move.SelectedValue), sortid + "." + sortchar + orderid, height + 1);
                }
            }
        }

        if (FolderMove == true)
        {
            for (int i = 0; i < this.GridFolder.Rows.Count; i++)
            {

                if (((CheckBox)(this.GridFolder.Rows[i].Cells[0].FindControl("CheckBox2"))).Checked == true)
                {
                //    if (this.GridFolder.Rows[i].Cells[1].Text != DDL_Move.SelectedValue)
                    if (FolderisParent( this.GridFolder.Rows[i].Cells[1].Text,DDL_Move.SelectedValue)==false )
                    {
                        

                        int orderid2 = 1;
                        try
                        {

                            orderid2 = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
                        }

                        catch
                        {
                        }

                        string sortchar2 = "";
                        if ((orderid2.ToString().Length > 1))
                        {
                            sortchar2 = ((char)((63 + orderid2.ToString().Length))).ToString();
                        }
                        else
                        {
                            sortchar2 = "";
                        }



                        string sortid2;
                        sortid2 = khatam.core.explorer.getSortId(height, int.Parse(DDL_Move.SelectedValue), sortidCurrent);

                        khatam.core.explorer.folderMove(this.GridFolder.Rows[i].Cells[1].Text, orderid2, int.Parse(DDL_Move.SelectedValue), sortid2 + "." + sortchar2 + orderid2, height + 1);
                    }
                }
            }



            idCat = DDL_Move.SelectedValue;
        }
            hideWins();
        bindFolder();



    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        hideWins();
    }
    protected void imgBtnAdd_Click(object sender, EventArgs e)
    {


        hideWins();


        DataTable dt = new DataTable();
        dt = khatam.core.explorer.getFolderType(type_content );
       // = khatam.core.explorer.getFolderType("news");
        DDL_ADDfilecat.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem a = new ListItem();
            a.Text = khatam.core.explorer.generateUrl(dt.Rows[i].ItemArray[0].ToString());
            a.Value = dt.Rows[i].ItemArray[0].ToString();
            DDL_ADDfilecat.Items.Add(a);
        }



        txtNewFileName.Text = "";

        this.msgAddFile.Visible = true;

        // try
        // {
        //  DDL_ADDfilecat.SelectedValue = idCat;
        // }
        // catch
        // {
        // }

    }
    protected void Img_Btn_DelVirtual_Click(object sender, ImageClickEventArgs e)
    {
        hideWins();
        MsgDelVirtual.Visible=true ;
    }
    protected void Img_Btn_UnDel_Click(object sender, ImageClickEventArgs e)
    {

        hideWins();
        this.MsgUnDel.Visible = true;
        //MsgDelVirtual.Visible = true;
    }
    protected void BtnVirtualDel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GV_File.Rows.Count  ; i++)
        {
            if (((CheckBox)(this.GV_File.Rows[i].Cells[0].FindControl("CheckBox1"))).Checked == true)
            {
                khatam.core.data.sql.updateField("deleted", "1", "id", this.GV_File.Rows[i].Cells[1].Text, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
        }

        hideWins();
        bindFolder();

    }
    public static bool  FolderisParent(string folder_sourceID, string folder_targetID)
    {
        string folder_sourceSortID, folder_targetSortID;


        folder_sourceSortID = khatam.core.data.sql.getField( "sortid", "id", folder_sourceID, "cat");
        folder_targetSortID = khatam.core.data.sql.getField( "sortid", "id", folder_targetID, "cat");

        return folder_targetSortID.Contains(folder_sourceSortID);

    }
    protected void btnUnDel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GV_File.Rows.Count; i++)
        {
            if (((CheckBox)(this.GV_File.Rows[i].Cells[0].FindControl("CheckBox1"))).Checked == true)
            {
                khatam.core.data.sql.updateField("deleted", "0", "id", this.GV_File.Rows[i].Cells[1].Text, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }
        }

        hideWins();
        bindFolder();
    }
    protected void GV_File_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ImgBtn_Newfolder1_Click(object sender, EventArgs e)
    {

    }
}