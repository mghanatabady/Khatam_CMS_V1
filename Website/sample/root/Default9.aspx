<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="Default9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="core/js/jquery-1.7.2.min.js"></script>

   <script type="text/javascript">

  
       function initializeSlider() {
           $('.tabs').each(function () {
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
           return true;
       }



       $(document).ready(function () {
           initializeSlider();
           //Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
           //   initializeSlider();
           // });
       });
   </script>

    <style>
			* {padding:0; margin:0;}

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

		</style>

</head>
<body style=" background-color: #d5e4f2;  font-family:Tahoma; font-size:10pt; direction:rtl ">
    <form id="form1" runat="server">
    <div>
    
  <ul class='tabs'>
    <li><a href='#tab1'>Tab 1</a></li>
    <li><a href='#tab2'>Tab 2</a></li>
    <li><a href='#tab3'>Tab 3</a></li>
  </ul>
  <div id='tab1'>
    <p>Hi, this is the first tab.</p>
  </div>
  <div id='tab2'>
    <p>This is the 2nd tab.</p>
  </div>
  <div id='tab3'>
    <p>And this is the 3rd tab.</p>
  </div>
        

    </div>
    </form>
</body>
</html>
