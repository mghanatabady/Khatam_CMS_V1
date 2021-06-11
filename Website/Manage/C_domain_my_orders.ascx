<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_domain_my_orders.ascx.cs" Inherits="Manage_C_domain_my_orders" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

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
            <div style="width: 995px; margin-right: 10px; display: inline-block" id="DIV1" runat="server">
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
                            <div id="Div2" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
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
                                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div dir="rtl" style="width: 995px;">
                <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg.gif);
                    display: block; width: 100%; background-repeat: repeat-x; height: 48px; text-align: left">
                    <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg.gif);
                        width: 5px; height: 48px">
                    </div>
                    <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg.gif);
                        width: 5px; height: 48px">
                    </div>
                    <div style="float: right; padding-right: 10px; padding-top: 10px">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/Addnew.gif"
                            Visible="false"  />
                    </div>
                    <div style="float: left; padding-right: 10px; padding-top: 10px">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_setting.gif"
                             Visible="false" />
                    </div>
                </div>
            </div>
            <div dir="rtl" style="width: 992px; border: 1px solid #AEBBC0; padding-right: 1px">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    DataKeyNames="id" DataSourceID="SqlDataSource2" SortedAscendingHeaderStyle-CssClass="sortasc-header"
                    SortedDescendingHeaderStyle-CssClass="sortdesc-header" Width="990px" 
           
                     PageSize="20"
                   
                              OnDataBound ="GridView2_OnDataBound"


                    GridLines="None" AllowPaging="True">
                    <AlternatingRowStyle CssClass="DataRowAlt" />
                    <Columns>
     <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="domain" HeaderText="نام دامنه" />
            <asp:BoundField DataField="title" HeaderText="شرح" />
          
   
            <asp:BoundField DataField="start" HeaderText="زمان شروع" 
                SortExpression="start" />

                <asp:BoundField DataField="exp" HeaderText="انقضا" 
                SortExpression="exp" />


                            <asp:BoundField DataField="payStatus" HeaderText="وضعیت پرداخت" 
                SortExpression="payStatus"  />

                            <asp:BoundField DataField="virtualServiceStatus" HeaderText="وضعیت سرویس" 
                SortExpression="virtualServiceStatus"  />

                                         <asp:BoundField DataField="invoice_id" HeaderText="شماره فاکتور" 
                SortExpression="invoice_id"  />

        
                                        <asp:TemplateField >
                                            <ItemTemplate  >

                                                <asp:ImageButton ID="btn_small_Renew" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_renew.gif" 
                                                    onclick="btn_small_renew_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('ثبت درخواست تمدید سرویس','تمدید','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="تمدید" />

                                            </ItemTemplate>
                                            <ItemStyle Width="40px" />
                        </asp:TemplateField>
                    </Columns>
                    <SortedAscendingHeaderStyle CssClass="sortasc-header" />
                    <SortedDescendingHeaderStyle CssClass="sortdesc-header" />
                    <RowStyle HorizontalAlign="Right" BorderColor="White" BorderStyle="Solid" BorderWidth="2px"
                        CssClass="DataRow" ForeColor="#1C53A2" />
                    <EmptyDataTemplate>
                        <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                            width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                                &nbsp;</div>
                            <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                توجه!<br />
                                هیچ موردی برای نمایش یافت نشد.</div>
                            <br />
                        </div>
                    </EmptyDataTemplate>
                    <HeaderStyle HorizontalAlign="Right" CssClass="cell-header" BackColor="#AEBBC0" BorderStyle="None"
                        ForeColor="Black" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server"
                    SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
            </div>
            <div dir="rtl" style="width: 100%; margin-top: -13px">
                <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg_footer.gif);
                    display: block; width: 100%; background-repeat: repeat-x; height: 47px; text-align: left">
                    <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg_footer.gif);
                        width: 4px; height: 47px">
                    </div>
                    <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg_footer.gif);
                        width: 4px; height: 47px">
                    </div>
                    <div style="float: right; padding-right: 10px; padding-top: 10px">
                    </div>
                </div>
            </div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        

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
                        <div id="Div18" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div17" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام دامنه</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_domain" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div19" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرح</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_title" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div29" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد کاربر</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_users_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div24" style="margin-top: 10px; width: 100%; display: inline-block">
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
                                زمان شروع</div>
                            <div style="float: right; width: 250px; text-align: right; direction: rtl">
                                از تاریخ 
                                
        <pcal:PersianDatePickup ID="filter_txt_start_from"  CssClass="txt_dialog_medium_ltr" runat="server" ></pcal:PersianDatePickup>
                                
                                
                                        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage=" فیلد تاریخ را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_start_from" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>
