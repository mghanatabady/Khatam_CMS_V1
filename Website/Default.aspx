<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"   
    UICulture="fa-IR"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



    

     <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
     <meta http-equiv="Content-Encoding" content="gzip" />
 <meta http-equiv="Accept-Encoding" content="gzip, deflate" />

<!--    <script src="http://jwpsrv.com/library/AIXYrL1sEeKE0RIxOQulpA.js"></script>-->

    
            <SCRIPT type="text/javascript" language=Javascript>
      <!--
                function addBookmark(url, desc) {
                    var bookmarkurl = url;
                    var bookmarktitle = desc;
                    var nonie = 'Sorry, only Mozilla Firefox and Internet Explorer support this method to add a bookmark/favourite\n But please feel free to visit the site\'s home page to add a bookmark manually';

                    if (window.sidebar) { // Mozilla Firefox Bookmark
                        window.sidebar.addPanel(bookmarktitle, bookmarkurl, "");
                    } else if (document.all) { // IE Favourites
                        window.external.AddFavorite(bookmarkurl, bookmarktitle);
                    } else {
                        alert(nonie);
                    }
                }
                

                function isNumberKey(evt) {
                    var charCode = (evt.which) ? evt.which : event.keyCode
                    if (charCode > 31 && (charCode < 48 || charCode > 57))
                        return false;

                    return true;
                }

                function isAlphabeticKey(evt) {
                    var charCode = (evt.which) ? evt.which : event.keyCode
                    if (charCode > 31 && (charCode < 48 || charCode > 57))
                        return false;
                       
                    return true;
                }


                function checkTextAreaMaxLength(textBox, e, length) {

                    var mLen = textBox["MaxLength"];
                    if (null == mLen)
                        mLen = length;

                    var maxLength = parseInt(mLen);
                    if (!checkSpecialKeys(e)) {
                        if (textBox.value.length > maxLength - 1) {
                            if (window.event)//IE
                            {
                                e.returnValue = false;
                                return false;
                            }
                            else//Firefox
                                e.preventDefault();
                        }
                    }
                }


 


               
               
      //-->
   </SCRIPT>



    <asp:PlaceHolder id="MetaPlaceHolder" runat="server" />
    <link id="faviicon" runat="server" rel="shortcut icon" type="image/x-icon" />
   
   
   
   	<style>
		/*	* {padding:0; margin:0;}

			html {
				background:url(/img/tiles/wood.png) 0 0 repeat;
				padding:15px 15px 0;
				font-family:sans-serif;
				font-size:14px;
			}

			p, h3 { 
				margin-bottom:15px;
			}

			div {
				padding:10px;
				width:600px;
				background:#fff;
			}
            
			.tabs li {
				list-style:none;
				display:inline;
			}

			.tabs a {
				padding:5px 10px;
				display:inline-block;
				background:#666;
				color:#fff;
				text-decoration:none;
			}

			.tabs a.active {
				background:#fff;
				color:#000;
			}
            */
		</style>
		
   <style type="text/css" >
	

	/*		div {
				padding:10px;
				width:600px;
				background:#fff;
			}*/

			.tabs li {
				list-style:none;
				display:inline;
				margin-top:10px;
			}

			.tabs a 
			{
			    /*border:1px solid #d3d3d3 ;*/
			    border-left:1px solid #d3d3d3 ;
			    border-right:1px solid #d3d3d3 ;
			    border-top:1px solid #d3d3d3 ;			    
			    
				padding:5px 10px;
				display:inline-block;
				background:#ebedf7;
				color:#7d7d7d;
				text-decoration:none;
				 
			}

			.tabs a.active {
				background:#f5f9f9;
				color:#000;
			}

		</style>
    
  
</head>
<body id="bodyTag" runat="server"    >

