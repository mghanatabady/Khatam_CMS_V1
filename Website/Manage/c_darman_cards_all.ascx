<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_darman_cards_all.ascx.cs" Inherits="Manage_c_darman_cards_all" %>
     <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


         <script language="javascript" type="text/javascript">
             function CallPrint(strid) {
                 var prtContent = document.getElementById(strid);
                 var WinPrint = window.open('', '', 'letf=0,top=0,width=1,header=0,height=1,toolbar=0,scrollbars=0,status=0');
                 
                 WinPrint.document.write(prtContent.innerHTML);
                 WinPrint.document.close();
                 WinPrint.focus();
                 WinPrint.print();
                 WinPrint.close();
                 //prtContent.innerHTML = strOldOne;
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
       <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
    <div style=" text-align:center ">
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </div>
    </ProgressTemplate>
</asp:UpdateProgress>

<br />

       <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
           <ContentTemplate>
               

                     <div style="width: 995px; margin-right: 10px; display: inline-block" id="DIV4" runat="server">
                <div title="window" style="float: right; margin-bottom: 10px">
                    <div>
                        <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_bg.gif);
                            width: 316px; background-repeat: repeat-x; height: 25px; text-align: left">
                            <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_left_bg.gif);
                                width: 11px; height: 25px">
                            </div>
                            <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_right_bg.gif);
                                width: 2px; height: 25px">
                            </div>
                            <div id="Div6" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                                padding-top: 1px">
                                فیلتر
                            </div>
                        </div>
                        <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                            width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                            <div dir="rtl" style="margin: 6px 9px 3px 10px; width: 295px; text-align: right">
                                <div style="width: 295px">
                                    <asp:ImageButton ID="ImageButton_fillter" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_setting.gif"
                                        OnClick="ImageButton_fillter_Click" />
                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_delete_wide.gif"
                                        OnClick="ImageButton_fillter_del_Click" />
                                    <strong>عبارت جستجو:</strong>
                                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


               


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
        Width="990px"  onselectedindexchanged="GridView2_SelectedIndexChanged"  
         GridLines="None"  OnDataBound ="GridView2_OnDataBound"  >
      
  
        <AlternatingRowStyle CssClass="DataRowAlt" />
      
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="fname" HeaderText="نام" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="نام خانوادگی" 
                SortExpression="lname" />
            <asp:BoundField DataField="iranNationalCode" HeaderText="کد ملی" 
                SortExpression="iranNationalCode" />
            <asp:BoundField DataField="tel" HeaderText="تلفن" SortExpression="tel" />
            <asp:BoundField DataField="mobile" HeaderText="موبایل" 
                SortExpression="mobile" />
            <asp:BoundField DataField="regDate" HeaderText="زمان ثبت" 
                SortExpression="regDate" />
            <asp:BoundField DataField="invoice_id" HeaderText="شماره فاکتور" 
                InsertVisible="False" ReadOnly="True" SortExpression="invoice_id" />
            <asp:BoundField DataField="reseller_id" HeaderText="کد نماینده" 
                InsertVisible="False" ReadOnly="True" SortExpression="reseller_id" />

            <asp:BoundField  DataField="title" HeaderText="شرح" SortExpression="title" />
            <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="price" />

                                        <asp:BoundField DataField="payStatus" HeaderText="وضعیت پرداخت" 
                SortExpression="payStatus"  />


            <asp:ButtonField Text="حذف" CommandName="del" Visible="False"  />
            <asp:ButtonField CommandName="editcom" Text="ویرایش" Visible="False" />
       
                             
                          

            <asp:TemplateField>
                <ItemTemplate>
              
                    <asp:ImageButton ID="btn_small_del" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('حذف کارت','حذف','direction:rtl,width:100');" 
                        onclick="btn_small_del_Click"  />
                    <asp:ImageButton ID="btn_small_edit" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_edit.gif"  Visible="false"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('ویرایش کارت','ویرایش','direction:rtl,width:100');" 
                        onclick="btn_small_edit_Click"  />
                    <asp:ImageButton ID="btn_small_use" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_card_use.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('ثبت درخواست مراجعه به پزشک','درج درخواست','direction:rtl,width:100');" 
                        onclick="btn_small_use_Click"  />

                    <asp:ImageButton ID="btn_small_use_del" runat="server"   
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_card_del.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('حذف درخواست مراجعه به پزشک','حذف درخواست','direction:rtl,width:100');" 
                        onclick="btn_small_use_del_Click"  />

                    <asp:ImageButton ID="btn_small_use_print" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_print_true.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"                           
                        onmouseover="return tooltip('چاپ کارت','چاپ','direction:rtl,width:100');" 
                        onclick="btn_small_print_Click"  />


                    <asp:ImageButton ID="ImageButton5" runat="server"   Visible="false" 
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_info.gif"  
                        Text="چاپ" onclick="btn_small_print_Click"  RowIndex='<%# Container.DisplayIndex %>'    />

                </ItemTemplate>
                <ItemStyle Width="220px" />
            </asp:TemplateField>
                             

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


  <div id="msgNotPaid"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        ثبت درخواست مراجعه به پزشک
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">


                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image8" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">توجه<br />
                                <span style="font-size: 9pt">فاکتور مرتبط با کارت مورد نظر شما پرداخت نگردیده است و به همین دلیل امکان درج درخواست مراجعه به پزشک وجود ندارد.</span></span></div>
                        <br />
                  

  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">

      <asp:Button ID="Button2" runat="server"  Text="تایید" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma"   />
   
  </div>
  
  </div>
    
  

  </div>

  <div id="msgNotPaidPrint"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        چاپ کارت
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">


                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image9" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">توجه<br />
                                <span style="font-size: 9pt">فاکتور مرتبط با کارت مورد نظر شما پرداخت نگردیده است و به همین دلیل امکان چاپ وجود ندارد.</span></span></div>
                        <br />
                  

  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">

      <asp:Button ID="Button15" runat="server"  Text="تایید" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma"   />
   
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


