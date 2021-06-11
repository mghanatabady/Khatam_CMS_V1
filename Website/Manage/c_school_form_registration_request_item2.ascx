<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_form_registration_request_item2.ascx.vb" Inherits="c_school_form_registration_request_item2" %>
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
    &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
        DataKeyNames="idreg" DataSourceID="SqlDataSource1" Height="50px" Width="740px">
        <Fields>
            <asp:BoundField DataField="idreg" HeaderText="شماره فرم" InsertVisible="False" ReadOnly="True"
                SortExpression="idreg" />
            <asp:BoundField DataField="Fname" HeaderText="نام" SortExpression="Fname" />
            <asp:BoundField DataField="Lname" HeaderText="نام خانوادگی" SortExpression="Lname" />
            <asp:BoundField DataField="Fathername" HeaderText="نام پدر" SortExpression="Fathername" />
            <asp:BoundField DataField="NationalCode" HeaderText="کد ملی" SortExpression="NationalCode" />
            <asp:BoundField DataField="Shsh" HeaderText="شماره شناسنامه" SortExpression="Shsh" />
            <asp:BoundField DataField="regplace" HeaderText="محل صدور" SortExpression="regplace" />
            <asp:BoundField DataField="day" HeaderText="روز تولد" SortExpression="day" />
            <asp:BoundField DataField="month" HeaderText="ماه تولد" SortExpression="month" />
            <asp:BoundField DataField="year" HeaderText="سال تولد" SortExpression="year" />
            <asp:BoundField DataField="tahsil_year" HeaderText="سال اخذ آخرین مدرک تحصیلی" SortExpression="tahsil_year" />
            <asp:BoundField DataField="tahsil_class" HeaderText="کلاس" SortExpression="tahsil_class" />
            <asp:BoundField DataField="tahsilCat" HeaderText="مقطع" SortExpression="tahsilCat" />
            <asp:BoundField DataField="rb_tahsil" HeaderText="رشته" SortExpression="rb_tahsil" />
            <asp:BoundField DataField="RB_Vazife" HeaderText="وضعیت وظیفه" SortExpression="RB_Vazife" />
            <asp:BoundField DataField="Stat" HeaderText="شهرستان" SortExpression="Stat" />
            <asp:BoundField DataField="part" HeaderText="بخش" SortExpression="part" />
            <asp:BoundField DataField="Village" HeaderText="روستا" SortExpression="Village" />
            <asp:BoundField DataField="address" HeaderText="آدرس" SortExpression="address" />
            <asp:BoundField DataField="postalcode" HeaderText="کد پستی" SortExpression="postalcode" />
            <asp:BoundField DataField="tel" HeaderText="تلفن" SortExpression="tel" />
            <asp:BoundField DataField="tel_Code" HeaderText="کد تلفن" SortExpression="tel_Code" />
            <asp:BoundField DataField="mob" HeaderText="موبایل" SortExpression="mob" />
            <asp:BoundField DataField="email" HeaderText="ایمیل" SortExpression="email" />
            <asp:BoundField DataField="datetime" HeaderText="زمان ثبت" SortExpression="datetime" />
        </Fields>
        <FieldHeaderStyle Width="200px" />
    </asp:DetailsView>
    &nbsp;<br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT school_form_registration_request2.* FROM school_form_registration_request2 WHERE (idreg = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
 <br />