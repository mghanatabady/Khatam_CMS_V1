<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_estate_add.ascx.cs" Inherits="Manage_C_estate_add" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<%@ Register assembly="DNA.UI.JQuery" namespace="DNA.UI.JQuery" tagprefix="DotNetAge" %>
<style type="text/css">
    #tabs ul
    {
        float: right;
        width: 99%;
    }
    #tabs ul li
    {
        float: right;
    }
    
    .ui-dialog-titlebar-close {
  visibility: hidden;
}

    .txtBox
    {
        width: 128px;
    }

</style>

    <!-- These 2 CSS files are required: any 1 jQuery UI theme CSS, plus the Tag-it base CSS. -->
    
    <link rel="stylesheet" type="text/css" href="../css/jquery.tagit.css">

    <!-- This is an optional CSS theme that only applies to this widget. Use it in addition to the jQuery UI theme. -->
    <link href="../css/tagit.ui-zendesk.css" rel="stylesheet" type="text/css">

    <!-- jQuery and jQuery UI are required dependencies. -->
 
    <script src="../core/js/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../core/js/jquery-ui-1.8.20.custom.min.js" type="text/javascript"></script>

    <!-- The real deal -->
	

<script src="../core/js/tag/tagit-themeroller.js" type="text/javascript"></script>


	<script type="text/javascript">
	    $(function () {
	        var sampleTags = ['c++', 'java', 'php', 'coldfusion', 'javascript', 'asp', 'ruby', 'python', 'c', 'scala', 'groovy', 'haskell', 'perl', 'erlang', 'apl', 'cobol', 'go', 'lua'];

	        //-------------------------------
	        // Minimal
	        //-------------------------------


	        //-------------------------------
	        // Single field
	        //-------------------------------
	        $('#singleFieldTags').tagit({
	            maxTags: 10,
	            tagSource: function (request, response) {
	                $.ajax({
	                    type: "POST",
	                    contentType: "application/json; charset=utf-8",
	                    url: "../GetAllSites.asmx/GetAllSites",
	                    data: "{'keywords':'" + request.term + "'}",
	                    dataType: "json",
	                    async: true,
	                    success: function (data) {
	                        response(data.d);
	                    },
	                    error: function (xhr, ajaxOptions, thrownError) {
	                        alert(xhr.status);
	                        alert(thrownError);
	                    }
	                });
	            }
	            //   tagsChanged: function () {
	            //     var tags = $('#singleFieldTags');
	            //instan/ce.tagit('#singleFieldTags');
	            //      var tagString = [];
	            //     for (var i in tags){
	            //         tagString.push(tags[i].label);
	            //   }
	            //  target.val(tagString.join(','));
	            //   alert(tagString.join(','));
	            ///  }
	            // This will make Tag-it submit a single form value, as a comma-delimited field.

	        });



	    });
	</script>

  <script type="text/javascript">
      $(document).ready(function () {
          $('#btnOK').click(function () {
              var str = '<root>';
              var temp = '';
              $('.tagit-choice').each(function () {
                  temp = $(this).html();
                  temp = "<tag>" + temp.replace('<a class="tagit-close ui-state-error-text">x</a>', '') + "</tag>";
                  str = str + temp;
              });
              str = str + '</root>';
              //alert(str);
              $('#Hidden1').val(str);
          });

      });



