using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient ;


/// <summary>
/// Summary description for loadercore
/// </summary>

namespace khatam
{
    namespace core
    {
        namespace UI
        {
           

                public static class ObjectManager
                {
                    
                    public static Control ControlsDic(string title, string instanceId, string languageID, bool editMode,bool tabed, string theme)
                    {
                        bool Demo;
                        Demo = khatam.core.ConfigurationManager.License.demo;
                        try
                        {



                            switch (title)
                            {



                                case "khatam.core.UI.WebControls.Menu": case "3":
                                    khatam.core.UI.WebControls.Menu Omenu = new khatam.core.UI.WebControls.Menu();

                                    DataTable dt = new DataTable();
                                    dt = getinstanceProperty(instanceId, languageID);
                                    int length;
                                    length = dt.Rows.Count;
                                    //Omenu.winVisible = true;
                                    Omenu.instanceID = instanceId;
                                    Omenu.Demo = Demo;
                                    Omenu.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("skin" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Omenu.skin = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("Width" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Omenu.WidthMenu = dt.Rows[i].ItemArray[3].ToString();

                                        }


                                        ;
                                    }

                                    return Omenu;








                               // case "khatam.core.UI.WebControls.footer":
                                 //   khatam.core.UI.WebControls.footer Ofooter = new khatam.core.UI.WebControls.footer();
                                  //  return Ofooter;
                                case "khatam.core.UI.WebControls.TreeCat":case "6":
                                    khatam.core.UI.WebControls.TreeCat OtreeCat = new khatam.core.UI.WebControls.TreeCat();
                                    return OtreeCat;

                                case "khatam.core.UI.WebControls.contentWin": case "8":
                                    khatam.core.UI.WebControls.contentWin OcontentWin = new khatam.core.UI.WebControls.contentWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OcontentWin.winVisible = true;
                                    OcontentWin.instanceID = instanceId;

                                    OcontentWin.Demo = Demo;
                                    OcontentWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {

                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) OcontentWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) OcontentWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OcontentWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OcontentWin;



                                case "khatam.core.UI.WebControls.contentList":  case "12":
                                    khatam.core.UI.WebControls.contentList ocontentList = new khatam.core.UI.WebControls.contentList();

                                    length = 0;

                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    ocontentList.winVisible = true;
                                    ocontentList.instanceID = instanceId;
                                    ocontentList.Demo = Demo;
                                    ocontentList.editMode = editMode;
                                    

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) ocontentList.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) ocontentList.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("contentTable" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.contentTable = dt.Rows[i].ItemArray[3].ToString();
                                        }

                                        if ("top" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.top = dt.Rows[i].ItemArray[3].ToString();


                                        }

                                        if ("listMainImageVisible" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.listMainImageVisible = bool.Parse( dt.Rows[i].ItemArray[3].ToString());

                                          //  ocontentList.listMainImageVisible = false;
                                        }

