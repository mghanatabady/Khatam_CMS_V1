<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_eshop_customer_item.ascx.vb" Inherits="C_shop_customer_item" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای دانش آموز تکراری است، لطفا کد دیگری را درج
            نمایید</span></div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<div id="DIV3" runat="server" style="width: 742px; font-size: 12pt; margin-left: 10px; margin-right: 10px; text-align: right;" dir="rtl" visible="false">
</div>
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt;">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" /></div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt; text-align: justify;">
    &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="740px">
        <Fields>
            <asp:BoundField DataField="customer_id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="customer_id" />
            <asp:BoundField DataField="first_name" HeaderText="نام" SortExpression="first_name" />
            <asp:BoundField DataField="last_name" HeaderText="نام خانوادگی" SortExpression="last_name" />
            <asp:BoundField DataField="customer_company" HeaderText="شرکت" SortExpression="customer_company" />
            <asp:BoundField DataField="degree" HeaderText="سمت" SortExpression="degree" />
            <asp:BoundField DataField="customer_state" HeaderText="استان" SortExpression="customer_state" />
            <asp:BoundField DataField="customer_city" HeaderText="شهر" SortExpression="customer_city" />
            <asp:BoundField DataField="custumer_addresses" HeaderText="آدرس" SortExpression="custumer_addresses" />
            <asp:BoundField DataField="customer_postcode" HeaderText="کدپستی" SortExpression="customer_postcode" />
            <asp:BoundField DataField="customer_phone" HeaderText="تلفن" SortExpression="customer_phone" />
            <asp:BoundField DataField="customer_mobile" HeaderText="موبایل" SortExpression="customer_mobile" />
            <asp:BoundField DataField="customer_fax" HeaderText="نمابر" SortExpression="customer_fax" />
            <asp:BoundField DataField="customer_email" HeaderText="ایمیل" SortExpression="customer_email" />
            <asp:BoundField DataField="customer_username" HeaderText="نام کاربری" ReadOnly="True"
                SortExpression="customer_username" />
            <asp:BoundField DataField="other_customer_details" HeaderText="سایر مشخصات" SortExpression="other_customer_details" />
        </Fields>
        <FieldHeaderStyle Width="200px" />
    </asp:DetailsView>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
        DataSourceID="SqlDataSource1" Visible="False">
        <Columns>
            <asp:BoundField DataField="customer_id" HeaderText="customer_id" InsertVisible="False"
                ReadOnly="True" SortExpression="customer_id" />
            <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
            <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
            <asp:BoundField DataField="customer_company" HeaderText="customer_company" SortExpression="customer_company" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT * FROM [Customers] WHERE ([customer_id] = @customer_id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="customer_id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
 <br />