<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default18.aspx.cs" Inherits="Default18" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="core/js/jquery-1.8.3.js"></script>
    <style type="text/css"  >
        #searchBoxOne input.search {
    font-size: 16px;
    color: #999;
    padding: 6px;
    -moz-box-shadow:inset 2px 2px 5px #ccc;
    box-shadow:inset 2px 2px 5px #ccc;
    border: 1px solid #b8b8b8;
}
#searchBoxOne input.submit {
    background: url(images/01_submit.png) top left no-repeat;
    width: 67px;
    height: 32px;
    border: none;
    color: #dee4ff;
    cursor: pointer;
}
#searchBoxOne input.submit:hover,
#searchBoxOne input.submit.hover {
    background: url(images/01_submit.png) bottom left no-repeat;
}

    </style>

    <script type ="text/javascript" >
        $(document).ready(function () {
            $("input.submit").bind('hover', function () {
                $(this).addClass('hover');
            }, function () {
                $(this).removeClass('hover');
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div id="searchBoxOne">
 
    <input type="text" />
    <input type="submit" value="Submit" />
 
</div>


    </div>
    </form>
</body>
</html>
