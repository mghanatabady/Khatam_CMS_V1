<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_uniproj_project_edit_teacher.ascx.cs" Inherits="Manage_c_uniproj_project_edit_teacher" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

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
       <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
    <div style=" text-align:center ">
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </div>
    </ProgressTemplate>
</asp:UpdateProgress>

<br />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

  
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
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>



    <br />
            <div id="mainWin" runat="server" >

            <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
                <Views>
                    <DotNetAge:View Text="اطلاعات پروژه" runat="server" ID="View">

                         <div style="background-image: url(../core/themeCP/Bitrix/CssImage/background/Form1_icon_Spacer.gif); margin-left: 9px;
                        width: 934px; margin-right: 9px; background-repeat: repeat-x; height: 47px; overflow: auto; margin-bottom:10px">
                        <div style="margin-top: 10px; float: right; margin-left: 5px; width: 27px; height: 31px">
                            <asp:Image ID="Image11" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Form1_icon1.gif" />
                        </div>
                   
                        <div style="margin-top: 15px; float: right; margin-left: 5px; width: 450px; height: 26px ; color:#494949">
                            <strong><span>لطفا اطلاعات فرم زیر را با دقت کامل کنید:</span></strong></div>
                    </div>
                       <div style="width: 954px;" id="Div_Main" runat="server">

                     

                                <div style=" background-color:#e0e4f1; margin-left: 9px; margin-bottom:10px;  margin-top:10px;
                        width: 934px; margin-right: 9px; padding-top:5px; font-weight:bold  ; text-align: center ; padding-bottom:5px; overflow:  hidden; color:#525355">
                                           
                        ویرایش اطلاعات پایه
                    </div>
                    <div id="rows2" runat="server">

                              <div class="row" >
                            <div class="field">عنوان <a href="#" class="tooltipA"  onmouseover="return tooltip('عنوان اصلی محتوا');" onmouseout="return hideTip();" onClick="return false;">[?]</a>
                                  </div>
                            <div class="fieldInputArea">
                                                   <asp:TextBox ID="Txt_Title" runat="server" CssClass="txtBox" MaxLength="149" Width="250px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  ControlToValidate="Txt_Title" runat="server"  Text="*" ErrorMessage="درج فیلد عنوان الزامی است" ValidationGroup="SaveAll" ></asp:RequiredFieldValidator>
                            </div>
                        </div>

                                                      <div class="row" >
                            <div class="field">نوع پروژه 
                                  </div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Text="بررسی و ارزیابی" Value="1" ></asp:ListItem>
                                    <asp:ListItem Text="شبیه سازی" Value="2" ></asp:ListItem>
                                    <asp:ListItem Text="طراحی و ساخت" Value="3" ></asp:ListItem>


                                </asp:DropDownList>
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
                                   
T
                                    
                                     Width="430px"></asp:TextBox>

                                    

        


                            </div>
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

                    
          
          

                </Views>



            </DotNetAge:Tabs>
            
    <div id="msgDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        وضعیت تعریف پروژه
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg4.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px;  width:380px">
                            <span style="color: black">آیا محتوای پروژه تکمیل شده و آماده ی ارائه به مدیر گروه و دانشجویان است؟
                            <br />
                            بله: اتمام مرحله ویرایش و ارسال به مدیر گروه و دانشجویان
                            <br />
                            خیر: ویرایش و تکمیل محتوای پروژه در آینده</span>

                        </div>
                        <br /> 
 
 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="Button21" runat="server" Font-Bold="true" Text="خیر" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px" OnClick="Button21_Click"   />

                <asp:Button ID="Button22" runat="server"  Text="بله" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="del_dialog_yes_Click"
           OnClientClick = "  this.value = 'حذف...'; this.style.background = 'silver';"
           />
  </div>
  
  </div>
    
  

  </div>
            
            <div id="btns" style="border-left: 1px solid #aaaaaa; border-right: 1px solid #aaaaaa;
                border-bottom: 1px solid #aaaaaa; padding: 10px; background-color: #f8f9fc; direction: rtl;
                border-top-color: #aaaaaa; border-top-width: 1px; margin-bottom: 10px; text-align: right;">
                <asp:Button ID="btnOK" ClientIDMode="Static" runat="server" BorderStyle="Solid" 
                    CssClass="button1" OnClick="btnOK_Click"
                    Text="تایید" ValidationGroup="SaveAll"  />
                <asp:Button ID="btn_cancel" runat="server" BorderStyle="Solid" CssClass="button1"
                    OnClick="btn_cancel_Click" Text="انصراف"  />
            </div>
            
               <div style="visibility: hidden">
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <asp:Button ID="Button11" runat="server" Text="Button" />
                <asp:Button ID="Button111" runat="server" Text="Button" />
                <asp:Button ID="Button1111" runat="server" Text="Button" />
                <asp:Button ID="Button11111" runat="server" Text="Button" />
                <asp:Button ID="Button111111" runat="server" Text="Button" />
                <asp:Button ID="ButtonH1" runat="server" Text="Button" />
                <asp:Button ID="ButtonH2" runat="server" Text="Button" />
                <asp:Button ID="ButtonH3" runat="server" Text="Button" />
                <asp:Button ID="ButtonH4" runat="server" Text="Button" />
                <asp:Button ID="ButtonH5" runat="server" Text="Button" />
                <asp:Button ID="ButtonH6" runat="server" Text="Button" />
                <asp:Button ID="ButtonH7" runat="server" Text="Button" />


                   <asp:HiddenField ID="HiddenField1" runat="server" />

                
            </div>

                </div>

            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_SendToGroupUser" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH1" PopupControlID="msgDel">
            </cc1:ModalPopupExtender>




    <asp:Label ID="trace" runat="server" ></asp:Label>

    <br />
    <br />
  
    <br />
     <br />

    <br />
    
    
                        <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    
     
     
</div>