<div id="msgDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف کارت
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg3_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">تایید برای حذف<br />
                                <span style="font-size: 9pt">آیا برای حذف کارت با کد 
                                    <asp:Label ID="del_lbl_code" runat="server" Text="Label"></asp:Label> مطمئن هستید؟</span></span></div>
                        <br /> 
 
 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="Button21" runat="server" Font-Bold="true" Text="خیر" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />

                <asp:Button ID="Button22" runat="server"  Text="بله" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="del_dialog_yes_Click"
           OnClientClick = "  this.value = 'حذف...'; this.style.background = 'silver';"
           />
  </div>
  
  </div>
    
  

  </div>


 <div id="msgUse"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        ثبت درخواست مراجعه به پزشک
  </div>


  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
  
  <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1"  >
<ProgressTemplate>
    <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
</ProgressTemplate>

</asp:UpdateProgress>


    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
                 <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; width:370px ;margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; ">
                            <span style="color: black">توجه<br />
                                <span style="font-size: 9pt">پس از ثبت درخواست امکان ویرایش یا حذف برای شما امکان پذیر نیست.</span></span></div>
                        <br />




    <div id="Div3" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">سوابق درخواست
      </div>
  <div style=" float: right ; width : 300px ; text-align:right; direction:rtl  ">
      <asp:GridView ID="gv_darman_card_use1" runat="server" AutoGenerateColumns="False" 
          DataKeyNames="id" DataSourceID="SqlDataSource1"   
            OnDataBound ="gv_darman_card_use1_DataBound"  ShowHeader="False" 
          Font-Size="9pt">
          <Columns>
              <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                  ReadOnly="True" SortExpression="id" />
              <asp:BoundField DataField="datetime" HeaderText="زمان" 
                  SortExpression="datetime" />
              <asp:BoundField DataField="drname" HeaderText="نام دکتر" 
                  SortExpression="drname" />
              <asp:TemplateField>
                  <ItemTemplate>

                                      <asp:ImageButton ID="btn_small_use" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/memo_small.png"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover='<%# Eval("memoTip") %>'  
                        onclick="btn_small_use_Click"  />

                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server"      
          
          ></asp:SqlDataSource>
      </div>
  </div>


    <div id="Div18" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">کد کارت
      </div>
  <div style=" float: right ; width : 200px ; text-align:right ">
      <asp:Label ID="use_lbl_code" runat="server" Text="Label"></asp:Label></div>
  </div>



    <div id="Div19" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">نام پزشک<asp:RequiredFieldValidator
              ID="RequiredFieldValidator5" runat="server" 
          ControlToValidate="use_txt_drName" ValidationGroup="use"   
          ErrorMessage="لطفا نام پزشک را درج نمایید">*</asp:RequiredFieldValidator></div>
  <div style=" float: right ; width : 200px ; text-align:right ">
      <asp:TextBox ID="use_txt_drName" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
  </div>

    <div id="Div27" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">شرح</div>
  <div style=" float: right ; width : 200px ; text-align:right ; direction:rtl  ">
      <asp:TextBox ID="use_txt_memo" TextMode="MultiLine"  CssClass="txt_dialog_large_rlt" runat="server"></asp:TextBox></div>
  </div>

    <div id="Div3" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">تاریخ
                                  <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage=" فیلد تاریخ تولد را با فرمت صحیح تاریخ درج نمایید مانند:format: 1390/12/30  "
                                 ControlToValidate="use_lbl_date" Text="*" ValidationGroup="use"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>


                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="use_lbl_date" runat="server" ValidationGroup="use" Text="*" ErrorMessage="درج فیلد تاریخ تولد ضروری است"></asp:RequiredFieldValidator>
  </div>
  <div style=" float: right ; width : 200px ; text-align:right ; direction:ltr   ">
   <pcal:PersianDatePickup ID="use_lbl_date" CssClass="txt_dialog_medium_ltr"  MaxLength="149" runat="server" ></pcal:PersianDatePickup>
