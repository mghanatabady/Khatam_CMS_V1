<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_formsFieldEdit.ascx.cs" Inherits="Manage_c_formsFieldEdit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<script src="../core/js/jquery-1.7.2-vsdoc.js" type="text/javascript"></script>

<script src="../core/js/jquery-1.7.2.min.js" type="text/javascript"></script>
<script src="../core/js/jquery-ui-1.8.20.custom.min.js" type="text/javascript"></script>
<script src="../core/js/JScript.js" type="text/javascript"></script>




<script type="text/javascript">

    $(document).ready(function () {

        var k = 1000;
        //بخش انتخاب ها
        $(document).on('click', '.btnOptionAdd', function () {

            // alert($('#' + parentid).parent().attr("element_type"));

            var showerid;
            showerid = $("#optionPropArea").parent().attr("showerid");

            // $("#" + showerid + "_txtOptionHidden").val(getOptionXML());
            var strResult = '';
            var oid = showerid + '_o' + k;

            strResult = '<div  id="' + oid + 'propEle"  parentid="' + oid + '"><input id="Radio4" name="private" value="" parentid="' + oid + '" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/add.gif" class="btnOptionAdd" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/delete.gif" class="btnOptionDel" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/stardim.gif" class="btnOptionStar" /> ' +
                '<br /> </div> ';

            $(this).parent().after(strResult);

            //alert($('#' + showerid).attr('element_type'));
            var elemenet_type = $('#' + showerid).attr('element_type');
            //alert($(this).attr("parentid"));

       switch (elemenet_type) {
                case 'checkbox':
                case 'radio':
                    $('#' + $(this).parent().attr("parentid")).after('<div id="' + oid + '"  option_is_default="false" isnew="true" deleted="false"    ><input id="' + oid
            + 'chk" type="' + elemenet_type + '"> <span id="' + oid + 'title"></span> <br></div>');

                    k++;
                    break;
                case 'select':
                    $('#' + $(this).parent().attr("parentid")).after(

                    '<option id="' + oid + '"  option_is_default="false" isnew="true" deleted="false"    ></option>'
            );
                    //'<option id="f' + i + '_o1"   isnew="true"  deleted="false" option_is_default="false"  >انتخاب اول</option>'
                    k++;
                    break;
                default:

            }



            // $("#" + "checkboxGroup").append('<div id="o3"><input id="o3chk" type="checkbox"><span id="o3title"></span><br></div>');


            //$("#optionPropArea").append(strResult);

        });
    });


    $(document).on('click', '.btnOptionStar', function () {

        var parentid = $(this).parent().attr("parentid");

        var element_type = $('#' + parentid).parent().parent().attr("element_type");
        //alert(parentid);
        //$('#' + parentid + 'chk').attr("cheket
        $('#' + parentid).prop("option_is_default", false);

        var str_chkCheked = '';

        switch (element_type) {

            case 'checkbox':
            case 'radio':

                if ($('#' + parentid + 'chk').attr("checked")) {
                    $('#' + parentid + 'chk').prop("checked", false);
                    $('#' + parentid).attr("option_is_default", false);

                    str_chkCheked = "stardim";
                }
                else {
                    $('#' + parentid + 'chk').prop("checked", true);
                    $('#' + parentid).attr("option_is_default", true);

                    str_chkCheked = "star";
                }
                break;
            case 'select':

                if ($('#' + parentid).attr('selected') == 'selected') {
                    $('#' + parentid).prop("selected").remove();
                   // $('#' + parentid).attr("option_is_default", false);

                    str_chkCheked = "stardim";
                }
                else {
                    $('#' + parentid).prop("selected", 'selected');
                   //$('#' + parentid).attr("option_is_default", true);

                    str_chkCheked = "star";
                }
                break;
            default:

        }





        if ((element_type == "radio") || (element_type == "select")) {
            var scr = '../core/themeCP/Bitrix/CssImage/btn/stardim.gif';
            $('.btnOptionStar').attr("src", scr);
        }
        var scr2 = '../core/themeCP/Bitrix/CssImage/btn/' + str_chkCheked + '.gif';

        $(this).attr("src", scr2);



    });


    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('keyup', '#Radio4', function () {

        //alert($(this).val());
        var parentid = $(this).attr("parentid");

        //alert(parentid);
        //$('#' + parentid + 'title').text($(this).val());
        var element_type = $('#' + parentid).parent().parent().attr("element_type");


        switch (element_type) {

            case 'checkbox':
            case 'radio':
                $('#' + parentid + 'title').text($(this).val());
                break;
            case 'select':
                $('#' + parentid ).text($(this).val());

        }

        //        $('#' + parentid ).text($(this).val());

        //var Ttitle = $("#txtTitle").val()
        //$('#' + showerid).attr({
        //  title: Ttitle
        //});
        //$('#' + showerid + "title").empty();
        //$('#' + showerid + "title").append(Ttitle);

        //  $('#' + showerid).attr({
        //  changed: "true"
        //});

    });

    // **************   delete border
    $(document).on('click', '.btnOptionDel', function () {

        var parentid = $(this).parent().attr("parentid");


        if ($("#" + parentid).attr("isnew") == "false") {
            //            delShowDialog($(this).attr("showerid"));
            delOptionShowDialog( parentid);
            //alert("is saved");

        }
         else {
        $('#' + parentid).remove();
        $(this).parent().remove();
        //      $("#fieldProprtiesArea").hide();
        //      $("#msgEmptyProp").show();
         }


        //checkEmptyBordersMsg();
        return false;
    });



    /************************function delShowDialog */

    function delOptionShowDialog(showerid) {
        $("#dialog").dialog({ modal: true, draggable: false, resizable: false
            , buttons: {
                "تایید": function () {
                    $("#" + showerid).attr({
                        deleted: true
                    });
                    $('#' + showerid).hide();
                    $('#' + showerid + 'propEle').hide();
                    $(this).parent().remove();
                 //   checkEmptyBordersMsg();
                //    $("#fieldProprtiesArea").hide();
                  
                //    $("#msgEmptyProp").show();

                    $(this).dialog("close");
                },
                "انصراف": function () {
                    $(this).dialog("close");
                }
            }
        });
    }


