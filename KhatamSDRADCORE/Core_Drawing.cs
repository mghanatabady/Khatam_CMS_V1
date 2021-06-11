using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using System.ComponentModel;



namespace khatam
{
    namespace core
    {
        namespace Drawing
        {

            public static class windows
            {

               public  struct msg
                {
                   public string title;
                   public string memo;
                   public bool rtl;
                   public msgMode msgMode;

                }
              public   enum msgMode
                {
                    Success,Error
                }
               public static  string getWinTagTitleOpen(string mode)
                {

                    

                    switch (mode)
                    {
                        case "none" :
                            return "";
                        case "win1":
                            return "<div class=\"Win1t_tb\"><div class=\"Win1b_tb\"><div class=\"Win1l_tb\"><div class=\"Win1r_tb\"><div class=\"Win1bl_tb\"><div class=\"Win1br_tb\"><div class=\"Win1tl_tb\"><div class=\"Win1tr_tb\">";
                        case "win2":
                            return "";
                        case "win3":
                            return "<div class=\"Win3t_tb\"><div class=\"Win3b_tb\"><div class=\"Win3l_tb\"><div class=\"Win3r_tb\"><div class=\"Win3bl_tb\"><div class=\"Win3br_tb\"><div class=\"Win3tl_tb\"><div class=\"Win3tr_tb\">";
                        case "win4":
                            return "<div class=\"Win4t_tb\"><div class=\"Win4b_tb\"><div class=\"Win4l_tb\"><div class=\"Win4r_tb\"><div class=\"Win4bl_tb\"><div class=\"Win4br_tb\"><div class=\"Win4tl_tb\"><div class=\"Win4tr_tb\">";
                        case "win5":
                            return "<div class=\"Win5t_tb\"><div class=\"Win5b_tb\"><div class=\"Win5l_tb\"><div class=\"Win5r_tb\"><div class=\"Win5bl_tb\"><div class=\"Win5br_tb\"><div class=\"Win5tl_tb\"><div class=\"Win5tr_tb\">";
                        default:
                            return "" +mode;
                            //break;
            
                    }


                   // return mode + str;//str;
                }

               public static string getwinTagTitleClose(string mode)
               {
                   switch (mode)
                   {
                       case "none":
                           return "";
                       case "win1":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win2":
                           return "";
                       case "win3":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win4":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win5":
                           return "</div></div></div></div></div></div></div></div>";
                       default:
                           return "" + mode;
                       //break;

                   }

                
               }


               public static string getWinTagcontentOpen(string mode)
               {

                   switch (mode)
                   {
                       case "none":
                           return "";
                       case "win1":
                           return "<div class=\"Win1t\"><div class=\"Win1b\"><div class=\"Win1l\"><div class=\"Win1r\"><div class=\"Win1bl\"><div class=\"Win1br\"><div class=\"Win1tl\"><div class=\"Win1tr\">";
                       case "win2":
                           return "<div class=\"Win2t\"><div class=\"Win2b\"><div class=\"Win2l\"><div class=\"Win2r\"><div class=\"Win2bl\"><div class=\"Win2br\"><div class=\"Win2tl\"><div class=\"Win2tr\">";
                       case "win3":
                           return "<div class=\"Win3t\"><div class=\"Win3b\"><div class=\"Win3l\"><div class=\"Win3r\"><div class=\"Win3bl\"><div class=\"Win3br\"><div class=\"Win3tl\"><div class=\"Win3tr\">";
                       case "win4":
                           return "<div class=\"Win4t\"><div class=\"Win4b\"><div class=\"Win4l\"><div class=\"Win4r\"><div class=\"Win4bl\"><div class=\"Win4br\"><div class=\"Win4tl\"><div class=\"Win4tr\">";
                       case "win5":
                           return "<div class=\"Win5t\"><div class=\"Win5b\"><div class=\"Win5l\"><div class=\"Win5r\"><div class=\"Win5bl\"><div class=\"Win5br\"><div class=\"Win5tl\"><div class=\"Win5tr\">";
     
                       default:

                           return "" + mode;
                       //break;

                   }

                  
               }

