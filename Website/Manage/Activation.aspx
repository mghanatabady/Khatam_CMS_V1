<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Activation.aspx.cs" Inherits="Manage_Activation" %>

<%@ Register assembly="MSCaptcha" namespace="MSCaptcha" tagprefix="cc1" %>

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
	}
	
</style>
</head>
<body class="loginBody">

       <shinkansen:StaticResourceManager ID="StaticResourceManager1" runat="server" HttpCompressWith="GZip"
        Crunch="true" Combine="true" ScriptPlacement="Bottom">
    </shinkansen:StaticResourceManager>
   
    <form id="form1" runat="server">
    
         
    <asp:Literal ID="ltr_demo" runat="server"></asp:Literal>




<table  background="<%=khatam.core.ConfigurationManager.Cp.themeTitle %>themeCP/Bitrix/img/top_bar_fill.gif" bgcolor="black" border="0" cellpadding="0" cellspacing="0" width="100%" height="25">
	<tbody><tr>
		<td class="header_text"></td>
		<td id="timerTD" align="right"></td>
	</tr>
</tbody></table>


<table border="0" cellpadding="0" cellspacing="0" width="100%" height="100%" 
       >
       <br />
       <br />
       <br />
       <br />

<tbody><tr><td align="center" valign="middle">

<div class="bx-auth-form">
<div class="bx-auth-header"><%= resendActivationEmail%>  

    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/activation.aspx?lang=fa-IR&e=<%= this.Request.QueryString["e"]%>&s=<%= this.Request.QueryString["s"]%>"> 
<img src="../core/themeCP/Bitrix/CssImage/Lang/fa.gif" style="border-width: 0px"  /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/activation.aspx?lang=en-US&e=<%= this.Request.QueryString["e"]%>&s=<%= this.Request.QueryString["s"]%>"> 
    <img src="../core/themeCP/Bitrix/CssImage/Lang/en.gif" style="border-width: 0px" /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/activation.aspx?lang=ar-AE&e=<%= this.Request.QueryString["e"]%>&s=<%= this.Request.QueryString["s"]%>">  
    <img src="../core/themeCP/Bitrix/CssImage/Lang/Ar.gif" style="border-width: 0px" /></a>
</div>


<table border="0" cellpadding="0" cellspacing="0" width="100%">
<tbody><tr>
	<td valign="top">
		<div class="bx-auth-picture"></div>

	</td>

    
     
	<td>
		<div class="bx-auth-table">
<div id="at_bitrix">



		
<table class="data-table bx-auth-table" runat="server" id="table">
	<thead>
	</thead>
	<tbody>

        	<tr>
			<td>
                &nbsp;</td>
		</tr>

			</tbody>
	<tfoot>



	</tfoot>
</table>

<div style="text-align: center">
   
                <asp:Label ID="LblMsg" runat="server" 
                    ></asp:Label>

                <br />
                <asp:Label ID="LblBackTologin" runat="server"  ></asp:Label>

            </div>



   
      


</div>
		</div>
	</td>
</tr>
</tbody></table>


</div>  
</td></tr></tbody></table>

<asp:Literal ID="ltl_status_script" runat="server"></asp:Literal>

    </form>
</body>
</html>