</script>



<div id="msgEdit" runat="server" >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        ویرایش فرم
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr" >
                                  <div dir="rtl" style="text-align: right; overflow:hidden  ">


                               <div class="formbuilder" style="width: 954px; float: right">
        <div id="rows" runat="server">
            <div class="row" style="background-color: #f8f9fc">
                <div class="tabArea" >
                    <script type="text/javascript">
                        $(function () {
                            //$("#tabs").tabs();
                            $("#tabs").tabs({ selected: 0 });
                            $('.divAddField').disableSelection();
                        });
	</script>
                    <div class="demo">
                        <div id="tabs">
                            <ul>
                                <li><a href="#tabs-1">اضافه کردن فیلد</a></li>
                                <li><a href="#tabs-2">تنظیمات فیلد</a></li></ul>
                            <div id="tabs-1">
                                <div class="divAddField" style=" overflow: hidden">
                                
                                
                                <div id="BtnAddBorder_Text" class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/single_line_text_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption" >
                                        متن یک خطی
                                    </div>
                                </div>

                                     <div id="BtnAddBorder_number"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/number_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                        اعداد
                                    </div>
                                </div>

                                     <div id="BtnAddBorder_textarea"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/paragraph_text_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                        متن چند خطی
                                    </div>
                                </div>
                              
                                     <div id="BtnAddBorder_checkbox"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/checkbox_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       چک باکس
                                    </div>
                                </div>
                            
                                     <div id="BtnAddBorder_select"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/dropdown_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       لیست کشویی
                                    </div>
                                </div>

                                         <div id="BtnAddBorder_radio"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/multiplechoice_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       لیست چند انتخابی
                                    </div>
                                </div>
                             
                               <!--          <div id="BtnAddBorder_simple_name"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/name_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       نام و نام خانوادگی
                                    </div>
                                </div>


                                            <div id="BtnAddBorder_address"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/address_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                      آدرس
                                    </div>
                                </div>-->
                                  
                                <div id="BtnAddBorder_phone"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/phone_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       تلفن
                                    </div>
                                </div>

                               <div id="BtnAddBorder_cellphone"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/mobile_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       موبایل
                                    </div>
                                </div>

                                   <div id="BtnAddBorder_date"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/date_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       تاریخ
                                    </div>
                                </div>

