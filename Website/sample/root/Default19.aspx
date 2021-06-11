<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default19.aspx.cs" Inherits="Default19" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


               <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat ="server"
            TargetControlID="TextBox1"
            Mask="999,999,999,999,999"
            MessageValidatorTip="true"
            MaskType="Number"
            InputDirection="RightToLeft"
            AcceptNegative="Left"
            DisplayMoney="None"
            ErrorTooltipEnabled="True" />
    </form>
</body>
</html>
