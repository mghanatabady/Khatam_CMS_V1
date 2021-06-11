<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Manage_Default" %>

<%@ Register Assembly="ScriptReferenceProfiler" Namespace="ScriptReferenceProfiler"
    TagPrefix="cc1" %>
     




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE-8" />
    <link href="../core/themeCP/Bitrix/admin.css" rel="stylesheet" />

    <link href="../core/themeCP/Bitrix/admin-public.css" rel="stylesheet" />
    <script src="../core/themeCP/Bitrix/core.js"></script>
    <script src="../core/themeCP/Bitrix/core_admin_interface.js"></script>


        <script src="../core/js/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../core/js/jquery-ui-1.8.20.custom.min.js" type="text/javascript"></script>
    <script src="../core/js/skinnytip.js" type="text/javascript"></script>
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8">

            <SCRIPT type="text/javascript" language=Javascript>
      <!--
                function isNumberKey(evt) {
                    var charCode = (evt.which) ? evt.which : event.keyCode
                    if (charCode > 31 && (charCode < 48 || charCode > 57))
                        return false;

                    return true;
                }
                function isAlphabeticKey(evt) {
                    var charCode = (evt.which) ? evt.which : event.keyCode
                    if (charCode > 31 && (charCode < 97 || charCode > 122) && (charCode < 65 || charCode > 90))
                    //  return charCode.UpperCase();
                    //if (charCode > 31 && (charCode < 65 || charCode > 90))
                        return false;

                    return true;
                }




                function checkTextAreaMaxLength(textBox, e, length) {

                    var mLen = textBox["MaxLength"];
                    if (null == mLen)
                        mLen = length;

                    var maxLength = parseInt(mLen);
                    if (!checkSpecialKeys(e)) {
                        if (textBox.value.length > maxLength - 1) {
                            if (window.event)//IE
                            {
                                e.returnValue = false;
                                return false;
                            }
                            else//Firefox
                                e.preventDefault();
                        }
                    }
                }




                $(document).on('click', '.btn_public', function () {
                    hidePicker();
                    // alert('ssss');
                    // $('.dpDiv').
                });


                $(document).on('focus', '.txt_dialog_medium_ltr', function () {
                    hidePicker();

                });

                $(document).on('focus', '.txt_dialog_medium_rtl', function () {
                    hidePicker();

                });



                function hidePicker() {
                    //$('.dpDiv').hide();

                    var elements = new Array();
                    elements = getElementsByClassName('dpDiv');
                    for (i in elements) {
                        elements[i].style.display = "none";
                        elements[i].style.visibility = "hidden";
                        adjustiFrame();
                    }

                }

                function getElementsByClassName(classname, node) {
                    if (!node) node = document.getElementsByTagName("body")[0];
                    var a = [];
                    var re = new RegExp('\\b' + classname + '\\b');
                    var els = node.getElementsByTagName("*");
                    for (var i = 0, j = els.length; i < j; i++)
                        if (re.test(els[i].className)) a.push(els[i]);
                    return a;
                }

               
               
      //-->
   </SCRIPT>





</head>
<body id="bx-admin-prefix">

