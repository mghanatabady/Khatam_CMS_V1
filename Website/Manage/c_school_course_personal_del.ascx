<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_course_personal_del.ascx.vb" Inherits="c_school_course_personal_del" %>
<div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt"> با حذف این درس نمرات مرتبط و انتخاب واحد های مرتبط حذف می گردند، آیا برای عملیات حذف مطمئن هستید؟<br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button2" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<br />
<br />