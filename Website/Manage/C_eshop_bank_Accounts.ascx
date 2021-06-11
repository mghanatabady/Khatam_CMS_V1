<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_bank_Accounts.ascx.cs" Inherits="Manage_C_shop_bank_Accounts" %>

   <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


       <script type="text/javascript">
           function fnDisable(object) {
               object.disabled = 1;
               var cancelBtn = document.getElementById("<%= add_dialog_save.ClientID %>");
               cancelBtn.disabled = 1;

               return true;
           }


     </script>

<script type="text/javascript" language="javascript">

    var lastPostBackId = '';

    var pageReqMan = Sys.WebForms.PageRequestManager.getInstance();

    pageReqMan.add_initializeRequest(checkSubmitButton);




    function checkSubmitButton(sender, args) {

        if (pageReqMan.get_isInAsyncPostBack() && args.get_postBackElement().id == lastPostBackId) {

            args.set_cancel(true);

        }

        else {

            lastPostBackId = args.get_postBackElement().id;

        }

    }
 
    </script>


   <div style= " width:995px; float:right ">
       <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
           <ContentTemplate>
               


               <div style=" width: 995px; margin-right: 10px; height: 100px; visibility:hidden ; display:none " id="DIV1" runat="server">
    <div title="window">
        <div>
            <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_bg.gif); width: 316px; background-repeat: repeat-x;
                height: 25px; text-align: left">
                
                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_left_bg.gif); width: 11px;
                    height: 25px">
                </div>
                <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_right_bg.gif); width: 2px;
                    height: 25px">
                </div>
                <div id="Div2" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                    padding-top: 1px">
                    جستجو
                </div>
            </div>
            <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                <div dir="rtl" style="margin: 6px 9px 3px 10px; width: 295px; text-align: left">
                    <div style="width: 295px">
                        <strong>عبارت:</strong>
                        <asp:TextBox ID="Txt_Search" runat="server" Font-Names="Tahoma" Font-Size="10pt"
                            Width="127px"></asp:TextBox>&nbsp;<asp:DropDownList ID="DDL_Search" runat="server"
                                Font-Names="Tahoma" Font-Size="10pt" Width="100px">
                                <asp:ListItem Value="0">کد</asp:ListItem>
                                <asp:ListItem Value="1">نام</asp:ListItem>
                                <asp:ListItem Selected="True" Value="2">نام خانوادگی</asp:ListItem>
                                <asp:ListItem Value="3">همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; width: 295px; text-align: left">
                    <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>


                  <div dir="rtl" style=" width:995px;">
    <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg.gif); display:block  ; width: 100%; background-repeat: repeat-x;
        height: 48px; text-align: left">
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg.gif); width: 5px;
            height: 48px">
        </div>

           <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg.gif); width: 5px;
            height: 48px">
        </div>         
        
        <div style=" float:right ;  padding-right:10px ; padding-top:10px ">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/Addnew.gif" 
                onclick="ImageButton1_Click1" />
       
        </div>
     
         
        </div>
</div>






<div  dir="rtl"  style=" width: 992px;  border: 1px solid #AEBBC0;   padding-right:1px   ">
    <asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderStyle="None"
        DataKeyNames="id" DataSourceID="SqlDataSource2" PageSize="50" 
        Width="990px" onselectedindexchanged="GridView2_SelectedIndexChanged"  
        OnRowCommand="GridView2_RowCommand" GridLines="None"   >
      
  
        <AlternatingRowStyle CssClass="DataRowAlt" />
      
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="cardNo" HeaderText="شماره کارت" />
            <asp:BoundField DataField="shabaNo" HeaderText="شماره شبا" />
            <asp:BoundField DataField="bankName" HeaderText="بانک" />
            <asp:BoundField DataField="accountNo" HeaderText="شماره حساب" />
            <asp:BoundField DataField="name" HeaderText="نام صاحب حساب" />
            <asp:ButtonField Text="حذف" CommandName="del" Visible="False"  />
            <asp:ButtonField CommandName="editcom" Text="ویرایش" Visible="False" />
       
                             
     

            <asp:ButtonField ButtonType="Image" 
                ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif" 
                Text="حذف"  CommandName="cmdDel" />
            
                                 

        </Columns>
        <EmptyDataTemplate>
            <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; 
                border-left: red 2px solid; width: 100%;  border-bottom: red 2px solid;
                height: 45px; text-align: right; border-style: none;">
                <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                <div style=" margin-top: 5px; float: right; width: 560px; color: red;
                   height: 26px">
                    توجه!<br />هیچ موردی برای نمایش یافت نشد.</div>
                <br />
            </div>
        </EmptyDataTemplate>
        <RowStyle HorizontalAlign="Right" BorderColor="White" BorderStyle="Solid" 
            BorderWidth="2px" CssClass="DataRow" ForeColor="#1C53A2" />
              <HeaderStyle 
            HorizontalAlign="Right" BackColor="#AEBBC0" BorderStyle="None" 
            ForeColor="Black" />
    </asp:GridView>
</div>


                  <div dir="rtl" style=" width: 100%; margin-top:-13px">
    <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg_footer.gif); display:block  ; width: 100%; background-repeat: repeat-x;
        height: 47px; text-align: left">
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg_footer.gif); width: 4px;
            height: 47px">
        </div>

           <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg_footer.gif); width: 4px;
            height: 47px">
        </div>         
        
        <div style=" float:right ;  padding-right:10px ; padding-top:10px ">
     
        </div>
     
         
        </div>
</div>



<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
 
    
    
    
          
            >
</asp:SqlDataSource>


<div id="msgAdd"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        ایجاد حساب بانکی جدید
  </div>


  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
  
  <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1"  >
<ProgressTemplate>
    <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
</ProgressTemplate>

