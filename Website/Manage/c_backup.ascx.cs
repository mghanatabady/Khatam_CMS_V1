﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient ;
using System.IO;
using System.Collections;
using System.Diagnostics;
using Ionic.Zip;

public partial class Manage_c_backup : System.Web.UI.UserControl
{



    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "نسخه پشتیبان";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/backup-icon.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " نسخه پشتیبان";
        l.Text = l.Text + "</span> ";


        if (khatam.core.ConfigurationManager.License.demo == true)
        {

            this.btn_Save.Enabled = false;
            btn_Save.ToolTip = "در نسخه دمو این امکان وجود ندارد";

            btn_restore.Enabled = false;
            btn_restore.ToolTip = "در نسخه دمو این امکان وجود ندارد";
        }
        
        
        //((Label)(Parent.FindControl("Label1"))).Text = " نسخه پشتیبان < ";
        //((Label)(Parent.FindControl("Label1"))).ForeColor  = System.Drawing.Color.Gray ;

        if (khatam.core.ConfigurationManager.License.demo == true)
        {
          //  Button1.Enabled = false;
          ///  Button1.ToolTip = "در نسخه دمو این امکان وجود ندارد";

        }

       //## if (Page.IsPostBack == false)
       //## {



           //## DirectoryInfo StoreFile = new DirectoryInfo(Server.MapPath("../manage/sql/"));
           //## FileInfo[] fi;//= new FileInfo("sssssssss");



            //Dim StoreFile As System.IO.Directory


            //Dim Files As String()
            //Dim File As String

        //##    string[] files;
         //##   string file;

//##            fi = StoreFile.GetFiles();


    //##        foreach (var item in fi)
        //##    {
            //##    ListItem li = new ListItem();
     //##           li.Text = item.ToString();
         //##       ListBox1.Items.Add(li);
//##            }