                                        if ("listMainImageSize" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.listMainImageSize =int.Parse( dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }


                                        if ("headerVisible" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.headerVisible = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }


                                        if ("headerContent" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.headerContent = dt.Rows[i].ItemArray[3].ToString();

                                            //  ocontentList.listMainImageVisible = false;
                                        }


                                        if ("headerImageSize" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.headerImageSize =int.Parse( dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }


                                        if ("headerImageVisible" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.headerImageVisible = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }

                                        if ("listMainType" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.listMainType = int.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }

                                        if ("rssIconVisible" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.rssIconVisible = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }

                                        if ("descVisible" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.descVisible = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }

                                        if ("sortMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentList.sortMode = int.Parse(dt.Rows[i].ItemArray[3].ToString());

                                            //  ocontentList.listMainImageVisible = false;
                                        }

                               
                                        
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return ocontentList;


                                case "khatam.core.UI.WebControls.loginWin":
                                case "15":
                                    khatam.core.UI.WebControls.loginWin OloginWin = new khatam.core.UI.WebControls.loginWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OloginWin.winVisible = true;
                                    OloginWin.instanceID = instanceId;
                                    OloginWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OloginWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OloginWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OloginWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OloginWin;


                                case "khatam.core.UI.WebControls.contentPaging":
                                case "13":
                                    khatam.core.UI.WebControls.contentPaging ocontentPaging = new khatam.core.UI.WebControls.contentPaging();

                                    length = 0;

                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    ocontentPaging.winVisible = true;
                                    ocontentPaging.instanceID = instanceId;
                                    ocontentPaging.editMode = editMode;
                                    


                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentPaging.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentPaging.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentPaging.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("sortType" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            ocontentPaging.sortType  = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        //if ("contentTable" == dt.Rows[i].ItemArray[2].ToString())
                                        //{
                                        //   ocontentPaging.contentTable = dt.Rows[i].ItemArray[3].ToString();


                                        //}
                                        //
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return ocontentPaging;


                                case "khatam.core.UI.WebControls.contentItemWin":
                                case "14":
                                    khatam.core.UI.WebControls.contentItemWin OcontentItemWin = new khatam.core.UI.WebControls.contentItemWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OcontentItemWin.winVisible = true;
                                    OcontentItemWin.instanceID = instanceId;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            //OcontentItemWin.title = dt.Rows[i].ItemArray[3].ToString();

                                            //OcontentItemWin.title =  khatam.core.data.sql.getField("title", "id", "1", "article", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OcontentItemWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        //if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        //{
                                        //OcontentItemWin.memo = khatam.core.data.sql.getField("page", "id", "1", "article", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                                        //}

                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OcontentItemWin;

                                



                                case "khatam.core.UI.WebControls.shopCart":
                                case "18":
                                    khatam.core.UI.WebControls.shopCart OshopCart = new khatam.core.UI.WebControls.shopCart();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OshopCart.winVisible = true;
                                    OshopCart.instanceID = instanceId;


                                    // OshopCart.Demo = Demo;
                                    // OshopCart.editMode = editMode;

                                    OshopCart.title = "سبد خرید";


                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            // Ocarousel.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OshopCart.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            //Ocarousel.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }




                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OshopCart;

                                case "khatam.core.UI.WebControls.seacrhWin":
                                case "19":
                                    khatam.core.UI.WebControls.seacrhWin OseacrhWin = new khatam.core.UI.WebControls.seacrhWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OseacrhWin.winVisible = true;
                                    OseacrhWin.instanceID = instanceId;


                                    OseacrhWin.Demo = Demo;
                                    OseacrhWin.editMode = editMode;


                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                             OseacrhWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OseacrhWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OseacrhWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        OseacrhWin.theme = theme;
                                        ;
                                    }




                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OseacrhWin;



                                case "khatam.core.UI.WebControls.membrshipWin":
                                case "20":
                                    khatam.core.UI.WebControls.membrshipWin OmembrshipWin = new khatam.core.UI.WebControls.membrshipWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OmembrshipWin.winVisible = true;
                                    OmembrshipWin.instanceID = instanceId;

                                    //OmembrshipWin.Demo = Demo;
                                    //OmembrshipWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OmembrshipWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OmembrshipWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OmembrshipWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OmembrshipWin;


                                case "khatam.core.UI.WebControls.commentWin":
                                case "21":
                                    khatam.core.UI.WebControls.commentWin OcommentWin = new khatam.core.UI.WebControls.commentWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OcommentWin.winVisible = true;
                                    OcommentWin.instanceID = instanceId;

                                    OcommentWin.Demo = Demo;
                                    OcommentWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OcommentWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OcommentWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OcommentWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OcommentWin;



                              


                                case "khatam.core.UI.WebControls.domainSearchWin":
                                case "23":
                                    khatam.core.UI.WebControls.domainSearchWin OdomainSearchWin = new khatam.core.UI.WebControls.domainSearchWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OdomainSearchWin.winVisible = true;
                                    OdomainSearchWin.instanceID = instanceId;

                                    OdomainSearchWin.Demo = Demo;
                                    OdomainSearchWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdomainSearchWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdomainSearchWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdomainSearchWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("showPriceTable" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdomainSearchWin.showPriceTable =bool.Parse( dt.Rows[i].ItemArray[3].ToString());

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OdomainSearchWin;


                                case "khatam.core.UI.WebControls.formPlaceHolder":
                                case "24":
                                    khatam.core.UI.WebControls.formPlaceHolder OformPlaceHolder = new khatam.core.UI.WebControls.formPlaceHolder();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OformPlaceHolder.winVisible = true;
                                    OformPlaceHolder.instanceID = instanceId;

                                    OformPlaceHolder.Demo = Demo;
                                    OformPlaceHolder.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OformPlaceHolder.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OformPlaceHolder.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OformPlaceHolder.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }



                                        if ("formID" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OformPlaceHolder.formID  = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                      //  if ("showPriceTable" == dt.Rows[i].ItemArray[2].ToString())
                                      //  {
                                       //     OformPlaceHolder.showPriceTable = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                       // }
                                       // ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OformPlaceHolder;

                                case "khatam.core.UI.WebControls.slider":
                                case "16":
                                   
                                    khatam.core.UI.WebControls.slider Oslider = new khatam.core.UI.WebControls.slider();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    Oslider.winVisible = true;
                                    Oslider.instanceID = instanceId;

                                    Oslider.Demo = Demo;
                                    Oslider.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo1" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo1 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo2" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo2 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo3" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo3 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo4" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo4 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo5" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo5 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo6" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo6 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo7" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo7 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo8" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo8 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo9" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo9 = dt.Rows[i].ItemArray[3].ToString();
                                        }
                                        if ("memo10" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Oslider.memo10 = dt.Rows[i].ItemArray[3].ToString();
                                        }

                                        if ("memo1show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo1show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo2show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo2show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo3show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo3show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo4show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo4show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo5show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo5show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo6show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo6show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo7show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo7show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo8show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo8show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo9show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo9show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                        if ("memo10show" == dt.Rows[i].ItemArray[2].ToString()) Oslider.memo10show =bool.Parse( dt.Rows[i].ItemArray[3].ToString());
                                                                                
                                  }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return Oslider;

                               

                                //  cost += 25;
                                //goto case 1;

                                case "khatam.core.UI.WebControls.darmanInquiryWin":
                                case "25":
                                    khatam.core.UI.WebControls.darmanInquiryWin OdarmanInquiryWin = new khatam.core.UI.WebControls.darmanInquiryWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OdarmanInquiryWin.winVisible = true;
                                    OdarmanInquiryWin.instanceID = instanceId;

                                    OdarmanInquiryWin.Demo = Demo;
                                    OdarmanInquiryWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdarmanInquiryWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdarmanInquiryWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdarmanInquiryWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("showPriceTable" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OdarmanInquiryWin.showPriceTable = bool.Parse(dt.Rows[i].ItemArray[3].ToString());

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OdarmanInquiryWin;


                                case "khatam.core.UI.WebControls.tabs":
                                case "26":
                                    khatam.core.UI.WebControls.tabs Otabs = new khatam.core.UI.WebControls.tabs();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    Otabs.winVisible = true;
                                    Otabs.instanceID = instanceId;

                                    Otabs.Demo = Demo;
                                    Otabs.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Otabs.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Otabs.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            Otabs.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("tab1InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab1InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab2InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab2InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab3InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab3InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab4InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab4InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab5InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab5InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab6InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab6InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab7InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab7InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab8InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab8InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab9InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab9InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab10InstanceID" == dt.Rows[i].ItemArray[2].ToString()) Otabs.tab10InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return Otabs;


                                case "khatam.core.UI.WebControls.linkToUs":
                                case "27":
                                    khatam.core.UI.WebControls.linkToUs OlinkToUs = new khatam.core.UI.WebControls.linkToUs();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OlinkToUs.winVisible = true;
                                    OlinkToUs.instanceID = instanceId;

                                    OlinkToUs.Demo = Demo;
                                    OlinkToUs.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {

                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) OlinkToUs.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            if (!tabed) OlinkToUs.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OlinkToUs.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }
                                        ;
                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OlinkToUs;


                                case "khatam.core.UI.WebControls.estateSearchWin":
                                case "28":
                                    khatam.core.UI.WebControls.estateSearchWin OestateSearchWin = new khatam.core.UI.WebControls.estateSearchWin();


                                    dt = getinstanceProperty(instanceId, languageID);

                                    length = dt.Rows.Count;
                                    OestateSearchWin.winVisible = true;
                                    OestateSearchWin.instanceID = instanceId;
                                    OestateSearchWin.editMode = editMode;

                                    OestateSearchWin.Demo = Demo;
                                  


                                    OestateSearchWin.editMode = editMode;

                                    for (int i = 0; i < length; i++)
                                    {
                                        if ("title" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OestateSearchWin.title = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("windowsMode" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OestateSearchWin.windowsMode = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("memo" == dt.Rows[i].ItemArray[2].ToString())
                                        {
                                            OestateSearchWin.memo = dt.Rows[i].ItemArray[3].ToString();

                                        }

                                        if ("tab1InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab1InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab2InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab2InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab3InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab3InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab4InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab4InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab5InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab5InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab6InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab6InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab7InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab7InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab8InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab8InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab9InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab9InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("tab10InstanceID" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.tab10InstanceID = dt.Rows[i].ItemArray[3].ToString();
                                        if ("ordering" == dt.Rows[i].ItemArray[2].ToString()) OestateSearchWin.ordering = dt.Rows[i].ItemArray[3].ToString();

                                   

                                    }

                                    //OcontentWin.memo = "تست محتوا" + getinstanceProperty(instanceId, languageID).Rows[0].ItemArray[3].ToString();
                                    // OcontentWin.memo = "مرتضی";
                                    // OcontentWin.title  = "قنات آبادی" + instanceId ;
                                    //OcontentWin.windowsMode = "win2";
                                    //OcontentWin.windowsMode = khatam.core.Drawing.windows ;
                                    //OcontentWin.windowsMode =Sys  ;
                                    return OestateSearchWin;



                                // cost += 50;

                                default:
                                    Label Odefault = new Label();
                                    Odefault.Text = "Control Not Found!!!";
                                    return Odefault;
                            }


                        }
                        catch (Exception exc)
                        {
                            Label Olabel = new Label();
                            Olabel.Text = "Control Load Error!!!" + exc.Message;
                            return Olabel;
                        }




                    }

                    static string str_sql;

                    public static DataTable getinstanceProperty(string instanceId, string language)
                    {



                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                        parameters.Add("id_Core_ServerControlsInstance", instanceId);
                        parameters.Add("language", language);


                        //str_sql = "SELECT    *  FROM         Core_ServerControlsInstanceVal  WHERE     (id_Core_ServerControlsInstance = @id_Core_ServerControlsInstance)";

                        str_sql = "SELECT     id, id_Core_ServerControlsInstance, propertyTitle, propertyValue, propertytype, language  FROM         Core_ServerControlsInstanceVal  WHERE     (id_Core_ServerControlsInstance = @id_Core_ServerControlsInstance) AND (language = @language OR   language = 0 OR  language IS NULL)";
                        //            + (field_target + ("   FROM  "
                        //            + (table + ("   WHERE     ("
                        //          + (field_where + " = @field_where_value)"))))));
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }
                    
                    public static string objectAdd(string objectId, string title)
                    {

                        ArrayList a = new ArrayList();
                        ArrayList b = new ArrayList();

                        a.Add("id_Core_ServerControl");
                        b.Add(objectId);

                        a.Add("title");
                        b.Add(title);

                        //a.Add("propertyTitle");
                        //b.Add("title");



                        string iid;

                        //iid =  khatam.core.data.sql.AddScope(a, b, "Core_serverControlsInstance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        //khatam.core.UI.WebControls.contentWin cw = new khatam.core.UI.WebControls.contentWin();

                        //cw.addInstanceProperty(iid);

                        iid = khatam.core.data.sql.AddScope(a, b, "Core_serverControlsInstance");


                        switch (objectId)
                        {
                            case "3":
                                khatam.core.UI.WebControls.Menu m1 = new khatam.core.UI.WebControls.Menu();
                                m1.addInstanceProperty(iid);
                                break;
                            case "6":
                                khatam.core.UI.WebControls.TreeCat tc1 = new khatam.core.UI.WebControls.TreeCat();
                                //tc1.addInstanceProperty(iid);
                                break;
                            case "8":
                                khatam.core.UI.WebControls.contentWin cl8 = new khatam.core.UI.WebControls.contentWin();
                                cl8.addInstanceProperty(iid);

                                break;

                            case "12":
                                khatam.core.UI.WebControls.contentList col = new khatam.core.UI.WebControls.contentList();
                                col.addInstanceProperty(iid);
                                break;

                            case "13":
                                khatam.core.UI.WebControls.contentPaging cp1 = new khatam.core.UI.WebControls.contentPaging();
                                cp1.addInstanceProperty(iid);
                                break;

                            case "14":
                                khatam.core.UI.WebControls.contentItemWin ci1 = new khatam.core.UI.WebControls.contentItemWin();
                                ci1.addInstanceProperty(iid);
                                break;


                            case "15":
                                khatam.core.UI.WebControls.loginWin cl = new khatam.core.UI.WebControls.loginWin();
                                cl.addInstanceProperty(iid);
                                break;


                            case "16":
                                khatam.core.UI.WebControls.slider  sl = new khatam.core.UI.WebControls.slider ();
                                sl.addInstanceProperty(iid);
                                break;

                        

                            case "18":
                                khatam.core.UI.WebControls.shopCart shp = new khatam.core.UI.WebControls.shopCart();
                                shp.addInstanceProperty(iid);
                                break;

                            case "19":
                                khatam.core.UI.WebControls.seacrhWin sW = new khatam.core.UI.WebControls.seacrhWin();
                                sW.addInstanceProperty(iid);
                                break;

                            case "20":
                                khatam.core.UI.WebControls.membrshipWin mw = new khatam.core.UI.WebControls.membrshipWin();
                                mw.addInstanceProperty(iid);
                                break;

                            case "21":
                                khatam.core.UI.WebControls.commentWin cwin = new khatam.core.UI.WebControls.commentWin();
                                cwin.addInstanceProperty(iid);
                                break;

                            
                            case "23":
                                khatam.core.UI.WebControls.domainSearchWin cdomainSearchWin = new khatam.core.UI.WebControls.domainSearchWin();
                                cdomainSearchWin.addInstanceProperty(iid);
                                break;

                            case "24":
                                khatam.core.UI.WebControls.formPlaceHolder cformPlaceHolder = new khatam.core.UI.WebControls.formPlaceHolder();
                                cformPlaceHolder.addInstanceProperty(iid);
                                break;
                            case "25":
                                khatam.core.UI.WebControls.slider cslideShow = new khatam.core.UI.WebControls.slider();
                                cslideShow.addInstanceProperty(iid);
                                break;
                            case "26":
                                khatam.core.UI.WebControls.tabs ctabs = new khatam.core.UI.WebControls.tabs();
                                ctabs.addInstanceProperty(iid);
                                break;

                            case "27":
                                khatam.core.UI.WebControls.linkToUs clinkToUs = new khatam.core.UI.WebControls.linkToUs();
                                clinkToUs.addInstanceProperty(iid);
                                break;

                            case "28":
                                khatam.core.UI.WebControls.estateSearchWin _estateSearchWin = new khatam.core.UI.WebControls.estateSearchWin();
                                _estateSearchWin.addInstanceProperty(iid);
                                break;
                   

                            default:
                                break;
                        }


                        return "";
                    }

                    public static string objectUpdate(string Core_serverControlsInstance_id, string id_core_serverControl)
                    {




                        switch (id_core_serverControl)
                        {
                            case "3":
                                khatam.core.UI.WebControls.Menu m1 = new khatam.core.UI.WebControls.Menu();
                                m1.addInstanceProperty(Core_serverControlsInstance_id);
                                break;
                            case "6":
                                khatam.core.UI.WebControls.TreeCat tc1 = new khatam.core.UI.WebControls.TreeCat();
                                //tc1.addInstanceProperty(iid);
                                break;
                            case "8":
                                khatam.core.UI.WebControls.contentWin cl8 = new khatam.core.UI.WebControls.contentWin();
                                cl8.addInstanceProperty(Core_serverControlsInstance_id);

                                break;

                            case "12":
                                khatam.core.UI.WebControls.contentList col = new khatam.core.UI.WebControls.contentList();
                                col.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "13":
                                khatam.core.UI.WebControls.contentPaging cp1 = new khatam.core.UI.WebControls.contentPaging();
                                cp1.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "14":
                                khatam.core.UI.WebControls.contentItemWin ci1 = new khatam.core.UI.WebControls.contentItemWin();
                                ci1.addInstanceProperty(Core_serverControlsInstance_id);
                                break;


                            case "15":
                                khatam.core.UI.WebControls.loginWin cl = new khatam.core.UI.WebControls.loginWin();
                                cl.LoginValidUserOnly = true ;

                                cl.addInstanceProperty(Core_serverControlsInstance_id);
                                break;


                            case "16":
                                khatam.core.UI.WebControls.slider sl = new khatam.core.UI.WebControls.slider();
                                sl.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                        



                            case "18":
                                khatam.core.UI.WebControls.shopCart shp = new khatam.core.UI.WebControls.shopCart();
                                shp.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "19":
                                khatam.core.UI.WebControls.seacrhWin sW = new khatam.core.UI.WebControls.seacrhWin();
                                sW.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "20":
                                khatam.core.UI.WebControls.membrshipWin mw = new khatam.core.UI.WebControls.membrshipWin();
                                mw.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "21":
                                khatam.core.UI.WebControls.commentWin cwin = new khatam.core.UI.WebControls.commentWin();
                                cwin.addInstanceProperty(Core_serverControlsInstance_id);
                                break;


                            case "23":
                                khatam.core.UI.WebControls.domainSearchWin cdomainSearchWin = new khatam.core.UI.WebControls.domainSearchWin();
                                cdomainSearchWin.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "24":
                                khatam.core.UI.WebControls.formPlaceHolder cformPlaceHolder = new khatam.core.UI.WebControls.formPlaceHolder();
                                cformPlaceHolder.addInstanceProperty(Core_serverControlsInstance_id);
                                break;
                            case "25":
                                khatam.core.UI.WebControls.slider cslideShow = new khatam.core.UI.WebControls.slider();
                                cslideShow.addInstanceProperty(Core_serverControlsInstance_id);
                                break;
                            case "26":
                                khatam.core.UI.WebControls.tabs ctabList = new khatam.core.UI.WebControls.tabs();
                                ctabList.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            case "28":
                                khatam.core.UI.WebControls.estateSearchWin cestateSearchWin = new khatam.core.UI.WebControls.estateSearchWin();
                                cestateSearchWin.addInstanceProperty(Core_serverControlsInstance_id);
                                break;

                            default:
                                break;
                        }


                        return "";
                    }

                    public static string updateAllObjectsProperty()
                    {

                        DataTable dt = new DataTable();
                        dt = khatam.core.data.sql.getTable("Core_serverControlsInstance");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            khatam.core.UI.ObjectManager.objectUpdate(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString());
                        }

                        return "updated";

                    }

                    public static string objectDelete(string serverControlsInstanceId)
                    {


                        khatam.core.data.sql.Sql_Del_Row("id_Core_ServerControlsInstance", serverControlsInstanceId, "Core_serverControlsInstanceVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        khatam.core.data.sql.Sql_Del_Row("id_core_serverControlInstance", serverControlsInstanceId, "Core_serverControlsInstancePlacing", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        khatam.core.data.sql.Sql_Del_Row("id", serverControlsInstanceId, "Core_serverControlsInstance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        return "";
                    }



                    public static string getModule()
                    {
                        string str = "";


                       // Test test = new Test(); // Create new instance with string array

                        //foreach (string element in test.Elements) // Loop over elements with property
                        //{
                        //str = element + " " + str;
                        //}
                        string[] moduleArr = khatam.core.ConfigurationManager.License.moduleArr;


                        foreach (string element in moduleArr)
                        {
                            str = element + " " + str;
                        }



                        return str;
                    }

                


                    public static string getValidPermissonSqlWhere(string colname)
                    {
                        string str = "";
                        // " + colname  + " 

                        str = "  " + colname  + " = N'accessVisualContentManager' ";
                        str = str + "or  " + colname + "  = N'accessLayoutManager' ";
                        str = str + "or  " + colname + "  = N'update' ";
                        str = str + "or  " + colname + "  = N'baseSetting' ";
                        str = str + "or  " + colname + "  = N'objects' ";
                        str = str + "or  " + colname + "  = N'module' ";
                        str = str + "or  " + colname + "  = N'sections' ";

                        str = str + "or  " + colname + "  LIKE N'core%' ";
                        str = str + "or  " + colname  + "  = N'ManagerUsers' ";
                        str = str + "or  " + colname  + "  = N'ManageUsersGroups' ";
                        str = str + "or  " + colname  + "  = N'theme' ";
                        str = str + "or  " + colname  + "  = N'language' ";
                        str = str + "or  " + colname  + "  = N'backup' ";
                        str = str + "or  " + colname  + "  LIKE N'menu%' ";
                        str = str + "or  " + colname  + "  LIKE N'special_pages%' ";
                        str = str + "or  " + colname  + "  = N'email' ";
                        str = str + "or  " + colname  + "  = N'webstats' ";
                        str = str + "or  " + colname  + "  = N'password_edit' ";
                        str = str + "or  " + colname  + "  = N'profile' ";
                        str = str + "or  " + colname  + "  LIKE N'comment%' ";


                        string[] moduleArr = khatam.core.ConfigurationManager.License.moduleArr;
                       

                        for (int i = 0; i < moduleArr.Length; i++)
                        {

                            str = str + "or  " + colname  + "  LIKE N'" + moduleArr[i]  + "%' ";

                        }





                        //str =  " or  " + colname  + "  LIKE N'" + element  + "%' " + str;
                        //if (element. == true ) {

                        //}


                        str = "AND (" + str + ")";

                        //str = "AND ( " + colname  + "  LIKE N'article%' OR   " + colname  + "  LIKE N'news%')";

                        return str;
                    }

                    public static string getValidObjectSqlWhere()
                    {
                        string str = "";


                        str = " core_serverControls.title = N'khatam.core.UI.WebControls.Menu' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.TreeCat' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.contentWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.contentList' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.contentPaging' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.contentItemWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.loginWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.slider' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.seacrhWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.membrshipWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.commentWin' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.tabs' ";
                        str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.linkToUs' ";


                       // str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.OnlineOrderForm' ";
                      //  str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.formPlaceHolder' ";
                      //  str = str + " or core_serverControls.title = N'khatam.core.UI.WebControls.slideShow' ";



                        string[] moduleArr = khatam.core.ConfigurationManager.License.moduleArr;

                        for (int i = 0; i < moduleArr.Length; i++)
                        {

                            str = str + "or core_serverControls.title LIKE N'%" + moduleArr[i] + "%' ";

                        }





                        //str =  " or  " + colname  + "  LIKE N'" + element  + "%' " + str;
                        //if (element. == true ) {

                        //}


                        str = "AND (" + str + ")";

                        //str = "AND ( " + colname  + "  LIKE N'article%' OR   " + colname  + "  LIKE N'news%')";
                        //str = "and (core_serverControls.title like N'%shop%' or core_serverControls.title like N'%content%')";
                        return str;
                    }

                    public static string getPageSqlWhere()
                    {
                        string str = "";


                        str = " core_section.title = N'default.aspx' ";

                        str = str + " or core_section.title LIKE N'%contactus%' ";
                        str = str + " or core_section.title LIKE N'%special_pages_item%' ";
                        str = str + " or core_section.title LIKE N'%contactus%' ";
                        str = str + " or core_section.title LIKE N'%sitemap%' ";
                        str = str + " or core_section.title LIKE N'%search%' ";
                        str = str + " or core_section.title LIKE N'%login%' ";
                        str = str + " or core_section.title LIKE N'%membership%' ";
                        str = str + " or core_section.title LIKE N'%OnlineOrderForm%' ";


                        string[] moduleArr = khatam.core.ConfigurationManager.License.moduleArr;

                        for (int i = 0; i < moduleArr.Length; i++)
                        {

                            str = str + " or core_section.title LIKE N'%" + moduleArr[i] + "%' ";

                        }


                        //str =  " or  " + colname  + "  LIKE N'" + element  + "%' " + str;
                        //if (element. == true ) {

                        //}


                        // str = "AND (" + str + ")";

                        //str = "AND ( " + colname  + "  LIKE N'article%' OR   " + colname  + "  LIKE N'news%')";

                        return str;
                    }

                 

                }
            



         

                public static class SectionManager
                {

                    public static string demoBarHtml()
                    {
                        string html = "<div id=\"demo\" runat=\"server\" style=\"background-color: #FFCC00; height: 20px\">"
+ " <div style=\"float: right; font-weight: 700;\">"
+ khatam.core.ConfigurationManager.License.demoNo + " &nbsp;نسخه دمو سایت ساز خاتم (طراحی"
+ " وب سایت، سیستم مدیریت محتوا، پورتال پرتال) شماره"
+ " </div>"
+ " <div style=\"float: left\">"
+ " <a href=\"http://www.yourDomain.com/web/portal/" + khatam.core.ConfigurationManager.License.demoNo + "/\">آشنایی بیشتر و سفارش خرید<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/btn/Shopcart.gif\" /></a>"
+ "|"
+ " <a href=\""+ khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath+"Manage/Default.aspx\">دموی کنترل پنل</a> |<a href=\"http://www.yourDomain.com/web/portal/\">"
+ " سایر نمونه ها</a> | <a href=\"http://www.yourDomain.com/web/special_pages/1/سایت%20ساز%20طراحی%20وب%20سایت\">"
+ " معرفی امکانات سایت ساز</a> | <a href=\"http://www.yourDomain.com/web/contactus/\">تماس با"
+ " ما </a>"
+ " </div>"
+ " </div>";

                        //this.demo.Visible = khatam.core.ConfigurationManager.License.demo;
                        //this.Label1.Text = khatam.core.ConfigurationManager.License.demoNo;
                        //demo_hl_linkToContent.NavigateUrl = "http://www.yourDomain.com/web/portal/" + khatam.core.ConfigurationManager.License.demoNo + "/";

                        return html;

                    }


                    public static string demoFooterScript()
                    {
                        string html = "<a title=\"Web Analytics\" href=\"http://getclicky.com/66638551\"><img alt=\"Web Analytics\" src=\"//static.getclicky.com/media/links/badge.gif\" border=\"0\" /></a> " +
                     " <script src=\"//static.getclicky.com/js\" type=\"text/javascript\"></script> " +
                     " <script type=\"text/javascript\">try{ clicky.init(66638551); }catch(e){}</script> " +
                     " <noscript><p><img alt=\"Clicky\" width=\"1\" height=\"1\" src=\"//in.getclicky.com/66638551ns.gif\" /></p></noscript>";

                        return html;

                    }

                    public static  void   load_section_placeholders(string  section_str ,Page  me_page ,
                    string  connection_str ,string  language , bool  editMode , bool  Demo, string theme )
                    {
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_content"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_content2"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_Footer"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_header"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_NAVIGATION"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_u"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("ph_beforeft"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_ufrist"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_exFooter"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_first_script"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        load_placesholder((PlaceHolder)me_page.FindControl("PH_exheader"), section_str, me_page, connection_str, language, editMode, Demo, theme);
                        

                  //  load_placesholder(CType(me_page.FindControl("PH_content"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_content2"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_Footer"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_header"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_NAVIGATION"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_u"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("ph_beforeft"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_ufrist"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                 //   load_placesholder(CType(me_page.FindControl("PH_exFooter"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                  //  load_placesholder(CType(me_page.FindControl("PH_first_script"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                  //  load_placesholder(CType(me_page.FindControl("PH_exheader"), PlaceHolder), section_str, me_page, connection_str, language, editMode, Demo);
                    }

                       public static   void  load_placesholder(PlaceHolder  ph ,string  section_str , Page  me_page , string  connection_str ,string  language , bool editMode , bool Demo, string theme)
                       {
                        
                    DataTable  ph_dt = new DataTable();
                    ph_dt = getServerControlTitle(section_str, ph.ID, language, connection_str);


                    //TextBox newtxt = new TextBox();
                   // newtxt.Text = ph_dt.Rows.Count.ToString()
                     //      ;
                   // ph.Controls.Add(newtxt);


                    if ( ph_dt.Rows.Count > 0 )
                           {
                      //  ph.Controls.Clear()
                        for (int j=0; j< ph_dt.Rows.Count ;j++)
                          {
                        //For j = 0 To ph_dt.Rows.Count - 1\
                          //    TextBox newtxt2 = new TextBox();
                            //   newtxt2.Text = ph_dt.Rows[j].ItemArray[0].ToString();
                            //   ph.Controls.Add(newtxt2);

                              ph.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(ph_dt.Rows[j].ItemArray[0].ToString()
                            , ph_dt.Rows[j].ItemArray[1].ToString(), language, editMode,false,theme  ));
                           }
                        //Next j
                           }
                       }



                       
                    
                   public  static DataTable    Get_Component_url(string  setting_section_title , string  placeholder_controlid , string  connectionstring) 
                   {
                       string  str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("setting_section_title", setting_section_title);
                    parameters.Add("setting_placeholder_title", placeholder_controlid);
                   



                   // 'str_sql = "SELECT     " & field_target & "   FROM " & table & "  WHERE     (" & field_where & " = @" & field_where & ") AND (enable = @enable)"
                    str_sql = "SELECT     setting_component.url  " +
                    "FROM         setting_component INNER JOIN " +
                    "Setting_placeholder_ref_section_ref_component ON  " +
                    "setting_component.id = Setting_placeholder_ref_section_ref_component.id_setting_component INNER JOIN " +
                    "setting_section ON Setting_placeholder_ref_section_ref_component.id_setting_section = setting_section.id INNER JOIN " +
                    "setting_placeholder ON Setting_placeholder_ref_section_ref_component.id_setting_placeholder = setting_placeholder.id " +
                    "WHERE     (setting_placeholder.title = @setting_placeholder_title) AND (setting_section.title = @setting_section_title) " ;
                    //'"WHERE     (setting_ref_them_secction_component_placeholder.id_setting_theme = @id_setting_theme) AND (setting_section.title = @title_setting_section) AND  " +
                    //'         "(setting_placeholder.title = @title_setting_placeholder) ";


                    return  DBFunctions.ExecuteReader(str_sql, parameters,System.Data.CommandType.Text, connectionstring);

                   }

                 public static  DataTable   getServerControlTitle(string setting_section_title , string  placeholder_controlid ,string  LangId , string  connectionstring)
                {

                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("setting_section_title", setting_section_title);
                    parameters.Add("setting_placeholder_title", placeholder_controlid);
                    parameters.Add("idLanguage", LangId);

                    string  str;
                    string option_str="";

                    if (setting_section_title.StartsWith("_"))
                    {
                        option_str = "_option";
                    }
                    str = " SELECT      Core_ServerControls.title,Core_ServerControlsInstance.id AS idInstance " + 
" FROM         Core_ServerControls INNER JOIN " + 
                      " Core_ServerControlsInstance ON Core_ServerControls.id = Core_ServerControlsInstance.id_core_serverControl INNER JOIN " + 
                      " Core_ServerControlsInstancePlacing ON Core_ServerControlsInstance.id = Core_ServerControlsInstancePlacing.id_core_serverControlInstance INNER JOIN " +
                    "  Core_section" + option_str + " ON Core_ServerControlsInstancePlacing.id_setting_section = Core_section" + option_str + ".id INNER JOIN " + 
                    "  core_placeholder ON Core_ServerControlsInstancePlacing.id_setting_placeholder = core_placeholder.id " +
                    " WHERE     (core_placeholder.title = @setting_placeholder_title) AND (Core_section" + option_str + ".title = @setting_section_title) AND (Core_ServerControlsInstancePlacing.idLanguage=@idLanguage) ";
//" WHERE     (core_placeholder.title = @setting_placeholder_title) AND (Core_section.title = @setting_section_title) AND (Core_ServerControlsInstancePlacing.idLanguage=@idLanguage) ";



                    //' Return DBFunctions.ExecuteReader("usp_core_getServerControlTitle", parameters, Data.CommandType.StoredProcedure, connectionstring)
                    return DBFunctions.ExecuteReader(str, parameters, System.Data.CommandType.Text, connectionstring);

                }

       

                    public static string  addSectionProperty(string id_sectionVal)
                    {

                        DataTable dt = new DataTable();
                        dt = khatam.core.data.sql.getTable("language");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "yuig1", "yui-gc", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "yuig1", "yui-gc", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "yui_id", "doc4", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "yui_class", "yui-t2", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "title", "عنوان", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "keywords", "کلمه کلیدی", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "description", "شرح", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "Author", "ایمیل نویسنده", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "lastmod", "2011/11/11", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "changefreq", "monthly", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());
                            khatam.core.data.sql.addPropertyRow(id_sectionVal, "priority", "0.5", "Core_sectionVal", dt.Rows[i].ItemArray[0].ToString());

                        }

                        return "added";
                    }


         
                    public static string updateAllSectionProperty()
                    {

                        DataTable dt = new DataTable();
                        dt = khatam.core.data.sql.getTable("core_section");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            addSectionProperty(dt.Rows[i].ItemArray[0].ToString());
                        }

