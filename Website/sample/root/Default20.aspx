<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default20.aspx.cs" Inherits="Default20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript">
        function InsertComma() {
            var txtObj = document.getElementById('<%=TextBox1.ClientID %>');
        var txtVal = replaceAll(txtObj.value, ',', '');
       // alert(txtObj.value);
        if (txtObj.value != "") {
            var newVal = "";
            for (var i = 0; i < txtVal.length; i++) {
                //alert(txtVal.substring(i, 1));
                newVal = newVal + txtVal.substring(i, i + 1);

                if ((i + 1) % 3 == 0 && i != 0 && i + 1 < txtVal.length) {
                    newVal = newVal + ",";
                }
            }
            txtObj.value = newVal;
        }

    }

    function replaceAll(txt, replace, with_this) {
        return txt.replace(new RegExp(replace, 'g'), with_this);
    }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    </div>
    </form>
</body>
</html>