</asp:UpdateProgress>


    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
  <div id="row" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">شماره کارت</div>
  <div style=" float: right ; width : 200px ; text-align:right ; ">
      <asp:TextBox ID="add_txt_cardNo" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
  </div>
  
  
    <div id="Div3" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">شماره شبا<asp:RequiredFieldValidator
              ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="add_txt_shabaNo" ValidationGroup="add"   
          ErrorMessage="لطفا شماره شبا را درج نمایید">*</asp:RequiredFieldValidator></div>
  <div style=" float: right ; width : 200px ; text-align:right ">
      <asp:TextBox ID="add_txt_shabaNo" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
  </div>

    <div id="Div4" style=" margin-top:10px ; width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">بانک<asp:RequiredFieldValidator
              ID="RequiredFieldValidator5" runat="server" 
          ControlToValidate="add_txt_bankName" ValidationGroup="add"   
          ErrorMessage="لطفا نام بانک را درج نمایید">*</asp:RequiredFieldValidator></div>
  <div style=" float: right ; width : 200px ; text-align:right ">
      <asp:TextBox ID="add_txt_bankName" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
  </div>

    <div id="Div5" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">شماره حساب</div>
  <div style=" float: right ; width : 200px ; text-align:right ; ">
      <asp:TextBox ID="add_txt_accountNo" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
  </div>
  

    <div id="Div6" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">نام صاحب حساب<asp:RequiredFieldValidator
              ID="RequiredFieldValidator6" runat="server" 
          ControlToValidate="add_txt_bankName" ValidationGroup="add"   
          ErrorMessage="لطفا نام صاحب حساب را درج نمایید">*</asp:RequiredFieldValidator></div>
  <div style=" float: right ; width : 200px ; text-align:right ; ">
      <asp:TextBox ID="add_txt_name" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
      

      </div>
  </div>
  


  <div id="Div15" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px"></div>
  <div style=" float: right; width : 300px ; text-align:right; direction:rtl">
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="add" />
      </div>
  </div>


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      <asp:Button ID="msgAdd_btn_cancel" runat="server" Font-Bold="true" Text="انصراف" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />
      <asp:Button ID="add_dialog_save" runat="server"  Text="تایید" Width ="88px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="add_dialog_save_Click" 
           OnClientClick = " if (Page_ClientValidate('add')){ this.value = 'ذخیره...'; this.style.background = 'silver';};"
           />
   
  </div>
  
  </div>
    
  

  </div>
 



  <div id="msgIdentityError"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف شماره حساب
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg3_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">تایید برای حذف<br />
                                <span style="font-size: 9pt">آیا برای حذف شماره حساب کد 
                                    <asp:Label ID="del_lbl_code" runat="server" Text="Label"></asp:Label> مطمئن هستید؟</span></span></div>
                        <br /> 
 
 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="Button2" runat="server" Font-Bold="true" Text="خیر" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />

                <asp:Button ID="Button7" runat="server"  Text="بله" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="add2_dialog_save_Click"
           OnClientClick = "  this.value = 'حذف...'; this.style.background = 'silver';"
           />
  </div>
  
  </div>
    
  

  </div>


  <div id="msgOk"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        ایجاد کاربر جدید
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">


                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image12" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">عملیات موفقیت آمیز<br />
                                <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                        <br />
                  

  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">

      <asp:Button ID="Button9" runat="server"  Text="تایید" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma"  />
   
  </div>
  
  </div>
    
  

  </div>


  <div id="msgError"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        ایجاد کاربر جدید
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
           
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; ">
                            <span style="color: black">عملیات ناموفق<br />
                                <span style="font-size: 9pt">خطای سیستمی، این خطا برای گروه پیشتیبانی ارسال گردید و در اسرع وقت به آن رسیدگی می شود.</span></span></div>
                        <br /> 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">

      <asp:Button ID="Button12" runat="server"  Text="تایید" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" />
   
  </div>
  
  </div>
    
  

  </div>


 <div style=" visibility:hidden " >
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="Button11" runat="server" Text="Button" />
        <asp:Button ID="Button111" runat="server" Text="Button" />
        <asp:Button ID="Button1111" runat="server" Text="Button" />

                   <asp:Button ID="Button1112" runat="server" onclick="Button1112_Click1" 
                   Text="Button" />
        </div>



                <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender" runat="server"  BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button1"  PopupControlID ="msgAdd"   >
       </cc1:ModalPopupExtender>


       <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender2" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button11"  PopupControlID ="msgIdentityError" >
       </cc1:ModalPopupExtender>

       
       <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender3" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button111"  PopupControlID ="msgOk">
       </cc1:ModalPopupExtender>

       
       <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender4" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button1111"  PopupControlID ="msgError">
       </cc1:ModalPopupExtender>


               <br />
               <br />
    


           </ContentTemplate>
       </asp:UpdatePanel>




    
     
               


    


    


    


     


    


    


    


 


    


    


    



    


    


    


 


    


    


    


     <div id="msgEdit" runat="server" >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        ویرایش شی
    1tr_tb">
        ویرایش شی
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
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
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtEditTitle" ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               								         
<asp:Button ID="Button6" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>

  <div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid; width: 100%;
    border-bottom: red 2px solid; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با عمل حذف تمام مشخصات مرتبط با کاربر نیز حذف خواهد گردید، آیا برای عملیات حذف 
        کاربر شماره 
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;مطمئن
        هستید؟ 
            <br />
            <asp:Button ID="Button4" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" onclick="Button4_Click" />&nbsp;<asp:Button 
            ID="Button5" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" 
            onclick="BtnCancel_Click" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    border-left: teal 2px solid; width: 100%; 
    border-bottom: teal 2px solid; height: 45px; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>





</div> 