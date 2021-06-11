<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="nogray_js/1.1.4/ng_all.js" type="text/javascript"></script>
    <script src="nogray_js/1.1.4/components/timepicker.js" type="text/javascript"></script>

    <script type="text/javascript" >
        ng.ready(function () {
            var tp = new ng.TimePicker({
                input: 'timepicker_input',  // the input field id
                start: '9:00 am',  // what's the first available hour
                end: '6:00 pm',  // what's the last avaliable hour
                top_hour: 12  // what's the top hour (in the clock face, 0 = midnight)
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="text" id="timepicker_input" value="10:25 am" />
    </div>
    </form>
</body>
</html>
