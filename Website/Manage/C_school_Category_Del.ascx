<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Category_Del.ascx.vb" Inherits="C_school_Category_Del" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 81px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 65px">
        توجه!<br />
        <span style="font-size: 9pt">امکان حذف رشته مورد نظر به جهت تعریف پایه های ذیل وجود ندارد،
            لطفا پایه های ذیل را حذف نمایید.</span></div>
    <br />
</div>
<div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt"> آیا برای حذف رشته مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button2" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px" id="Div_Lessons" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="50" Width="742px">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="school_base_cat_title" HeaderText="پایه" SortExpression="school_base_cat_title" />
            <asp:BoundField DataField="school_branch_title" HeaderText="شاخه" SortExpression="school_branch_title" />
            <asp:BoundField DataField="title" HeaderText="رشته" SortExpression="title" />
        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        SelectCommand="SELECT school_Category.title, school_branch.title AS school_branch_title, school_base_cat.title AS school_base_cat_title, school_Base.id FROM school_Base INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id WHERE (school_Category.id = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>
<br />