</script>  
 

                
<div style="width: 995px; float: right">
  
      <div id="summaryValidation"  dir="rtl"  style="text-align: right"  >
                         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="SaveAll" />
                        </div>
                         <br />
                              <br />

  
                    <div id="MSG_OK" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                        margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
                        border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image12" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">عملیات موفقیت آمیز<br />
                                <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                        <br />
                    </div>

    <br />
            <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
                <Views>
                    <DotNetAge:View Text="اطلاعات محتوا" runat="server" ID="View">

                         <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto; margin-bottom:10px">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image11" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px ; color:#494949">
                            <strong><span>لطفا اطلاعات فرم زیر را با دقت کامل کنید:</span></strong></div>
                    </div>
                       <div style="width: 954px;" id="Div_Main" runat="server">

                               <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                                   <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> اطلاعات پایه محتوا
                    </div>


                    

                    <div id="rowsDiv" runat="server">
                        <div class="row">
                            <div class="field">
                                   کد</div>
                            <div class="fieldInputArea">
                            <% = idpage_content %>
                               
                            </div>
                        </div>
                              <div class="row">
                            <div class="field">
                                  کد محتوا</div>
                            <div class="fieldInputArea">
                                <% = idpage  %>
                            </div>
                        </div>

                      <div class="row">
                            <div class="field">
                                  تعداد بازدید</div>
                            <div class="fieldInputArea">
                                <% = visitCounter%>
                            </div>
                        </div>
                       

                        
                    </div>

                                <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        ویرایش اطلاعات پایه
                    </div>
                    <div id="rows2" runat="server">
                        <div class="row">
                            <div class="field">
                                   نمایش</div>
                            <div class="fieldInputArea">
                                <asp:CheckBox ID="chk_Content_Enable" runat="server" />
                            </div>
                        </div>
                              <div class="row" >
                            <div class="field">
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator12" 
                                        runat="server" ErrorMessage="درج عنوان محتوا الزامی است" ValidationGroup="SaveAll"  Text="*" ControlToValidate="Txt_Title">
                                        </asp:RequiredFieldValidator>
                                عنوان <a href="#" class="tooltipA"  onmouseover="return tooltip('عنوان اصلی محتوا');" onmouseout="return hideTip();" onClick="return false;">[?]</a>
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="Txt_Title" runat="server" CssClass="txtBox" MaxLength="149" Width="250px"></asp:TextBox>

                       
                            </div>
                        </div>
                    
                              <div class="row">
                            <div class="field">
                                  نویسنده</div>
                            <div class="fieldInputArea">
                               <asp:TextBox ID="txt_tag_Author" runat="server" CssClass="txtBox" MaxLength="120" Width="250px"></asp:TextBox>
                            </div>
                        </div>


                                  <div class="row">
                            <div class="field">
                                  شرح
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                runat="server" Display="dynamic" 
                ControlToValidate="txt_tag_Description" 
                ValidationExpression="^([\S\s]{0,300})$" 
                ErrorMessage="درج بیش از 300 کاراکتر در بخش شرح مجاز نیست" Text="*" ValidationGroup="SaveAll" />

                                  
                                  </div>
                            <div class="fieldInputArea">
                                   <asp:TextBox ID="txt_tag_Description" runat="server" CssClass="txtBox" Height="60px"
                                    TextMode="MultiLine" 
                                    
                                    MaxLength="10" 
                                      ClientIDMode="Static"
                                   

                                    
                                     Width="430px"></asp:TextBox>

                                    

        </asp:RegularExpressionValidator>


                            </div>
                        </div>

                                  <div id="divValidationArea" class="row" runat="server" visible="false" >
                            <div class="field">
                                  تایید</div>
                            <div class="fieldInputArea">
                                <asp:CheckBox ID="chk__Valid_Enable" runat="server" />
                              
                            </div>
                        </div>

                          <div id="divImportantArea" class="row" runat="server" >
                            <div class="field">
                                  مهم</div>
                            <div class="fieldInputArea">
                                <asp:CheckBox ID="chk_important_Enable" runat="server" />
                              
                            </div>
                        </div>


                                                          <div id="div4" class="row" runat="server"  >
                            <div class="field">
                                                                     <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage=" فیلد تاریخ در قسمت زمان نمایش را را با فرمت صحیح تاریخ درج نمایید مانند:format: 1390/12/30  "
                                 ControlToValidate="txt_birthday" Text="*" ValidationGroup="SaveAll"    MaximumValue = "2012/12/30"   MinimumValue = "1012/1/1"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>


                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="txt_birthday" runat="server" ValidationGroup="SaveAll" Text="*" ErrorMessage="درج فیلد تاریخ در قسمت زمان نمایش ضروری است"></asp:RequiredFieldValidator>
                                   شروع نمایش از 
                                  </div>
                            <div class="fieldInputArea">
                                                        
                                                        <asp:TextBox ID="txt_birthday"  CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox>


                                <asp:DropDownList ID="ddl_time" runat="server">
                                <asp:ListItem Text="00:00 صبح" Value="0"></asp:ListItem>
                                <asp:ListItem Text="00:15 صبح" Value="15"></asp:ListItem>
                                <asp:ListItem Text="00:30 صبح" Value="30"></asp:ListItem>
                                <asp:ListItem Text="00:45 صبح" Value="45"></asp:ListItem>
                                <asp:ListItem Text="01:00 صبح" Value="60"></asp:ListItem>
                                <asp:ListItem Text="01:15 صبح" Value="75"></asp:ListItem>
                                <asp:ListItem Text="01:30 صبح" Value="90"></asp:ListItem>
                                <asp:ListItem Text="01:45 صبح" Value="105"></asp:ListItem>
                                <asp:ListItem Text="02:00 صبح" Value="120"></asp:ListItem>
                                <asp:ListItem Text="02:15 صبح" Value="135"></asp:ListItem>
                                <asp:ListItem Text="02:30 صبح" Value="150"></asp:ListItem>
                                <asp:ListItem Text="02:45 صبح" Value="165"></asp:ListItem>
                                <asp:ListItem Text="03:00 صبح" Value="180"></asp:ListItem>
                                <asp:ListItem Text="03:15 صبح" Value="195"></asp:ListItem>
                                <asp:ListItem Text="03:30 صبح" Value="210"></asp:ListItem>
                                <asp:ListItem Text="03:45 صبح" Value="225"></asp:ListItem>
                                <asp:ListItem Text="04:00 صبح" Value="240"></asp:ListItem>
                                <asp:ListItem Text="04:15 صبح" Value="255"></asp:ListItem>
                                <asp:ListItem Text="04:30 صبح" Value="270"></asp:ListItem>
                                <asp:ListItem Text="04:45 صبح" Value="285"></asp:ListItem>
                                <asp:ListItem Text="05:00 صبح" Value="300"></asp:ListItem>
                                <asp:ListItem Text="05:15 صبح" Value="315"></asp:ListItem>
                                <asp:ListItem Text="05:30 صبح" Value="330"></asp:ListItem>
                                <asp:ListItem Text="05:45 صبح" Value="345"></asp:ListItem>
                                <asp:ListItem Text="06:00 صبح" Value="360"></asp:ListItem>
                                <asp:ListItem Text="06:15 صبح" Value="375"></asp:ListItem>
                                <asp:ListItem Text="06:30 صبح" Value="390"></asp:ListItem>
                                <asp:ListItem Text="06:45 صبح" Value="405"></asp:ListItem>
                                <asp:ListItem Text="07:00 صبح" Value="420"></asp:ListItem>
                                <asp:ListItem Text="07:15 صبح" Value="435"></asp:ListItem>
                                <asp:ListItem Text="07:30 صبح" Value="450"></asp:ListItem>
                                <asp:ListItem Text="07:45 صبح" Value="465"></asp:ListItem>
                                <asp:ListItem Text="08:00 صبح" Value="480"></asp:ListItem>
                                <asp:ListItem Text="08:15 صبح" Value="495"></asp:ListItem>
                                <asp:ListItem Text="08:30 صبح" Value="510"></asp:ListItem>
                                <asp:ListItem Text="08:45 صبح" Value="525"></asp:ListItem>
                                <asp:ListItem Text="09:00 صبح" Value="540"></asp:ListItem>
                                <asp:ListItem Text="09:15 صبح" Value="555"></asp:ListItem>
                                <asp:ListItem Text="09:30 صبح" Value="570"></asp:ListItem>
                                <asp:ListItem Text="09:45 صبح" Value="585"></asp:ListItem>
                                <asp:ListItem Text="10:00 صبح" Value="600"></asp:ListItem>
                                <asp:ListItem Text="10:15 صبح" Value="615"></asp:ListItem>
                                <asp:ListItem Text="10:30 صبح" Value="630"></asp:ListItem>
                                <asp:ListItem Text="10:45 صبح" Value="645"></asp:ListItem>
                                <asp:ListItem Text="11:00 صبح" Value="660"></asp:ListItem>
                                <asp:ListItem Text="11:15 صبح" Value="675"></asp:ListItem>
                                <asp:ListItem Text="11:30 صبح" Value="690"></asp:ListItem>
                                <asp:ListItem Text="11:45 صبح" Value="705"></asp:ListItem>
                                <asp:ListItem Text="12:00 صبح" Value="720"></asp:ListItem>
                                <asp:ListItem Text="12:15 صبح" Value="735"></asp:ListItem>
                                <asp:ListItem Text="12:30 صبح" Value="750"></asp:ListItem>
                                <asp:ListItem Text="12:45 صبح" Value="765"></asp:ListItem>
                                <asp:ListItem Text="13:00 عصر" Value="780"></asp:ListItem>
                                <asp:ListItem Text="13:15 عصر" Value="795"></asp:ListItem>
                                <asp:ListItem Text="13:30 عصر" Value="810"></asp:ListItem>
                                <asp:ListItem Text="13:45 عصر" Value="825"></asp:ListItem>
                                <asp:ListItem Text="14:00 عصر" Value="840"></asp:ListItem>
                                <asp:ListItem Text="14:15 عصر" Value="855"></asp:ListItem>
                                <asp:ListItem Text="14:30 عصر" Value="870"></asp:ListItem>
                                <asp:ListItem Text="14:45 عصر" Value="885"></asp:ListItem>
                                <asp:ListItem Text="15:00 عصر" Value="900"></asp:ListItem>
                                <asp:ListItem Text="15:15 عصر" Value="915"></asp:ListItem>
                                <asp:ListItem Text="15:30 عصر" Value="930"></asp:ListItem>
                                <asp:ListItem Text="15:45 عصر" Value="945"></asp:ListItem>
                                <asp:ListItem Text="15:00 عصر" Value="960"></asp:ListItem>
                                <asp:ListItem Text="16:15 عصر" Value="975"></asp:ListItem>
                                <asp:ListItem Text="16:30 عصر" Value="990"></asp:ListItem>
                                <asp:ListItem Text="16:45 عصر" Value="1005"></asp:ListItem>
                                <asp:ListItem Text="17:00 عصر" Value="1020"></asp:ListItem>
                                <asp:ListItem Text="17:15 عصر" Value="1035"></asp:ListItem>
                                <asp:ListItem Text="17:30 عصر" Value="1050"></asp:ListItem>
                                <asp:ListItem Text="17:45 عصر" Value="1065"></asp:ListItem>
                                <asp:ListItem Text="18:00 عصر" Value="1080"></asp:ListItem>
                                <asp:ListItem Text="18:15 عصر" Value="1095"></asp:ListItem>
                                <asp:ListItem Text="18:30 عصر" Value="1110"></asp:ListItem>
                                <asp:ListItem Text="18:45 عصر" Value="1125"></asp:ListItem>
                                <asp:ListItem Text="19:00 عصر" Value="1140"></asp:ListItem>
                                <asp:ListItem Text="19:15 عصر" Value="1155"></asp:ListItem>
                                <asp:ListItem Text="19:30 عصر" Value="1170"></asp:ListItem>
                                <asp:ListItem Text="19:45 عصر" Value="1185"></asp:ListItem>
                                <asp:ListItem Text="20:00 عصر" Value="1200"></asp:ListItem>
                                <asp:ListItem Text="20:15 عصر" Value="1215"></asp:ListItem>
                                <asp:ListItem Text="20:30 عصر" Value="1230"></asp:ListItem>
                                <asp:ListItem Text="20:45 عصر" Value="1245"></asp:ListItem>
                                <asp:ListItem Text="21:00 عصر" Value="1260"></asp:ListItem>
                                <asp:ListItem Text="21:15 عصر" Value="1275"></asp:ListItem>
                                <asp:ListItem Text="21:30 عصر" Value="1290"></asp:ListItem>
                                <asp:ListItem Text="21:45 عصر" Value="1305"></asp:ListItem>
                                <asp:ListItem Text="22:00 عصر" Value="1320"></asp:ListItem>
                                <asp:ListItem Text="22:15 عصر" Value="1335"></asp:ListItem>
                                <asp:ListItem Text="22:30 عصر" Value="1350"></asp:ListItem>
                                <asp:ListItem Text="22:45 عصر" Value="1365"></asp:ListItem>
                                <asp:ListItem Text="23:00 عصر" Value="1380"></asp:ListItem>
                                <asp:ListItem Text="23:15 عصر" Value="1395"></asp:ListItem>
                                <asp:ListItem Text="23:30 عصر" Value="1410"></asp:ListItem>
                                <asp:ListItem Text="23:45 عصر" Value="1425"></asp:ListItem>                                
                  
                                </asp:DropDownList>
                            </div>
                        </div>

                    


                        
                    </div>

                                                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        ویرایش اطلاعات موتور های جستجو
                    </div>

                    <div id="rows3" runat="server">
                        <div class="row">
                            <div class="field">
                                   تگ ها</div>
                            <div class="fieldInputArea">
                                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                                <input id="Hidden1"  clientidmode="Static" type="hidden" runat="server"   />  

		                 <asp:TextBox ID="txt_tag_keywords" runat="server" CssClass="txtBox" MaxLength="120" Visible="false"></asp:TextBox>

                            </div>
                        </div>
                     
                    

                        
                    </div>




                    </div>


                    <div id="Div_Part_Shop" runat="server">
                    
                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        اطلاعات محصول
                    </div>

                           <div id="rows_shop" runat="server">

                                         <div class="row">
                            <div class="field">
                                  شیوه فروش </div>
                            <div class="fieldInputArea">
                            <asp:DropDownList ID="ddl_shop_DdlSellMode" runat="server" CssClass="txtBox">
                                                                <asp:ListItem Text="فروش آنلاین" Value="1"> 
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="فقط با تماس" Value="2"  > 
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="توقف فروش" Value="3"> 
                                                                </asp:ListItem>
                                                                </asp:DropDownList>
                            </div>
                        </div>



                        <div class="row">
                            <div class="field">
                                  سازنده </div>
                            <div class="fieldInputArea">
                         <asp:TextBox ID="Txt_manufacturer" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="field">
                                  لینک درایور </div>
                            <div class="fieldInputArea">
                           <asp:TextBox ID="Txt_driver" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="field">
                                  PDF مرتبط </div>
                            <div class="fieldInputArea">
                                            <asp:TextBox ID="Txt_pdf" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>
                     
                        <div class="row">
                            <div class="field">
                                  آیدی یاهو فروشنده </div>
                            <div class="fieldInputArea">
                         <asp:TextBox ID="Txt_Shop_YahooID" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>
                        
                               <div class="row">
                            <div class="field">
                                  تلفن ثابت فروشنده </div>
                            <div class="fieldInputArea">
                           <asp:TextBox ID="Txt_Shop_shopAssistantTel" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>
                        
                               <div class="row">
                            <div class="field">
                                 موبایل فروشنده  </div>
                            <div class="fieldInputArea">
                                            <asp:TextBox ID="Txt_Shop_shopAssistantMobile" runat="server" CssClass="txtBox"></asp:TextBox>
                         
                            </div>
                        </div>
                        
                               <div class="row">
                            <div class="field">
                                  ایمیل فروشنده </div>
                            <div class="fieldInputArea">
                         <asp:TextBox ID="Txt_Shop_shopAssistantEmail" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>  
                        
                         
                                <div class="row">
                            <div class="field">
                                   وزن به گرم</div>
                            <div class="fieldInputArea">
                         <asp:TextBox ID="txt_shop_weight" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div> 


                                <div class="row">
                            <div class="field">عرض (متر)</div>
                            <div class="fieldInputArea">
                            <asp:TextBox ID="txt_shop_Width" runat="server" CssClass="txtBox"></asp:TextBox>
                         
                            </div>
                        </div> 
                     
                                <div class="row">
                            <div class="field">طول (متر)</div>
                            <div class="fieldInputArea">
                            <asp:TextBox ID="txt_shop_Length" runat="server" CssClass="txtBox"></asp:TextBox>
                         
                            </div>
                        </div>                          

                                <div class="row">
                            <div class="field">
                                  ارتفاع (متر)</div>
                            <div class="fieldInputArea">
                         <asp:TextBox ID="txt_shop_Height" runat="server" CssClass="txtBox"></asp:TextBox>
                            </div>
                        </div>  

 



                                <div class="row">
                            <div class="field">
                                 شکستنی  </div>
                            <div class="fieldInputArea">
                                <asp:CheckBox ID="chk_shop_Breakable"  runat="server" />
                            </div>
                        </div>  

                                <div class="row">
                            <div class="field">
                                 مایعات  </div>
                            <div class="fieldInputArea">
                         <asp:CheckBox ID="chk_shop_Liquid"  runat="server" />
                            </div>
                        </div>  
                        
                    </div>

                    </div>
                                                                   
                                               <div id="divDirectLink" runat="server">
                                    <asp:Literal ID="LiteralDirectLinkCurent" runat="server"></asp:Literal>
                                    <br />
                                    آپلود فایل لینک مستقیم (جدید):<br />
                                    <asp:FileUpload ID="FileUploadDirectLink" runat="server" />
                                    <br />
                                    <br />
                                    <asp:Label ID="FileDLName" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label ID="FileDLSize" runat="server"></asp:Label>
                                    <br />
                                    <asp:Literal ID="LiteralDirectLink" runat="server"></asp:Literal>
                                    <br />
                                    <br />
                                    <asp:Button ID="btnUploadDirectLink" runat="server" Text="Upload" OnClick="btnUploadDirectLinkImage_Click" />
                                    <br />
                                    <hr />
                                </div>
                           
                                <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x"
                                    id="Div_Part_Software" runat="server">
                                    <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Password" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Link1" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Link2" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Link3" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Crack1" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Crack2" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_BuilderSite" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <br />
                                    </div>
                                    <div style="margin-top: 5px; width: 205px">
                                        <div style="width: 200px; height: 34px">
                                            <span>پسورد</span></div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود1</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود2</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود3</div>
                                        <div style="width: 200px; height: 34px">
                                            کرک 1</div>
                                        <div style="width: 200px; height: 34px">
                                            کرک 2</div>
                                        <div style="width: 200px; height: 34px">
                                            سایت سازنده</div>
                                        <br />
                                    </div>
                                </div>
                                <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x"
                                    id="Div_Part_Clip" runat="server">
                                    <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Clip_Password" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Clip_Link1" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Clip_Link2" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Clip_Link3" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <br />
                                    </div>
                                    <div style="margin-top: 5px; width: 205px">
                                        <div style="width: 200px; height: 34px">
                                            <span>پسورد</span></div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود1</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود2</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود3</div>
                                        <br />
                                    </div>
                                </div>
                                <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x"
                                    id="Div_Part_Mobile" runat="server">
                                    <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Mobile_password" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Mobile_Link1" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Mobile_Link2" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Mobile_Link3" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <br />
                                    </div>
                                    <div style="margin-top: 5px; width: 205px">
                                        <div style="width: 200px; height: 34px">
                                            <span>پسورد</span></div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود1</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود2</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک دانلود3</div>
                                        <br />
                                    </div>
                                </div>
                                
                                <div id="Div_part_library" runat="server" style="margin-left: 9px; width: 724px;
                                    margin-right: 9px; background-repeat: repeat-x">
                                    <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_author" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_translator" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_isbn" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Link1_Book" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Link2_Book" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Library_password" runat="server" CssClass="txtBox"></asp:TextBox></div>
                                        <br />
                                    </div>
                                    <div style="margin-top: 5px; width: 205px">
                                        <div style="width: 200px; height: 34px">
                                            <span>نویسنده کتاب</span></div>
                                        <div style="width: 200px; height: 34px">
                                            مترجم</div>
                                        <div style="width: 200px; height: 34px">
                                            شابک</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک 1</div>
                                        <div style="width: 200px; height: 34px">
                                            لینک 2</div>
                                        <div style="width: 200px; height: 34px">
                                            پسورد</div>
                                        <br />
                                    </div>
                                </div>
                                <div id="Div_Part_speciallink" runat="server" style="margin-left: 9px; width: 724px;
                                    margin-right: 9px; background-repeat: repeat-x">
                                    <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Speciallink" runat="server" CssClass="txtBox" MaxLength="255"></asp:TextBox></div>
                                        <div style="width: 480px; height: 34px">
                                            <asp:TextBox ID="Txt_Speciallink_Title" runat="server" CssClass="txtBox" MaxLength="255"></asp:TextBox></div>
                                    </div>
                                    <div style="margin-top: 5px; width: 205px">
                                        <div style="width: 200px; height: 34px">
                                            لینک</div>
                                        <div style="width: 200px; height: 34px">
                                            متن لینک</div>
                                    </div>
                                </div>
                                <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x"
                                    id="Div_host" runat="server">
                                   <!--هاست -->
                               
                                </div>

                                  <div 
                                    id="Div_news" runat="server">

                                                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        اطلاعات خبر
                    </div>

                    <div id="Div3" runat="server">
                        <div class="row">
                            <div class="field">
                                   تاریخ خبر</div>
                            <div class="fieldInputArea" >
                            <span dir="ltr" >
                              <asp:TextBox ID="PersianDateTextBox"  CssClass="txtBox_ltr" runat="server"></asp:TextBox>
       </span>

                                        <asp:RangeValidator ID="RangeValidator1" ValidationGroup="SaveAll" 
                                        runat="server" ErrorMessage="تاریخ نامعتبر است" Text="تاریخ نامعتبر است" Type="Date" ControlToValidate="PersianDateTextBox" MaximumValue="2012/11/11" MinimumValue="1012/11/11" ></asp:RangeValidator>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                        runat="server" ErrorMessage="لطفا تاریخ خبر را درج کنید" ValidationGroup="SaveAll"  Text="لطفا تاریخ خبر را درج کنید" ControlToValidate="PersianDateTextBox">
                                        </asp:RequiredFieldValidator>
                                        
                            </div>
                        </div>
                     
                        <div class="row">
                            <div class="field">
                                   منبع</div>
                            <div class="fieldInputArea">
                               <asp:TextBox ID="Txt_news_source" runat="server" CssClass="txtBox" MaxLength="49"></asp:TextBox></div>
                            </div>
                        </div>
                        

                        
                    </div>


                              
                                
                             




                                  <div id="Div_menu" runat="server" style="margin-left: 9px; width: 724px; margin-right: 9px;
                                background-repeat: repeat-x">
                                <div style="margin-top: 5px; float: left; width: 505px; margin-right: 5px; text-align: right">
                                    <div style="width: 480px; height: 34px" dir="ltr">
                                        <asp:TextBox ID="Txt_menu_link" runat="server" CssClass="txtBox" MaxLength="255"  Width="250px"></asp:TextBox></div>
                                    <div style="width: 480px; height: 34px">
                                        <asp:TextBox ID="Txt_menu_title" runat="server" CssClass="txtBox" MaxLength="255"   Width="250px"></asp:TextBox></div>
                                </div>
                                <div style="margin-top: 5px; width: 205px">
                                    <div style="width: 200px; height: 34px">
                                        لینک</div>
                                    <div style="width: 200px; height: 34px">
                                        متن
                                    </div>
                                </div>
                            </div>



              


                        <div 
                                    id="Div_link" runat="server">

                                                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        لینک
                    </div>

                
                        <div class="row">
                            <div class="field">
                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator13" 
                                        runat="server" ErrorMessage="درج لینک الزامی است" ValidationGroup="SaveAll"  Text="*" ControlToValidate="Txt_Link_Link">
                                        </asp:RequiredFieldValidator>
                                   لینک</div>
                            <div class="fieldInputArea" >
                            <span dir="ltr" >
                                                                      <asp:TextBox ID="Txt_Link_Link" runat="server" CssClass="txtBox"></asp:TextBox></div>

       </span>

                        </div>
                            </div> 
                        
                     
                        
                  
                

                                                <div    id="div_portal" runat="server">

                                                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        اطلاعات پرتال
                    </div>

                    <div id="Div5" runat="server">
                        <div class="row">
                            <div class="field">
                                   هزینه راه اندازی - ریال</div>
                            <div class="fieldInputArea" >
                            <span dir="ltr" >
                              <asp:TextBox ID="txt_portal_setupPrice"  CssClass="txtBox_ltr" runat="server"></asp:TextBox>
                                     </span>                                      
                                        
                            </div>
                        </div>
                     
                        <div class="row">
                            <div class="field">
                                   شرح برای درج در فاکتور</div>
                            <div class="fieldInputArea">
                               <asp:TextBox ID="txt_portal_memo_invoice" runat="server" CssClass="txtBox" Height="120px"
                                    TextMode="MultiLine" 
                                    
                                    MaxLength="10" 
                                      ClientIDMode="Static"
                                   

                                    
                                     Width="430px"></asp:TextBox></div>
                            </div>
                        </div>
                        

                        
                    </div>

                                <br />
                                <br />
                    </DotNetAge:View>

                    <DotNetAge:View Text="ویرایشگر" runat="server" ID="ViewEdit">
                        <div dir="rtl" style="text-align: right">
                         
                            
                                
                              	<CKEditor:CKEditorControl ID="CKEditor1" runat="server" Height="200"   FilebrowserBrowseUrl="../core/ckfinder/ckfinder.html"  BasePath="~/core/ckeditor" TemplatesFiles="~/core/ckeditor/plugins/templates/templates/default.js">
		
		</CKEditor:CKEditorControl>
                            
                                
                              
                      
                    
                         
                          
                        </div>
                    </DotNetAge:View>

                    
          

                       

                        <DotNetAge:View Text="تصاویر" runat="server" ID="View_picture">
                       
                         آپلود تصویر جدید:<br />
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <br />
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                                <br />
                                <asp:Button ID="btnUploadImage" runat="server" Text="Upload" OnClick="btnUploadImage_Click" />
                                <br />
                                <br />
                                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                                <br />
                                <br />
                                <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                                <br />
                                <br />
                           
    <br />

                    </DotNetAge:View>

                         

                  
                      <DotNetAge:View Text="قوانین فروش" runat="server" ID="View_saleTerm">


                               <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div dir="rtl" style="width: 100%;">
                            <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
                                height: 30px; text-align: left">
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif);
                                    margin-left: 5px; width: 3px; margin-right: 5px; height: 30px">
                                </div>
                                <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <asp:ImageButton ID="imgBtnCore_SaleTermShowAdd" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif"
                                    OnClick="imgBtnCore_SaleTermShowAdd_Click" />
                            </div>
                        </div>
                        <div id="divAddSaleTerm" runat="server" style="width: 350px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            تعریف قانون فروش جدید
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right; line-height: 20px;">
                                                            
  

  <div id="saleTerm_div_error_min" visible="false" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                            border-left: red 2px solid; width: 100%; border-bottom: red 2px solid; text-align: right;
                            margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; width: 313px; color: red; padding-top: 5px">
                                اخطار!<br />
                                <span style="font-size: 9pt">حداقل سفارش <asp:Label ID="sale_term_lbl_min_quantity_field" runat="server" Text="Label"></asp:Label> <asp:Label ID="sale_term_lbl_min_unit_field2" runat="server" Text="Label"></asp:Label> قبلا تعریف گردیده است!
                                    
                                    <br />
                             
                                   
                                </span>
                            </div>
                            <br />
                        </div>

                                                                          
                                                                
                                                                حداقل سفارش<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                                                    ErrorMessage="درج مقدار حداقل سفارش الزامی است" ControlToValidate="Saleterm_Add_txt_min"  ValidationGroup="saleTermADD" Text="*"></asp:RequiredFieldValidator><asp:Label ID="sale_term_lbl_min_unit_field" runat="server" Text="Label"></asp:Label>
                                                                 <br />
                                                                <asp:TextBox ID="Saleterm_Add_txt_min" runat="server"></asp:TextBox>

                                                                <br />
                                                                   
                                                                 <br />

 مبلغ به ریال<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                                                    ErrorMessage="درج قیمت الزامی است" ControlToValidate="Saleterm_Add_txt_Price"  ValidationGroup="saleTermADD" Text="*"></asp:RequiredFieldValidator>
                                                                 <br />
                                                                <asp:TextBox ID="Saleterm_Add_txt_Price" runat="server"></asp:TextBox>

                                                                <br />
                                                                   
                                                                 <br />