<!--
                                 <div id="BtnAddBorder_time"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/time_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       ساعت
                                    </div>
                                </div>-->


                                        <div id="BtnAddBorder_url"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/website_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       وب سایت
                                    </div>
                                </div>

                                
                                
                                        <div id="BtnAddBorder_email"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/mail_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       ایمیل
                                    </div>
                                </div>


                                
                                        <div id="BtnAddBorder_currency"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/price_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       قیمت
                                    </div>
                                </div>

                                
                                        <div id="BtnAddBorder_file"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/file_upload_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       آپلود فایل
                                    </div>
                                </div>

                                       <div id="BtnAddBorder_section"  class="btnAddField">
                                    <div class="btnAddFieldImg">
                                        <img src="../core/themeCP/Bitrix/CssImage/btn/section_break_bg.gif" />
                                    </div>
                                    <div class="btnAddFieldCaption">
                                       جداکننده
                                    </div>
                                </div>


                                </div>
                            </div>
                            <div id="tabs-2">

                                  <div id="msgEmptyProp"  dir="rtl" style="border-right: 00297f 2px solid; border-top: red 2px solid;
                        border-left: red 2px solid; width: 272px; margin-right: 10px;
                        margin-top: 10px; padding-bottom: 10px; border-bottom: red 2px solid; margin-bottom:10px ;
                          border: 2px solid #0066CC; overflow:hidden; text-align:justify ">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/help.png" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; margin-bottom: 5px; float: right;
                            padding-top: 5px; ">
                            ابتدا فیلد مورد نظر خود را انتخاب کنید!<br />
                            <span style="font-size: 9pt"></span>
                        </div>
                        <br />
                    </div>

                        
                        <div id="fieldProprtiesArea" style=" font-size:10pt ;line-height:200%">
                          
                        
                        </div>
                            </div>
                        </div>
                    </div>
                    <!-- End demo -->
                    <div style="display: none" class="demo-description">
                        <p>
                            Click tabs to swap between content that is broken into logical sections.</p>
                    </div>
                </div>
                <div id="fieldInputArea" class="fieldInputArea" style="background-color:  White; padding:5px;
                     border:1px solid #cccccc;
                    text-align: right">
                    <div style="background-color: White">
                        <h1>
                            <asp:Label ID="lbl_Form_Name" runat="server"></asp:Label>
                      
                        </h1>
                      
                        <p>
                          
                            <asp:Label ID="lbl_Form_descraption" runat="server"></asp:Label>
                            </p>
               
                   <div id="MSG1"  dir="rtl" style="border-right: 00297f 2px solid; border-top: red 2px solid;
                        border-left: red 2px solid; width: 542px; margin-right: 10px;
                        margin-top: 10px; padding-bottom: 10px; border-bottom: red 2px solid; margin-bottom:10px ;
                          border: 2px solid #0066CC; overflow:hidden; text-align:justify ">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/help.png" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; margin-bottom: 5px; float: right;
                            width: 483px; padding-top: 5px; ">
                            توجه!<br />
                            <span style="font-size: 9pt">در این فرم هیچ فیلیدی وجود ندارد، از منوی سمت راست فیلد های دلخواه خود را اضافه کنید.</span>
                        </div>
                        <br />
                    </div>


                            <div class="drager">
	
    

<ul id="sortable"  runat="server"  >
                    
  


</ul>

</div>

                    </div>
                           
                </div>
            </div>
        </div>

        	
	<style>
	.drager ul { list-style-type: none; margin: 0; padding: 0; margin-bottom: 10px; }
	.drager li { margin: 5px; padding: 5px; width: 150px; }
	    .Cpbtn
        {
            height: 26px;
        }
	</style>
	<script type="text/javascript">
	    $(function () {
	        $("#sortable").sortable({
	            //revert: true,
	            axis: 'y'
	        });

	        $("ul, li").disableSelection();
	    });

	    //   $(".sortable").resizable({ resize: function (event, ui) { ui.size.width = ui.originalSize.width; } }); 
	</script>



   




    </div>

                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="btnSaveStatus" CssClass="Cpbtn" runat="server" Text="تایید"  
                      onclick="btnSaveStatus_Click" Width="30px"   />
								         
<asp:Button ID="Button6" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>

  </div>

   <input id="TextHidden"    type="hidden"    runat="server"  style=" width:720px; " />
  <br />
  <br />



<div class="demo"  style=" visibility:hidden ">

<div id="dialog" title="اخطار حذف فیلد">
<br />
	<p>با حذف این فیلد تمامی اطلاعات مرتبط با آن از بین می روند، آیا برای حذف فیلد مطمئن هستید؟</p>
</div>

</div>
<br /><br />
<asp:Label ID="Label1" runat="server" Text="" ></asp:Label>

<br />
<br />