               public static string getwinTagContentClose(string mode)
               {
                   switch (mode)
                   {
                       case "none":
                           return "";
                       case "win1":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win2":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win3":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win4":
                           return "</div></div></div></div></div></div></div></div>";
                       case "win5":
                           return "</div></div></div></div></div></div></div></div>";
                       default:
                           return "" + mode;
                       //break;

                   }

                   
               }


               public static string getErrorMessage(string title, string memo, bool rtl)
               {
                   string html = "";
                   if (rtl)
                   {
                       html = "<div id=\"Div1\"dir=\"rtl\" style=\"border-right: red 2px solid; border-top: red 2px solid;"
    + " border-left: red 2px solid; width: 100%;"
    + " border-bottom: red 2px solid; text-align: right; margin-top:10px\">"
    + " <div style=\"margin-top: 5px; float: right; width: 38px; height: 26px\">"
    + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif\" />&nbsp;</div>"
    + " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; color: red;"
    + " padding-top: 5px\">"
    + title + "<br />"
    + " <span style=\"font-size: 9pt\">" + memo
    + " "
    + " </span>"
    + " </div>"
    + " <br />"
    + " </div>";
                   }
                   else
                   {
                       html = "<div id=\"Div1\"dir=\"ltr\" style=\"border-right: red 2px solid; border-top: red 2px solid;"
                           + " border-left: red 2px solid; width: 100%;"
                           + " border-bottom: red 2px solid; text-align: left; margin-top:10px\">"
                           + " <div style=\"margin-top: 5px; float: left; width: 38px; height: 26px\">"
                            + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif\" />&nbsp;</div>"
                           + " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; color: red;"
                           + " padding-top: 5px\">"
                          + title + "<br />"
                           + " <span style=\"font-size: 9pt\">" + memo
                           + " "
                           + " </span>"
                           + " </div>"
                           + " <br />"
                           + " </div>";

                   }


                   return html;
                   //break;




               }

               public static string getSuccessMessage(string title, string memo, bool rtl)
               {
                   string html = "";
                   if (rtl)
                   {
                       html = "<div id=\"Div1\"dir=\"rtl\" style=\"border-right: teal 2px solid; border-top: teal 2px solid;"
    + " border-left: teal 2px solid; width: 100%;"
    + " border-bottom: teal 2px solid; text-align: right; margin-top:10px\">"
    + " <div style=\"margin-top: 5px; float: right; width: 38px; height: 26px\">"
    + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif\" />&nbsp;</div>"
    + " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; "
    + " padding-top: 5px\">"
    + title + "<br />"
    + " <span style=\"font-size: 9pt\">" + memo
    + " "
    + " </span>"
    + " </div>"
    + " <br />"
    + " </div>";
                   }
                   else
                   {
                       html = "<div id=\"Div1\"dir=\"ltr\" style=\"border-right: red 2px solid; border-top: red 2px solid;"
                           + " border-left: red 2px solid; width: 100%;"
                           + " border-bottom: red 2px solid; text-align: left; margin-top:10px\">"
                           + " <div style=\"margin-top: 5px; float: left; width: 38px; height: 26px\">"
                            + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif\" />&nbsp;</div>"
                           + " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; color: red;"
                           + " padding-top: 5px\">"
                          + title + "<br />"
                           + " <span style=\"font-size: 9pt\">" + memo
                           + " "
                           + " </span>"
                           + " </div>"
                           + " <br />"
                           + " </div>";

                   }


                   return html;
                   //break;




               }


