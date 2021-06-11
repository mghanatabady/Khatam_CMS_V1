<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BackFromSaman.aspx.cs" Inherits="BackFromSaman" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   
    <title>درگاه پرداخت الکترونیک || اطلاعات دریافتی از بانک</title>
        <link href="core/themeCP/Bitrix/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
  <div id="doc4" class="yui-t5">
   <div id="hd" style="border-bottom: #edebeb 1px solid">
       </div>
     <div id="bd">
	<div id="yui-main">
	<div class="yui-b"><div class="yui-g" style="text-align: right" dir="rtl">
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
                <div style="float: right; width: 162px; height: 29px">
                    اطلاعات دریافتی از بانک</div>
                <div style="margin-top: 10px; float: right; background-image: url(images/free_website_split_horizontal.gif);
                    width: 538px; background-repeat: repeat-x; height: 4px">
                </div>
            </span>
                </span>
                <br />
                <br />
                <div dir="rtl" style="float: right; width: 460px;">
                    <div style="float: right; width: 460px; height: 29px; margin-right: 4px;" id="Div3" language="javascript" onclick="return DIV2_onclick()">
                        <table id="TABLE1" border="3" class="node" dir="rtl" language="javascript" onclick="return TABLE1_onclick()"
                            style="width: 500px; text-align: center; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;">
                            <tbody>
                                <tr>
                                    <td align="right" colspan="2" style="vertical-align: middle; height: 50px;">
                                        <%= message %>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        مبلغ کل خريد
                                    </td>
                                    <td align="right">
                                        <font color="#000000">
                                        <%= t_lAmount %>ريال</font>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        شماره خرید</td>
                                    <td align="right">
                                        <font color="#000000">
                                        <%= t_strResNum %>
                                        </font>&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        رسيد ديجيتالي
                                    </td>
                                    <td align="right">
                                        <font color="#000000">
                                        <%= t_strRefNum %>
                                        </font>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:HyperLink ID="Hl1" runat="server">بازگشت به صفحه فاکتور</asp:HyperLink>
                                    </td>
                                    <td align="right">
                                        &nbsp;</td>
                                </tr>
                            </tbody>
                        </table>
                        </div>
                </div>
            <div dir="rtl" style="float: right; width: 194px; text-align: center;">
                <img src="core/themeCP/Bitrix/CssImage/icon/bank/arm-1.gif" /></div>
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
</div>
	</div>
	<div class="yui-b">
        <br />
        <div style="background-image: url(images/forms/free_website_split.gif); width: 240px;
            background-repeat: repeat">
            <br />
            <br />
            <br />
            <div style="border-right: #c4d3e5 1px solid; border-top: #c4d3e5 1px solid; margin-left: 20px;
                border-left: #c4d3e5 1px solid; width: 210px; border-bottom: #c4d3e5 1px solid;
                background-color: #f6f9fd; padding-right: 5px; padding-left: 5px; text-align: justify;" dir="rtl">
                <h2>
                    نکته مهم:</h2>
                اطلاعات خرید شما مستقیما از بانک دریافت گردید و برای شما نمایش داده شده است.<br />
                <br />
            </div>
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
    </body>
</html>