<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Layout.aspx.cs" Inherits="Layout" %>

<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>

<%@ Register assembly="RadDock.Net2" namespace="Telerik.WebControls" tagprefix="cc1" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title></title>
   
	
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
   

     <!--
     

    <link href="Module/Core/Build/reset-fonts-grids.css" rel="stylesheet" type="text/css" />
  
	<script src="Module/core/Scripts/AC_RunActiveContent.js" type="text/javascript"></script>
	<link id="MyStyleSheet" rel="stylesheet" type="text/css" runat="server" />
 <script src="Scripts/jquery-1.5.2.min.js" type="text/javascript"></script>   
    <script src="fckeditor/fckeditor.js" type="text/javascript"></script>




     -->
   
    <script src="core/js/jquery-1.9.1.js" type="text/javascript"></script>
    


       <script  type="text/javascript" >




           $(document).ready(function () {


               //

               //$(dockObj).fadeOut();


               //var str_r = $(".RadDockableObjectTitle").html();
               //var str_r = $(".RadDockableObjectTitle").closest(".RadDockingZone").attr("id");


               //for  


               //str_r = str_r;

               //$("#Text1").val(str_r);

               $("#btnSaveObjectStatus").click(function () {
                   var str_r = "";

                   // var str_r = $(".RadDockableObjectTitle").size();

                   $(".RadDockableObjectTitle").each(function (index) {

                       //str_r = $(".RadDockableObjectTitle").text().index() + ":" + str_r
                       //str_r = index + " " + str_r

                       str_name = ".RadDockableObjectTitle:eq(" + index + ")"
                       str_r = $(str_name).text() + "," + $(str_name).closest(".RadDockingZone").attr("id") + ";" + str_r

                       //+ ":" + $(".RadDockableObjectTitle").closest(".RadDockingZone").attr("id").text(); 

                   });

                   $("#Text1").val(str_r);

               });

           });






    </script>

		<script   type="text/javascript"  >
		    function alertCommand(dockableObject, command) {
		        $(dockableObject).remove()
		        //  alert("Command [" + command.Name + "] clicked.");
		    }

            

	
		</script>


        <script  type="text/javascript">
            $(document).ready(function () {

                $('#start_btn').click(function () {

                    $('#component_panel').toggle(200);



                });


                $('#toolbar_hide_btn').toggle(function () {


                    $('#toolbar_top').slideUp();
                    $('#toolbar_hide_btn').attr("src", "images/cp/toolbar_hide_btn_down.gif");


                },

                 function () {
                     $('#toolbar_top').slideDown();
                     $('#toolbar_hide_btn').attr("src", "images/cp/toolbar_hide_btn_up.gif");


                 });



         


            }); 

        </script>

        <script type="text/javascript" >



            $(document).ready(function () {
                $("#menu").hide();
                $("#menuLang").hide();




                var pageHeight = $(document).height();

                var p = $(".topbar");
                var position = p.position();
                var topSide = position.top + 132;
              
                var pos1 = $("#btnPages").position();
                $("#panelSide").css("top", topSide);
                $("#panelSideHide").css("top", topSide);


                $("#panelSide").css("height", (pageHeight - topSide));
                //  $("#panelSide").css("top", $("#btnPages").height );
                $("#panelSideHide").css("height", (pageHeight - topSide));


                $("#menu").hide();
                $("#menuLang").hide();
                $("#panelSideHide").hide();

                $("#btnGrids").hover(
              function () {
                  $('#btnGrids').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCPr.gif");
              },
               function () {
                   $('#btnGrids').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCP.gif");
               }
               );


                $("#btnPages").hover(
               function () {

                   $('#btnPages').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCP001r.gif");
               },
                function () {
                    $('#btnPages').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCP001.gif");
                }
               );

                $("#btnLang").hover(
                function () {

                    $('#btnLang').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCP002r.gif");
                },
              function () {
                  $('#btnLang').attr("src", "core/themeCP/Bitrix/CssImage/topbar/btnCP002.gif");
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


                $("#BtnPanel").click(function () {
                    //$("#BtnPanel").hide();
                    $("#panelSideHide").show();
                    $("#panelSide").hide();
                });


                $("#BtnPanelShow").click(function () {
                    //$("#BtnPanel").hide();
                    $("#panelSideHide").hide();
                    $("#panelSide").show();
                });






            });


        </script>
            
    <style type="text/css">
        #btnGrids
        {
            border-width: 0px;
        }
        .style1
        {
            color: #FFFFFF;
        }
        .style2
        {
            color: #deed46;
        }
        .style4
        {
            color: #49cfb2;
        }
    </style>




            
</head>



<body id="bodyTag" runat="server">

 <shinkansen:StaticResourceManager ID="StaticResourceManager1" runat="server" 
           HttpCompressWith="GZip" Crunch="true" Combine="true" ScriptPlacement="Bottom">

</shinkansen:StaticResourceManager>


	<form id="form1" runat="server">

    
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    
    </asp:ScriptManager>

    <asp:Literal ID="ltr_demo" runat="server"></asp:Literal>




    <cc1:RadDockingManager ID="RadDockingManager1" runat="server" Skin="default" />


        <radA:RadAjaxManager ID="RadAjaxManager1" runat="server" >
    </radA:RadAjaxManager>


        <div class="topbar"  style=" width:100%;" id="topbar_div" runat="server" >
    
        <div style="width:100%;  height: 24px; color:White ">
    <div style="float:left; margin-left:5px; margin-top:5px">سیستم مدیریت محتوا</div>
    <div style="float:right; margin-right:5px; margin-top:5px">خدمات جامع فناوری وب</div>
    </div>

    
    <div id="top_btns" style="   margin-left:13px" >


    <div id="AccessVisualContentManager_div"  runat="server"   style=" float:left;  background-color: #d2d2cc;  margin-right:5px;margin-top:6px ">
<div class="t_dent"><div class="b_dent"><div class="l_dent"><div class="r_dent"><div class="bl_dent"><div class="br_dent"><div class="tl_dent"><div class="tr_dent">

    <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="False" 
        ForeColor="#474747" NavigateUrl="~/Default.aspx">وب سایت</asp:HyperLink>
</div></div></div></div></div></div></div></div> 
</div>



<div id="AccessLayoutManager_div" runat="server"    style=" float:left;  background-color: #ffffff;  margin-right:5px;margin-top:6px ">
<div class="t_dent"><div class="b_dent"><div class="l_dent"><div class="r_dent"><div class="bl_dent"><div class="br_dent"><div class="tl_dent"><div class="tr_dent">
    <asp:HyperLink ID="HyperLink5" runat="server" Font-Underline="False" 
        ForeColor="#474747" NavigateUrl="~/Layout.aspx">جیدمان</asp:HyperLink>
</div></div></div></div></div></div></div></div> 
</div>


<div style=" float:left;  background-color: #d2d2cc;  margin-right:5px;margin-top:6px ">
<div class="t_dent"><div class="b_dent"><div class="l_dent"><div class="r_dent"><div class="bl_dent"><div class="br_dent"><div class="tl_dent"><div class="tr_dent">
    <asp:HyperLink ID="HyperLink4" runat="server" Font-Underline="False" 
        ForeColor="#474747" NavigateUrl="~/manage/Default.aspx">کنترل پنل</asp:HyperLink>
</div></div></div></div></div></div></div></div> 
</div>


<div style=" float:right ;  margin-right:10px; margin-top:5px">

    <a href="manage/Default.aspx?mode=logout" 
        style="color:#cacaca; text-decoration: none; font-size: 8pt;" >خروج از سیستم
  

</a>
  

</div>


</div>
      




</div>


<div class="toolbar2"   style="float: none;				clear: both;" >

   
   <div class="testt" style=" float:left; margin-right: 2px; margin-left: 2px;"  >
    <img id="btnPages"  src="core/themeCP/Bitrix/CssImage/topbar/btnCP001.gif" />
    
       <div style=" text-align:right ;border: 1px solid #b6b6b6; position: absolute;   background-color: #fcfcfc; width: 250px; overflow: auto; top: 83px; left: 134px; height: 303px; background-image: url('core/themeCP/Bitrix/CssImage/toolbar/menuBorder.gif'); background-repeat: repeat-y; padding-left: 30px; z-index: 9999;  "   
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
    <img id="btnLang" src="core/themeCP/Bitrix/CssImage/topbar/btnCP002.gif" />
     <div style="border: 1px solid #b6b6b6; position: absolute;   background-color: #fcfcfc; width: 89px; overflow: auto; top: 83px; left: 134px; height: 85px; background-image: url('core/themeCP/Bitrix/CssImage/toolbar/menuBorder.gif'); background-repeat: repeat-y; padding-left: 30px; z-index: 9999; " 
            id="menuLang" > 
                <asp:HyperLink ID="HL_Lang1" runat="server">فارسی</asp:HyperLink> 
                <br />
    <asp:HyperLink ID="HL_Lang2" runat="server">English</asp:HyperLink> 
    <br />
    <asp:HyperLink ID="HL_Lang3" runat="server">Arabic</asp:HyperLink> 
    <br />
    <asp:HyperLink ID="HL_Lang4" runat="server">Deutsch</asp:HyperLink> 
    
            </div>

    </div>


    
    <div class="areaGrid" style=" padding: 5px; float:left; direction:rtl; font-size:8pt;  font-family:Tahoma; text-align:right "  >

    

    <fieldset>
            <legend>قاب بندی</legend>
          
            <span class="style1">█ </span>پهنای  صفحه
             
        <asp:DropDownList ID="DdlBodySize" runat="server" AutoPostBack="True" 
            Font-Names="Tahoma" onselectedindexchanged="DdlBodySize_SelectedIndexChanged">
            <asp:ListItem Value="doc">750 پیکسل</asp:ListItem>
            <asp:ListItem Value="doc2">950 پیکسل</asp:ListItem>
            <asp:ListItem Value="doc4">974 پیکسل</asp:ListItem>
            <asp:ListItem Value="doc3">100 درصد</asp:ListItem>
        </asp:DropDownList>

        <br />
            <span class="style2">█ </span>وضعیت ستون کناری
         
        <asp:DropDownList ID="DdlBodyCol" runat="server" AutoPostBack="True" 
            Font-Names="Tahoma" 
            onselectedindexchanged="DdlBodyCol_SelectedIndexChanged" >
            <asp:ListItem Value="yui-t7">بدون ستون</asp:ListItem>
            <asp:ListItem Value="yui-t1">160 پیکسل چپ</asp:ListItem>
            <asp:ListItem Value="yui-t2">180 پیکسل چپ</asp:ListItem>
            <asp:ListItem Value="yui-t3">300 پیکسل چپ</asp:ListItem>
           <asp:ListItem Value="yui-t4">160 پیکسل راست</asp:ListItem>
            <asp:ListItem Value="yui-t5">240 پیکسل راست</asp:ListItem>
            <asp:ListItem Value="yui-t6">300 پیکسل راست</asp:ListItem>
        
        </asp:DropDownList>


              <br >
            <span class="style4">█  </span>تقسیم بندی محتوا
         
        <asp:DropDownList ID="DdlContentCol" runat="server" AutoPostBack="True" 
            Font-Names="Tahoma"   
            onselectedindexchanged="DdlContentCol_SelectedIndexChanged" >

           
            <asp:ListItem Value="yui-g">2 ستون (50/50)</asp:ListItem>
            <asp:ListItem Value="yui-gc">2 ستون (66/33)</asp:ListItem>
            <asp:ListItem Value="yui-gd">2 ستون (33/66)</asp:ListItem>
           <asp:ListItem Value="yui-ge">2 ستون (75/25)</asp:ListItem>
           <asp:ListItem Value="yui-gf">2 ستون (25/75)</asp:ListItem>
            
        
        </asp:DropDownList>


        </fieldset>



    </div>


        
    <div class="areaObjects" style=" padding: 5px; float:left; direction:rtl; font-size:8pt;  font-family:Tahoma; text-align:right "  >

    

    <fieldset>
            <legend>درج اشیا</legend>
          
            <span class="style1">█ </span>لیست اشیا
             
       <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="title" DataValueField="id" Font-Names="Tahoma" 
            Width="165px">
    </asp:DropDownList>
  

    <br />
   





        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
     
            SelectCommand="SELECT title, id FROM core_serverControlsInstance">
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Text="درج شی" onclick="Button1_Click" 
            Font-Names="Tahoma"  ValidationGroup="none" />
           
        <asp:Button ID="btnSaveObjectStatus" runat="server" Text="ذخیره وضعیت" 
            onclick="btnSaveObjectStatus_Click" Font-Names="Tahoma"  ValidationGroup="none"  />
        
        <br />
        
        
    &nbsp;
        <input id="Text1" type="text"     runat="server"
            style=" width:40px;  visibility:hidden   "    />


        </fieldset>



    </div>

        


                        <div style="float: left; margin-right: 10px; margin-top: 10px ;  ">
     
            <div style="text-align: right; font-size:9pt ;margin-right: 10px;  direction:ltr  ;">
                <asp:PlaceHolder ID="ph_pageInfo" runat="server"></asp:PlaceHolder>      
            </div> 
        
        </div>







    </div>
    <!-- debug error of half show add temp raddock -->
     <div  style="visibility: hidden;  " >
     <cc1:RadDockingZone ID="RadDockingZone1" runat="server" Width="100%"  BackColor="#d5e6ec">
           </cc1:RadDockingZone>
           </div>
	   <div id="exhd" runat="server" style=" width:100%"   >
       <cc1:RadDockingZone ID="RadDockingZone_exheader" runat="server" Width="100%" BackColor="#d5e6ec">
           </cc1:RadDockingZone>
           
      
   </div>



 


	<div id="doc_div" class="yui-t5" runat="server"  style="background-color: #ffffff" >

       


		<div id="hd">

             <cc1:RadDockingZone ID="RadDockingZone_hd" runat="server" Width="100%" BackColor="#4bacc6">
           </cc1:RadDockingZone>

		</div>
		<div id="bd">
			<div id="yui-main">
				<div class="yui-b">
					<div class="yui-g">
						<!-- YOUR DATA GOES HERE -->

                             <cc1:RadDockingZone ID="RadDockingZone_content" runat="server" Width="100%" BackColor="#48d77c">
           </cc1:RadDockingZone>

					</div>
					<div class="yui-g" runat="server"  visible="false" id="yui" >
						<div class="yui-u first" >
                   
                                     <cc1:RadDockingZone ID="raddockingzone_ufrist" runat="server" Width="100%"  BackColor="#49cfb2">
           </cc1:RadDockingZone>


						</div>
						<div class="yui-u" >
							
                            <cc1:RadDockingZone ID="RadDockingZone_u" runat="server" Width="100%" 
                                BackColor="#49cfb2">
                                          </cc1:RadDockingZone>

						</div>
					</div>
					

                     <cc1:RadDockingZone ID="RadDockingZone_content2" runat="server" Width="100%" BackColor="#94e646">
                                          </cc1:RadDockingZone>

				</div>
			</div>
			<div class="yui-b" id="dvNavigation" runat="server"    >
				<!-- YOUR NAVIGATION GOES HERE -->

                  <cc1:RadDockingZone ID="RadDockingZone_NAVIGATION" runat="server" 
                    Width="100%" BackColor="#deed46" >
                                          </cc1:RadDockingZone>

			</div>
		</div>
		<div id="ft">
			

             <cc1:RadDockingZone ID="RadDockingZone_beforeft" runat="server" Width="100%" BackColor="#f4b946">
                                          </cc1:RadDockingZone>

			

             <cc1:RadDockingZone ID="RadDockingZone_Footer" runat="server" Width="100%" BackColor="#f79646">
                                          </cc1:RadDockingZone>
		</div>

  


 

	</div>

              <div id="ft_external" 
        style="  width:100%; " >

                	<cc1:RadDockingZone ID="RadDockingZone_exFooter" runat="server" Width="100%" BackColor="#fce0d4">
           </cc1:RadDockingZone>
</div>
    
    


    
    <div id="panelSide" 
        
        
        style="left: 0px; border-style: none;  width: 187px; height: 100px; top: 152px; position: absolute; background-image: url('core/themeCP/Bitrix/CssImage/Panel/panelBg.gif'); right: 1047px; ">
    
    <div style=" width: 160px;">
    
        </div>



    <div id="objects" style=" text-align:left ; font-size:9pt ; padding:5px">

            <div dir="rtl" >
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>



<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
                                  
             عنوان صفحه
             <br /><br />
        <asp:TextBox ID="txtSectionTitle" runat="server" Width="165px" Font-Names="Tahoma" MaxLength="120"  ></asp:TextBox>
             <br />


                         <br />
             کلمات کلیدی
             <br /><br />
        <asp:TextBox ID="txtSectionKeywords" runat="server" TextMode="MultiLine" Width="165px" 
                    Height="40px" Font-Names="Tahoma" MaxLength="80"  ></asp:TextBox>
             <br />

            <br />
             شرح
             <br />   <br />
        <asp:TextBox ID="txtSectionDescription" runat="server" TextMode="MultiLine" Width="165px" 
                    Height="50px" Font-Names="Tahoma" MaxLength="200"  ></asp:TextBox>
             <br />

             <br />
نویسنده
             <br />   <br />
        <asp:TextBox ID="txtSectionAuthor" runat="server"  Width="165px" Font-Names="Tahoma" 
                    MaxLength="20"  ></asp:TextBox>
             <br />
               <br />

                            <br />
دوره ی تغییر
             <br />   <br />
                <asp:DropDownList ID="DDLSectionChangefreq" runat="server" Width="165px" Font-Names="Tahoma" >
                    <asp:ListItem Value="always">هر لحظه</asp:ListItem>
                    <asp:ListItem Value="hourly">هر ساعت</asp:ListItem>
                    <asp:ListItem Value="daily">روزانه</asp:ListItem>
                    <asp:ListItem Value="weekly">هفتگی</asp:ListItem>
                    <asp:ListItem Value="monthly">ماهانه</asp:ListItem>
                    <asp:ListItem Value="yearly">سالیانه</asp:ListItem>
                     <asp:ListItem Value="never">هرگز</asp:ListItem>
                                           
                                     </asp:DropDownList>
             <br />
               <br />

                            <br />
درجه اهمیت
             <br />   <br />
      
                                     <asp:DropDownList ID="DDLSectionPriority" runat="server" Width="70px" Font-Names="Tahoma" >
                                         <asp:ListItem>0.0</asp:ListItem>
                                         <asp:ListItem>0.1</asp:ListItem>
                                         <asp:ListItem>0.2</asp:ListItem>
                                         <asp:ListItem>0.3</asp:ListItem>
                                         <asp:ListItem>0.4</asp:ListItem>
                                         <asp:ListItem>0.5</asp:ListItem>
                                         <asp:ListItem>0.6</asp:ListItem>
                                         <asp:ListItem>0.7</asp:ListItem>
                                         <asp:ListItem>0.8</asp:ListItem>
                                         <asp:ListItem>0.9</asp:ListItem>
                                         <asp:ListItem>1.0</asp:ListItem>
                                     </asp:DropDownList>
      
             <br />
               <br />


              

                <asp:Button ID="Button2" runat="server" Text="ثبت" Font-Names="Tahoma" 
                    onclick="Button2_Click"  />


    </ContentTemplate>
</asp:UpdatePanel>

             </div>
            </div>


        <img id="BtnPanel" src="core/themeCP/Bitrix/CssImage/Panel/BtnPanel.gif" 
            style="position: absolute; top: 150px; left: 181px; cursor: pointer;" />
    </div>

    <div id="panelSideHide" 
        
        style="left: 0px; border-style: none; width: 20px; height: 100px; top: 132px; position: absolute; background-image: url('core/themeCP/Bitrix/CssImage/Panel/panelHideBg.gif');">

        <img id="BtnPanelShow" src="core/themeCP/Bitrix/CssImage/Panel/BtnPanelshow.gif" 
            style="position: absolute; top: 150px; left: 14px; cursor: pointer;" />
    </div>

        <asp:Literal ID="ltl_status_script" runat="server"></asp:Literal>


	</form>
</body>


</html>