               public static string getMessage(msg _msg)
               {
                   string html = "";
                   if (_msg.rtl)
                   {
                       html = "<div id=\"Div1\"dir=\"rtl\" style=\"border-right: teal 2px solid; border-top: teal 2px solid;"
                        + " border-left: teal 2px solid;  float: right;width: 400px;"
                        + " border-bottom: teal 2px solid; text-align: right;padding: 10px; margin-bottom:10px\">"
                        + " <div style=\"margin-top: 5px; float: right; width: 38px; height: 26px\">"
                        + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif\" />&nbsp;</div>"
                        //+ " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; "
                        + " <div > "
                        //+ " padding-top: 5px\">"
                        + _msg.title  + "<br />"
                        + " <span style=\"font-size: 9pt\">" + _msg.memo 
                        + " </span>"
                        + " </div>"    
                        + " </div>";
                   }

                               //("<div  style=\"padding: 10px;direction:rtl ; text-align:right  ; border: 1px solid #d6d4c5; margin-left: 10px; width: 942px;  float: right; margin-bottom: 10px; background-color:#fdfde3\">"));          
        

                   else
                   {
                       html = "<div id=\"Div1\"dir=\"ltr\" style=\"border-right: red 2px solid; border-top: red 2px solid;"
                           + " border-left: red 2px solid; width: 100%;"
                           + " border-bottom: red 2px solid; text-align: left; margin-top:10px\">"
                           + " <div style=\"margin-top: 5px; float: left; width: 38px; height: 26px\">"
                            + "<img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif\" />&nbsp;</div>"
                           + " <div style=\"padding-right: 5px; margin-top: 5px;width: 493px; color: red;"
                           + " padding-top: 5px\">"
                          + _msg.title + "<br />"
                           + " <span style=\"font-size: 9pt\">" + _msg.memo
                           + " "
                           + " </span>"
                           + " </div>"
                           + " <br />"
                           + " </div>";

                   }


                   return html;
                   //break;




               }

            }


            public static class EditorWin
            {
                public static string EditBorderOpen(string instanceID, string windowsMode)
                {


                    string j_ve_div;
                    j_ve_div = "<script type=\"text/javascript\" >" +
    "$(document).ready(function () {" +

        "$(\"#edit" + instanceID + "\").hide();" +

        "$(\"#d" + instanceID + "\").mousemove(function () {" +
        "    $(\"#d" + instanceID + "\").addClass(\"ve_div\");" +
        "    $(\"#edit" + instanceID + "\").show();" +
        "});" +

        "$(\"#d" + instanceID + "\").mouseout(function () {" +
        "    $(\"#d" + instanceID + "\").removeClass(\"ve_div\");" +
        "    $(\"#edit" + instanceID + "\").hide();" +
        "});" +
    "});" +

"</script>";


                    //j_ve_div = j_ve_div + "<div style=\" \">";
                    //j_ve_div = j_ve_div + "aaaaa";

                    if (windowsMode == "none")
                    {
                        j_ve_div = j_ve_div + "<div id=\"d" + instanceID + "\" style=\" border: 1px dashed  blue\" >";
                        //j_ve_div = j_ve_div + "<br />";
                        //j_ve_div = j_ve_div + "<br />";
                        //j_ve_div = j_ve_div + "<br />";
                    }
                    else
                    {
                        j_ve_div = j_ve_div + "<div id=\"d" + instanceID + "\" >";
                    }

                    j_ve_div = j_ve_div + "<div id=\"edit" + instanceID + "\" class=\"ve_btn\"  >";
                    //j_ve_div = j_ve_div + "<img id=\"btnAdd" + instanceID + "\" onclick=\"showDialog('newPerson" + instanceID + "');\" src=\"core/themeCP/Bitrix/CssImage/btn/edit.gif\" />";
                    j_ve_div = j_ve_div + "<img id=\"btnAdd" + instanceID + "\" onclick=\"showDialog('newPerson" + instanceID + "');\" src=\"" 
                        + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +            
                    "core/themeCP/Bitrix/CssImage/btn/edit.gif\" />";


            

                    j_ve_div = j_ve_div + "</div>";



                    //j_ve_div = j_ve_div + "</div>";


                    return j_ve_div;

                }


        

            }

            public static class image
            {

                public  struct Point

{

      public int height;

      public int width;

}



                public static   Point getSizeStandard(int id)
                {

                   

                    Point[] p = new Point[10];

                    p[1].width= 50; 
                    p[1].height = 50;

                    p[2].width = 75;              
                    p[2].height = 75;

                    p[3].width = 100;
                    p[3].height = 100;

                    p[4].width = 120;
                    p[4].height = 120;

                    p[5].width = 150;
                    p[5].height = 150;

                    p[6].width = 200;
                    p[6].height = 200;

                    p[7].width = 300;
                    p[7].height = 300;

                    p[8].width = 400;
                    p[8].height = 400;

                    p[9].width = 550;
                    p[9].height = 550;


                    return p[id];


                }

            }

      

        }

    }
}
