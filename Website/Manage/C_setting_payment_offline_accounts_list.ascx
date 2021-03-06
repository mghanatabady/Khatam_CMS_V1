<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_setting_payment_offline_accounts_list.ascx.vb" Inherits="manage_C_setting_payment_offline_accounts_list" %>
<br />
<div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">اخطار با حذف درس، درس مذکور از انتخاب واحد دروس تمامی دانش
            آموزان گروه حذف خواهد شد. &nbsp;آیا برای حذف معلم مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" /><span style="color: #000000">&nbsp;</span><asp:Button
                    ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
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
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_new.gif" /></div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" Width="742px" 
        PageSize="50" EnableModelValidation="True">
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:ButtonField CommandName="school_class_del" Text="حذف" />
        </Columns>
        <EmptyDataTemplate>
            <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; margin-left: 70px;
                border-left: red 2px solid; width: 652px; margin-right: 10px; border-bottom: red 2px solid;
                height: 45px; text-align: right">
                <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                <div style="padding-right: 5px; margin-top: 5px; float: right; width: 560px; color: red;
                    padding-top: 5px; height: 26px">
                    توجه!<br />
                    هیچ موردی برای نمایش یافت نشد.</div>
                <br />
            </div>
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Khatam_site %>" 
        SelectCommand="SELECT setting_payment_offline_accounts.* FROM setting_payment_offline_accounts">
    </asp:SqlDataSource>
</div>
