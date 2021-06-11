<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs"  Inherits="Manage_Login" %>

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
	
        .auto-style1 {
            height: 30px;
        }
	
        .auto-style2 {
            width: 200px;
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




<table bgcolor="black" border="0" cellpadding="0" cellspacing="0" width="100%" height="25">
	<tbody><tr>
		<td class="header_text"></td>
		<td id="timerTD" align="right"  style="color:White; padding-right: 10px; font-size: 8pt;" >
        
                  
                <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>" style="color: #cacaca; text-decoration: none;
                    font-size: 8pt;">صفحه اصلی </a>
        
        
        </td>
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
<div class="bx-auth-header"><%=Authorization%> 

    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/login.aspx?lang=fa-IR"> 
<img src="../core/themeCP/Bitrix/CssImage/Lang/FA.gif" style="border-width: 0px"  /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/login.aspx?lang=en-US"> 
    <img src="../core/themeCP/Bitrix/CssImage/Lang/en.gif" style="border-width: 0px" /></a>
    <a href="<%= khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath%>manage/login.aspx?lang=ar-AE">  
    <img src="../core/themeCP/Bitrix/CssImage/Lang/Ar.gif" style="border-width: 0px" /></a>
</div>


<table border="0" cellpadding="0" cellspacing="0" width="100%">
<tbody><tr>
	<td valign="top">
		<div class="bx-auth-picture"></div>
        <div id="demoUserPass" runat="server"  >
        <br />
        نام کاربری: demo@yourDomain.com
        <br />
        کلمه عبور: demo
        </div>

	</td>

    
     
	<td>
		<div class="bx-auth-table">
<div id="at_bitrix">






    <div  style="width:300px; text-align:left ">
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>       
       


<table class="data-table bx-auth-table">
	<thead>
		<tr>
			<td colspan="2"><b><%=Authorization%> </b></td>
		</tr>
	</thead>
	<tbody>
		<tr>



			<td>
                <asp:RequiredFieldValidator ID="VrfUsername" runat="server" 
                    ControlToValidate="TxtUserName" >*</asp:RequiredFieldValidator>
                <%=UserName%>:</td>
			<td><asp:TextBox ID="TxtUserName" runat="server" Width="150px" 
                    ValidationGroup="loginFrm"></asp:TextBox></td>
		</tr>
		<tr>
			<td>
                <asp:RequiredFieldValidator ID="VrfPassword" runat="server" 
                    ControlToValidate="TxtPassword" >*</asp:RequiredFieldValidator>
                <%=Password%>:</td>
			<td><asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" Width="150px" 
                    ValidationGroup="loginFrm"></asp:TextBox></td>
		</tr>

        	<tr>
			<td></td>
			<td>
                <obout:CaptchaImage ID="CaptchaImage1" runat="server" />
                </td>
		</tr>

        	<tr>
			<td>
                <asp:RequiredFieldValidator ID="VrfCaptcha" runat="server" 
                  ControlToValidate="TxtCaptcha">*</asp:RequiredFieldValidator>
                 <%=CAPTCHAcode%>:</td>
			<td><asp:TextBox ID="TxtCaptcha" runat="server" Width="150px" 
                    ValidationGroup="loginFrm"></asp:TextBox></td>
		</tr>
			</tbody>
	<tfoot>



			<tr>
			<td colspan="2"><input id="USER_REMEMBER" name="USER_REMEMBER" value="Y" type="checkbox" runat="server" /><label for="USER_REMEMBER"><%=RememberMeOnthisComputer%></label></td>
		</tr>



			<tr>
			<td colspan="2" dir="rtl" style="text-align: right">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ForeColor="#FF0001" ValidationGroup="loginFrm" />
                <br />
                <asp:Label ID="LblIncorectUserOrPass" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                <br />
                <asp:Label ID="LblIncorectCaptcha" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                <br />
            
                    <asp:Label ID="LblEmailNotActive" runat="server" ForeColor="Red" 
                    Visible="False"></asp:Label>
                </td>
		</tr>
			<tr>
			<td colspan="2" class="authorize-submit-cell"> 



                <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" 
                    onclick="Button1_Click" Width="100px" />
          

			</td>
		</tr>
	</tfoot>
</table>
	<p>
<b><%=ForgotYourPassword%></b><br>
        <%=Gotothe%> <%=requestPasswordForm%><br>





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
