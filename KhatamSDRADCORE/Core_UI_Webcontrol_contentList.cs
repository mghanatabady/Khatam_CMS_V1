using khatam.core.globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:contentList runat=server></{0}:contentList>")]
                public class contentList : CompositeControl
                {


                    static Button btnok = new Button();

                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();
                    

                    public string contentTable;

                    public string top;

                    public bool listMainImageVisible;

                    public bool headerVisible;

                    public bool headerImageVisible;

                    public int listMainImageSize;

                    public int listMainType;

                    public int headerImageSize;

                    public string headerContent;

                    public bool rssIconVisible;

                    public bool descVisible;

                    public int sortMode;
                     public  DateTime pub_date;
                    

                    public string memo
                    {
                        get
                        {
                            String s = (String)ViewState["memotxt"];
                            return ((s == null) ? String.Empty : s);
                        }

                        set
                        {
                            ViewState["memotxt"] = value;
                        }
                    }


                    public Boolean showWin
                    {
                        get
                        {

                            Boolean s = (Boolean)ViewState["showWin"];
                            return s;


                        }

                        set
                        {
                            ViewState["showWin"] = value;
                        }
                    }

                    public string title
                    {
                        get
                        {
                            String s = (String)ViewState["textproperty"];
                            return ((s == null) ? String.Empty : s);
                        }

                        set
                        {
                            ViewState["textproperty"] = value;
                        }
                    }




                    public string txtBoxValue2
                    {
                        get
                        {
                            TextBox txtboxt2 = (TextBox)this.FindControl("txtbox" + instanceID);

                            return txtboxt2.Text;
                        }
                        set
                        {
                            TextBox txtboxt2 = (TextBox)this.FindControl("txtbox" + instanceID);

                            txtboxt2.Text = value;
                        }
                    }



                    public string fckvalue3
                    {
                        get
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            return fck1.Text;
                        }
                        set
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            fck1.Text = value;
                        }
                    }


         


                    public string texthf
                    {
                        get
                        {
                            TextBox textb = (TextBox)this.FindControl("Text1" + instanceID);

                            return textb.Text;
                        }
                        set
                        {
                            TextBox textb = (TextBox)this.FindControl("Text1" + instanceID);

                            textb.Text = value;
                        }
                    }




                    public string windowsMode;

                    public string instanceID;


                    public Boolean winVisible;

                    public bool editMode;
                    public bool Demo;






                    protected override void CreateChildControls()
                    {


                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));


                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  + "editor.aspx?instanceID=" + instanceID + "&mode=8\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }
                         





                        //if (editMode) this.Controls.Add(new LiteralControl(khatam.core.Drawing.EditorWin.EditBorderOpen(instanceID,windowsMode )));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));

                        string contentUrl;

                        string tmp_contentTable="";
                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                            tmp_contentTable = "estate";
                        else
                            tmp_contentTable = contentTable;

                        contentUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + tmp_contentTable + "/";

                        string str_title = "<a class=\"winCaption\" href=\"" + contentUrl + "\">" + title + "</a>";

                        if (rssIconVisible)
                            str_title = str_title + "<a class=\"winCaption\" href=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                                "rss.ashx?type=" + contentTable
                                + "\">" + 
                                " <img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + 
                                 "core/themeCP/Bitrix/CssImage/btn/rss.png\" /> " + "</a>";

                        this.Controls.Add(new LiteralControl(str_title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));

                       


                        if (headerVisible) this.Controls.Add(ContentListHeader());
                        
                        if (listMainType == 1) this.Controls.Add(ContentListMainGridDetails());
                        if (listMainType == 2) this.Controls.Add(ContentListMainGridThumbnail() );
                        if (listMainType == 3) this.Controls.Add(ContentListSimpleSlider());
                        if (listMainType == 4) this.Controls.Add(ContentListPagingSlider());
                        //if (listMainType == 5) this.Controls.Add(ContentListSlideUP());
                        //if (listMainType == 6) this.Controls.Add(ContentListNewsTickers());
             
                        //this.Controls.Add(ContentListSimpleSlider());


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));


                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));

                        
                        //if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        //if (editMode) this.Controls.Add(new LiteralControl(khatam.core.Drawing.EditorWin.EditPopupScript(instanceID)));
                        //if (editMode) this.Controls.Add(editwinpop());



                    }


                    protected void btnAddSave_Click(object sender, EventArgs e)
                    {
                        Page.Validate("Add");

                        if (Page.IsValid)
                        {
                            //Names.Add(Guid.NewGuid(), txtNewName.Text);
                            //LoadNames();
                            CloseDialog("newPerson" + instanceID);

                            //reset
                            ///txtNewName.Text = string.Empty;

                            khatam.core.data.sql.InstanceValSet(instanceID, "title", txtBoxValue2);

                            DropDownList ODDLwin = new DropDownList();

                            ODDLwin = (DropDownList)FindControl("DDLwin" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "windowsMode", ODDLwin.SelectedValue);



                          

                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            TextBox txtTop = new TextBox();
                            txtTop = (TextBox)FindControl("txttop" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "top", txtTop.Text);


                            DropDownList ODDLtype = new DropDownList();

                            ODDLwin = (DropDownList)FindControl("DDLtype" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "contentTable", ODDLwin.SelectedValue);

                            CheckBox Ochkbox1 = new CheckBox();
                            Ochkbox1 = (CheckBox)FindControl("chkbox1" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "listMainImageVisible", Ochkbox1.Checked.ToString());



                            DropDownList ODLLMainImageSize = new DropDownList();

                            ODLLMainImageSize = (DropDownList)FindControl("DLLMainImageSize" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "listMainImageSize", ODLLMainImageSize.SelectedValue);


                            CheckBox OchkboxheaderVisible = new CheckBox();

                            OchkboxheaderVisible = (CheckBox)FindControl("chkboxheaderVisible" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "headerVisible", OchkboxheaderVisible.Checked.ToString());

                            TextBox OtbHeaderContent = new TextBox();
                            OtbHeaderContent = (TextBox)FindControl("tbHeaderContent" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "headerContent", OtbHeaderContent.Text);
                            //tbHeaderContent


                            DropDownList ODLLHeaderImageSize = new DropDownList();
                            ODLLHeaderImageSize = (DropDownList)FindControl("DLLHeaderImageSize" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "headerImageSize", ODLLHeaderImageSize.SelectedValue);


                            CheckBox OchkboxHeaderImageVisible = new CheckBox();
                            OchkboxHeaderImageVisible = (CheckBox)FindControl("chkboxHeaderImageVisible" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "headerImageVisible", OchkboxHeaderImageVisible.Checked.ToString());


                            DropDownList ODDLlistMainType = new DropDownList();
                            ODDLlistMainType = (DropDownList)FindControl("DDLlistMainType" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "listMainType", ODDLlistMainType.SelectedValue);



                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }

                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }


                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "contentTable", "news", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "top", "10", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "headerContent", "1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "headerType", "1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "headerImageSize", "1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "listMainImageVisible", "False", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "listMainImageSize", "2", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "headerVisible", "False", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "headerImageVisible", "False", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "listMainType", "1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "rssIconVisible", "False", "Core_serverControlsInstanceVal", null);

                        khatam.core.data.sql.addPropertyRow(Instance, "descVisible", "false", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "sortMode", "1", "Core_serverControlsInstanceVal", null);



                 

                        // F# listMainDescriptionVisible


                        return "added";
                    }


           


                    public Control ContentListHeader()
                    {

                        string id;
                        string imageUrl, temp2;

                        id = headerContent;
                        PlaceHolder ph = new PlaceHolder();


                        if (khatam.core.data.sql.Sql_Check_identity("id", id, contentTable,
                            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) == false )
                        {
                            string titlef = khatam.core.data.sql.getField("title", "id", id, contentTable);

                            string imageName = khatam.core.data.sql.getField( "image", "id", id, contentTable);

                            string description = khatam.core.data.sql.getField( "description", "id", id, contentTable);

                            //string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);



                            ph.Controls.Add(new LiteralControl("<div  style=\" display:  inline-block; margin-bottom:10px; margin-right:10px \">"));


                            if (headerImageVisible)
                            {
                                ph.Controls.Add(new LiteralControl("<div style=\"float:right; margin-left:10px \">"));
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + headerImageSize + "/" + imageName;
                                temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>";
                                ph.Controls.Add(new LiteralControl(temp2));
                                ph.Controls.Add(new LiteralControl("</div>"));
                            }


                            ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify\">"));

                            ph.Controls.Add(new LiteralControl("<a class=\"public_Link\" href=\"" + url + "\">"));
                            ph.Controls.Add(new LiteralControl(titlef));
                            ph.Controls.Add(new LiteralControl(" </a>"));
                            ph.Controls.Add(new LiteralControl("<br />"));
                            ph.Controls.Add(new LiteralControl(description));
                            ph.Controls.Add(new LiteralControl("</div>"));
                            ph.Controls.Add(new LiteralControl("</div>"));
                        }
                        else
                        {
                            ph.Controls.Add(new LiteralControl("<br />"));
                            ph.Controls.Add(new LiteralControl("محتوای مورد نظر برای هدر یافت نشد"));
                            
                        }

                        return ph;

                    }


                    public Control ContentListMainGridDetails()
                    {

                        DataTable dt = new DataTable();

                        dt = khatam.core.data.sql.getTableContent(contentTable, int.Parse(top), sortMode );


                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                        {
                            contentTable = "estate";
                         
                        }
                                                
                        
                        PlaceHolder ph = new PlaceHolder();




                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string titlef = dt.Rows[i].ItemArray[1].ToString();
                            string imageUrl = dt.Rows[i].ItemArray[2].ToString();
                            string id = dt.Rows[i].ItemArray[0].ToString();
                            string description = dt.Rows[i].ItemArray[3].ToString();

                            try
                            {
                              pub_date = DateTime.Parse(dt.Rows[0].ItemArray[4].ToString());
                            }
                            catch
                            {

                            }



                            string  timeStr= "";
                      // if (ci.pub_date != null) { timeStr = khatam.core.globalization.dateTime.GetPersianDateTime(ci.pub_date  ); };
                       try
                       {
                           if (pub_date  > DateTime.MinValue)
                           {
                               timeStr =
                                   numbers.GetPersianNumbers(dateTime.GetPersianDate (pub_date));
                           };
                       }
                       catch
                       {
                       }

                           

                            //ph.Controls.Add(new LiteralControl(" <div>sssssss"));    





                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                            {
                                 imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo" +  listMainImageSize  + ".jpg";
                            }
                            else
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + listMainImageSize + "/" + dt.Rows[i].ItemArray[2].ToString();
                            }


                            // ph.Controls.Add(new LiteralControl("<div class=\"slam\">"));
                            string temp2;
                            //temp2 = "<img alt=\"\" src=\"images/check_green.gif\" />";

                            //##ph.Controls.Add(new LiteralControl("<div>"));



                            //ph.Controls.Add(new LiteralControl(temp2));

                            //##   ph.Controls.Add(new LiteralControl("   <div>    <img style=\"width:30px;height:60px;vertical-align:middle ; \" >   Works. </div> ")) ;

                            //ph.Controls.Add(new LiteralControl("<a class=\"contentList_Link\" href=\"" + url + "\">" + temp2 + titlef + "</a>"));
                            //##ph.Controls.Add(new LiteralControl("<a class=\"contentList_Link\" href=\"" + url + "\">" + titlef + "</a>"));
                            //##ph.Controls.Add(new LiteralControl("</div>"));

                            //ph.Controls.Add(new LiteralControl("<br />"));

                            // ph.Controls.Add(new LiteralControl(" </div>"));  

                            ph.Controls.Add(new LiteralControl("<a class=\"contentList_Link\" href=\"" + url + "\">"));

                            ph.Controls.Add(new LiteralControl("<div  style=\"width: 100%; display:  inline-block; \" >"));

                            //ph.Controls.Add(new LiteralControl("<div  style=\"float:right ; width: "  +  khatam.core.Drawing.image.getSizeStandard(7).height   +  "px  \">"));



                            if (listMainImageVisible)
                            {

                                ph.Controls.Add(new LiteralControl("<div  style=\"float:right;  width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width + 10) + "px  ;  height:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).height + 10) + "px   \" >"));

                                temp2 = "  <img alt=\"\"  ;  src=\"" + imageUrl + "\"  />";

                                ph.Controls.Add(new LiteralControl(temp2));
                                ph.Controls.Add(new LiteralControl(" </div>"));
                            }

                            ph.Controls.Add(new LiteralControl("<div>"));

                            ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentTitle\" >"));                            
                            ph.Controls.Add(new LiteralControl(titlef + " - " + timeStr ));
                            ph.Controls.Add(new LiteralControl(" </div>"));


                            
                            //شرح خبر تست 1</div>
                            if (descVisible)
                            {
                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentDesc\" >"));
                                ph.Controls.Add(new LiteralControl(description ));
                                ph.Controls.Add(new LiteralControl(" </div>"));

                            }

                            
                            ph.Controls.Add(new LiteralControl(" </div>"));


                            ph.Controls.Add(new LiteralControl(" </div>"));

                            ph.Controls.Add(new LiteralControl(" </a>"));


                        }

                        return ph;
                    }

                    public Control ContentListMainGridThumbnail()
                    {

                        DataTable dt = new DataTable();

                        dt = khatam.core.data.sql.getTableContent(contentTable, int.Parse(top), sortMode );

                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                        {
                            contentTable = "estate";

                        }

                        PlaceHolder ph = new PlaceHolder();

                        ph.Controls.Add(new LiteralControl(" <div  style=\"width: 100%; display:  inline-block; \" >"));



                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string titlef = dt.Rows[i].ItemArray[1].ToString();
                            string imageUrl = dt.Rows[i].ItemArray[2].ToString();
                            string id = dt.Rows[i].ItemArray[0].ToString();

                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                            {
                                 imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo" +  listMainImageSize  + ".jpg";
                            }
                            else
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + listMainImageSize + "/" + dt.Rows[i].ItemArray[2].ToString();
                            }

                            string temp2;

                            //ph.Controls.Add(new LiteralControl("<a class=\"contentList_Link\" href=\"" + url + "\">")); 


                            //ph.Controls.Add(new LiteralControl("<div  style=\"width: 100%; display:  inline-block; \" >"));


                            //##ph.Controls.Add(new LiteralControl("<div  style=\"width: 100px; height:100px ;   background-color:red ; float:right \" >"));

                            //ph.Controls.Add(new LiteralControl("<div  style=\"background-color: #FF0000; width: " + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width + 20) + "  px;   text-align:center ; float:right ; margin-top:10px \" >"));

                            ph.Controls.Add(new LiteralControl("<div  style=\" width: " + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize ).width  + 10) +  "px ;   text-align:center ; float:right ; margin-top:10px \" >"));

                            

                            if (listMainImageVisible)
                            {

                                // ph.Controls.Add(new LiteralControl("<div  style=\"float:right;  width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width + 10) + "px  ;  height:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).height) + "px   \" >"));

                                ph.Controls.Add(new LiteralControl("<div  style=\" width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width + 4) + "px  ;  height:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).height) + "px   \" >"));

                                

                                temp2 = "  <img alt=\"\"  ;  src=\"" + imageUrl + "\"  />";

                                temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>";


                                ph.Controls.Add(new LiteralControl(temp2));
                                ph.Controls.Add(new LiteralControl(" </div>"));
                            }

                            ph.Controls.Add(new LiteralControl("<div  style=\" padding-right: 5px; padding-left: 5px;\" >"));


                          
                            
                            // ph.Controls.Add(new LiteralControl(titlef));

                            ph.Controls.Add(new LiteralControl("<div >"));
                            ph.Controls.Add(new LiteralControl("<a  class=\"pagingGridDetailContentTitle\" href=\"" + url + "\">"));

                            ph.Controls.Add(new LiteralControl(titlef));
                            ph.Controls.Add(new LiteralControl(" </a>"));
                     
                           ph.Controls.Add(new LiteralControl(" </div>"));


                            ph.Controls.Add(new LiteralControl(" </div>"));


                            ph.Controls.Add(new LiteralControl(" </div>"));

                            //    ph.Controls.Add(new LiteralControl(" </a>"));  


                        }


                        ph.Controls.Add(new LiteralControl(" </div>"));


                        return ph;
                    }

                    public Control ContentListSimpleSlider()
                    {

                        DataTable dt = new DataTable();

                        dt = khatam.core.data.sql.getTableContent(contentTable, int.Parse(top), sortMode);

                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                        {
                            contentTable = "estate";

                        }

                        PlaceHolder ph = new PlaceHolder();


                        ph.Controls.Add(new LiteralControl(" <div class=\"list_carousel\"> "));
                        ph.Controls.Add(new LiteralControl("  <ul id=\"foo2" + this.UniqueID + "\">  "));

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string titlef = dt.Rows[i].ItemArray[1].ToString();
                            string imageUrl = dt.Rows[i].ItemArray[2].ToString();
                            string id = dt.Rows[i].ItemArray[0].ToString();

                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo" + listMainImageSize + ".jpg";
                            }
                            else
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + listMainImageSize + "/" + dt.Rows[i].ItemArray[2].ToString();
                            }

                            string temp2;


                            ph.Controls.Add(new LiteralControl(" <li>"));
                            ph.Controls.Add(new LiteralControl("<div class=\"image_carousel_img\" style=\" width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width) + "px  ; \" >"));

                            if (listMainImageVisible)
                            {



                                temp2 = "  <img alt=\"\"  ;  src=\"" + imageUrl + "\"  />";

                                temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>";


                                ph.Controls.Add(new LiteralControl(temp2));

                            }
                            ph.Controls.Add(new LiteralControl(" <br/>"));

                            ph.Controls.Add(new LiteralControl("<a  class=\"pagingGridDetailContentTitle\" href=\"" + url + "\">"));
                            ph.Controls.Add(new LiteralControl(titlef));
                            ph.Controls.Add(new LiteralControl(" </a>"));

                            ph.Controls.Add(new LiteralControl(" </div>"));
                            ph.Controls.Add(new LiteralControl("</li>"));

                        }



                        string html1 = "				</ul> " +
                        "				<div class=\"clearfix\" ></div> " +
                        "<a id=\"next2" + this.UniqueID + "\" class=\"next\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +
                        "<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
                        "<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
                        "<a id=\"prev2" + this.UniqueID + "\" class=\"prev\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>";

                        //ph.Controls.Add(new LiteralControl(html1));

      



                        ph.Controls.Add(new LiteralControl(" </div>"));


                        /*     string html = "<div class=\"list_carousel\"> " +
     "<ul id=\"foo2" + this.UniqueID + "\">  ";
                             if (memo1show) html = html + "<li>" + memo1 + "</li> ";
                             if (memo2show) html = html + "<li>" + memo2 + "</li> ";
                             if (memo3show) html = html + "<li>" + memo3 + "</li> ";
                             if (memo4show) html = html + "<li>" + memo4 + "</li> ";
                             if (memo5show) html = html + "<li>" + memo5 + "</li> ";
                             if (memo6show) html = html + "<li>" + memo6 + "</li> ";
                             if (memo7show) html = html + "<li>" + memo7 + "</li> ";
                             if (memo8show) html = html + "<li>" + memo8 + "</li> ";
                             if (memo9show) html = html + "<li>" + memo9 + "</li> ";
                             if (memo10show) html = html + "<li>" + memo10 + "</li> ";
                             */
                        script1();
                        return ph;
                    }

                    public Control ContentListPagingSlider()
                    {

                        DataTable dt = new DataTable();

                        dt = khatam.core.data.sql.getTableContent(contentTable, int.Parse(top), sortMode);

                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                        {
                            contentTable = "estate";

                        }

                        PlaceHolder ph = new PlaceHolder();


                        ph.Controls.Add(new LiteralControl(" <div class=\"list_carousel\"> "));
                        ph.Controls.Add(new LiteralControl("  <ul id=\"foo2" + this.UniqueID + "\">  "));

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string titlef = dt.Rows[i].ItemArray[1].ToString();
                            string imageUrl = dt.Rows[i].ItemArray[2].ToString();
                            string id = dt.Rows[i].ItemArray[0].ToString();

                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo" + listMainImageSize + ".jpg";
                            }
                            else
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + listMainImageSize + "/" + dt.Rows[i].ItemArray[2].ToString();
                            }

                            string temp2;

                   
                            ph.Controls.Add(new LiteralControl(" <li>"));
                            ph.Controls.Add(new LiteralControl("<div class=\"image_carousel_img\" style=\" width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width) + "px  ; \" >"));

                            if (listMainImageVisible)
                            {                



                                temp2 = "  <img alt=\"\"  ;  src=\"" + imageUrl + "\"  />";

                                temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>";


                                ph.Controls.Add(new LiteralControl(temp2));

                            }
                            ph.Controls.Add(new LiteralControl(" <br/>"));

                            ph.Controls.Add(new LiteralControl("<a  class=\"pagingGridDetailContentTitle\"  href=\"" + url + "\">"));
                            ph.Controls.Add(new LiteralControl(titlef));
                            ph.Controls.Add(new LiteralControl(" </a>"));

                            ph.Controls.Add(new LiteralControl(" </div>"));
                            ph.Controls.Add(new LiteralControl("</li>"));   

                        }



                        string html1 =   "				</ul> " +
                        "				<div class=\"clearfix\" style=\"	margin: 5px;\"></div> " +
                        "<a id=\"next2" + this.UniqueID + "\" class=\"next\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +
                        "<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
                        "<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
                        "<a id=\"prev2" + this.UniqueID + "\" class=\"prev\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>" ;

                        ph.Controls.Add(new LiteralControl(html1));

                        string html2 = "<div class=\"clearfix\"></div>"