<div id="tiplayer" style="position:absolute; visibility:hidden; z-index:10000;"></div>



    <shinkansen:staticresourcemanager ID="StaticResourceManager1" runat="server" HttpCompressWith="GZip"
        Crunch="true" Combine="true" ScriptPlacement="Top">
    </shinkansen:staticresourcemanager>


    <form id="form1" runat="server">









       <script type="text/javascript" >



           $(document).ready(function () {
               $("#menu").hide();
               $("#menuLang").hide();

               var localPath = '<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  %>';

               $("#btnPages").hover(
               function () {

               $('#btnPages').attr("src", localPath+ "core/themeCP/Bitrix/CssImage/topbar/btnCP001r.gif");
               },
               function () {
                   $('#btnPages').attr("src", localPath + "core/themeCP/Bitrix/CssImage/topbar/btnCP001.gif");
               }

               );

               $("#btnLang").hover(
                function () {

                    $('#btnLang').attr("src", localPath + "core/themeCP/Bitrix/CssImage/topbar/btnCP002r.gif");
                },
              function () {
                  $('#btnLang').attr("src", localPath + "core/themeCP/Bitrix/CssImage/topbar/btnCP002.gif");
              }

               );



               $("#btnPages").mouseenter(function () {

                   var width = $("#btnPages").width();
                   var height = $("#btnPages").height();
                   var pos = $("#btnPages").position(); // returns an object with the attribute top and left 

                   $("#menu").css("left", pos.left);
                   $("#menu").css("top", pos.top + height);
                   $("#menu").fadeIn('fast');


               });



               $(".testt").mouseleave(function () {
                   $("#menu").hide();
               });




               $("#btnLang").mouseenter(function () {

                   var width = $("#btnLang").width();
                   var height = $("#btnLang").height();
                   var pos = $("#btnLang").position(); // returns an object with the attribute top and left 

                   $("#menuLang").css("left", pos.left);
                   $("#menuLang").css("top", pos.top + height);
                   $("#menuLang").fadeIn('fast');

               });


               // function () {
               $(".areaLang").mouseleave(function () {
                   $("#menuLang").hide();
               });


           });

   

         



        </script>


    <script type="text/javascript" >
        // Wait until the DOM has loaded before querying the document
        $(document).ready(function () {
            $('.tabs_title2').each(function () {
                // For each set of tabs, we want to keep track of
                // which tab is active and it's associated content
                var $active, $content, $links = $(this).find('a');

                
                // If the location.hash matches one of the links, use that as the active tab.
                // If no match is found, use the first link as the initial active tab.
                $active = $($links.filter('[href="' + location.hash + '"]')[0] || $links[0]);
                $active.addClass('active');
                $content = $($active.attr('href'));

                // Hide the remaining content
                $links.not($active).each(function () {
                    $($(this).attr('href')).hide();
                });

                // Bind the click event handler
                $(this).on('click', 'a', function (e) {
                    // Make the old tab inactive.
                    //alert($(this).find('.winTabActive1t_tb').attr('class'));

                    //$(this).find('.winTabActive1t_tb').removeClass();

                    $active.removeClass('active');
                    $content.hide();

                    // Update the variables with the new link and content
                    $active = $(this);
                    $content = $($(this).attr('href'));

                    // Make the tab active.
                    $active.addClass('active');
                    $content.fadeIn();

                    // Prevent the anchor's default click action
                    e.preventDefault();
                });
            });
        });
		</script>



    <!--      <script type="text/javascript">
                //<![CDATA[
              hs.registerOverlay({
                  thumbnailId: 'thumb3',
                    html: '<div class="closebutton" onclick="return hs.close(this)" title="Close"></div>',
                    position: 'top right',
                    fade: 2 // fading the semi-transparent overlay looks bad in IE
                });

               // hs.expandCursor = '<%= khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath   %>highslide/graphics/zoomin.cur';
              hs.graphicsDir = '<%= khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath   %>highslide/graphics/';
                hs.wrapperClassName = 'floating-caption';
                