                        DataTable dt2 = new DataTable();
                        dt2 = khatam.core.data.sql.getTable("core_section_option");

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            addSectionProperty(dt2.Rows[i].ItemArray[0].ToString());
                        }


                        //dt.Dispose()
                        return "updated";
                    }



       


                    public static string getProperty(string sectionId, string title, string langId)
                    {


                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("id_Core_Section", sectionId);
                        parameters.Add("propertyTitle", title);
                        parameters.Add("language", langId);
                        
                        string sql_str;
                      //  if (int.Parse(sectionId) > 999)
                      //  {
                        //    sql_str = "SELECT     propertyValue  FROM         core_sectionVal_option  WHERE     (id_Core_section_option = @id_Core_Section) AND (propertyTitle = @propertyTitle) AND (language = @language)";
                      //  }
                      //  else
                      //  {
                            sql_str = "SELECT     propertyValue  FROM         core_sectionVal  WHERE     (id_Core_Section = @id_Core_Section) AND (propertyTitle = @propertyTitle) AND (language = @language)";

                       // }


                        return DBFunctions.ExecuteScaler(sql_str, parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();



                    }



                    public static string setProperty(string propertyValue, string sectionId, string title, string langId)
                    {


                        Dictionary<string, object> parameters = new Dictionary<string, object>();

                        parameters.Add("propertyValue", propertyValue);
                        parameters.Add("id_Core_Section", sectionId);
                        parameters.Add("propertyTitle", title);
                        parameters.Add("language", langId);

                               string sql_str="";
                             //  if (int.Parse(sectionId) > 999)
                             //  {
                               //    sql_str = "UPDATE    core_sectionVal_option   SET              propertyValue = @propertyValue  WHERE     (id_Core_Section_option = @id_Core_Section) AND (propertyTitle = @propertyTitle) AND (language = @language)";

                             //  }
                             //  else
                             //  {
                                   sql_str = "UPDATE    core_sectionVal   SET              propertyValue = @propertyValue  WHERE     (id_Core_Section = @id_Core_Section) AND (propertyTitle = @propertyTitle) AND (language = @language)";
                            //   }
                        

                        
                        return DBFunctions.ExecuteNonQuery(sql_str , parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();



                    }


                    public static DataTable getSection(string LangId)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        // parameters.Add("field_where_value", field_where_value);
                        //  str_sql = ("SELECT N'layout.aspx?id=' + cast (id as nvarchar) + N'&lang=' + '" +  LangId  + "'  AS N'id', title  from Core_section");
                        str_sql = "(SELECT     N'layout.aspx?id=' + cast(core_section.id AS nvarchar) + N'&lang=' + '1' AS N'id', Dictionary_Lang.title as title " +
                "FROM         Dictionary_Lang INNER JOIN " +
                                      " Dictionary ON Dictionary_Lang.id_dictionary = Dictionary.id INNER JOIN " +
                                      " Core_section ON Dictionary.id = Core_section.IdDictionary  where ( " + khatam.core.UI.ObjectManager.getPageSqlWhere() +
                            //  "  ) order by Dictionary_Lang.title " +
                                          "  )  " +
                                         " union " +
                " SELECT " +
                 " N'layout.aspx?id=' + cast([Core_section_option].id AS nvarchar) + N'&lang=' + '1'  " +
                  " AS N'id', Core_section_option.title as title " +
                  " FROM [Core_section_option]  ) order by title "
                       ;




                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString());
                    }

          

                }
            
        }
    }
}



