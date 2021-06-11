<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivationReSend.aspx.cs" Inherits="Manage_ActivationReSend" %>

<%@ Register assembly="MSCaptcha" namespace="MSCaptcha" tagprefix="cc1" %>

<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.Captcha" tagprefix="obout" %>


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
         <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
         
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

    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/ActivationReSend.aspx?lang=fa-IR"> 
<img src="../core/themeCP/Bitrix/CssImage/Lang/fa.gif" style="border-width: 0px"  /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/ActivationReSend.aspx?lang=en-US"> 
    <img src="../core/themeCP/Bitrix/CssImage/Lang/en.gif" style="border-width: 0px" /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/ActivationReSend.aspx?lang=ar-AE">  
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
		<tr>
			<td colspan="2"><b><%=Authorization%> </b></td>
		</tr>
	</thead>
	<tbody>
		<tr>



			<td>
                <asp:RequiredFieldValidator ID="VrfUsername" runat="server" 
                    ControlToValidate="TxtEmail" >*</asp:RequiredFieldValidator>
                <%=Email%>:</td>
			<td><asp:TextBox ID="TxtEmail" runat="server" Width="150px" 
                    ValidationGroup="loginFrm"></asp:TextBox></td>
		</tr>

        	<tr>
			<td></td>
			<td>
                <obout:CaptchaImage ID="CaptchaImage1" runat="server" />
                </td>
		</tr>

			</tbody>
	<tfoot>



	    	<tr>
			<td>
                <asp:RequiredFieldValidator ID="VrfCaptcha" runat="server" 
                  ControlToValidate="TxtCaptcha">*</asp:RequiredFieldValidator>
                 <%=CAPTCHAcode%>:</td>
			<td><asp:TextBox ID="TxtCaptcha" runat="server" Width="150px" 
                    ValidationGroup="loginFrm"></asp:TextBox></td>
		</tr>



			<tr>
			<td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ForeColor="#FF0001" ValidationGroup="loginFrm" />
                <br />
                <asp:Label ID="LblUserNotFound" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                <br />
                <asp:Label ID="LblIncorectCaptcha" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                                     <br />
                <asp:Label ID="LblErrorUserWasActive" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                </td>
		</tr>
			<tr>
			<td colspan="2" class="authorize-submit-cell"> 
                <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" 
                    onclick="Button1_Click" Width="100px" />  </td>
		</tr>
	</tfoot>
</table>

<div style="text-align: center">
        <asp:Label ID="lblEmailSentOD" runat="server" 
            style="text-align: center; font-weight: 700;"></asp:Label>
            </div>

	<p>
<b><%=BackToLoginPage%></b><br />
      

<script type="text/javascript">
    try { document.form_auth.USER_PASSWORD.focus(); } catch (e) { }
</script>
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