</script>
        -->



          



       <script type="text/javascript">
           hs.graphicsDir = '<%= khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath   %>highslide/graphics/';
            hs.align = 'center';
            hs.transitions = ['expand', 'crossfade'];
            hs.outlineType = 'rounded-white';
            hs.fadeInOut = true;
            hs.dimmingOpacity = 0.75;

            // define the restraining box
            hs.useBox = false;
            hs.width = 640;
            hs.height = 480;

            // Add the controlbar
            hs.addSlideshow({
                //slideshowGroup: 'group1',
                interval: 5000,
                repeat: false,
                useControls: true,
                fixedControls: 'fit',
                overlayOptions: {
                    opacity: 1,
                    position: 'top center',
                    hideOnMouseOut: true
                }
            });
</script>
   

 

    <asp:Literal ID="ltr_demo" runat="server"></asp:Literal>
    <div class="topbar" style="width: 100%; display:inline-block " id="topbar_div" runat="server" visible="false">
        <div style="width: 100%; height: 24px; color: White">
            <div style="float: left; margin-left: 5px; margin-top: 5px">
                سیستم مدیریت محتوا</div>
            <div style="float: right; margin-right: 5px; margin-top: 5px">
                خدمات جامع فناوری وب</div>
        </div>
        <div id="top_btns" style="margin-left: 13px; ">
            <div id="AccessVisualContentManager_div" runat="server" visible="false" style="float: left;
                background-color: #ffffff; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/">وب سایت</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="AccessLayoutManager_div" runat="server" visible="false" style="float: left;
                background-color: #d2d2cc; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink5" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/Layout.aspx">جیدمان</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div style="float: left; background-color: #d2d2cc; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink4" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/manage/Default.aspx">کنترل پنل</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="float: right; margin-right: 10px; margin-top: 5px">
            <a id="link_logout" runat="server" href="manage/Default.aspx?mode=logout" style="color: #cacaca; text-decoration: none;
                font-size: 8pt;">خروج از سیستم </a>
        </div>
    </div>
<div id="toolbar2" class="toolbar2" runat="server" style="width: 100%"  >

   
   <div class="testt" style=" float:left;"  >
    <img id="btnPages"  src = "<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  %>core/themeCP/Bitrix/CssImage/topbar/btnCP001.gif" />
    
       <div style=" text-align:right ;border: 1px solid #b6b6b6; position: absolute;   background-color: #fcfcfc; width: 250px; overflow: auto; top: 83px; left: 134px; height: 303px; background-image: url('<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  %>core/themeCP/Bitrix/CssImage/toolbar/menuBorder.gif'); background-repeat: repeat-y; padding-left: 30px; z-index: 9999;  "   
            id="menu" > 
   <!-- menu stuff in here display: none;  display: none; --> 
            
              <!-- menu stuff in hکere display: none; --> 
            
            <asp:DataList ID="DataList1" runat="server"
                RepeatColumns="1">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl='<%# Eval("id","{0}") %>' 
    Text='<%# Eval("title") %>' style="font-size: small"></asp:HyperLink>
                </ItemTemplate>
            </asp:DataList>
         
</div>


</div>