</div>
  </div>
  

  
  <div id="Div32" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px"></div>
  <div style=" float: right; width : 300px ; text-align:right; direction:rtl">
      <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
          ValidationGroup="use" />
      </div>
  </div>


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      <asp:Button ID="Button8" runat="server" Font-Bold="true" Text="انصراف" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />
      <asp:Button ID="Button10" runat="server"  Text="تایید" Width ="88px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="use" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="use_dialog_save_Click" 
           OnClientClick = " if (Page_ClientValidate('use')){ this.value = 'ذخیره...'; this.style.background = 'silver';};"
           />
   
  </div>
  
  </div>
    
  

  </div>


<div id="msgUseFull"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        کوپن های کارت اتمام یافته است
  </div>


  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
  
  <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1"  >
<ProgressTemplate>
    <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
</ProgressTemplate>

</asp:UpdateProgress>


    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
                 <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image7" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; width:370px ;margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; ">
                            <span style="color: black">توجه<br />
                                <span style="font-size: 9pt">تعداد 5 کوپن قبلا درخواست داده شده اند و امکان 
                            درج درخواست جدید وجود ندارد.</span></span></div>
                        <br />




    <div id="Div5" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">سوابق درخواست
      <br />
      کارت
      <asp:Label ID="useFull_lbl_code" runat="server" Text="Label"></asp:Label>
      </div>
  <div style=" float: right ; width : 300px ; text-align:right; direction:rtl  ">
      <asp:GridView ID="gv_darman_card_useFull" runat="server" AutoGenerateColumns="False" 
          DataKeyNames="id" DataSourceID="SqlDataSource1"   
           ShowHeader="False"  OnDataBound="gv_darman_card_useFull_DataBound" 
          Font-Size="9pt">
          <Columns>
              <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                  ReadOnly="True" SortExpression="id" />
              <asp:BoundField DataField="datetime" HeaderText="زمان" 
                  SortExpression="datetime" />
              <asp:BoundField DataField="drname" HeaderText="نام دکتر" 
                  SortExpression="drname" />
              <asp:TemplateField>
                  <ItemTemplate>

                                      <asp:ImageButton ID="btn_small_use" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/memo_small.png"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover='<%# Eval("memoTip") %>'  
                        onclick="btn_small_use_Click"  />

                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource3" runat="server" 

          
          SelectCommand="SELECT id, darman_cards_id, reg_user_id, datetime, N'return tooltip(''' + memo + N''',''شرح'' ,''direction:rtl,width:200'');' AS memoTip, drname FROM darman_card_use"></asp:SqlDataSource>
      </div>
  </div>




  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      
      <asp:Button ID="Button14" runat="server"  Text="بستن" Width ="88px" 
          Height="31px" BackColor="#9DC023" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" 
          
           />
   
  </div>
  
  </div>
    
  

  </div>

  <div id="msgUseDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف درخواست های کارت</div>


  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
  
  <asp:UpdateProgress ID="UpdateProgress5" runat="server" AssociatedUpdatePanelID="UpdatePanel1"  >