<br />
                                تا تاریخ 
        <pcal:PersianDatePickup ID="filter_txt_start_to" CssClass="txt_dialog_medium_ltr"  runat="server" ></pcal:PersianDatePickup>                               
                                
                                
                                        <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage=" فیلد تاریخ  را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_start_to" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>

                        </div>
                  

                            </div>


                                              <div id="Div27" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                انقضا</div>
                            <div style="float: right; width: 250px; text-align: right; direction: rtl">
                                از تاریخ 
                                
        <pcal:PersianDatePickup ID="filter_txt_exp_from"  CssClass="txt_dialog_medium_ltr" runat="server" ></pcal:PersianDatePickup>
                                
                                
                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage=" فیلد تاریخ را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_exp_from" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>
<br />
                                تا تاریخ 
        <pcal:PersianDatePickup ID="filter_txt_exp_to" CssClass="txt_dialog_medium_ltr"  runat="server" ></pcal:PersianDatePickup>                               
                                
                                
                                        <asp:RangeValidator ID="RangeValidator4" runat="server" ErrorMessage=" فیلد تاریخ  را با فرمت صحیح تاریخ درج نمایید مانند: 1390/12/30  2012/12/30"
                                 ControlToValidate="filter_txt_exp_to" Text="*" ValidationGroup="filter"    MaximumValue = "2012/11/11"   MinimumValue = "1012/11/11"
                                   Type ="Date"
                                 
                                ></asp:RangeValidator>

                        </div>
                  

                            </div>

              
                                      <div id="Div22" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شماره فاکتور</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_invoice_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>





    
                 

                                                   <div id="Div23" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px"></div>
  <div style=" float: right; width : 300px ; text-align:right; direction:rtl">
      <asp:ValidationSummary ID="ValidationSummary4" runat="server" 
          ValidationGroup="filter" />
      </div>
  </div>

                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button10" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button_filter_ok" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="if (Page_ClientValidate('filter')){   this.value = 'بروز رسانی...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
  


            <div id="msgRenew" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تمدید سرویس
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress10" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">

                        <div id="Div26" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مدت زمان تمدید</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="ddl_payCycle" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                 
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button3" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button4" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_renew_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>
             
            <div id="msgRenewIsDuplicate" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                   تمدید سرویس
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress11" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="direction:rtl ; text-align:right  ">
                            درخواست تمدید برای این سرویس قبلا صادر گردیده است. لطفا فاکتور شماره
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                     را پرداخت نمایید.
                     </div>
                 
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                      
                        <asp:Button ID="Button24" runat="server" Text="بستن" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma"  OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>
             
                
                <div id="msgStatus" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تغییر وضعیت
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">

                        <div id="Div4" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                وضعیت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="ddl_status" runat="server" Font-Names="tahoma">
                                <asp:ListItem Text="راه اندازی نشده" Value="1"></asp:ListItem>
                                <asp:ListItem Text="در انتظار ارسال مدارک" Value="2"></asp:ListItem>
                                <asp:ListItem Text="در حال راه اندازی" Value="3"></asp:ListItem>
                                <asp:ListItem Text="فعال" Value="4"></asp:ListItem>
                                <asp:ListItem Text="غیر فعال" Value="5"></asp:ListItem>                                                     

                                </asp:DropDownList>
                            </div>
                        </div>
                 
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button2" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button5" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_status_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>
                 <div style="visibility: hidden">
                        <asp:HiddenField ID="hiddenField" runat="server" />

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
                <asp:Button ID="ButtonH8" runat="server" Text="Button" />
                <asp:Button ID="ButtonH9" runat="server" Text="Button" />

            </div>


      
            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_gridFilter" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button111111" PopupControlID="gridFilter">
            </cc1:ModalPopupExtender>
    

            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgRenew" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH6" PopupControlID="msgRenew">
            </cc1:ModalPopupExtender>

            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgRenewIsDuplicate" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH8" PopupControlID="msgRenewIsDuplicate">
            </cc1:ModalPopupExtender>
           
           
            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgStatus" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH9" PopupControlID="msgStatus">
            </cc1:ModalPopupExtender>
           

            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
<br />
<br />