<div class="areaLang" style=" float:left;"  >
    <img id="btnLang" src="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  %>core/themeCP/Bitrix/CssImage/topbar/btnCP002.gif" />
     <div style="border: 1px solid #b6b6b6; position: absolute;   background-color: #fcfcfc; width:auto ; overflow:auto  ; top: 83px; left: 134px; height:auto ; background-image: url('<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  %>core/themeCP/Bitrix/CssImage/toolbar/menuBorder.gif'); background-repeat: repeat-y; padding-left: 30px; z-index: 9999; " 
            id="menuLang" > 
        <asp:DataList ID="DataList_lang" runat="server"
                RepeatColumns="1">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl='<%# Eval("url","{0}") %>' 
    Text='<%# Eval("title") %>' style="font-size: small"></asp:HyperLink>
                </ItemTemplate>
            </asp:DataList>
    
            </div>

    </div>

                 <div style="float: left; margin-right: 10px; margin-top: 10px ;  ">
     
            <div style="text-align: right; font-size:9pt ;margin-right: 10px;  direction:ltr  ;">
                <asp:PlaceHolder ID="ph_pageInfo" runat="server"></asp:PlaceHolder>                
            </div> 
        
        </div>


         <div style=" margin-right: 10px;  padding-top:10px  " dir="rtl">
            <div style="float: right; visibility:hidden; display:none  ">
                <img src="UpLoad/profiles/1/user1.jpg" />
            </div>
            <div style="text-align: right; margin-right: 10px; float:right; direction: rtl;">
                <asp:PlaceHolder ID="ph_userInfo" runat="server"></asp:PlaceHolder>
             </div>
        </div>
        

    </div>


    <div id="first_script">
        <asp:PlaceHolder ID="PH_first_script" runat="server"></asp:PlaceHolder>
    </div>
    <div id="exheader">
        <asp:PlaceHolder ID="PH_exheader" runat="server"></asp:PlaceHolder>
    </div>
    <div id="doc_div" class="yui-t5" runat="server" >
        <div class="Dov_divinner">
            <div class="Doc_divt">
                <div class="Doc_divb">
                    <div class="Doc_divl">
                        <div class="Doc_divr">
                            <div class="Doc_divbl">
                                <div class="Doc_divbr">
                                    <div class="Doc_divtl">
                                        <div class="Doc_divtr">
                                            <div id="hd">
                                                <asp:PlaceHolder ID="PH_header" runat="server"></asp:PlaceHolder>
                                            </div>
                                            <div id="bd" >
                                                <div id="yui-main">
                                                    <div class="yui-b">
                                                        <div class="yui-g">
                                                            <!-- YOUR DATA GOES HERE -->
                                                            <asp:PlaceHolder ID="PH_content" runat="server"></asp:PlaceHolder>
         

                                 



        

                                                        </div>
                                                        <div class="yui-g" runat="server" visible="false" id="yui">
                                                            <div class="yui-u first">
                                                                <asp:PlaceHolder ID="PH_ufrist" runat="server"></asp:PlaceHolder>
                                                            </div>
                                                            <div class="yui-u">
                                                                <asp:PlaceHolder ID="PH_u" runat="server"></asp:PlaceHolder>
                                                            </div>
                                                        </div>
                                                        <asp:PlaceHolder ID="PH_content2" runat="server"></asp:PlaceHolder>
                                                    </div>
                                                </div>
                                                <div class="yui-b">
                                                    <!-- YOUR NAVIGATION GOES HERE -->
                                                    <asp:PlaceHolder ID="PH_NAVIGATION" runat="server"></asp:PlaceHolder>

                                                       
 

      
         





                                                </div>
                                            </div>
                                       
                                                 <div id="dvBeforeFooter">
                                                <asp:PlaceHolder ID="ph_beforeft" runat="server"></asp:PlaceHolder>
                                                
                                            </div>
                                           
                                            <div id="dvFooter" >
            <div class="dvFootert">
                <div class="dvFooterb">
                    <div class="dvFooterl">
                        <div class="dvFooterr">
                            <div class="dvFooterbl">
                                <div class="dvFooterbr">
                                    <div class="dvFootertl">
                                        <div class="dvFootertr">
                                                <asp:PlaceHolder ID="PH_Footer" runat="server"></asp:PlaceHolder>

                                            

                                        
            


                                                </div> </div> </div> </div> </div> </div> </div> </div> 
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="ft_external" style="width: 100%;">
        <asp:PlaceHolder ID="PH_exFooter" runat="server"></asp:PlaceHolder>       
        <asp:Literal ID="ltl_status_script" runat="server"></asp:Literal>

     


    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"  ScriptMode="Release">
    </asp:ScriptManager>




    

    </form>
    
</body>
</html>
