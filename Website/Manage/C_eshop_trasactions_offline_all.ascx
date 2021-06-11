<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_trasactions_offline_all.ascx.cs" Inherits="Manage_C_shop_trasactions_offline_all" %>
<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>

<br />




<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div dir="rtl" id="dddd" runat="server" >
        
    <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
        height: 30px; text-align: left; overflow:none   ">
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif" onclick="ImageButton1_Click" />
        
        
         
        </div>
</div>

<div id="msgAdd" runat="server"   >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        درج تراکنش جدید
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">



                                بدهکار/بستانکار
                                  <br />
                                     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="txtBox" Font-Names="Tahoma" 
        >
                                         <asp:ListItem Value="1">بستانکار</asp:ListItem>
                                         <asp:ListItem Value="-1">بدهکار</asp:ListItem>
    </asp:DropDownList>
                                      <br />
                                      <br />

                                                شماره فاکتور
                                  <br />
                                          <asp:TextBox ID="add_txt_invoiceId" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ControlToValidate="add_txt_invoiceId" ErrorMessage="لطفا شماره فاکتور را درج نمایید." 
                                          ValidationGroup="add_trans">*</asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                     شرح
                                  <br />
                                          <asp:TextBox ID="add_txt_title" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="add_txt_title" ValidationGroup="add_trans" ErrorMessage="لطفا شرح تراکنش را درج نمایید">*</asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                                      مبلغ - ریال
                                  <br />
                                          <asp:TextBox ID="txt_edit_amount" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txt_edit_amount" ErrorMessage="لطفا مبلغ تراکنش را درج نمایید" ValidationGroup="add_trans">*</asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                         <br /> تاریخ:
                      <br />
                      <div dir="rtl">
                          <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="فیلد روز معتبر نیست" ControlToValidate="txt_day" ValidationGroup="add_trans" MinimumValue="1" MaximumValue="31" Type="Integer" Text="*"></asp:RangeValidator>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                        runat="server" Text="*" ErrorMessage="لطفا روز واریز وجه را وارد نمایید" ValidationGroup="add_trans"   ControlToValidate="txt_day">
                                        </asp:RequiredFieldValidator>روز   <asp:TextBox ID="txt_day" 
                              runat="server" Width="30px"></asp:TextBox>  &nbsp; /   
                              
                              <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage=" فیلد ماه معتبر نیست" ControlToValidate="txt_month" ValidationGroup="add_trans" MinimumValue="1" MaximumValue="12" Type="Integer" Text="*"></asp:RangeValidator>
                              
                              
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                                        runat="server" Text="*" ErrorMessage="لطفا ماه واریز وجه را درج نمایید" ValidationGroup="add_trans"   ControlToValidate="txt_month">
                                        </asp:RequiredFieldValidator>ماه <asp:TextBox ID="txt_month" 
                              runat="server" Width="30px"></asp:TextBox>  &nbsp; /   
                              
                               <asp:RangeValidator ID="RangeValidator3" runat="server" 
                              ErrorMessage="فیلد سال را به صورت معتبر مانند 1391 وارد نمایید" 
                              ControlToValidate="txt_year" ValidationGroup="add_trans" Type="Integer" MinimumValue="1390" 
                              MaximumValue="1500" Text="*"></asp:RangeValidator>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                                        runat="server" Text="*" ErrorMessage="لطفا فیلد سال را درج نمایید" ValidationGroup="add_trans"   ControlToValidate="txt_year">
                                        </asp:RequiredFieldValidator>سال <asp:TextBox ID="txt_year" 
                              runat="server" Width="30px"></asp:TextBox> 
                              </div>
                                      <br />
                                      <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="add_trans" runat="server" />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="Button2" CssClass="Cpbtn" ValidationGroup="add_trans" runat="server" Text="تایید" 
                      onclick="Button2_Click" />
								         
<asp:Button ID="Button3" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>

  <div id="msgEdit" runat="server" >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
       تغییر وضعیت تراکنش آفلاین
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">


                                        کد تراکنش
                                  <br />
                                      <asp:Label ID="LblEditCode" runat="server" Text="Label"></asp:Label>
                                      <br />
                                      <br />

                                                            
                                     وضعیت
                                  <br />
                                      <asp:DropDownList ID="ddl_edit_state" runat="server" Font-Names="Tahoma">
                                          <asp:ListItem Value="1">معتبر نیست</asp:ListItem>
                                          <asp:ListItem Value="2">تایید شده</asp:ListItem>
                                      </asp:DropDownList>
                                      <br />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="Button1" CssClass="Cpbtn" runat="server" Text="تایید" 
                      onclick="Button1_Click" />
								         
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
        <span style="font-size: 9pt"> آیا برای عملیات حذف تراکنش شماره 
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
        <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>


<div  dir="rtl"  style=" width: 100%;   ">
    &nbsp;<asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource2" PageSize="50" 
        Width="100%" onselectedindexchanged="GridView2_SelectedIndexChanged"  
        OnRowCommand="GridView2_RowCommand" OnDataBound="gv_sbt_bound" >
        <FooterStyle BackColor="#F1F3FA" />
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="idInvoice" HeaderText="شماره فاکتور" SortExpression="idInvoice" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="accontsDesc" HeaderText="شرح" SortExpression="accontsDesc" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="fishNo" HeaderText="شماره فیش" 
                SortExpression="fishNo">
            </asp:BoundField>
            <asp:BoundField DataField="FishDateTime" HeaderText="تاریخ" 
                SortExpression="FishDateTime"></asp:BoundField>
            <asp:BoundField DataField="amount" HeaderText="مبلغ" 
                SortExpression="amount"></asp:BoundField>
            <asp:BoundField DataField="regDate" HeaderText="تاریخ درج" 
                SortExpression="regDate" />
            <asp:BoundField DataField="state" HeaderText="وضعیت" SortExpression="state" />
            <asp:ButtonField CommandName="editcom" Text="تغییر وضعیت" />
            <asp:ButtonField CommandName="del" Text="حذف" />
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
        <RowStyle HorizontalAlign="Right" />
              <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" 
            HorizontalAlign="Right" />
    </asp:GridView>
</div>


<asp:SqlDataSource ID="SqlDataSource1" runat="server" >
  
    
    </asp:SqlDataSource>
<p>
    &nbsp;</p>

<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
 
    
    
    SelectCommand="SELECT core_transaction.* FROM core_transaction" >
           
</asp:SqlDataSource>

    </ContentTemplate>
</asp:UpdatePanel>



