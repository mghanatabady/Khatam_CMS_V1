<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendToSaman.aspx.cs" Inherits="SendToSaman" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>درگاه پرداخت الکترونیک </title>
    <link href="core/themeCP/Bitrix/StyleSheet.css" rel="stylesheet" type="text/css" />

    <script language="javascript" type="text/javascript">
// <![CDATA[

        function OK_onclick() {

        }

// ]]>
    </script>
    <style type="text/css">
        .style1
        {
            width: 106px;
            height: 75px;
        }
    </style>
</head>
<body>
    <div style="font-family:Tahoma; text-align:center;">
    <form id="form1" method="post" action="https://sep.shapark.ir/payment.aspx">
       <div id="doc4" class="yui-t5">
   <div id="hd" style="border-bottom: #edebeb 1px solid">
       </div>
     <div id="bd">
	<div id="yui-main">
	<div class="yui-b">
    <div id="mainArea" class="yui-g" runat="server"  style="text-align: right" dir="rtl">
        <br />
        <br />
        <br />
        <div style="width: 709px; height: 100px">
            <span style="font-size: 12pt"></span>
            <h1>
                <span style="color: #1988c8">
             درگاه پرداخت الکترونیک </span>
                </h1>
            <span style="font-size: 12pt; color: darkgray"><span style="color: dimgray">
                <div style="float: right; width: 182px; height: 29px">
                    تایید
                    اطلاعات وجه پرداختی</div>
                <div style="margin-top: 10px; float: right; background-image: url(images/free_website_split_horizontal.gif);
                    width: 525px; background-repeat: repeat-x; height: 4px">
                </div>
            </span>
                </span>
                <br />
                <br />
                <div dir="rtl" style="float: right; width: 460px;">
                    <div style="float: right; width: 460px; height: 29px; margin-right: 4px;" id="Div3">
                        <br />
                        <div style="float: right; width: 119px; height: 29px; text-align: left; ">
                            شماره پیش فاکتور</div>
                        <div id="Div4" language="javascript" onclick="return DIV1_onclick()" style="float: right;
                            width: 329px; margin-right: 4px; height: 29px">
                            <asp:Label ID="lbl_id" runat="server" Font-Bold="True"></asp:Label></div>
                        <div style="float: right; width: 119px; height: 29px; text-align: left">
                            &nbsp;مبلغ واریزی (ریال)</div>
                        <div style="float: right; width: 327px; margin-right: 4px; height: 29px">
                            <asp:Label ID="lbl_price" runat="server"></asp:Label></div>
                        <br />
                        <br />
                        <div style="float: right; width: 119px; height: 29px; text-align: left">
                        </div>
                        <div style="width: 299px; margin-right: 4px; height: 30px">
                            <div>
                 
                                <input type="hidden" id="Amount" name="Amount" value="<%= Amount %>"/>
                                <input type="hidden" id="MID" name="MID"value="<%= MID %>"/>
                                <input type="hidden" id="ResNum" name="ResNum" value="<%= ResNum %>"/>
                                <input type="hidden" id="Wage" name="Wage" value="0"/>
                                <input type="hidden" id="RedirectURL" name="RedirectURL" value="<%= RedirectURL %>"/>

                                <br />
                                <br />
                                <input type="submit" value="پرداخت از طریق بانک سامان" id="OK" 
                                    onclick="return OK_onclick()" style="font-family: tahoma" />
                                    
                                </div>
                        </div>
                        <br />
                        </div>
                </div>
            <div dir="rtl" style="float: right; width: 240px; text-align: center;">
                <img alt="" class="style1" 
                    src="core/themeCP/Bitrix/CssImage/icon/bank/arm-1.gif" /></div>
                <br />
                <br />
                <br />
                <br />
                <br />
            
                
                
          </div>
        <br />
        <br />
        <br />
        <br />
	<!-- YOUR DATA GOES HERE -->
	</div>
    <div id="msg_earlyPaid" class="yui-g" runat="server"  style="text-align: right" dir="rtl">
    این فاکتور قبلا پرداخت شده است
    </div>
</div>
	</div>
	<div class="yui-b">
        <br />
        <div style="background-image: url(images/forms/free_website_split.gif); width: 240px;
            background-repeat: repeat">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <!-- YOUR NAVIGATION GOES HERE --></div>
	
	</div>
   <div id="ft">
      
      </div>
</div>
    </form>
    </div>
</body>
</html>