+ " <a class=\"prev3\" id=\"foo2_prev\" href=\"#\"><span>prev</span></a>"
+ " <a class=\"next3\" id=\"foo2_next\" href=\"#\"><span>next</span></a>";
//+ " <div class=\"pagination3\" id=\"foo2_pag\"></div>";

                      //  ph.Controls.Add(new LiteralControl(html2));
                        string html3 = "				</ul> " +
"				<div class=\"clearfix\"></div> " +
"<a id=\"next3" + this.UniqueID + "\" class=\"next3\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +
"<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
"<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
"<a id=\"prev3" + this.UniqueID + "\" class=\"prev3\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>";

                        //ph.Controls.Add(new LiteralControl(html3));



                        ph.Controls.Add(new LiteralControl(" </div>"));

                        
                   /*     string html = "<div class=\"list_carousel\"> " +
"<ul id=\"foo2" + this.UniqueID + "\">  ";
                        if (memo1show) html = html + "<li>" + memo1 + "</li> ";
                        if (memo2show) html = html + "<li>" + memo2 + "</li> ";
                        if (memo3show) html = html + "<li>" + memo3 + "</li> ";
                        if (memo4show) html = html + "<li>" + memo4 + "</li> ";
                        if (memo5show) html = html + "<li>" + memo5 + "</li> ";
                        if (memo6show) html = html + "<li>" + memo6 + "</li> ";
                        if (memo7show) html = html + "<li>" + memo7 + "</li> ";
                        if (memo8show) html = html + "<li>" + memo8 + "</li> ";
                        if (memo9show) html = html + "<li>" + memo9 + "</li> ";
                        if (memo10show) html = html + "<li>" + memo10 + "</li> ";
                        */
                        script1();
                        return ph;
                    }

                    public Control ContentListSlideUP()
                    {

                        DataTable dt = new DataTable();

                        dt = khatam.core.data.sql.getTableContent(contentTable, int.Parse(top), sortMode);

                        if ((contentTable == "estate_1") || (contentTable == "estate_2"))
                        {
                            contentTable = "estate";

                        }

                        PlaceHolder ph = new PlaceHolder();


                        ph.Controls.Add(new LiteralControl(" <div class=\"list_carousel\"> "));
                        ph.Controls.Add(new LiteralControl("  <ul id=\"foo2" + this.UniqueID + "\">  "));

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string titlef = dt.Rows[i].ItemArray[1].ToString();
                            string imageUrl = dt.Rows[i].ItemArray[2].ToString();
                            string id = dt.Rows[i].ItemArray[0].ToString();

                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + khatam.core.strings.Url.replaceTitleNonChar(titlef);

                            if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo" + listMainImageSize + ".jpg";
                            }
                            else
                            {
                                imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/" + listMainImageSize + "/" + dt.Rows[i].ItemArray[2].ToString();
                            }

                            string temp2;


                            ph.Controls.Add(new LiteralControl(" <li>"));
                         //   ph.Controls.Add(new LiteralControl("<div class=\"image_carousel_img\" style=\" width:" + (khatam.core.Drawing.image.getSizeStandard(listMainImageSize).width) + "px  ; \" >"));
                            ph.Controls.Add(new LiteralControl("<div class=\"image_carousel_img\" style=\" width:100%  ; \" >"));

                            if (listMainImageVisible)
                            {



                                temp2 = " rfff <img alt=\"\"  ;  src=\"" + imageUrl + "\"  />";

                                temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>";


                                ph.Controls.Add(new LiteralControl(temp2));

                            }
                            ph.Controls.Add(new LiteralControl(" <br/>"));

                            ph.Controls.Add(new LiteralControl("<a  class=\"pagingGridDetailContentTitle\" href=\"" + url + "\">"));
                            ph.Controls.Add(new LiteralControl(titlef));
                            ph.Controls.Add(new LiteralControl(" </a>"));

                            ph.Controls.Add(new LiteralControl(" </div>"));
                            ph.Controls.Add(new LiteralControl("</li>"));

                        }



                        string html1 = "				</ul> " +
                        "				<div class=\"clearfix\"></div> ";
                       // "<a id=\"next2" + this.UniqueID + "\" class=\"next\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +
                       // "<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
                       // "<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
                       // "<a id=\"prev2" + this.UniqueID + "\" class=\"prev\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>";

                        ph.Controls.Add(new LiteralControl(html1));





                        ph.Controls.Add(new LiteralControl(" </div>"));

                        scriptElastic();
                        return ph;
                    }

           

                    void html11()
                    {
                        string html = "<div class=\"list_carousel\"> " +
                        "<ul id=\"foo2" + this.UniqueID + "\">  ";
                      html = html + "<li> memo1 </li> ";
                        html = html + "<li> memo2 </li> ";
                         html = html + "<li> + memo3 </li> ";
                        html = html + "<li> + memo4 </li> ";
                         html = html + "<li> + memo5 </li> ";
                        html = html + "<li> + memo6 </li> ";
                        html = html + "<li> + memo7 </li> ";
                        html = html + "<li> + memo8 </li> ";
                       html = html + "<li> memo9 </li> ";
                       html = html + "<li> memo10 </li> ";

                        html = html + "				</ul> " +
"				<div class=\"clearfix\"></div> " +
"<a id=\"next2" + this.UniqueID + "\" class=\"next\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +
"<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
"<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
"<a id=\"prev2" + this.UniqueID + "\" class=\"prev\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>" +


        //	"<div id=\"pager2\" class=\"pager\"></div> " +
            "</div>";
                        this.Controls.Add(new LiteralControl(html));

                    }

                    void script1()
                    {
                        string html = " <script type=\"text/javascript\" language=\"javascript\"> "
                       + "$(document).ready(function () {"
                        + "$(\"#play" + this.UniqueID + "\").hide(); "
                            //+"//	Scrolled by user interaction"
                        + "$('#foo2" + this.UniqueID + "').carouFredSel({ "
                        + "auto: true, "
                        + "prev: '#prev2" + this.UniqueID + "', "
                        + "next: '#next2" + this.UniqueID + "', "
                        + "pagination: \"#pager2" + this.UniqueID + "\", "
                        + "mousewheel: true, "
                        + "swipe: { "
                        + "onMouse: true,	"
                        + "onTouch: true "
                        + "},  scroll:{ pauseOnHover: true}"
                        + "}); "
                        + "$(\"#pause" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"pause\"); "
                        + "$(\"#pause" + this.UniqueID + "\").hide(); "
                        + "$(\"#play" + this.UniqueID + "\").show(); "
                        + "});"
                        + "$(\"#play" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"play\"); "
                        + "$(\"#play" + this.UniqueID + "\").hide() ;"
                        + "$(\"#pause" + this.UniqueID + "\").show(); "
                        + "});"
                        + " }); </script>";



                        this.Controls.Add(new LiteralControl(html));

                    }

                    void script2()
                    {
                        string html = " <script type=\"text/javascript\" language=\"javascript\"> "
                       + "$(document).ready(function () {"
                        + "$(\"#play" + this.UniqueID + "\").hide(); "
                            //+"//	Scrolled by user interaction"
                        + "$('#foo2" + this.UniqueID + "').carouFredSel({ "
                        + "auto: true, direction:'up',"
                        + "prev: '#prev2" + this.UniqueID + "', "
                        + "next: '#next2" + this.UniqueID + "', "
                        + "pagination: \"#pager2" + this.UniqueID + "\", "
                        + "mousewheel: true, "
                        + "swipe: { "
                        + "onMouse: true,	"
                        + "onTouch: true "
                        + "},  scroll:{ pauseOnHover: true}"
                        + "}); "
                        + "$(\"#pause" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"pause\"); "
                        + "$(\"#pause" + this.UniqueID + "\").hide(); "
                        + "$(\"#play" + this.UniqueID + "\").show(); "
                        + "});"
                        + "$(\"#play" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"play\"); "
                        + "$(\"#play" + this.UniqueID + "\").hide() ;"
                        + "$(\"#pause" + this.UniqueID + "\").show(); "
                        + "});"
                        + " }); </script>";



                        this.Controls.Add(new LiteralControl(html));

                    }

                    void scriptElastic()
                    {
                        string html = " <script type=\"text/javascript\" language=\"javascript\"> "
                        + "$(document).ready(function () {"
                        + " $('#foo2" + this.UniqueID + "').carouFredSel({"
                        //+" items: 1,"
                        +" scroll: {"
                        +" duration: 2500,"
                        +" timeoutDuration: 1500,"
                        +" easing: 'elastic'"
                        +" }"
                        +" });"
                        //+ "});"
                        + " }); </script>";



                        this.Controls.Add(new LiteralControl(html));

                    }

                    void scriptUp()
                    {
                        string html = " <script type=\"text/javascript\" language=\"javascript\"> "
                        + "$(document).ready(function () {"
                        + " $('#foo2" + this.UniqueID + "').carouFredSel({"
                        + " items: 1,"
                        + " scroll: {"
                        + " duration: 2500,"
                        + " timeoutDuration: 1500,"
                        + " easing: 'elastic',   items: {		width: \"100%\"	}"
                        + " }"
                        + " });"
                            //+ "});"
                        + " }); </script>";



                        this.Controls.Add(new LiteralControl(html));

                    }

                    void script3()
                    {
                        string html = " <script type=\"text/javascript\" language=\"javascript\"> "
                       + "$(document).ready(function () {"
                        + "$(\"#play" + this.UniqueID + "\").hide(); "
                            //+"//	Scrolled by user interaction"
                        + "$('#foo2" + this.UniqueID + "').carouFredSel({ "
                            //   + "auto: true, direction: \"up\","
                        + "auto: true, "
                        + "prev: '#prev2" + this.UniqueID + "', "
                        + "next: '#next2" + this.UniqueID + "', "
                        + "pagination: \"#pager2" + this.UniqueID + "\", "
                        + "mousewheel: true, "
                        + "items: 1, scroll: { duration: 2500, timeoutDuration: 1500, easing: 'elastic' } ,"

                        + "swipe: { "
                        + "onMouse: true,  	"
                        + "onTouch: true "


                        + "} "
                        + "}); "
                        + "$(\"#pause" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"pause\"); "
                        + "$(\"#pause" + this.UniqueID + "\").hide(); "
                        + "$(\"#play" + this.UniqueID + "\").show(); "
                        + "});"
                        + "$(\"#play" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"play\"); "
                        + "$(\"#play" + this.UniqueID + "\").hide() ;"
                        + "$(\"#pause" + this.UniqueID + "\").show(); "
                        + "});"
                        + " }); </script>";



                        this.Controls.Add(new LiteralControl(html));

                    }
     
     
                }
            }
        }
    }
}
