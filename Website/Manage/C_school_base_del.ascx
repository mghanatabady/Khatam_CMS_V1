<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_base_del.ascx.vb" Inherits="C_school_base_del" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 81px; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 65px">
        توجه!<br />
        <span style="font-size: 9pt">امکان حذف پایه مورد نظر به جهت تعریف کلاس های &nbsp;ذیل وجود ندارد،
            لطفا ابتدا کلاس های ذیل را حذف نمایید.</span></div>
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
        <span style="font-size: 9pt"> آیا برای حذف پایه مطمئن هستید؟<br />
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
            <asp:BoundField DataField="school_Class_title" HeaderText="عنوان کلاس" SortExpression="school_Class_title" />
            <asp:BoundField DataField="school_branch_title" HeaderText="شاخه" SortExpression="school_branch_title" />
            <asp:BoundField DataField="school_Category_title" HeaderText="رشته" SortExpression="school_Category_title" />
            <asp:BoundField DataField="school_Base_cat_title" HeaderText="پایه" SortExpression="school_Base_cat_title" />
        </Columns>
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        SelectCommand="SELECT school_branch.title AS school_branch_title, school_Category.title AS school_Category_title, school_base_cat.title AS school_Base_cat_title, school_Class.title AS school_Class_title, school_Class.id FROM school_Class INNER JOIN school_Base ON school_Class.id_school_base = school_Base.id INNER JOIN school_base_cat ON school_Base.year_number = school_base_cat.id INNER JOIN school_Category ON school_Base.id_school_category = school_Category.id INNER JOIN school_branch ON school_Category.id_school_branch = school_branch.id WHERE (school_Base.id = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    &nbsp;&nbsp;</div>
<br />
<br />
<br /><div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px" id="Div1" runat="server">
    &nbsp;&nbsp;</div>