<ProgressTemplate>
    <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
</ProgressTemplate>

</asp:UpdateProgress>


    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
     




    <div id="Div16" style=" margin-top:10px;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px">سوابق درخواست
      <br />
      کارت
      <asp:Label ID="msgUseDel_lbl" runat="server" Text="Label"></asp:Label>
      </div>
  <div style=" float: right ; width : 300px ; text-align:right; direction:rtl  ">
      <asp:GridView ID="gv_darman_card_useDel" runat="server" AutoGenerateColumns="False" 
          DataKeyNames="id" DataSourceID="SqlDataSource1"   
           ShowHeader="False"  OnDataBound="gv_darman_card_useFull_DataBound" 
          Font-Size="9pt">
          <Columns>
              <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                  ReadOnly="True" SortExpression="id" />
              <asp:BoundField DataField="datetime" HeaderText="زمان" 
                  SortExpression="datetime" />
              <asp:BoundField DataField="drname" HeaderText="نام دکتر" 
                  SortExpression="drname" />
              <asp:TemplateField>
                  <ItemTemplate>

                                      <asp:ImageButton ID="btn_small_use" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/memo_small.png"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover='<%# Eval("memoTip") %>'  
                        onclick="btn_small_use_Click"  />

                  </ItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField>
                  <ItemTemplate>
                      <asp:ImageButton ID="msgUseDel_btn_small_del" runat="server"  
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('حذف کارت','حذف','direction:rtl,width:100');" 
                        onclick="msgUseDel_btn_small_del_Click"  />
                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
          <EmptyDataTemplate>
              هیچ درخواستی یافت نگردید.
          </EmptyDataTemplate>
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource4" runat="server" 

          
          SelectCommand="SELECT id, darman_cards_id, reg_user_id, datetime, N'return tooltip(''' + memo + N''',''شرح'' ,''direction:rtl,width:200'');' AS memoTip, drname FROM darman_card_use"></asp:SqlDataSource>
      </div>
  </div>




  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      
      <asp:Button ID="Button13" runat="server"  Text="بستن" Width ="88px" 
          Height="31px" BackColor="#9DC023" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" 
          
           />
   
  </div>
  
  </div>
    
  

  </div>

  
  
  <div id="gridFilter" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    فیلتر
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div7" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_id" CssClass="txt_dialog_medium_rtl"
                                 
                                 runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div8" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_fname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div20" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_lname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div21" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد ملی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_iranNationalCode" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div22" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_tel" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                              <div id="Div24" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_mobile" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>

                                                      <div id="Div10" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                زمان ثبت</div>
                            <div style="float: right; width: 250px; text-align: right; direction: rtl">
                                از تاریخ 
                                
        <pcal:PersianDatePickup ID="filter_txt_regDate_from"  CssClass="txt_dialog_medium_ltr" runat="server" ></pcal:PersianDatePickup>
                                
                                
                                        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage=" فیلد تاریخ را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_regDate_from" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>
<br />
                                تا تاریخ 
        <pcal:PersianDatePickup ID="filter_txt_regDate_to" CssClass="txt_dialog_medium_ltr"  runat="server" ></pcal:PersianDatePickup>                               
                                
                                
                                        <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage=" فیلد تاریخ  را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_regDate_to" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>

                        </div>
                  

                            </div>

                        <div id="Div11" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شماره فاکتور
                             </div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_invoice_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                         </div>

                        <div id="Div12" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد نماینده
                             </div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_reseller_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                         </div>


                        <div id="Div13" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرح
                             </div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_title" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                         </div>

                        <div id="Div14" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                قیمت
                             </div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                    از مبلغ <asp:TextBox ID="filter_txt_price_from" CssClass="txt_dialog_medium_ltr txt_number" runat="server"></asp:TextBox>
