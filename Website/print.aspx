<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css" >
         html
         {
           font-family:Tahoma;   
         }
    
    </style>
    <META NAME="ROBOTS" CONTENT="NOINDEX, NOFOLLOW">

</head>
<body onload="window.print();" class="printbody">
    <form id="form1" runat="server">

    
    <div>
    <div id="header" style=" width:100%; display:block; ">
    <div id="logo" style=" float:right ; direction:rtl  ">
            <img id="imgLogo" class="style1" 
            runat="server" /><br />
        <strong>
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
    </strong>
    </div>


         <div id="info"  style=" text-align:left;  font-weight:bold; float:left; direction: rtl;" 
            dir="rtl"> شماره:
         <asp:Label ID="LblId" runat="server"></asp:Label>
     <br />
     <asp:Label ID="lblDate" runat="server"></asp:Label>
     <br /> لینک:
     <span dir="ltr"  >
             <asp:HyperLink ID="hlLink" runat="server"></asp:HyperLink> </span>
     

      <br />
        
     </div>

    </div>
    
    <div id="content" style="  clear: both; direction:rtl ; text-align:justify  ">    
    <asp:PlaceHolder ID="ph" runat="server"></asp:PlaceHolder>
    </div> 
    <div id="footer" style=" text-align:center ">
             <asp:Label ID="lbl_footer" runat="server"></asp:Label>

    </div>

    </div>
    </form>
</body>
</html>