<div id="saleTerm_add_div_customSettingArea" runat="server" >
                                  
                                                               

                                                                <asp:CheckBox ID="CheckBox1" runat="server" Text="توقف فروش در صورت موجود نبودن در انبار " Visible="false" />

                                                                
                                                                                                                                  
                                                                                                                                       <br />
                                                                                                                                        <asp:ValidationSummary ID="ValidationSummary2" ValidationGroup="saleTermADD" runat="server" />   
                                                                <br />
                                            
                                                                  </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="saleTerm_add_btnSave" CssClass="Cpbtn" runat="server" Text="تایید" OnClick="saleTerm_add_btnSave_Click"  ValidationGroup="saleTermADD" />
                                                            <asp:Button ID="Button17" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div id="divEditSaleTerm" runat="server" style="width: 350px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            ویرایش قانون فروش
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right; line-height: 20px;">
                                                            
  

  <div id="saleTerm_edit_div_error_min" visible="false" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                            border-left: red 2px solid; width: 100%; border-bottom: red 2px solid; text-align: right;
                            margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; width: 313px; color: red; padding-top: 5px">
                                اخطار!<br />
                                <span style="font-size: 9pt">حداقل سفارش <asp:Label ID="sale_term_edit_lbl_min_quantity_field" runat="server" Text="Label"></asp:Label> <asp:Label ID="sale_term_edit_lbl_min_unit_field2" runat="server" Text="Label"></asp:Label> قبلا تعریف گردیده است!
                                    
                                    <br />
                             
                                   
                                </span>
                            </div>
                            <br />
                        </div>

                                                                کد <asp:Label ID="saleTerm_Edit_lbl_code" runat="server" Text="Label"></asp:Label><br />
                                                                
                                                                حداقل سفارش<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                                                                    ErrorMessage="درج مقدار حداقل سفارش الزامی است"  ControlToValidate="Saleterm_Edit_txt_min"  ValidationGroup="saleTermEdit" Text="*"></asp:RequiredFieldValidator><asp:Label ID="sale_term_edit_lbl_min_unit_field" runat="server" Text="Label"></asp:Label>
                                                                 <br />
                                                                <asp:TextBox ID="Saleterm_Edit_txt_min" runat="server"></asp:TextBox>

                                                                <br />
                                                                   
                                                                 <br />

 مبلغ به ریال<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server"
                                                                  ErrorMessage="درج قیمت الزامی است" ControlToValidate="Saleterm_Edit_txt_Price"  ValidationGroup="saleTermEdit" Text="*"></asp:RequiredFieldValidator>
                                                                 <br />
                                                                <asp:TextBox ID="Saleterm_Edit_txt_Price" runat="server"></asp:TextBox>

                                                                <br />
                                                                   
                                                                 <br />
