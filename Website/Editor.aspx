<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editor.aspx.cs"   Inherits="Editor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="core/ckeditor/ckeditor.js" type="text/javascript"></script>
    <script src="core/js/jquery-1.7.2.min.js" type="text/javascript"></script>
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

   <style type="text/css" >
	

	
	/*		div {
				padding:10px;
				width:600px;
				background:#fff;
			}*/

			.tabs li {
				list-style:none;
				display:inline;
				/*margin-top:10px;*/
			}

			.tabs a 
			{
			    /*border:1px solid #d3d3d3 ;*/
			    border-left:1px solid #d3d3d3 ;
			    border-right:1px solid #d3d3d3 ;
			    border-top:1px solid #d3d3d3 ;			    
			    
				padding:5px 5px;
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
<body style=" background-color: #d5e4f2;  font-family:Tahoma; font-size:10pt; direction:rtl ">
    <form id="form1" runat="server">
    
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

 

    </form>
</body>
</html>
