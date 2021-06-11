<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pay.aspx.cs" Inherits="pay" %>
    <%@ Register Assembly="PersianDateControls 2.0" Namespace="PersianDateControls" TagPrefix="pdc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />


    <link href="css/StyleSheet.css" rel="stylesheet" type="text/css" />
<link href="Content/StyleSheet_calender.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
       
        }
        </style>

               <SCRIPT type="text/javascript" language=Javascript>
      <!--
                   function isNumberKey(evt) {
                       var charCode = (evt.which) ? evt.which : event.keyCode
                       if (charCode > 31 && (charCode < 48 || charCode > 57))
                           return false;

                       return true;
                   }
               
               
      //-->
   </SCRIPT>

</head>
<body>

    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div id = "container">

    <div id="header" >
     <div style=" text-align:center; font-size:small  "> بسمه تعالی </div>
     <div style=" text-align:center ; font-size:larger ; font-weight:bold  "> 
         <asp:Label ID="lbl_title" runat="server" Text="پیش فاکتور"></asp:Label> </div>

     <div style=" text-align:left;  font-weight:bold; float:left; direction: rtl;" 
            dir="rtl"> شماره:
         <asp:Label ID="LblId" runat="server"></asp:Label>
     <br />
     <asp:Label ID="lblDate" runat="server"></asp:Label>
      <br />
        
     </div>

        <img id="imgLogo" class="style1" 
            runat="server" /><br />
        <strong>
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
    </strong>
    <br />
    <br />
    
    <br />
        <div id="MSG_Expire" runat="server"  visible="false" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid; width: 100%;
    border-bottom: red 2px solid; text-align: right; margin-top:10px">
            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                <asp:Image ID="Image4" runat="server" 
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                &nbsp;</div>
            <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
                پیش فاکتور منقضی شده است!<br />
                <span style="font-size: 9pt">مهلت&nbsp; پرداخت این پیش فاکتور به اتمام رسیده 
                است. در صورت نیاز سفارش جدید ثبت نمایید.<br />
                </span>
            </div>
            <br />
        </div>
        <div id="MSG_Expire_FishOntherProcess" runat="server"   visible="false" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid; width: 100%;
    border-bottom: red 2px solid; text-align: right; margin-top:10px">
            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                <asp:Image ID="Image2" runat="server" 
                    ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                &nbsp;</div>
            <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
                مهلت پرداخت پیش فاکتور به اتمام رسیده است!<br />
                <span style="font-size: 9pt">اطلاعات تراکنش های آفلاین -واریزی شما بررسی می شوند و در صورت تایید سفارش 
                شما انجام می پذیرد.&nbsp; <br />
                </span>
            </div>
            <br />
        </div>
    <br />
    خریدار: 
         <asp:PlaceHolder ID="ph_customer" runat="server"></asp:PlaceHolder>
    <br />
    <br />

    </div>

    <div id="content"><strong>اطلاعات سفارش:<br />
        </strong><br />
      <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" 
                                                CssClass="col2" GridLines="Vertical"  
            Width="605px" BackColor="White"  
                                                              BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                              ForeColor="Black" 
            DataSourceID="SqlDataSource5" 
            onselectedindexchanged="gv1_SelectedIndexChanged">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="ردیف" />
                                                    <asp:BoundField DataField="catid" HeaderText="کد" />
                                                    <asp:BoundField DataField="title" HeaderText="شرح کالا / خدمات"  />
                                                    <asp:BoundField DataField="quantity" HeaderText=" تعداد" />
                                                    <asp:BoundField DataField="price" HeaderText="قیمت" />
                                                    <asp:BoundField DataField="sum" HeaderText="جمع" />
                                                  

                                                    
                                      

                                                </Columns>
                                                <EmptyDataTemplate>
                                                    هیچ کالایی در سبد خرید شما یافت نگردید.
                                                </EmptyDataTemplate>
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" BorderColor="#003300" BorderStyle="Solid" 
                                                    BorderWidth="1px" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
              
              SelectCommand="SELECT * FROM [core_invoice_line] WHERE ([invoice_id] = @invoice_id)">
              <SelectParameters>
                  <asp:QueryStringParameter Name="invoice_id" QueryStringField="id" 
                      Type="Int32" />
              </SelectParameters>
          </asp:SqlDataSource>
          <br />
          <br />
        </div>

     

         <div id="sendinfo" runat="server">
         <strong>اطلاعات ارسال :
             <br />
             </strong>
             وضعیت سفارش: <asp:Label ID="lbl_send_state" runat="server" 
                 Text="Label"></asp:Label><br />

             شیوه ارسال: <asp:Label ID="lbl_senmode_title" runat="server" Text="Label"></asp:Label><br />

             کشور : <asp:Label ID="lbl_country" runat="server" Text="Label"></asp:Label><br />

             استان : <asp:Label ID="lbl_state" runat="server" Text="Label"></asp:Label><br />

             شهر : <asp:Label ID="lbl_city" runat="server" Text="Label"></asp:Label><br />
              <div id="div_Address"  runat="server">
              آدرس محل تحویل : <asp:Label ID="lbl_Address" runat="server" Text="Label"></asp:Label><br />

              کد پستی محل تحویل : <asp:Label ID="lbl_zipCode" runat="server" Text="Label"></asp:Label><br />
              </div>
              تلفن ثابت تحویل گیرنده : <asp:Label ID="lbl_tel" runat="server" Text="Label"></asp:Label><br />

               موبایل تحویل گیرنده : <asp:Label ID="lbl_cellPhone" runat="server" Text="Label"></asp:Label><br />

               پیام : <asp:Label ID="lbl_msg" runat="server" Text="Label"></asp:Label><br />

                   <div id="div_SendPrice_source" runat="server">
                   مبلغ ارسال مبدا <asp:Label ID="lbl_Send_desc" runat="server" ></asp:Label>&nbsp;: <asp:Label ID="lbl_SendPrice_source" runat="server"></asp:Label> ریال<br />
                   </div>
                  <div id="div_SendPrice_target" runat="server">
                  مبلغ ارسال مقصد : 
             <asp:Label ID="lbl_SendPrice_target" runat="server"></asp:Label> <br />
             </div>
                  


             <br />
         
         </div>

      <div id="payinfo" runat="server"  >
                جمع مبلغ قابل پرداخت - ریال:
       
           <asp:Label ID="lbl_total_order_and_send_price" runat="server" Font-Bold="True"></asp:Label>
                &nbsp;<br />

                       جمع مبلغ سفارش:
       
           <asp:Label ID="lbl_total_order_price" runat="server" ></asp:Label>
          &nbsp;ریال<br />

    <br />
    <div ID="div_payStatus" runat="server">
      وضعیت پرداخت:<br />