<div id="Div6" runat="server" >
                     
                                                               

                                                                <asp:CheckBox ID="CheckBox2" runat="server" Text="توقف فروش در صورت موجود نبودن در انبار " Visible="false" />

                                                                
                                                                                                                                  
                                                                                                                                       <br />
                                                                                                                                        <asp:ValidationSummary ID="ValidationSummary3" ValidationGroup="saleTermEdit" runat="server" />   
                                                                <br />
                                            
                                                                  </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="saleTerm_Edit_btnSave" CssClass="Cpbtn" runat="server" Text="تایید" OnClick="saleTerm_Edit_btnSave_Click"  ValidationGroup="saleTermEdit" />
                                                            <asp:Button ID="BtnCancel_edit" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        


                        <div id="divDelSaleTerm" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                            border-left: red 2px solid; width: 100%; border-bottom: red 2px solid; text-align: right;
                            margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image9" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; width: 493px; color: red; padding-top: 5px">
                                اخطار!<br />
                                <span style="font-size: 9pt">برای حذف قانون فروش 
                                    <asp:Label ID="sale_term_del_lbl_id" runat="server" Text="Label"></asp:Label> مطمئن هستید؟
                                    <br />
                                    <asp:Button ID="Button22" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                                        ValidationGroup="Teacher_Add" Width="42px" OnClick="Button4_Click" />&nbsp;<asp:Button
                                            ID="Button23" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px"
                                            OnClick="BtnCancel_Click" /><br />
                                    <br />
                                </span>
                            </div>
                            <br />
                        </div>
                        <div id="divOkSaleTerm" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                            border-left: teal 2px solid; width: 100%; border-bottom: teal 2px solid; height: 45px;
                            text-align: right; margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                                <asp:Image ID="Image10" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
                                padding-top: 5px; height: 26px">
                                <span style="color: black">عملیات موفقیت آمیز<br />
                                    <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                            <br />
                        </div>
                        <div dir="rtl" style="width: 550px;">
                            &nbsp;<asp:GridView ID="saleTerm_gv" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="false" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
                                DataKeyNames="core_sale_terms_id" DataSourceID="SqlDataSource6" PageSize="50" Width="100%" OnSelectedIndexChanged="saleTerm_gv_SelectedIndexChanged"
                                OnRowCommand="saleTerm_gv_RowCommand" >
                                <FooterStyle BackColor="#F1F3FA" />
                               <Columns>
                               <asp:BoundField DataField="core_sale_terms_id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                                        SortExpression="core_sale_terms_id" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="min" HeaderText="حداقل سفارش" InsertVisible="False" ReadOnly="True"
                                        SortExpression="min" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="month" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:ButtonField Text="حذف" CommandName="del" />
                                    <asp:ButtonField CommandName="editcom" Text="ویرایش" />
                                </Columns>
                           
                                <EmptyDataTemplate>
                                    <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                                        width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                                        <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                            <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                                        <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                            توجه!<br />
                                            هیچ موردی برای نمایش یافت نشد.</div>
                                        <br />
                                    </div>
                                </EmptyDataTemplate>
                                <RowStyle HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" HorizontalAlign="Right" />
                            </asp:GridView>
                        </div>
                        <p>
                            <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                                SelectCommand="SELECT * FROM [core_sale_terms] WHERE ([catId] = @catId)">
                                 <SelectParameters>
            <asp:QueryStringParameter Name="catId" QueryStringField="id" Type="Int32" />
        </SelectParameters>
                                
                                </asp:SqlDataSource>
                        </p>

                           <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        واحد قوانین فروش
                    </div>

                           <div id="rows23" runat="server">
                           
                                   <div class="row">
                            <div class="field">
                               واحد فروش</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_shop_units" OnSelectedIndexChanged="ddl_shop_units_SelectedIndexChanged1" CssClass="txtBox" runat="server" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div> 
                           </div>
                          

                        </ContentTemplate>
                            </asp:UpdatePanel>


                           
                           
                    </DotNetAge:View>


                    <DotNetAge:View Text="سیکل پرداخت" runat="server" ID="View_paycycle" Visible="false">
                        <asp:UpdatePanel ID="UpdatePanelCycle" runat="server">
                    <ContentTemplate>
                        <div dir="rtl" style="width: 100%;">
                           
                            <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
                                height: 30px; text-align: left">
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif);
                                    margin-left: 5px; width: 3px; margin-right: 5px; height: 30px">
                                </div>
                                <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <asp:ImageButton ID="imgBtnPayCycleNew" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif"
                                    OnClick="imgBtnPayCycleNew_Click" />
                            </div>
                        </div>
                        <div id="paycycle_div_msgAdd" runat="server" style="width: 350px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            تعریف سیکل پرداخت جدید
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right">
                                                                مدت زمان
                                                                <br />
                                                                <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Tahoma">
                                                                    <asp:ListItem Value="1">یک ماه</asp:ListItem>
                                                                    <asp:ListItem Value="2">دو ماه</asp:ListItem>
                                                                    <asp:ListItem Value="3">سه ماه</asp:ListItem>
                                                                    <asp:ListItem Value="6">شش ماه</asp:ListItem>
                                                                    <asp:ListItem Value="12">یک سال</asp:ListItem>
                                                                    <asp:ListItem Value="24">دو سال</asp:ListItem>
                                                                    <asp:ListItem Value="36">سه سال</asp:ListItem>
                                                                    <asp:ListItem Value="48">چهار سال</asp:ListItem>
                                                                    <asp:ListItem Value="60">پنج سال</asp:ListItem>
                                                                    <asp:ListItem Value="72">شش سال</asp:ListItem>
                                                                    <asp:ListItem Value="84">هفت سال</asp:ListItem>
                                                                    <asp:ListItem Value="96">هشت سال</asp:ListItem>
                                                                    <asp:ListItem Value="108">نه سال</asp:ListItem>
                                                                    <asp:ListItem Value="120">ده سال</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <br />
                                                                <br />
                                                                قیمت ریال
                                                                <br />
                                                                <asp:TextBox ID="paycycle_txt_price" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="paycycle_txt_price"
                                                                    ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="paycycle_btn_add_save" CssClass="Cpbtn" runat="server" Text="تایید" OnClick="paycycle_btn_add_save_Click" />
                                                            <asp:Button ID="paycycle_btn_add_Cancel" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="paycycle_btn_add_Cancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="paycycle_div_msgEdit" runat="server">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            ویرایش شی
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right">
                                                                کد شی
                                                                <br />
                                                                <asp:Label ID="LblEditCode" runat="server" Text="Label"></asp:Label>
                                                                <br />
                                                                <br />
                                                                نوع شی
                                                                <br />
                                                                <asp:Label ID="LblEditType" runat="server" Text="Label"></asp:Label>
                                                                <br />
                                                                <br />
                                                                عنوان
                                                                <br />
                                                                <asp:TextBox ID="txtEditTitle" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEditTitle"
                                                                    ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="Button6" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="paycycle_div_MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                            border-left: red 2px solid; width: 100%; border-bottom: red 2px solid; text-align: right;
                            margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; width: 493px; color: red; padding-top: 5px">
                                اخطار!<br />
                                <span style="font-size: 9pt">با عمل حذف تمام مشخصات مرتبط با شی نیز حذف خواهد گردید،
                                    آیا برای عملیات حذف شی شماره
                                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;مطمئن هستید؟
                                    <br />
                                    <asp:Button ID="Button16" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                                        ValidationGroup="Teacher_Add" Width="42px" OnClick="Button4_Click" />&nbsp;<asp:Button
                                            ID="Button7" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px"
                                            OnClick="BtnCancel_Click" /><br />
                                    <br />
                                </span>
                            </div>
                            <br />
                        </div>
                        <div id="paycycle_div_MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                            border-left: teal 2px solid; width: 100%; border-bottom: teal 2px solid; height: 45px;
                            text-align: right; margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
                                padding-top: 5px; height: 26px">
                                <span style="color: black">عملیات موفقیت آمیز<br />
                                    <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                            <br />
                        </div>
                        <div dir="rtl" style="width: 550px;">
                            &nbsp;<asp:GridView ID="paycycle_gv" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
                                DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="50" Width="100%" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
                                OnRowCommand="GridView2_RowCommand">
                                <FooterStyle BackColor="#F1F3FA" />
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                                        SortExpression="id" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="month" HeaderText="مدت زمان" SortExpression="month" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="price" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:ButtonField Text="حذف" CommandName="del" />
                                    <asp:ButtonField CommandName="editcom" Text="ویرایش" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                                        width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                                        <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                            <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                                        <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                            توجه!<br />
                                            هیچ موردی برای نمایش یافت نشد.</div>
                                        <br />
                                    </div>
                                </EmptyDataTemplate>
                                <RowStyle HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" HorizontalAlign="Right" />
                            </asp:GridView>
                        </div>
                        <p>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                SelectCommand="SELECT * FROM [core_paycycle] WHERE ([catId] = @catId) ">
                               <SelectParameters>
            <asp:QueryStringParameter Name="catId" QueryStringField="id" Type="Int32" />
        </SelectParameters>
                                </asp:SqlDataSource>
                        </p>
                        </ContentTemplate>
                            </asp:UpdatePanel>
                    </DotNetAge:View>


                           
                    
                    

                  
                            <DotNetAge:View Text="فیلد های انتخابی" runat="server" ID="ViewFieldOptional">

                             <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <div dir="rtl" style="width: 100%;">
                            <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
                                height: 30px; text-align: left">
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif);
                                    margin-left: 5px; width: 3px; margin-right: 5px; height: 30px">
                                </div>
                                <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <asp:ImageButton ID="imgBtnCore_PropAdd" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif"
                                    OnClick="imgBtnCore_PropAdd_Click" />
                            </div>
                        </div>
                        <div id="divPropAdd" runat="server" style="width: 350px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            تعریف فیلد جدید
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right; line-height: 20px;">
                                                                عنوان
                                                                <br />
                                                                <asp:TextBox ID="txtPropTitle" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPropTitle"
                                                                    ErrorMessage="*" ValidationGroup="core_propAdd">*</asp:RequiredFieldValidator>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="btnPropAdd_Save" CssClass="Cpbtn" runat="server" Text="تایید" OnClick="btnPropAdd_Save_Click" ValidationGroup="core_propAdd" />
                                                            <asp:Button ID="Button11" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="divPropEdit" runat="server">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            ویرایش شی
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right">
                                                                کد شی
                                                                <br />
                                                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                                                <br />
                                                                <br />
                                                                نوع شی
                                                                <br />
                                                                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                                                <br />
                                                                <br />
                                                                عنوان
                                                                <br />
                                                                <asp:TextBox ID="TextBox5" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox5"
                                                                    ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="Button12" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="divPropEditDefVal" runat="server" style=" width:500px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            ویرایش دامنه مقادیر
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">






                                                        <div dir="rtl" style="width: 100%;">
                            <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
                                height: 30px; text-align: left">
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif);
                                    margin-left: 5px; width: 3px; margin-right: 5px; height: 30px">
                                </div>
                                <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif);
                                    width: 2px; height: 30px">
                                </div>
                                <asp:ImageButton ID="imgBtnprop_defValADD" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif"
                                    OnClick="imgBtnprop_defValADD_Click" />
                            </div>
                        </div>




                        <div id="divProp_defVal_ADD" runat="server" style="width: 350px">
                            <div class="CPWin1t_tb">
                                <div class="CPWin1b_tb">
                                    <div class="CPWin1l_tb">
                                        <div class="CPWin1r_tb">
                                            <div class="CPWin1bl_tb">
                                                <div class="CPWin1br_tb">
                                                    <div class="CPWin1tl_tb">
                                                        <div class="CPWin1tr_tb">
                                                            تعریف مقدار جدید
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t">
                                <div class="CPWin1b">
                                    <div class="CPWin1l">
                                        <div class="CPWin1r">
                                            <div class="CPWin1bl">
                                                <div class="CPWin1br">
                                                    <div class="CPWin1tl">
                                                        <div class="CPWin1tr">
                                                            <div dir="rtl" style="text-align: right; line-height: 20px;">
                                                                عنوان
                                                                <br />
                                                                <asp:TextBox ID="txt_Prop_defVal_ADD_title" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_Prop_defVal_ADD_title"
                                                                    ErrorMessage="*" ValidationGroup="core_prop_defVal_Add">*</asp:RequiredFieldValidator>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="btnPropAddDefVal" CssClass="Cpbtn" runat="server" Text="تایید" OnClick="btnPropAddDefVal_Save_Click" ValidationGroup="core_prop_defVal_Add" />
                                                            <asp:Button ID="btnPropAddDefVal_cancel" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="btnPropAddDefVal_Cancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>



                        <br />

                                                            <div dir="rtl" style="text-align: right">
                                                                <asp:GridView ID="gv_propDefVal" runat="server" AllowPaging="True" 
                                                                    AllowSorting="True" AutoGenerateColumns="False" BorderColor="#BDC6E0" 
                                                                    BorderStyle="Solid" BorderWidth="1px" DataKeyNames="core_prop_defVal_id" 
                                                                    DataSourceID="SqlDataSource4" OnRowCommand="GridView2_RowCommand" 
                                                                    OnSelectedIndexChanged="GridView2_SelectedIndexChanged" PageSize="50" 
                                                                    Width="100%">
                                                                    <FooterStyle BackColor="#F1F3FA" />
                                                                    <Columns>
                                                                        <asp:BoundField DataField="core_prop_defVal_id" 
                                                                            HeaderStyle-HorizontalAlign="Right" HeaderText="کد" 
                                                                            InsertVisible="False" ReadOnly="True" SortExpression="core_prop_defVal_id">
                                                                        </asp:BoundField>
                                                               
                                                                        <asp:BoundField DataField="title" HeaderText="مقدار" SortExpression="title" />
                                                                               <asp:ButtonField Text="حذف" CommandName="del" />
                                    <asp:ButtonField CommandName="editcom" Text="ویرایش" />
                                                                    </Columns>
                                                                    <EmptyDataTemplate>
                                                                        <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                                        width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                                                                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                                                                <asp:Image ID="Image8" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                                                                                &nbsp;</div>
                                                                            <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                                                                توجه!<br /> هیچ موردی برای نمایش یافت نشد.</div>
                                                                            <br />
                                                                        </div>
                                                                    </EmptyDataTemplate>
                                                                    <RowStyle HorizontalAlign="Right" />
                                                                    <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" 
                                                                        HorizontalAlign="Right" />
                                                                </asp:GridView>
                                                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                                                                   
                                                                   ></asp:SqlDataSource>
                                                                <br />
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="CPWin1t_bb">
                                <div class="CPWin1b_bb">
                                    <div class="CPWin1l_bb">
                                        <div class="CPWin1r_bb">
                                            <div class="CPWin1bl_bb">
                                                <div class="CPWin1br_bb">
                                                    <div class="CPWin1tl_bb">
                                                        <div class="CPWin1tr_bb">
                                                            <asp:Button ID="Button15" CssClass="Cpbtn" runat="server" Text="انصراف" OnClick="BtnCancel_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div id="divPropDel" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
                            border-left: red 2px solid; width: 100%; border-bottom: red 2px solid; text-align: right;
                            margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; width: 493px; color: red; padding-top: 5px">
                                اخطار!<br />
                                <span style="font-size: 9pt">با عمل حذف تمام مشخصات مرتبط با شی نیز حذف خواهد گردید،
                                    آیا برای عملیات حذف شی شماره
                                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>&nbsp;مطمئن هستید؟
                                    <br />
                                    <asp:Button ID="Button13" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                                        ValidationGroup="Teacher_Add" Width="42px" OnClick="Button4_Click" />&nbsp;<asp:Button
                                            ID="Button14" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px"
                                            OnClick="BtnCancel_Click" /><br />
                                    <br />
                                </span>
                            </div>
                            <br />
                        </div>
                        <div id="divPropMsgOk" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
                            border-left: teal 2px solid; width: 100%; border-bottom: teal 2px solid; height: 45px;
                            text-align: right; margin-top: 10px">
                            <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                                <asp:Image ID="Image7" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />&nbsp;</div>
                            <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
                                padding-top: 5px; height: 26px">
                                <span style="color: black">عملیات موفقیت آمیز<br />
                                    <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                            <br />
                        </div>
                        <div dir="rtl" style="width: 550px;">
                            &nbsp;<asp:GridView ID="gv_prop" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
                                DataKeyNames="core_prop_id" DataSourceID="SqlDataSource3" PageSize="50" Width="100%" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
                                OnRowCommand="gv_prop_RowCommand">
                                <FooterStyle BackColor="#F1F3FA" />
                                <Columns>
                                    <asp:BoundField DataField="core_prop_id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                                        SortExpression="core_prop_id" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="title" HeaderText="عنوان" SortExpression="title" HeaderStyle-HorizontalAlign="Right">
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:ButtonField Text="حذف" CommandName="del" />
                                    <asp:ButtonField CommandName="editcom" Text="ویرایش" />
                                     <asp:ButtonField CommandName="defVals" Text="ویرایش دامنه مقادیر" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                                        width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                                        <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                            <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                                        <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                            توجه!<br />
                                            هیچ موردی برای نمایش یافت نشد.</div>
                                        <br />
                                    </div>
                                </EmptyDataTemplate>
                                <RowStyle HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" HorizontalAlign="Right" />
                            </asp:GridView>
                        </div>
                        <p>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                SelectCommand="SELECT    core_prop_id , cat_id, title   FROM         core_prop"></asp:SqlDataSource>
                        </p>

                          
                          
                          
                            <div id="Div2" runat="server">
                    
                    <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
تعیین مقادیر فیلد های انتخابی 
                    </div>

                         
                             <asp:PlaceHolder ID="PlaceHolder_fieldTab" runat="server"></asp:PlaceHolder>


                    </div>



                        </ContentTemplate>
                            </asp:UpdatePanel>


                           
                    </DotNetAge:View>


                </Views>



            </DotNetAge:Tabs>
            <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" ClientIDMode="Static" runat="server" BorderStyle="Solid" 
                    CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="SaveAll"  />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف"  />
            </div>

    <asp:Label ID="trace" runat="server" ></asp:Label>

    <br />
    <br />
  
    <br />
     <br />

    <br />
    
    
    
     
     
</div>


