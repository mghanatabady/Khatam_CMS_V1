<%@ Page Language="C#" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family:Tahoma;
            
        }
        .row
        {
             background-color:Lime;
             direction:rtl;
             text-align:right;
             padding:10px 20px 20px 20px;
              line-height:200%;
              
        }
  
        
    </style>

    <link href="core/css/flick/fb_form.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server"  >
   
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
 
    </form>
</body>
</html>