            //this.ListBox1.SelectedValue = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("theme", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


        }
    

   

      protected void Button1_Click(object sender, EventArgs e)
      {

          BackupDatabase();
      }


      public  void BackupDatabase()
      {
          string sConnect = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
          string dbName;

          using (SqlConnection cnn = new SqlConnection(sConnect))
          {
              cnn.Open();
              dbName = cnn.Database.ToString();

           //   ServerConnection sc = new ServerConnection(cnn);
             // Server sv = new Server(sc);

              // Check that I'm connected to the user instance
           //   Console.WriteLine(sv.InstanceName.ToString());

              string strTimeStamp = DateTime.UtcNow.ToString(); 
              strTimeStamp = strTimeStamp.Replace("/", "-");
              strTimeStamp = strTimeStamp.Replace(" ", "-"); 
              strTimeStamp = strTimeStamp.Replace(":", "-"); 
              
              // Create backup device item for the backup
           //   BackupDeviceItem bdi = new BackupDeviceItem(Server.MapPath(@"sql/" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().ToString().Replace(".","_") 
             //     + "-SqlBackup-" + strTimeStamp + ".bak"), DeviceType.File);

              // Create the backup informaton
//              Backup bk = new Backup();
  //            bk.Devices.Add(bdi);
    //          bk.Action = BackupActionType.Database;
      //        bk.BackupSetDescription = "SQL Express is a great product!";
        //      bk.BackupSetName = "SampleBackupSet";
          //    bk.Database = dbName;
            //  bk.ExpirationDate = new DateTime(2007, 5, 1);
          //    bk.LogTruncation = BackupTruncateLogType.Truncate;

              // Run the backup
           //   bk.SqlBackup(sv);
              Console.WriteLine("Your backup is complete.");
          }
      }

      protected void BtnOK_Click(object sender, EventArgs e)
      {

      }
      protected void BtnCancel_Click(object sender, EventArgs e)
      {

      }
 
      void load_xml(string file_path, string tablename)
      {
          DataSet ds = new DataSet();
          ds.ReadXml(file_path);

          Khatam_Functions.KUI.Database.sql.Sql_Del_all_Row("Core_serverControlsInstance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          insertCore_serverControlsInstance(ds.Tables[0]);

          Khatam_Functions.KUI.Database.sql.Sql_Del_all_Row("Core_serverControlsInstancePlacing", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          insertDt(ds.Tables[1], "Core_serverControlsInstancePlacing");

          Khatam_Functions.KUI.Database.sql.Sql_Del_all_Row("Core_serverControlsInstanceVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          insertDt(ds.Tables[2], "Core_serverControlsInstanceVal");

          Khatam_Functions.KUI.Database.sql.Sql_Del_all_Row("Core_sectionVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
          insertDt(ds.Tables[3], "Core_sectionVal");

      }

      void load_xml_content(string file_path)
      {
          DataSet ds = new DataSet();
          ds.ReadXml(file_path);

          lbl_msg.Text = "";

        string domainname= ds.Tables[0].Rows[0].ItemArray[1].ToString();    

            for (int i = 1; i < ds.Tables.Count; i++)
            // for (int i = 0; i < 1; i++)

			{
                lbl_msg.Text = ds.Tables[i].TableName + " , " + lbl_msg.Text;
            Khatam_Functions.KUI.Database.sql.Sql_Del_all_Row(ds.Tables[i].TableName, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
              insertDtIdentity(ds.Tables[i],domainname);
			}

          //Label3.Text = ds.Tables[2].Columns[0].DataType.ToString();
         
      }

      public  void insertDtIdentity(DataTable dt,string domainName)
      {
          string str_sql, str_sql2;
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();




          string str_into = "", str_VALUES= "";
          for (int j = 0; j <= dt.Columns.Count -1; j++)
          {
              if (j == 0)
              {
                  str_into = dt.Columns[j].Caption;
                  str_VALUES = '@' + dt.Columns[j].Caption;
              }
              else
              {
                  str_into = str_into + " , " + dt.Columns[j].Caption;
                  str_VALUES = str_VALUES + " , " + '@' + dt.Columns[j].Caption;
              }
           }

       
          str_sql = ("begin SET           IDENTITY_INSERT [" + dt.TableName + "] ON " +
        " INSERT       " +
         "  INTO            " + dt.TableName + "(" + str_into + ") " +
" VALUES     (" + str_VALUES + ") " +
" SET              IDENTITY_INSERT [" + dt.TableName + "] OFF  end");

                  

          for (int i = 0; i <= dt.Rows.Count - 1; i++)
          {

              parameters.Clear();

              for (int k = 0; k < dt.Columns.Count; k++)
              {
                //  if (dt.Columns[k].DataType ==System.Type.GetType("System.DateTime"))
                  if (dt.Columns[k].Caption.ToString().EndsWith("date") || dt.Columns[k].Caption.ToString().EndsWith("Date"))
                  {
                     // parameters.Add(dt.Columns[k].Caption, "2010/1/1");
                      parameters.Add(dt.Columns[k].Caption,DateTime.Parse( dt.Rows[i].ItemArray[k].ToString()));
                  }
                  else
                  {
                     // parameters.Add(dt.Columns[k].Caption, dt.Rows[i].ItemArray[k].ToString());

                      parameters.Add(dt.Columns[k].Caption, dt.Rows[i].ItemArray[k].ToString().Replace
                         (domainName,khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() ).Replace(
                          "src=\"/manage/", "src=\"" + "http://" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()
                         + "/manage/")//.Replace("/10009","")
                        // "src=\"/manage/", "src=\"http://" +khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + "/manage/")
                         //http://yourDomain.com/10001/manage/upload/winAwards.jpg
                         );
                      //src="/manage/
                  }
              //Label3.Text = " | " + dt.Rows[i].ItemArray[k] + " | " + Label3.Text;    
              }
              //begin end
            //  try
            //  {
                  DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString();
             // }
             // catch (Exception)
            //  {
                  
                  
            //  }

             


          }
      }


      public static void insertCore_serverControlsInstance(DataTable dt)
      {
          string str_sql;
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

          for (int i = 0; i <= dt.Rows.Count - 1; i++)
          {



              //parameters.Add("field_where_value", field_where_value);
              str_sql = ("SET           IDENTITY_INSERT [Core_serverControlsInstance] ON " +
                                " INSERT       " +
                                 "  INTO            Core_serverControlsInstance(id, id_core_serverControl, title)  " +
       " VALUES     (" + dt.Rows[i].ItemArray[0] + ", " + dt.Rows[i].ItemArray[1] + " , N'" + dt.Rows[i].ItemArray[2] + "')  " +
       " SET              IDENTITY_INSERT [Core_serverControlsInstance] OFF  ");

              DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString();


          }
      }


      public static void insertDt(DataTable dt, string tablename)
      {
          int i;
          int j;
          ArrayList item_name = new ArrayList();
          ArrayList item_value = new ArrayList();

          ArrayList list = new ArrayList();


          for (i = 0; i <= dt.Rows.Count - 1; i++)
          {
              item_name.Clear();
              item_value.Clear();
              for (j = 0; j <= dt.Columns.Count - 1; j++)
              {
                  //this.Label1.Text = (dt.Columns[j].Caption + this.Label1.Text);
                  if ((dt.Columns[j].Caption != "id"))
                  {
                      item_name.Add(dt.Columns[j].Caption);
                      item_value.Add(dt.Rows[i].ItemArray[j]);
                  }
              }


              khatam.core.data.sql.Add(item_name, item_value, tablename);
          }
      }


      protected void Button5_Click(object sender, EventArgs e)
      {

      }

      protected void Btn_Clk_Save_Object_XML(object sender, EventArgs e)
      {
          DataTable dt = new DataTable();
          dt = khatam.core.data.sql.getTable("Core_serverControlsInstance");
          dt.TableName = "Core_serverControlsInstance";

          DataTable dt2 = new DataTable();
          dt2 = khatam.core.data.sql.getTable("Core_serverControlsInstancePlacing");
          dt2.TableName = "Core_serverControlsInstancePlacing";

          DataTable dt3 = new DataTable();
          dt3 = khatam.core.data.sql.getTable("Core_serverControlsInstanceVal");
          dt3.TableName = "Core_serverControlsInstanceVal";

          DataTable dt4 = new DataTable();
          dt4 = khatam.core.data.sql.getTable("Core_sectionVal");
          dt4.TableName = "Core_sectionVal";


          

          DataSet ds = new DataSet();
          ds.Tables.Add(dt);
          ds.Tables.Add(dt2);
          ds.Tables.Add(dt3);
          ds.Tables.Add(dt4);

          khatam.core.XML.IO.Export_DataSet_To_File(ds,
              "Objects_Backup_" +
              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_Date_" +
              DateTime.UtcNow.ToShortDateString() + "_Time_" + DateTime.UtcNow.ToShortTimeString()  + "_London_Time");

          
      }
      protected void BtnContent_Clk_Save_Object_XML(object sender, EventArgs e)
      {
          DataSet ds = new DataSet();

          DataTable dt_sync = new DataTable();
          dt_sync.TableName = "sync_setting";
          dt_sync.Columns.Add("title");
          dt_sync.Columns.Add("memo");
          DataRow newrow;

          newrow = dt_sync.NewRow();
          newrow[0] = "domainName";
          newrow[1] =khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir();
                


          dt_sync.Rows.Add(newrow);

          ds.Tables.Add(dt_sync);

          DirectoryInfo StoreFile = new DirectoryInfo(Server.MapPath("../Install/module/sql/content/"));
          FileInfo[] fi;

          string[] files;
          string file;

          fi = StoreFile.GetFiles();
           

          foreach (var item in fi)
          {

              DataTable dt = new DataTable();
              
              dt = khatam.core.data.sql.getTable(item.ToString().Replace(".sql",""));

              dt.TableName = item.ToString().Replace(".sql", "");

     


              ds.Tables.Add(dt);
          }



        //  ds.Tables[0].Columns[0].DataType = typeof(string);
  /*        DataTable dtCloned = dt.Clone(); 
dtCloned.Columns[0].DataType = typeof(Int32); 
foreach (DataRow row in dt.Rows)  
{ 
    dtCloned.ImportRow(row); 
} */
      
          khatam.core.XML.IO.Export_DataSet_To_File(ds,
              "Backup_" +
              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_Date_" +
              DateTime.UtcNow.ToShortDateString() + "_Time_" + DateTime.UtcNow.ToShortTimeString() + "_London_Time");

      }
      protected void Btn_Restore_Contents_Click(object sender, EventArgs e)
      {
          string strpath;
          /*if (FileUpload2.HasFile)
          {
              try
              {
                  strpath = Server.MapPath(@"UpLoad\");
                  this.FileUpload2.SaveAs((strpath + this.FileUpload2.FileName));
                  Label2.Text = "ارسال موفقیت آمیز <br> " +
                  "File name: " + FileUpload2.PostedFile.FileName +
                  "<br>" + "File Size: " + FileUpload2.PostedFile.ContentLength +
                  " kb<br>" + "Content type: " + FileUpload2.PostedFile.ContentType;

                  // split file name
                  string[] stringBuffer;


                  stringBuffer = this.FileUpload2.PostedFile.FileName.Split('1');

                  load_xml_content((Server.MapPath("upload\\") + FileUpload2.FileName));

              }
              catch (Exception ex)
              {
                  Label2.Text = ("ERROR: " + ex.Message.ToString());
              }
          }
          else
          {
              // ~�'E /1 5H1* 9/E 'F*.'( A'�D
              Label2.Text = "";
          }*/
      }
      protected void btn_Save_Click(object sender, EventArgs e)
      {




          DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, TimeZoneInfo.Utc.Id, "Iran Standard Time");
          string dtFa = khatam.core.globalization.dateTime.GetPersianDateTime(dtLocal);

          var downloadFileName = string.Format("BackUp-{0}-{1}.zip", khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir(), dtFa);
          Response.AddHeader("Content-Disposition", "attachment; filename=" + downloadFileName);
          Response.ContentType = "application/zip";


          var zip = new ZipFile();



          var readMeContent = string.Format("This ZIP file was created by DotNetZip at {0} and contains the following files:{1}{1}", DateTime.Now, Environment.NewLine);


          var FilesPath = Server.MapPath("~/manage/upload/");

          zip.AddDirectory(FilesPath);






          DataSet ds = new DataSet();

          DataTable dt_sync = new DataTable();
          dt_sync.TableName = "sync_setting";
          dt_sync.Columns.Add("title");
          dt_sync.Columns.Add("memo");
          DataRow newrow;

          newrow = dt_sync.NewRow();
          newrow[0] = "domainName";
          newrow[1] = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir();



          dt_sync.Rows.Add(newrow);

          ds.Tables.Add(dt_sync);




          DirectoryInfo StoreFile = new DirectoryInfo(Server.MapPath("../Install/module/sql/content/"));
          FileInfo[] fi;


          string[] files;
          string file;

          fi = StoreFile.GetFiles();



          foreach (var item in fi)
          {

              DataTable dt = new DataTable();

              dt = khatam.core.data.sql.getTable(item.ToString().Replace(".sql", ""));

              dt.TableName = item.ToString().Replace(".sql", "");




              ds.Tables.Add(dt);
          }



          //  ds.Tables[0].Columns[0].DataType = typeof(string);
          /*        DataTable dtCloned = dt.Clone(); 
        dtCloned.Columns[0].DataType = typeof(Int32); 
        foreach (DataRow row in dt.Rows)  
        { 
            dtCloned.ImportRow(row); 
        } */

          //  khatam.core.XML.IO.Export_DataSet_To_File(ds,
          //    "Backup_" +
          //  khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_Date_" +
          //  DateTime.UtcNow.ToShortDateString() + "_Time_" + DateTime.UtcNow.ToShortTimeString() + "_London_Time");

          try
          {
              zip.RemoveEntry("xml_settings.xml");
          }
          catch 
          {
              
              
          }
        


          //  zip.AddEntry("xml_settings.xml", ConvertStringToBytes(ds.GetXml()));
          zip.AddEntry("xml_settings.xml", ConvertStringToBytes(ds.GetXml()));
          // zip.AddEntry("xml_settings.xml", ConvertStringToBytes("aaaaaa"));



          // zip.AddFile(



          zip.Save(Response.OutputStream);

      }


        public static byte[] ConvertStringToBytes(string input)    {      MemoryStream stream = new MemoryStream();   
            using (StreamWriter writer = new StreamWriter(stream))       {   
                writer.Write(input);         writer.Flush();       }  
            return stream.ToArray(); 
}


        protected virtual void DisplayAlert(string message)
        {
          this.Page.ClientScript.RegisterStartupScript(
                            this.GetType(),
                            Guid.NewGuid().ToString(),
                            string.Format("alert('{0}');", message.Replace("'", @"\'")),
                            true
                        );
        }


        protected void btn_restore_Click(object sender, EventArgs e)
        {

         
            // Make sure file has been uploaded and has a ZIP extension...
            if (!fuZIP.HasFile || string.Compare(".zip", Path.GetExtension(fuZIP.FileName), true) != 0
                 || !fuZIP.FileName.ToString().StartsWith("BackUp-")
                )
            {
                DisplayAlert("فایل معتبر نیست، لطفا فایل پشتیبان معتبر را انتخاب نمایید");
                return;
            }

            FileCleanup(Server.MapPath("~/manage/upload/"));

            var extractToFolder = Server.MapPath("~/manage/upload");

            using (var zip = ZipFile.Read(fuZIP.FileBytes))
            {
               

                zip.ExtractAll(extractToFolder, ExtractExistingFileAction.DoNotOverwrite);

             //   gvZIPContents.DataSource = zip.Entries;
               // gvZIPContents.DataBind();
            }

            load_xml_content((Server.MapPath("upload\\") + "xml_settings.xml"));
            

        }

        private static void FileCleanup(string directoryName)
        {
            try
            {
                string[] filenames = Directory.GetFiles(directoryName);

                foreach (string filename in filenames)
                {
                    File.Delete(filename);
                }

                string[] dirnames = Directory.GetDirectories(directoryName);

                foreach (string dirname in dirnames)
                {
                    Directory.Delete(dirname,true);
                }
                //if (Directory.Exists(directoryName))
               // {
                 //   Directory.Delete(directoryName);
               // }
            }
            catch (Exception ex)
            {
                // you might want to log it, or swallow any exceptions here 
            }
        } 
}