<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_newsletter.ascx.vb" Inherits="C_newsletter" %>
<div style="margin-left: 10px; width: 759px; margin-right: 10px" id="DIV1" runat="server" visible="false">
    <div dir="rtl" style="border-right: #d7d6ba 1px solid; padding-right: 5px; border-top: #d7d6ba 1px solid;
        padding-left: 5px; font-size: 9pt; padding-bottom: 5px; border-left: #d7d6ba 1px solid;
        width: 742px; padding-top: 5px; border-bottom: #d7d6ba 1px solid; font-family: tahoma;
        background-color: #fefdea; text-align: justify">
        <br />
        <span style="color: red">پیام گروه فنی:</span> مجموعه کاربرانی که در بخش خبرنامه
        شما ثبت نام می گردند به شرح زیر هستند، و تا شماره 521 در سرویس ارسال ایمیل گروهی
        بروز رسانی گردیده اند. برای ارسال ایمیل به کاربران کافی است از ایمیل info@.com
        به newsletter1@.com ارسال نمایید تا سرور به صورت خودکار و لحظه ای به تمامی
        اعضای خبرنامه ایمیل شما را ارسال نماید.</div>
</div>
<br />
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify;">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="id" DataSourceID="SqlDataSource1"
        RepeatColumns="4" Width="720px">
        <ItemTemplate>
            &nbsp;<asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>'></asp:Label><br />
            <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>'></asp:Label><br />
            <br />
        </ItemTemplate>
    </asp:DataList><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        SelectCommand="SELECT [id], [email] FROM [Newsletter]"></asp:SqlDataSource>

</div>