<br />
                                تا مبلغ <asp:TextBox ID="filter_txt_price_to" CssClass="txt_dialog_medium_ltr txt_number" runat="server"></asp:TextBox>
                            </div>
                         </div>


                           <div id="Div15" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px"></div>
  <div style=" float: right; width : 300px ; text-align:right; direction:rtl">
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="filter" />
      </div>
  </div>

                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button7" runat="server"  CssClass="btn_public" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" onclick="Button7_Click" />
                        <asp:Button ID="Button_filter_ok" CssClass="btn_public" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="if (Page_ClientValidate('filter')){  this.value = 'بروز رسانی...';this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>









              <!--style=" visibility:hidden ; display:none "-->
<div  style=" visibility:hidden ; display:none " >
    <div id="bill" class="printCard">
<div style=" width: 97mm; height: 135mm ;">
<div style="width: 97mm; height: 57mm">
<div style=" float:left; width:70mm; direction: rtl;  height:30mm; margin-top:20mm;  text-align:right; margin-right:2mm; font-family: tahoma; font-size: 9pt; font-weight: bold;" dir="rtl" 
    >
    <asp:Label ID="card_lbl_name" runat="server" Text="Label"></asp:Label>        
    <br />
    <asp:Label ID="card_lbl_nationlCode" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="card_lbl_cardNo" runat="server" Text="Label"></asp:Label>
    <br />
    <div  >
    <asp:Label ID="card_lbl_expDate" runat="server" Text="Label"></asp:Label>
    </div>
    <br />
 </div>
<div  style="  float:left; width:20mm; height:26mm; margin-top:7mm; vertical-align: middle; text-align: center;"  >


    <img id="card_img" runat="server"  
         style="width:20mm; height:26mm;" />
</div>
</div>
    <asp:PlaceHolder ID="card_ph_rows" runat="server"></asp:PlaceHolder>

</div>


  



</div>

</div>











 <div style=" visibility:hidden ">
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="ButtonH1" runat="server" Text="Button" />
        <asp:Button ID="ButtonH2" runat="server" Text="Button" />
        <asp:Button ID="ButtonH3" runat="server" Text="Button" />
        <asp:Button ID="ButtonH4" runat="server" Text="Button" />
        <asp:Button ID="ButtonH5" runat="server" Text="Button" />
        <asp:Button ID="ButtonH8" runat="server" Text="Button" />
        <asp:Button ID="ButtonH9" runat="server" Text="Button" />
        <asp:Button ID="ButtonH10" runat="server" Text="Button" />







        <asp:Button ID="Button11" runat="server" Text="Button" />
        <asp:Button ID="Button111" runat="server" Text="Button" />
        <asp:Button ID="Button1111" runat="server" Text="Button" />
                       <asp:Button ID="Button1112" runat="server" onclick="Button1112_Click1" 
                   Text="Button" />
                   </div>


       
       <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender3" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button111"  PopupControlID ="msgOk">
       </cc1:ModalPopupExtender>

              <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgDel" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH5"  PopupControlID ="msgDel">
       </cc1:ModalPopupExtender>

              <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgUse" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH1"  PopupControlID ="msgUse">
       </cc1:ModalPopupExtender>

                     <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgUseFull" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH3"  PopupControlID ="msgUseFull">
       </cc1:ModalPopupExtender>
  

       <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender4" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="Button1111"  PopupControlID ="msgError">
       </cc1:ModalPopupExtender>


                     <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_gridFilter" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH4" PopupControlID="gridFilter">
            </cc1:ModalPopupExtender>


                   <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgNotPaid" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH8"  PopupControlID ="msgNotPaid">
       </cc1:ModalPopupExtender>

           <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgUseDel" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH9"  PopupControlID ="msgUseDel">
       </cc1:ModalPopupExtender>

                  <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgNotPaidPrint" runat="server" BackgroundCssClass="ModalPopupBG"
           DynamicServicePath="" Enabled="True" TargetControlID="ButtonH10"  PopupControlID ="msgNotPaidPrint">
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
    "CPWin1tr_tb">
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