&nbsp;<asp:Label ID="lbl_payStatus" runat="server" style="font-weight: 700"></asp:Label>
          
          <br />
          </div>



          <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
              AssociatedUpdatePanelID="UpdatePanel1">
              <ProgressTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />

              </ProgressTemplate>
          </asp:UpdateProgress>
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
              <ContentTemplate>
              <div id="selectPayMode" runat="server">
               
          زمان اعتبار پیش فاکتور:
          <br />
          <asp:Label ID="lbl_expire" runat="server" Font-Bold="True"></asp:Label>
                      <br />       <br />

                  شیوه پرداخت
                  <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                      DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="id" 
                      Font-Names="Tahoma" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                      <asp:ListItem>بانک سامان</asp:ListItem>
                  </asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    
                      SelectCommand="SELECT * FROM [core_payMode] where (enable=1)"></asp:SqlDataSource>
                  <br />
                  <br />
                  </div>
 <div id="MSG_fish_ok" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    border-left: teal 2px solid; width: 100%; 
    border-bottom: teal 2px solid; height: 45px; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>


                  <asp:Panel ID="panelFish" runat="server" Visible="false" >
                      <br />
                      شماره حساب ها:<br />
                      <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                          DataKeyNames="id" DataSourceID="SqlDataSource7" GridLines="None" 
                          ShowHeader="False">
                          <Columns>
                              <asp:TemplateField>
                                  <ItemTemplate>
                                      <asp:Label ID="Label3" runat="server" Font-Bold="True" 
                                          Text='<%# Eval("bankName") %>'></asp:Label>
                                      <br />
                                      شماره حساب:<asp:Label ID="Label6" runat="server" 
                                          Text='<%# Eval("accountNo") %>'></asp:Label>
                                      <br />
                                      شماره کارت:<asp:Label ID="Label5" runat="server" Text='<%# Eval("cardNo") %>'></asp:Label>
                                      <br />
                                      شماره شبا:
                                      <asp:Label ID="Label4" runat="server" Text='<%# Eval("shabaNo") %>'></asp:Label>
                                      <br />
                                      به نام :
                                      <asp:Label ID="Label7" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                      <br />
                                      <br />
                                  </ItemTemplate>
                              </asp:TemplateField>
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                        
                          SelectCommand="SELECT * FROM [core_Bank_accounts]"></asp:SqlDataSource>
                      <br />
                      <div style="border: 1px solid #808080">
                      شماره حساب&nbsp;
                      <asp:DropDownList ID="ddl_accounts" runat="server" AutoPostBack="True" 
                          datasourceid="SqlDataSource3" DataTextField="title" DataValueField="id" 
                          Font-Names="Tahoma" 
                          onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                          <asp:ListItem>بانک سامان</asp:ListItem>
                      </asp:DropDownList>
                      <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                          
                          SelectCommand="SELECT id,  shabaNo,  bankName + ' ' + cardNo + ' ' + accountNo as title, enable
 FROM [core_Bank_accounts]"></asp:SqlDataSource>

                
                  
                      <br />
                      شماره فیش / ارجاع<asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                          runat="server" ControlToValidate="txt_fish_no" 
                          ErrorMessage="لطفا شماره فیش ارجاع را درج نمایید" Text="*" 
                          ValidationGroup="fish"></asp:RequiredFieldValidator>
                      : 
                      <asp:TextBox ID="txt_fish_no" runat="server" Font-Names="Tahoma"></asp:TextBox>
                      <br />

                      <br /> تاریخ:
                      <br />
                      <div dir="rtl">
                          <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="فیلد روز معتبر نیست" ControlToValidate="txt_day" ValidationGroup="fish" MinimumValue="1" MaximumValue="31" Type="Integer" Text="*"></asp:RangeValidator>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                        runat="server" Text="*" ErrorMessage="لطفا روز واریز وجه را وارد نمایید" ValidationGroup="fish"   ControlToValidate="txt_day">
                                        </asp:RequiredFieldValidator>روز   <asp:TextBox ID="txt_day" 
                              runat="server" Width="30px"></asp:TextBox>  &nbsp; /   
                              
                              <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage=" فیلد ماه معتبر نیست" ControlToValidate="txt_month" ValidationGroup="fish" MinimumValue="1" MaximumValue="12" Type="Integer" Text="*"></asp:RangeValidator>
                              
                              
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                                        runat="server" Text="*" ErrorMessage="لطفا ماه واریز وجه را درج نمایید" ValidationGroup="fish"   ControlToValidate="txt_month">
                                        </asp:RequiredFieldValidator>ماه <asp:TextBox ID="txt_month" 
                              runat="server" Width="30px"></asp:TextBox>  &nbsp; /   
                              
                               <asp:RangeValidator ID="RangeValidator3" runat="server" 
                              ErrorMessage="فیلد سال را به صورت معتبر مانند 1391 وارد نمایید" 
                              ControlToValidate="txt_year" ValidationGroup="fish" Type="Integer" MinimumValue="1390" 
                              MaximumValue="1500" Text="*"></asp:RangeValidator>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                        runat="server" Text="*" ErrorMessage="لطفا فیلد سال را درج نمایید" ValidationGroup="fish"   ControlToValidate="txt_year">
                                        </asp:RequiredFieldValidator>سال <asp:TextBox ID="txt_year" 
                              runat="server" Width="30px"></asp:TextBox> 


                   </div>
            

                                     

                      <br />

                      مبلغ
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                          ControlToValidate="txt_fish_amount" 
                          ErrorMessage="لطفا مبلغ فیش را درج نمایید" Text="*" 
                          ValidationGroup="fish"></asp:RequiredFieldValidator>
                      (ریال):
                      <asp:TextBox ID="txt_fish_amount" runat="server"></asp:TextBox>
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                      
                          SelectCommand="SELECT * FROM [core_payMode]"></asp:SqlDataSource>
                      <br />
                      <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="fish" runat="server" />
                      <br />
                      <asp:Button ID="btn_reg_fish" runat="server" Text="ثبت  تراکنش" 
                          onclick="btn_reg_fish_Click" ValidationGroup="fish" Font-Names="Tahoma" />
                          </div>

                  </asp:Panel>

                  <asp:Panel ID="Panel_saman" runat="server">
                       <asp:Button ID="sendToSaman" runat="server" Font-Names="Tahoma" 
                      Text="پرداخت آنلاین" onclick="Button1_Click" />

                  </asp:Panel>


                      <br />

             
                      <br />

      


    
    <div id="div_transactions" runat="server">
     <br />
    <br />   
                  <strong>تراکنش های مالی (آفلاین):
                  <br />
                  </strong>
          <br />
          <asp:GridView ID="gv_fish" runat="server" AutoGenerateColumns="False" 
              DataKeyNames="id" DataSourceID="SqlDataSource4" BackColor="White" 
              BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
              ForeColor="Black" GridLines="Vertical" Width="605px" 
                     OnDataBound="gv_fish_bound"  >
              <AlternatingRowStyle BackColor="#CCCCCC" />
              <Columns>
                  <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                      ReadOnly="True" SortExpression="id" />
                  <asp:BoundField DataField="fishNo" HeaderText="شماره فیش" 
                      SortExpression="fishNo" />
                  <asp:BoundField DataField="accontsDesc" HeaderText="شماره حساب" 
                      SortExpression="accontsDesc" />
                  <asp:BoundField DataField="FishDateTime" HeaderText="تاریخ فیش" 
                      SortExpression="FishDateTime" />
                  <asp:BoundField DataField="amount" HeaderText="مبلغ" 
                      SortExpression="amount" />
                  <asp:BoundField DataField="state" HeaderText="وضعیت" 
                      SortExpression="state" />
              </Columns>
              <EmptyDataTemplate>
                  هیچ موردی یافت نشد.
              </EmptyDataTemplate>
              <FooterStyle BackColor="#CCCCCC" />
              <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#808080" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#383838" />
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
             
              SelectCommand="SELECT * FROM [core_transaction] WHERE ([idInvoice] = @idInvoice)" 
                   >
              <SelectParameters>
                  <asp:QueryStringParameter Name="idInvoice" QueryStringField="id" Type="Int32" />
              </SelectParameters>
          </asp:SqlDataSource>
             <strong>
          <br />
          تراکنش های مالی (آنلاین): 
                  <br />
          <br />
          </strong>
          <asp:GridView ID="gv_sbt" runat="server" AutoGenerateColumns="False" 
              DataKeyNames="resnum" DataSourceID="SqlDataSource6" BackColor="White" 
                      BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                      ForeColor="Black" GridLines="Vertical" Width="605px" OnDataBound="gv_sbt_bound">
              <AlternatingRowStyle BackColor="#CCCCCC" />
              <Columns>
                  <asp:BoundField DataField="resnum" HeaderText="کد تراکنش" InsertVisible="False" 
                      ReadOnly="True" SortExpression="resnum" />
                  <asp:BoundField DataField="RefNum" HeaderText="شماره ارجاع" 
                      SortExpression="RefNum" />
                  <asp:BoundField DataField="state" HeaderText="وضعیت" 
                      SortExpression="state" />
                  <asp:BoundField DataField="regDate" HeaderText="زمان ثبت" 
                      SortExpression="regDate" />
                  <asp:BoundField DataField="backDate" HeaderText="زمان بازگشت از بانک" 
                      SortExpression="backDate" />
              </Columns>
              <EmptyDataTemplate>
                  هیچ موردی یافت نشد.
              </EmptyDataTemplate>
              <FooterStyle BackColor="#CCCCCC" />
              <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#808080" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#383838" />
          </asp:GridView>
          <br />
          <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
             
              SelectCommand="SELECT * FROM [sbt] WHERE ([id_core_invoice] = @id_core_invoice)" 
            >
              <SelectParameters>
                  <asp:QueryStringParameter Name="id_core_invoice" QueryStringField="id" 
                      Type="Int32" />
              </SelectParameters>
          </asp:SqlDataSource>
          </div>
                  </ContentTemplate>



          </asp:UpdatePanel>
             <br />
    <br />
      </div>

      <div id="footer">
          <asp:PlaceHolder ID="ph_footer" runat="server"></asp:PlaceHolder>
</div>
    
    </div>
    </form>
</body>
</html>
