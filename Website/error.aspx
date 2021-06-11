<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
	<meta http-equiv="X-UA-Compatible" content="IE=7" />
  
    <link id="styleTag" rel="stylesheet" type="text/css" runat="server" />

    <style type="text/css">
	.header_text
	{
		font-family: Tahoma ;
		font-size:12px;
		color:white;
	background:#781813 url(/bitrix/images/main/wizard_sol/bg_fill.gif) repeat;
		
	}
	

	
</style>
</head>
<body class="loginBody_red">
       <shinkansen:StaticResourceManager ID="StaticResourceManager1" runat="server" HttpCompressWith="GZip"
        Crunch="true" Combine="true" ScriptPlacement="Bottom">
    </shinkansen:StaticResourceManager>

    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
         
    





<table border="0" cellpadding="0" cellspacing="0" width="100%" height="100%" 
       >
       <br />
       <br />
       <br />
       <br />

<tbody><tr><td align="center" valign="middle">

<div class="bx-auth-form">
<div class="bx-auth-header">
</div>


<table border="0" cellpadding="0" cellspacing="0" width="100%">
<tbody><tr>
	<td valign="top">
    
		<div class="bx-auth-picture_error"></div>
        <div id="demoUserPass" runat="server"  >
         </div>

	</td>

    
     
	<td>
		<div class="bx-auth-table">
<div id="at_bitrix">



		
<table class="data-table bx-auth-table"  style="  width:370px;  ">
	<thead>
		<tr>
			<td style= " text-align:right ; direction:rtl " >
             
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        

            </td>
		</tr>
	</thead>
	<tbody>
			</tbody>
	<tfoot>



	</tfoot>
</table>
	<p>



</div>
		</div>
	</td>
</tr>
</tbody></table>


</div>  
</td></tr></tbody></table>



    </form>
</body>
</html>
