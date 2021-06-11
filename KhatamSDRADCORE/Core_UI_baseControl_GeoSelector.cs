using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;


namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace baseControl
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:GeoSelector runat=server></{0}:GeoSelector>")]
                public class GeoSelector : CompositeControl
                {

                    public bool editMode;
                 
                    public event EventHandler SubmitHandler;

                    public bool CpMode;

                    public bool searchAllMode;
                    public  bool searchEstateMode;
                    public int searchEstate_agreement_type;


                    private  int defaultCountryId;
                    private int defaultEstateId;
                    public int defaultCityId;
                    public string ordering;


                   public  geo _geo = new geo();

                    public struct geo
                    {
                        public int CountryId;
                        public int EstateId;
                        public int CityId;
                        public int AreaId;
                    }
                    

                    public string selectedCountry
                    {
                        get
                        {
                            DropDownList _ddl_country = ddl_country;

                            return _ddl_country.SelectedValue;
                        }
                  
                    }

                    public string selectedstate
                    {
                        get
                        {
                            DropDownList _ddl_state = ddl_state;

                            return _ddl_state.SelectedValue;
                        }

                    }

                    public string selectedcity
                    {
                        get
                        {
                            DropDownList _ddl_city = ddl_city;

                            return _ddl_city.SelectedValue;
                        }

                    }

                    public string selectedarea
                    {
                        get
                        {
                            DropDownList _ddl_area = ddl_area;

                            return _ddl_area.SelectedValue;
                        }

                        set
                        {
                            TextBox pass = (TextBox)this.FindControl("PasswordControl");

                            pass.Text = value;
                        }

                    }

                    public string PasswordValue
                    {
                        get
                        {
                            TextBox pass = (TextBox)this.FindControl("PasswordControl");

                            return pass.Text;
                        }
                        set
                        {
                            TextBox pass = (TextBox)this.FindControl("PasswordControl");

                            pass.Text = value;
                        }
                    }

                    DropDownList ddl_country = new DropDownList();
                    DropDownList ddl_state = new DropDownList();
                    DropDownList ddl_city = new DropDownList();
                    DropDownList ddl_area = new DropDownList();



                    protected override void CreateChildControls()
                    {
                        Panel ph = new Panel();


                        string fieldCssClass = "";

                        if (ordering == "1") fieldCssClass = "field_horizontal";
                        if (ordering == "2") fieldCssClass = "field_vertical";


             
                        /**************************************************/

                        ph.Controls.Add(new LiteralControl("<div class=\"search_rows\">"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">کشور</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));

                        ddl_country.ID = "countryDropdown1" ;
                        ddl_country.DataValueField = "id";
                        ddl_country.DataTextField = "title";
                        ddl_country.Font.Name = "tahoma";
                        ddl_country.DataBound += ddl_country_OnDataBound;


                        ddl_country.SelectedIndexChanged += ddl_country_SelectedIndexChanged;

                        ddl_country.AutoPostBack = true;
                        ph.Controls.Add(ddl_country);

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        /*************************************************/

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">استان / ایالت</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));

                        ddl_state.ID = "stateDropdown1" ;
                        ddl_state.SelectedIndexChanged += ddl_state_SelectedIndexChanged;
                        ddl_state.DataValueField = "id";
                        ddl_state.DataTextField = "title";
                        ddl_state.Font.Name = "tahoma";
                        ddl_state.DataBound += ddl_state_OnDataBound;

                        ddl_state.AutoPostBack = true;                

                        ph.Controls.Add(ddl_state);

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        /************************************************/
                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">شهر / شهرستان</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));

                        ddl_city.ID = "cityDropdown1" ;
                        ddl_city.SelectedIndexChanged += ddl_city_SelectedIndexChanged;
                        ddl_city.DataValueField = "id";
                        ddl_city.DataTextField = "title";
                        ddl_city.Font.Name = "tahoma";
                        ddl_city.DataBound += ddl_city_OnDataBound;


                        ddl_city.AutoPostBack = true;
                        ph.Controls.Add(ddl_city);

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));


                         /***********************************************/

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">محدوده</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        ddl_area.ID = "areaDropdown1";
                        ddl_area.DataValueField = "id";
                        ddl_area.DataTextField = "title";
                        ddl_area.AutoPostBack = true;
                        ddl_area.Font.Name = "tahoma";
                        ddl_area.DataBound += ddl_area_OnDataBound;


                        ph.Controls.Add(ddl_area);

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));


                        ph.Controls.Add(new LiteralControl("</div>"));


                          if (_geo.AreaId  != 0) 
                          {
                              _geo.CityId = int.Parse(khatam.core.data.sql.getField("country_state_city_id", "country_state_city_area_id", _geo.AreaId.ToString(), "core_country_state_city_area"));
                              _geo.EstateId = int.Parse(khatam.core.data.sql.getField("country_state_id", "country_state_city_id", _geo.CityId.ToString(), "core_country_state_city"));
                              _geo.CountryId = int.Parse(khatam.core.data.sql.getField("country_country_id", "country_state_id", _geo.EstateId.ToString(), "core_country_state"));

                          }
                          else if (_geo.CityId  != 0) 
                          {
                              _geo.EstateId = int.Parse(khatam.core.data.sql.getField("country_state_id", "country_state_city_id", _geo.CityId.ToString(), "core_country_state_city"));
                              _geo.CountryId = int.Parse(khatam.core.data.sql.getField("country_country_id", "country_state_id", _geo.EstateId.ToString(), "core_country_state"));
                          }
                          else if (_geo.EstateId != 0) 
                          {                              
                              _geo.CountryId = int.Parse(khatam.core.data.sql.getField("country_country_id", "country_state_id", _geo.EstateId.ToString(), "core_country_state"));
                          }

                          // defaultCityId = 120;
                          //_geo.CityId = defaultCityId;
                          //_geo.EstateId  = int.Parse(khatam.core.data.sql.getField( "country_state_id", "country_state_city_id", defaultCityId.ToString(), "core_country_state_city"));
                          //_geo.CountryId = int.Parse(khatam.core.data.sql.getField( "country_country_id", "country_state_id", _geo.EstateId.ToString(), "core_country_state"));
                          //_geo.AreaId = 1;                               
                              
                          
                        ddl_country.DataSource = getCountrys();
                        ddl_country.DataBind();

                      
                         // DataBind();

                        //  if (!searchAllMode)
                        //  {
                              ddl_state.DataSource = getState(_geo.CountryId.ToString());
                              ddl_state.DataBind();

                              ddl_city.DataSource = getCity(_geo.EstateId.ToString());
                              ddl_city.DataBind();

                              ddl_area.DataSource = getArea(_geo.CityId.ToString());

                              ddl_area.DataBind();

                          //}

                          if (!Page.IsPostBack)
                          {
                              if (_geo.CountryId != 0)
                              {
                                  ddl_state.SelectedValue = _geo.EstateId.ToString();
                                  ddl_country.SelectedValue = _geo.CountryId.ToString();
                                  ddl_city.SelectedValue = _geo.CityId.ToString();


                                  ddl_area.SelectedValue = _geo.AreaId.ToString();
                              } 
                                  
                                  //setNotFounds(int.Parse(ddl_state.SelectedValue), int.Parse(ddl_city.SelectedValue), int.Parse(ddl_area.SelectedValue));

                          }

                          setNotFounds();


                      
                             // {
                             // ddl_country.SelectedIndex = 0;

                     
                          //}

                         /*************************************************/
                   //     UpdatePanel AjaxPanel = new UpdatePanel();
                    //    UpdateProgress alp = new UpdateProgress();
                    //    alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"RadControls/Ajax/Skins/Default/Loading1.gif\" />"));


                       // up.ID  = "up1";
                       // up.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                       // UpdateProgress uprogess = new UpdateProgress();
                       // uprogess.AssociatedUpdatePanelID = "up1" ;
                       // uprogess.Controls.Add(new LiteralControl ("در حال بارگذاری..."));

                        //alp.AssociatedUpdatePanelID = AjaxPanel.ClientID;
                        // }

                        //this.Controls.Add(alp);

                       // this.Controls.Add(uprogess);
                        //this.Controls.Add(ph);
                        //UpdatePanelTrigger upt ;
                        //(ddl_country.ClientID);
                       // AjaxPanel.Triggers.Add(upt )

                        //axPanel.ContentTemplateContainer.Controls.Add(ph);

                          UpdatePanel up = new UpdatePanel();

                         
                              AsyncPostBackTrigger trigger = new AsyncPostBackTrigger();
                              // associate the trigger with the drop down
                              trigger.ControlID = "countryDropdown1" ;
                              trigger.EventName = "SelectedIndexChanged";
                              // add the trigger to the update panel
                              up.Triggers.Add(trigger);

                              AsyncPostBackTrigger trigger1 = new AsyncPostBackTrigger();
                              // associate the trigger with the drop down
                              trigger1.ControlID = "stateDropdown1" ;
                              trigger1.EventName = "SelectedIndexChanged";
                              // add the trigger to the update panel
                              up.Triggers.Add(trigger1);

                              AsyncPostBackTrigger trigger2 = new AsyncPostBackTrigger();
                              // associate the trigger with the drop down
                              trigger2.ControlID = "cityDropdown1" ;
                              trigger2.EventName = "SelectedIndexChanged";
                              // add the trigger to the update panel
                            up.Triggers.Add(trigger2);

                              AsyncPostBackTrigger trigger3 = new AsyncPostBackTrigger();
                              // associate the trigger with the drop down
                              trigger3.ControlID = "areaDropdown1" ;
                              trigger3.EventName = "SelectedIndexChanged";
                              // add the trigger to the update panel
                              up.Triggers.Add(trigger3);

                         

                          up.ContentTemplateContainer.Controls.Add(ph);

                        this.Controls.Add(up);

                       

                        


                    }

                    protected void ddl_country_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        ddl_state.DataSource = getState(ddl_country.SelectedValue);
                       
                        ddl_state.DataBind();

                      

                            ddl_city.DataSource = getCity(ddl_state.SelectedValue);

                            ddl_city.DataBind();



                            ddl_area.DataSource = getArea(ddl_city.SelectedValue);

                            ddl_area.DataBind();

                      

                        setNotFounds();

                   
                    }

                    protected void ddl_country_OnDataBound(object sender, EventArgs e)
                    {
                        if (searchAllMode)
                        {
                            ListItem li0 = new ListItem();
                            li0.Text = "همه موارد";
                            li0.Value = "all";
                            ddl_country.Items.Insert(0, li0);
                        } 
                    }

                    protected void ddl_state_OnDataBound(object sender, EventArgs e)
                    {
                        if (searchAllMode)
                        {
                            if (ddl_state.Items.Count > 1)
                            {
                                ListItem li0 = new ListItem();
                                li0.Text = "همه موارد";
                                li0.Value = "all";
                                ddl_state.Items.Insert(0, li0);
                            }
                        }
                    }

                    protected void ddl_city_OnDataBound(object sender, EventArgs e)
                    {
                        if (searchAllMode)
                        {
                            if ((ddl_city.Items.Count > 0) && (ddl_city.Items[0].Value !="0" ))
                            {
                            ListItem li0 = new ListItem();
                            li0.Text = "همه موارد";
                            li0.Value = "all";
                            ddl_city.Items.Insert(0, li0);
                             }
                        }
                    }

                    protected void ddl_area_OnDataBound(object sender, EventArgs e)
                    {
                        if (searchAllMode)
                        {
                            if ((ddl_area.Items.Count > 0) && (ddl_area.Items[0].Value !="0" ))                           
                            {
                                ListItem li0 = new ListItem();
                                li0.Text = "همه موارد";
                                li0.Value = "all";
                                ddl_area.Items.Insert(0, li0);
                            }
                            
                        }
                    }

                    void setNotFounds()
                    {
                        ListItem li = new ListItem();
                        li.Text = "-";
                        li.Value = "0";

                        
                        ListItem li2 = new ListItem();
                        li2.Text = "انتخاب نشده";
                        li2.Value = "0";

                        if (ddl_state.Items.Count < 1)
                        {
                            
                            ddl_state.Items.Add(li);
                        }
                        else
                        {

                            if ((ddl_country.SelectedValue == _geo.CountryId.ToString()) && (_geo.EstateId == 0) && (!searchAllMode))
                            {
                                ddl_state.Items.Insert(0, li2);
                            }

                        }




                        if (ddl_city.Items.Count < 1)
                        {
                            ddl_city.Items.Add(li);
                        }
                        else
                        {
                            if ((ddl_country.SelectedValue == _geo.CountryId.ToString()) && 
                                (ddl_state.SelectedValue == _geo.EstateId.ToString()) &&
                                (_geo.CityId == 0) && (!searchAllMode))
                            {
                                ddl_city.Items.Insert(0, li2);
                            }

                           
                        }

                        if (ddl_area.Items.Count < 1)
                        {
                            ddl_area.Items.Add(li);
                        }
                        else
                        {
                            if ((ddl_country.SelectedValue == _geo.CountryId.ToString()) &&
                           (ddl_state.SelectedValue == _geo.EstateId.ToString()) &&
                           (ddl_city.SelectedValue == _geo.CityId.ToString()) &&
                           (_geo.AreaId == 0) && (!searchAllMode))
                            {
                                ddl_area.Items.Insert(0, li2);
                            }


                           
                        }

                    }

                    protected void ddl_state_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        ddl_city.DataSource = getCity(ddl_state.SelectedValue);

                        ddl_city.DataBind();


                      

                            ddl_area.DataSource = getArea(ddl_city.SelectedValue);

                            ddl_area.DataBind();
                        
                        
                        setNotFounds();

                    


                    }



                    protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        ddl_area.DataSource = getArea(ddl_city.SelectedValue);
                        //ddl_area.DataSource = getArea("47");
                        ddl_area.DataBind();

                 
                     

                        setNotFounds();


                    }


                    public DataTable getCountrys()
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                      

                        //parameters.Add("field_where_value", field_where_value);
                        // searchHasEstateMode
                        if (searchEstateMode)
                        {
                            string strDate;
                            strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                            str_sql = "SELECT DISTINCT core_country.country_id AS id, Dictionary_Lang.title " +
                            " FROM         Dictionary_Lang INNER JOIN " +
                            " core_country ON Dictionary_Lang.id_dictionary = core_country.dictionary_id INNER JOIN " +
                            " estate ON core_country.country_id = estate.country_id INNER JOIN " +
                            " Cat ON estate.id = Cat.id_content " +
                            " WHERE     (Dictionary_Lang.id_language = 1) AND (Cat.type_content = N'estate') AND (estate.agreement_type = " + searchEstate_agreement_type 
                            + ") AND (estate.enable = 1) AND (Cat.Valid = 1) AND    (Cat.showTime < CONVERT(DATETIME, '" + strDate  + "', 102)) AND (Cat.deleted = 0)"; 
                        }
                        else
                        {
                            str_sql = "SELECT core_country.country_id as id, Dictionary_Lang.title FROM Dictionary_Lang INNER JOIN core_country ON Dictionary_Lang.id_dictionary = core_country.dictionary_id WHERE (Dictionary_Lang.id_language = 1)";
                        }
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    public DataTable getState(string country_country_id)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    

                        parameters.Add("country_country_id", country_country_id);
                        if (searchEstateMode )
                        {
                                string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 
                            str_sql = "SELECT DISTINCT core_country_state.country_state_id AS id, Dictionary_Lang.title"
                              + " FROM Dictionary_Lang INNER JOIN"
                              + " core_country_state ON Dictionary_Lang.id_dictionary = core_country_state.dictionary_id INNER JOIN"
                              + " estate ON core_country_state.country_state_id = estate.country_state_id INNER JOIN"
                              + " Cat ON estate.id = Cat.id_content"
                              + " WHERE (Dictionary_Lang.id_language = 1) AND (core_country_state.country_country_id = @country_country_id) AND (Cat.type_content = N'estate') AND "
                              + " (estate.agreement_type = " + searchEstate_agreement_type + ") AND (estate.enable = 1) AND (Cat.Valid = 1) AND (Cat.showTime < CONVERT(DATETIME, '"
                              + strDate + "', 102)) AND (Cat.deleted = 0)";
                        }
                        else
                        {
                            str_sql = "SELECT core_country_state.country_state_id as id, Dictionary_Lang.title FROM Dictionary_Lang INNER JOIN core_country_state ON Dictionary_Lang.id_dictionary = core_country_state.dictionary_id WHERE (Dictionary_Lang.id_language = 1) AND (core_country_state.country_country_id = @country_country_id)";

                        }
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    public DataTable getCity(string country_state_id)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("country_state_id", country_state_id);
                        if (searchEstateMode)
                        {
                                string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                            str_sql = "SELECT DISTINCT core_country_state_city.country_state_city_id AS id, Dictionary_Lang.title"
+" FROM core_country_state_city INNER JOIN"
+" Dictionary_Lang ON core_country_state_city.dictionary_id = Dictionary_Lang.id_dictionary INNER JOIN"
+" estate ON core_country_state_city.country_state_city_id = estate.country_state_city_id INNER JOIN"
+" Cat ON estate.id = Cat.id_content"
+" WHERE (Dictionary_Lang.id_language = 1) AND (core_country_state_city.country_state_id = @country_state_id) AND (Cat.type_content = N'estate') AND "
+" (estate.agreement_type = " + searchEstate_agreement_type + ") AND (estate.enable = 1) AND (Cat.Valid = 1) AND (Cat.showTime < CONVERT(DATETIME, '"
                              + strDate + "', 102)) AND (Cat.deleted = 0)";




                        }
                        else
                        {
                            str_sql = "SELECT core_country_state_city.country_state_city_id as id, Dictionary_Lang.title FROM core_country_state_city INNER JOIN Dictionary_Lang ON core_country_state_city.dictionary_id = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) AND (core_country_state_city.country_state_id = @country_state_id)";
                        }
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    public DataTable getArea(string country_state_city_id)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("country_state_city_id", country_state_city_id);
                        if (searchEstateMode)
                        {
                                           string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                            str_sql = "SELECT DISTINCT core_country_state_city_area.country_state_city_area_id AS id, Dictionary_Lang.title"
+" FROM core_country_state_city_area INNER JOIN"
+" Dictionary_Lang ON core_country_state_city_area.dictionary_id = Dictionary_Lang.id_dictionary INNER JOIN"
+" estate ON core_country_state_city_area.country_state_city_area_id = estate.core_country_state_city_area_id INNER JOIN"
+" Cat ON estate.id = Cat.id_content"
+" WHERE (core_country_state_city_area.country_state_city_id = @country_state_city_id) AND (Cat.type_content = N'estate') AND (estate.agreement_type = " + searchEstate_agreement_type  + ") AND "
+" (estate.enable = 1) AND (Cat.Valid = 1) AND (Cat.showTime < CONVERT(DATETIME, '"+ strDate + "', 102)) AND (Cat.deleted = 0)"
+" GROUP BY core_country_state_city_area.country_state_city_area_id, Dictionary_Lang.title";
                                ;
                        }
                        else
                        {
                            str_sql = "SELECT      core_country_state_city_area.country_state_city_area_id as id, Dictionary_Lang.title  FROM         core_country_state_city_area INNER JOIN                  Dictionary_Lang ON core_country_state_city_area.dictionary_id = Dictionary_Lang.id_dictionary WHERE     (core_country_state_city_area.country_state_city_id = @country_state_city_id)";                        }
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }



                    void Submit_Click(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);

                    }


                }
            }
        }
    }
}
