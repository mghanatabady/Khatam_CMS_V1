$(document).ready(function () {


    $(".fieldBorderBtns").hide();
    var i = 0;

    checkEmptyBordersMsg();


    //******************* ADD Borders ********************//
    $('#BtnAddBorder_Text').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="text" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">متن یک خطی</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_section').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="section" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><hr/><span id="f' + i + 'title">جداکننده</span>  <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_phone').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="phone" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">تلفن</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_cellphone').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="cellphone" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">موبایل</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_url').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="url" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">وب سایت</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_email').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="email" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">ایمیل</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_currency').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="currency" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">قیمت</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_date').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="date" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">تاریخ</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" value="1390/12/30" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_number').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="number" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">عدد</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" value="0123456789" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_textarea').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="textarea" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">متن چند خطی</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><textarea id="f' + i + '_text" class="Element_TextBox_medium" cols="20" name="S1" rows="2" type="textarea"></textarea>   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });

    $('#BtnAddBorder_file').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder"  element_type="file" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">آپلود فایل</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" /><input id="Button1" type="button"  value="upload" /><div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));
        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_checkbox').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder" element_type="checkbox" isnew="false" deleted="false" private="false"  size="medium" ' +
             ' req="false" unique="false"  DefValue="" guidelines=""  ><span id="f' + i + 'title">عنوان</span>' +
             '<span id="f' + i + 'regStar" class="regStar">*</span></br>    ' +

                    '<div id="f' + i + 'checkboxGroup" >' +

        /*****************************/
               '<div id="f' + i + '_o1"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o1chk" type="checkbox"  /><span id="f' + i + '_o1title">انتخاب اول</span></br></div>' +
               '<div id="f' + i + '_o2"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o2chk" type="checkbox"  /><span id="f' + i + '_o2title">انتخاب دوم</span></br></div>' +
               '<div id="f' + i + '_o3"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o3chk" type="checkbox" /><span id="f' + i + '_o3title">انتخاب سوم</span></br></div>' +
        /*****************************/
            '</div>' +
         ' <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + 'deleteBtn" showerid="f' + i + '" class="deleteBtn" ' +
         ' src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>'

         ));

        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_radio').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder" element_type="radio" isnew="false" deleted="false" private="false"  size="medium" ' +
             ' req="false" unique="false"  DefValue="" guidelines=""  ><span id="f' + i + 'title">عنوان</span>' +
             '<span id="f' + i + 'regStar" class="regStar">*</span></br>    ' +

                    '<div id="f' + i + 'checkboxGroup" >' +

        /*****************************/
               '<div id="f' + i + '_o1"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o1chk" type="radio" name="groupF' + i + '" checked="checked"  /><span id="f' + i + '_o1title">انتخاب اول</span></br></div>' +
               '<div id="f' + i + '_o2"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o2chk" type="radio" name="groupF' + i + '" /><span id="f' + i + '_o2title">انتخاب دوم</span></br></div>' +
               '<div id="f' + i + '_o3"   isnew="true"  deleted="false" option_is_default="false" ><input id="f' + i + '_o3chk" type="radio" name="groupF' + i + '" /><span id="f' + i + '_o3title">انتخاب سوم</span></br></div>' +
        /*****************************/
            '</div>' +
         ' <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + 'deleteBtn" showerid="f' + i + '" class="deleteBtn" ' +
         ' src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>'

         ));

        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    $('#BtnAddBorder_select').click(function () {
        $("#sortable").append($('<div id="f' + i + '" class="fieldBorder" element_type="select" isnew="false" deleted="false" private="false"  size="medium" ' +
             ' req="false" unique="false"  DefValue="" guidelines=""  ><span id="f' + i + 'title">عنوان</span>' +
             '<span id="f' + i + 'regStar" class="regStar">*</span></br>    ' +

                    '<select id="f' + i + 'checkboxGroup" style="font-family: tahoma" >' +

        /*****************************/
            '<option id="f' + i + '_o1"   isnew="true"  deleted="false" option_is_default="false"  >انتخاب اول</option>' +
            '<option id="f' + i + '_o2"   isnew="true"  deleted="false" option_is_default="false" selected="selected" >انتخاب دوم</option>' +
            '<option id="f' + i + '_o3"   isnew="true"  deleted="false" option_is_default="false"  >انتخاب سوم</option>' +
        /*****************************/
            '</select>' +
         ' <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + 'deleteBtn" showerid="f' + i + '" class="deleteBtn" ' +
         ' src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>'

         ));

        checkEmptyBordersMsg();
        $(".fieldBorderBtns").hide();
        i++;
    });


    //$("#sortable").append($('<div id="f' + i + '" class="fieldBorder" isnew="true" deleted="false" size="medium" private="false"   req="false" unique="false"  DefValue="" guidelines="" ><span id="f' + i + 'title">عنوان</span> <span id="f' + i + 'regStar" class="regStar">*</span></br><input id="f' + i + '_text" class="Element_TextBox_medium" type="text" />   <div id="f' + i + 'b"  class="fieldBorderBtns"><img id="f' + i + '"deleteBtn" showerid="f' + i + '" class="deleteBtn" src="../core/themeCP/Bitrix/cssimage/btn/delete.gif" /> </div> </div>').hide().fadeIn("fast"));


    // **************   delete border       
    $(document).on('click', '.deleteBtn', function () {

        var showerid = $(this).attr("showerid");

        if ($("#" + showerid).attr("isnew") == "false") {
            delShowDialog($(this).attr("showerid"));

        }
        else {
            $('#' + showerid).remove();
            $("#fieldProprtiesArea").hide();
            $("#msgEmptyProp").show();
        }


        checkEmptyBordersMsg();
        return false;
    });


    // نمایش پنجره propertise
    $(document).on('click', '.fieldBorder', function () {
        $("#fieldProprtiesArea").show();
        $('.fieldBorder').removeClass("fieldBorder_Clicked");
        $(this).addClass("fieldBorder_Clicked");

        $("#tabs").tabs({ selected: 1 });

        $("#fieldProprtiesArea").empty();
        var senderId = $(this).attr("id");
        var senderTitle = $(this).attr("title");
        var senderSize = $(this).attr("size");
        var senderprivate = $(this).attr("private");
        var senderreq = $(this).attr("req");
        var senderunique = $(this).attr("unique");
        var senderDefValue = $(this).attr("DefValue");
        var senderguidelines = $(this).attr("guidelines");
        var optionXML = $('#' + $(this).attr("id") + "_txtOptionHidden").val();
        var element_type = $(this).attr("element_type");


        AddPropTextBox(senderId, senderTitle, element_type, senderSize, senderreq, senderprivate, senderunique, senderDefValue, senderguidelines, optionXML);

        $("#msgEmptyProp").hide();
        $("#fieldProprtiesArea").show();


    });






    //  اضافه کردن بخش نام فیلد
    function AddPropTextBox(showerid, title, element_type, size, required, private, unique, defVal, msghelp, optionXML) {


        // if (!$("#" + showerid).attr("title")) {
        //var title = $('#' + showerid + 'title').val();
        var title = $('#' + showerid + 'title').text();
        // f10000title
        //append(Ttitle);
        //      $("#" + showerid).attr({ title: "عنوان" })
        // };

        $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea" showerid="' + showerid +
              '"  >نام فیلد <img src="../core/themeCP/Bitrix/CssImage/btn/help.png" /></br><input id="txtTitle"  type="text" value="' + title + '" />  </div>'));

        $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea" showerid="' + showerid +
              '" >اندازه فیلد</br>' +
              '<select id="SelectSize" class="fieldPropElements_DdlFieldSize">  ' +
                '<option value="small" >کوچک</option>  ' +
                '<option value="medium" selected="selected">متوسط</option>  ' +
                '<option value="large" >بزرگ</option>  ' +
            '</select>  ' +
            '</div>'));

        $("#SelectSize").val(size);

        var strResult = '';
        $('#' + showerid + 'checkboxGroup').children().each(function () {

            //str_chkCheked = "stardim";

            var str_chkCheked = '';

            switch (element_type) {

                case 'radio':
                case 'checkbox':
                    if ($(this).children('#' + $(this).attr("id") + 'chk').attr("checked")) {
                        str_chkCheked = "star";
                        $(this).attr("option_is_default", true);
                    }
                    else {
                        str_chkCheked = "stardim";
                        $(this).attr("option_is_default", false);

                    }
                    break;
                case 'select':

                    //alert($(this).children('#' + $(this).attr("id")).attr("selected"));
                    //alert($(this).attr("selected"));

                    if (
                    $(this).attr("selected") == 'selected'
                    ) {
                        str_chkCheked = "star";
                        $(this).attr("option_is_default", true);
                    }
                    else {
                        str_chkCheked = "stardim";
                        $(this).attr("option_is_default", false);

                    }


                    break;

                default:

            }




            if ($(this).attr("deleted") != 'true') {
                if ((element_type == "checkbox") || (element_type == "radio")) {
                    strResult = strResult + '<div id=\"' + $(this).attr("id")
                + 'propEle\" parentId=\"' + $(this).attr("id")
                + '\" ><input id="Radio4" name="private" parentId=\"' + $(this).attr("id")
                + '\" value="' + $('#' + $(this).attr("id") + 'title').text() + '" /> ' +
                '<img parentId=\"' + $(this).attr("id") + '\" src="../core/themeCP/Bitrix/CssImage/btn/add.gif" class="btnOptionAdd" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/delete.gif" class="btnOptionDel" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/' + str_chkCheked + '.gif"  class="btnOptionStar"   /> ' +
                    //'<img src="../core/themeCP/Bitrix/CssImage/btn/star.gif" /> ' +
                '<br /> </div> ';
                }
                else if (element_type == "select") {
                    strResult = strResult + '<div id=\"' + $(this).attr("id")
                + 'propEle\" parentId=\"' + $(this).attr("id")
                + '\" ><input id="Radio4" name="private" parentId=\"' + $(this).attr("id")
                + '\" value="' + $(this).text() + '" /> ' +
                '<img parentId=\"' + $(this).attr("id") + '\" src="../core/themeCP/Bitrix/CssImage/btn/add.gif" class="btnOptionAdd" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/delete.gif" class="btnOptionDel" /> ' +
                '<img src="../core/themeCP/Bitrix/CssImage/btn/' + str_chkCheked + '.gif"  class="btnOptionStar"   /> ' +
                    //'<img src="../core/themeCP/Bitrix/CssImage/btn/star.gif" /> ' +
                '<br /> </div> ';
                }
            }
        });
        //***************option area
        if ((element_type == "checkbox") || (element_type == "radio") || (element_type == "select")) {
            $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea"  showerid="' + showerid +
              '" >' +

              '<fieldset id="optionPropArea">  ' +
                    '<legend>انتخاب ها: <img src="../core/themeCP/Bitrix/CssImage/btn/help.png" /> </legend>  '
                     + strResult +
              '</fieldset>  ' +
            '</div>'));
        }

        //*************** private area
        var rbPrivateALLchecked = ' ';
        var rbPrivateAdminchecked = ' ';
        if ((private == 'true') || (private == 'True')) {
            rbPrivateAdminchecked = 'checked="checked"';
        }
        else {
            rbPrivateALLchecked = 'checked="checked"';
        }



        $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsAreaHalf" style="   showerid="' + showerid +
              '" >' +

              '<fieldset>  ' +
                    '<legend>فیلد قابل دیدن برای:</legend>  ' +
                        '        <input id="rbPrivateALL" name="private" type="radio" ' + rbPrivateALLchecked + ' />  همه<br />  ' +
                        '       <input id="rbPrivateAdmin" name="private" type="radio" ' + rbPrivateAdminchecked + '  /> فقط مدیر  ' +
              '</fieldset>  ' +
            '</div>'));

        var chkRequiredchecked = ' ';

        if ((required == 'true') || (required == 'True')) {
            chkRequiredchecked = 'checked="checked"';
        }

        var chkUniquechecked = ' ';
        if ((unique == 'true') || (unique == 'True')) {
            chkUniquechecked = 'checked="checked"';
        }


        $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsAreaHalf"  showerid="' + showerid +
              '" >' +

              '<fieldset>  ' +
                    '<legend>قوانین:</legend>  ' +
                        '        <input id="chkRequired"  type="checkbox" ' + chkRequiredchecked + ' /> مورد نیاز <br />  ' +
                        '       <input id="chkUnique"  type="checkbox" ' + chkUniquechecked + ' /> منحصر به فرد   ' +
              '</fieldset>  ' +
            '</div>'));

        if (element_type == 'number') {
            $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea" showerid="' + showerid +
              '" >مقدار پیش فرض</br><input id="txt_DefValue" class="fieldPropElements_Txt_DefValue" type="text" value="' + defVal + '" onkeypress="return isNumberKey(event)" /></div>'));
        }
        else {
            $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea" showerid="' + showerid +
              '" >مقدار پیش فرض</br><input id="txt_DefValue" class="fieldPropElements_Txt_DefValue" type="text" value="' + defVal + '"  /></div>'));
        }

        $("#fieldProprtiesArea").append($('<div id="prop" class="fieldPropSectionsArea" showerid="' + showerid +
              '" >راهنمای کاربر</br><textarea id="txt_guidelines" class="fieldPropElements_Txt_guidelines"  name="S1" rows="2">' + msghelp + '</textarea></div>'));


        $(".fieldBorderBtns").hide();
        $("#" + $("#" + showerid).attr("id") + "b").show();

    }



    //  اضافه کردن بخش اندازه فیلد
    function AddSizeProp(showerid) {
        if (!$("#" + showerid).attr("size")) {

            $("#" + showerid).attr({ size: "2" })
        };

        $("#fieldProprtiesArea").append($('<select id="Select1"> ' +
            '<option value="1" >کوچک</option> ' +
            '<option value="2">متوسط</option> ' +
            '<option value="3">بزرگ</option> ' +
            '</select>'));

        $("#Select1 option[value=2]").attr('selected', 'selected');

        $(".fieldBorderBtns").hide();
        $("#" + $("#" + showerid).attr("id") + "b").show();

    }


    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('keyup', '.Element_TextBox', function () {
        //alert("ssssssssssssss");
        $('.Element_TextBox').val("");
        $('#txtTitle').focus();
    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('keyup', '#txtTitle', function () {

        var showerid = $("#prop").attr("showerid");
        var Ttitle = $("#txtTitle").val()
        $('#' + showerid).attr({
            title: Ttitle
        });
        $('#' + showerid + "title").empty();
        $('#' + showerid + "title").append(Ttitle);

        $('#' + showerid).attr({
            changed: "true"
        });

    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('change', '#SelectSize', function () {

        var showerid = $("#prop").attr("showerid");
        var Tsize = $("#SelectSize").val();
        //$("#txtTitle").val()
        $('#' + showerid).attr({
            size: Tsize
        });

        //  $("#SelectSize")
        $('#' + showerid + '_text').removeClass();
        $('#' + showerid + '_text').addClass("Element_TextBox_" + $("#SelectSize").val());
        //  $('#' + showerid + "title").empty();
        //   $('#' + showerid + "title").append(Ttitle);
        $('#' + showerid).attr({
            changed: "true"
        });
    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('change', 'input[name=private]', function () {

        var showerid = $("#prop").attr("showerid");


        if ($('#rbPrivateALL').is(':checked')) {
            $('#' + showerid).attr({
                private: 'false'
            });
        }
        if ($('#rbPrivateAdmin').is(':checked')) {
            $('#' + showerid).attr({
                private: 'true'
            });
        }


    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('change', '#chkRequired', function () {
        var showerid = $("#prop").attr("showerid");
        if ($('#chkRequired').is(':checked')) {
            $('#' + showerid).attr({
                req: 'true'
            });
            $("#" + showerid + "regStar").show();

        }
        else {
            $('#' + showerid).attr({
                req: 'false'
            });
            $("#" + showerid + "regStar").hide();
        }




    });

    $(document).on('change', '#chkUnique', function () {
        var showerid = $("#prop").attr("showerid");
        if ($('#chkUnique').is(':checked')) {
            $('#' + showerid).attr({
                unique: 'true'
            });

        }
        else {
            $('#' + showerid).attr({
                unique: 'false'
            });
        }

    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('keyup', '#txt_DefValue', function () {

        var showerid = $("#prop").attr("showerid");
        var TDefValue = $("#txt_DefValue").val()
        $('#' + showerid).attr({
            defvalue: TDefValue
        });

    });

    // پنجره مشخصات بروز رسانی عنوان
    $(document).on('keyup', '#txt_guidelines', function () {

        var showerid = $("#prop").attr("showerid");
        var Tguidelines = $("#txt_guidelines").val()
        $('#' + showerid).attr({
            guidelines: Tguidelines
        });

    });



    /************************function btnSaveStatus */

    $("#btnSaveStatus").click(function () {
        var str_r = "<root> ";



        $("#sortable").children().each(function () {
            str_r = str_r + "<control id=\"" + $(this).attr("id")
                 + "\"  title=\""
                + $('#' + $(this).attr("id") + 'title').text() + "\" "
               + " changed=\""
                + $(this).attr("changed") + "\""
                    + " deleted=\""
                + $(this).attr("deleted") + "\""

                         + " size=\""
                + $(this).attr("size") + "\""

            + " isnew=\""
                + $(this).attr("isnew") + "\""


                               + " private=\""
                + $(this).attr("private") + "\""

                                       + " req=\""
                + $(this).attr("req") + "\""

                                       + " unique=\""
                + $(this).attr("unique") + "\""

                                       + " DefValue=\""
                + $(this).attr("DefValue") + "\""

                                  + " guidelines=\""
                + $(this).attr("guidelines") + "\""

                                        + " element_type=\""
                + $(this).attr("element_type") + "\""

                + " element_id=\""
                + $(this).attr("element_id") +

                 "\" >";

            switch ($(this).attr("element_type")) {
                case 'checkbox':
                case 'radio':
            //     $("#" + $(this).attr("id") + "checkboxGroup").children().each(function () {
            //        var str_id = $(this).attr("id");
             //       str_r = str_r + '<option id="' + $(this).attr("id") + '" element_id="' + $(this).attr("element_id") + '"   title="' + $("#" + str_id + 'title').text() + '" option_is_default ="' + $('#' + parentid).attr('selected') + '" deleted ="' + $(this).attr("deleted") + '" isnew ="' + $(this).attr("isnew") + '" ></option>';
                    //   });

                    $("#" + $(this).attr("id") + "checkboxGroup").children().each(function () {
                        var str_id = $(this).attr("id");
                        str_r = str_r + '<option id="' + $(this).attr("id") + '" element_id="' + $(this).attr("element_id") + '"   title="' + $("#" + str_id + 'title').text() + '" option_is_default ="' + $(this).attr("option_is_default") + '" deleted ="' + $(this).attr("deleted") + '" isnew ="' + $(this).attr("isnew") + '" ></option>';
                    });
              

                    break;
                case 'select':
                    $("#" + $(this).attr("id") + "checkboxGroup").children().each(function () {
                    var str_id = $(this).attr("id");
                    str_r = str_r + '<option id="' + $(this).attr("id") + '" element_id="' + $(this).attr("element_id") + '"   title="' + $("#" + str_id).text() + '" option_is_default ="' + $('#' + $(this).attr("id")).prop('selected') + '" deleted ="' + $(this).attr("deleted") + '" isnew ="' + $(this).attr("isnew") + '" ></option>';
                });
                    break;
                default:

            }


            //if (($(this).attr("element_type") == "checkbox") || ($(this).attr("element_type") == "radio") || ($(this).attr("element_type") == "select")) {
               
              //  });
            
            str_r = str_r + "</control>";
            //$(div).appendChild($(this));
        });

        str_r = str_r + "</root>";

        $("#TextHidden").val(str_r);

    });


    /************************function delShowDialog */

    function delShowDialog(showerid) {
        $("#dialog").dialog({ modal: true, draggable: false, resizable: false
            , buttons: {
                "تایید": function () {
                    $("#" + showerid).attr({
                        deleted: true
                    });
                    $('#' + showerid).hide();
                    checkEmptyBordersMsg();
                    $("#fieldProprtiesArea").hide();
                    //   $("#" + showerid).hide();
                    $("#msgEmptyProp").show();

                    $(this).dialog("close");
                },
                "انصراف": function () {
                    $(this).dialog("close");
                }
            }
        });
    }

    /************************function checkEmptyBordersMsg */
    function checkEmptyBordersMsg() {
        //#sortable >
        // alert($("div [deleted=false]").size());
        //alert($("#sortable >div ").size());
        if ($("div [deleted=false]").size() < 1) {
            $("#MSG1").show();
            $("#tabs").tabs({ selected: 0 });
        }
        else {
            $("#MSG1").hide();
        }
    };
    /********************************************************/

});
      
    