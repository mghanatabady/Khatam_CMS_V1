<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Install_Default" %>

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
    
		<div class="bx-auth-picture_install"></div>
        <div id="demoUserPass" runat="server"  >
         </div>

	</td>

    
     
	<td>
		<div class="bx-auth-table">
<div id="at_bitrix">



		
<table class="data-table bx-auth-table"  style="  width:370px;  ">
	<thead>
		<tr>
			<td >
             
                     









                     <div id="Div1">



		<p><strong><%=pleaseAuthorize%>Install Process</strong></p>
<table class="data-table bx-auth-table">
	<thead>
		<tr>
			<td colspan="2"><b><%=Authorization%> End-User License Agreement</b></td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Height="150px" TextMode="MultiLine" 
                    Width="303px" ReadOnly="True">Khatam Software Development SOFTWARE LICENSE TERMS
Khatam Software Development WebSiteBuilder 1.1
These license terms are an agreement between Khatam Software Development Corporation (or based on where you live, one of its affiliates) and you.  Please read them.  They apply to the software named above, which includes the media on which you received it, if any.  The terms also apply to any Khatam Software Development
·	updates,
·	supplements,
·	Internet-based services, and 
·	support services
for this software, unless other terms accompany those items.  If so, those terms apply.
BY USING THE SOFTWARE, YOU ACCEPT THESE TERMS.  IF YOU DO NOT ACCEPT THEM, DO NOT USE THE SOFTWARE.
If you comply with these license terms, you have the rights below.
1.	INSTALLATION AND USE RIGHTS.  You may install and use any number of copies of the software on your devices.
2.	Scope of License.  The software is licensed, not sold. This agreement only gives you some rights to use the software.  Khatam Software Development reserves all other rights.  Unless applicable law gives you more rights despite this limitation, you may use the software only as expressly permitted in this agreement.  In doing so, you must comply with any technical limitations in the software that only allow you to use it in certain ways.    You may not
·	work around any technical limitations in the software;
·	reverse engineer, decompile or disassemble the software, except and only to the extent that applicable law expressly permits, despite this limitation;
·	make more copies of the software than specified in this agreement or allowed by applicable law, despite this limitation;
·	publish the software for others to copy;
·	rent, lease or lend the software;
·	transfer the software or this agreement to any third party; or
·	use the software for commercial software hosting services.
3.	BACKUP COPY.  You may make one backup copy of the software.  You may use it only to reinstall the software.
4.	DOCUMENTATION.  Any person that has valid access to your computer or internal network may copy and use the documentation for your internal, reference purposes.
5.	Export Restrictions.  The software is subject to United States export laws and regulations.  You must comply with all domestic and international export laws and regulations that apply to the software.  These laws include restrictions on destinations, end users and end use.  For additional information, see www.yourDomain.com/exporting &lt;http://www.yourDomain.com/exporting&gt;.
6.	SUPPORT SERVICES. Because this software is “as is,” we may not provide support services for it.
7.	Entire Agreement.  This agreement, and the terms for supplements, updates, Internet-based services and support services that you use, are the entire agreement for the software and support services.
8.	Applicable Law.
a.	United States.  If you acquired the software in the United States, Washington state law governs the interpretation of this agreement and applies to claims for breach of it, regardless of conflict of laws principles.  The laws of the state where you live govern all other claims, including claims under state consumer protection laws, unfair competition laws, and in tort.
b.	Outside the United States.  If you acquired the software in any other country, the laws of that country apply.
9.	Legal Effect.  This agreement describes certain legal rights.  You may have other rights under the laws of your country.  You may also have rights with respect to the party from whom you acquired the software.  This agreement does not change your rights under the laws of your country if the laws of your country do not permit it to do so.
10.	Disclaimer of Warranty.   The software is licensed “as-is.”  You bear the risk of using it.  Khatam Software Development gives no express warranties, guarantees or conditions.  You may have additional consumer rights under your local laws which this agreement cannot change.  To the extent permitted under your local laws, Khatam Software Development excludes the implied warranties of merchantability, fitness for a particular purpose and non-infringement.
11.	Limitation on and Exclusion of Remedies and Damages.  You can recover from Khatam Software Development and its suppliers only direct damages up to U.S. $5.00.  You cannot recover any other damages, including consequential, lost profits, special, indirect or incidental damages.
This limitation applies to
·	anything related to the software, services, content (including code) on third party Internet sites, or third party programs; and
·	claims for breach of contract, breach of warranty, guarantee or condition, strict liability, negligence, or other tort to the extent permitted by applicable law.
It also applies even if Khatam Software Development knew or should have known about the possibility of the damages.  The above limitation or exclusion may not apply to you because your country may not allow the exclusion or limitation of incidental, consequential or other damages.</asp:TextBox>
     
            </td>
		</tr>
		<tr>



			<td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" 
                    Text="I accept the terms in the license Agreement" />
            </td>
		</tr>
		<tr>
			<td class="style3">
                &nbsp;</td>
			<td>
                &nbsp;</td>
		</tr>

        	<tr>
			<td class="style3"><strong>Admin Detail</strong></td>
			<td>
             
                </td>
		</tr>

        	<tr>
			<td class="style3">First Name:<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Input First Name" ControlToValidate="txtFname" 
                    ValidationGroup="form">*</asp:RequiredFieldValidator>
                </td>
			<td>
             
                <asp:TextBox ID="txtFname" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" CssClass="txtBox"></asp:TextBox>
             
                </td>
		</tr>

        	<tr>
			<td class="style3">Last Name:<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Input Last Name" ControlToValidate="txtLname" 
                    ValidationGroup="form">*</asp:RequiredFieldValidator>
                </td>
			<td>
             
                <asp:TextBox ID="txtLname" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" CssClass="txtBox"></asp:TextBox>
             
                </td>
		</tr>

        	<tr>
			<td class="style3">Tel:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                    runat="server" ErrorMessage="Input Tel" ControlToValidate="txtTel" 
                    ValidationGroup="form">*</asp:RequiredFieldValidator>
                </td>
			<td>
             
                <asp:TextBox ID="txtTel" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" CssClass="txtBox"></asp:TextBox>
             
                </td>
		</tr>

        	<tr>
			<td class="style3">UserName,Email:<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="Input Email" ControlToValidate="txtEmail" 
                    ValidationGroup="form">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Email not Valid" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="form">*</asp:RegularExpressionValidator>
                </td>
			<td>
             
                <asp:TextBox ID="txtEmail" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" CssClass="txtBox"></asp:TextBox>
             
                </td>
		</tr>

        	<tr>
			<td class="style3">
                Password:<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" 
                    ErrorMessage="Input Password" ValidationGroup="form" CssClass="txtBox">*</asp:RequiredFieldValidator>
                </td>
			<td><asp:TextBox ID="txtPassword" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" TextMode="Password" CssClass="txtBox"></asp:TextBox></td>
		</tr>
			</tbody>
	<tfoot>



        	<tr>
			<td class="style3">
                Repeat Password:<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtPasswordRepeat" ErrorMessage="Input repeat password" 
                    ValidationGroup="form">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPassword" ControlToValidate="txtPasswordRepeat" 
                    ErrorMessage="Password repeat is not same">*</asp:CompareValidator>
                </td>
			<td><asp:TextBox ID="txtPasswordRepeat" runat="server" Width="150px" 
                    ValidationGroup="loginFrm" TextMode="Password"></asp:TextBox></td>
		</tr>



			<tr>
			<td colspan="2">&nbsp;</td>
		</tr>



			<tr>
			<td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ForeColor="#FF0001" ValidationGroup="form" />
                </td>
		</tr>



			<tr>
			<td colspan="2">
                <strong>Licence Detail:</strong>
                 <asp:Label ID="Label4" runat="server"></asp:Label>
                
                </td>
		</tr>



			<tr>
			<td colspan="2">
               
                <br />
                </td>
		</tr>



			<tr>
			<td colspan="2">
                <asp:Label ID="Label1" runat="server" ForeColor="Red" 
                    Text="I accept the terms in the license Agreement Check box is not active" 
                    Visible="False"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" ForeColor="Red" 
                    Text="Email is not uniq" 
                    Visible="False"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" ForeColor="Red" 
                    Text="Licence not valid" 
                    Visible="False"></asp:Label>
                <br />
                </td>
		</tr>
			<tr>
			<td colspan="2" class="authorize-submit-cell"> 
                <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" 
                    onclick="Button1_Click" Width="100px" Text="Install" 
                    ValidationGroup="form" />  </td>
		</tr>
	</tfoot>
</table>
	<p>
<a href="http://1112.demo.bitrixsoft.com/?forgot_password=yes" rel="nofollow"><b><%=ForgotYourPassword%></b></a><br>
        <%=Gotothe%> <a href="http://1112.demo.bitrixsoft.com/?forgot_password=yes" rel="nofollow"><%=requestPasswordForm%></a><br>

<script type="text/javascript">
    try { document.form_auth.USER_PASSWORD.focus(); } catch (e) { }
</script>
</div>

















        

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
