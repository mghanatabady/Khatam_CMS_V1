<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default22.aspx.cs" Inherits="Default22" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    

      <title>jQuery UI Dialog - Default functionality</title> 
     <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
      <script src="http://code.jquery.com/jquery-1.9.1.js"></script>  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script> 
     <link rel="stylesheet" href="/resources/demos/style.css" />  
<script type="text/javascript">
    
    function pageLoad(sender, args) {
         
        if (args.get_isPartialLoad()) {
             if ($("#win1").length != 0) {
                 $("#dialog").dialog({ modal: true });
                
            }
            else {
                 $("#dialog").dialog("destroy");
            }
       
       
        }
    }
</script>
</head>
<body>
    <form id="form1" runat="server">



        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    

       

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
      

                           <div id="win1" runat="server"  visible="false" ><div id="dialog" title="Basic dialog">  <p>This is the default dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p></div></div>
        
    
               

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" style="height: 26px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />

            </ContentTemplate>
        </asp:UpdatePanel>



 



 
    </form>
</body>
</html>