<div id="tiplayer" style="position:absolute; visibility:hidden; z-index:100000000; text-align:justify; direction:rtl"></div>
    <shinkansen:StaticResourceManager ID="StaticResourceManager1" runat="server" HttpCompressWith="GZip"
        Crunch="true" Combine="true" ScriptPlacement="Bottom">
    </shinkansen:StaticResourceManager>
    <form id="form1" runat="server">

    <asp:Literal ID="ltr_demo" runat="server"></asp:Literal>
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"  >
        <CompositeScript >
            <Scripts>
                <asp:ScriptReference Name="MicrosoftAjax.js" />
                <asp:ScriptReference Name="MicrosoftAjaxWebForms.js" />           
            </Scripts>            
        </CompositeScript>
    </asp:ScriptManager>
    <div class="topbar" style="width: 100%;" id="topbar_div" runat="server">
        <div style="width: 100%; height: 24px; color: White; font-size: 8pt">
            <div style="float: left; margin-left: 5px; margin-top: 5px">
                سیستم مدیریت محتوا</div>
            <div style="float: right; margin-right: 5px; margin-top: 5px">
                خدمات جامع فناوری وب</div>
        </div>
        <div id="top_btns" style="margin-left: 13px; font-size: 10pt">
            <div id="AccessVisualContentManager_div" runat="server" visible="false" style="float: left;
                background-color: #d2d2cc; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/Default.aspx">وب سایت</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="AccessLayoutManager_div" runat="server" visible="false" style="float: left;
                background-color: #d2d2cc; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink5" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/Layout.aspx">جیدمان</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div style="float: left; background-color: #ffffff; margin-right: 5px; margin-top: 6px">
                <div class="t_dent">
                    <div class="b_dent">
                        <div class="l_dent">
                            <div class="r_dent">
                                <div class="bl_dent">
                                    <div class="br_dent">
                                        <div class="tl_dent">
                                            <div class="tr_dent">
                                                <asp:HyperLink ID="HyperLink4" runat="server" Font-Underline="False" ForeColor="#474747"
                                                    NavigateUrl="~/manage/Default.aspx">کنترل پنل</asp:HyperLink>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div style="float: right; margin-right: 10px; margin-top: 5px">
                <a href="Default.aspx?mode=logout" style="color: #cacaca; text-decoration: none;
                    font-size: 8pt;">خروج از سیستم </a>
            </div>
        </div>
    </div>
    <div class="toolbar2" style="width: 100%">
         <div style="float: right; margin-right: 10px; margin-top: 10px ; " dir="rtl">
            <div style="float: right; visibility:hidden; display:none  ">
                <img src="UpLoad/profiles/1/user1.jpg" />
            </div>
            <div style="text-align: right; margin-right: 10px; direction: rtl;">
                <asp:PlaceHolder ID="ph_userInfo" runat="server"></asp:PlaceHolder>
             </div>
        </div>
    </div>




    <div id="doc3" class="yui-t7">
        <div id="hd">





        </div>
        <div id="bd">
            <div class="yui-g"  >
                <div class="adm-workarea"> 
                <!-- YOUR DATA GOES HERE -->
                <div style="padding-top: 10px;" dir="rtl">
                    <div style="width: 100%; height: 40px; overflow: auto">
                        <div style="width: 29px; height: 32px; float: right; margin-left: 10px;">
                            <asp:Image ID="imgMainTitle" runat="server" />
                        </div>
                        <div style="height: 32px;  float: right; text-align: right;" dir="rtl">
                            <asp:Label ID="lblMainTitle" runat="server" Font-Bold="False" Font-Names="Tahoma"
                                Font-Size="14pt"></asp:Label>
                        </div>
                    </div>
                    <hr />
                    <div  style="height: 32px; padding-left: 5px; font-size: 9pt; color: black; text-decoration: none;">
                        <div style="height: 17px; float: right; margin-left: 2px; margin-right: 2px; color: red;">
                            <img src="../core/themeCP/Bitrix/CssImage/btn/desktop.gif" />
                        </div>
                        <div style="height: 17px; float: right;">
                            <asp:HyperLink ID="HyperLink11" runat="server" Font-Underline="False" ForeColor="Black"
                                NavigateUrl="Default.aspx?mode=main">   صفحه اصلی  </asp:HyperLink>
                        </div>
                        <div style="height: 17px; float: right;">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
                <div style="width: 974px; float: right ; ">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </div>
            </div>
                </div>
        </div>
    </div>

    <div id="Footerbg" style="background-color: #e5e3df; height: 26px; border-top: #d4d0c8 1px solid;
        border-bottom: #d4d0c8 1px solid; position: fixed; bottom: 0; left: 0; width: 100%;">
        <div dir="rtl" style="height: 26px; padding-top: 4px;">
            <strong style="color: Navy; text-align: left; float: left; padding-left: 6px; font-size: 8pt;
                font-weight: normal; text-decoration: none;">سیستم مدیریت محتوا نسخه 8.04 |
                <asp:HyperLink ID="hl_brand1" runat="server" Font-Underline="False" ForeColor="Navy">[hl_brand1]</asp:HyperLink><a
                    style="color: Navy" href="http://www.yourDomain.com/"></a> </strong><strong style="color: Navy;
                        float: right; padding-right: 6px; font-size: 8pt; font-weight: normal; text-decoration: none;"
                        id="STRONG1">
                        <asp:HyperLink ID="Hl_brand_support" runat="server" Font-Underline="False" ForeColor="Navy">پشتیبانی</asp:HyperLink><a
                            style="color: Navy" href="http://support.yourDomain.com/"></a> | <a style="color: Navy"
                                href="http://www.yourDomain.com/"></a></strong>

                                <asp:Literal ID="ltl_status_script" runat="server"></asp:Literal>
        </div>
    </div>


    </form>
</body>
</html>
