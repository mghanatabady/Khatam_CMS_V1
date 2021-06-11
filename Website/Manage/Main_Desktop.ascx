<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Main_Desktop.ascx.cs" Inherits="Manage_Main_Desktop" %>

    <asp:PlaceHolder ID="Announcement_ph" runat="server"></asp:PlaceHolder>


<div id="Div_cat1" runat="server" style="  float: right; margin-bottom: 10px;" visible="true">
    <div style="float: right; width: 120px; font-family: tahoma; text-align: center">
        
        <img src="../core/themeCP/Bitrix/CssImage/icon/page_content.gif" />
        <br />
        <span style="font-size: 8pt">مدیریت محتوا</span>&nbsp;</div>
    <div style="float: right;  width: 850px;
        background-repeat: repeat-y; direction: rtl; text-align: right;"><asp:DataList ID="DataList1" runat="server" DataKeyField="id"
            RepeatColumns="9" CssClass="main_desktop_item" 
            RepeatDirection="Horizontal">
            <ItemStyle Width="89px" HorizontalAlign="Center" VerticalAlign="Top" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%# Eval("image","~/core/themeCP/Bitrix/CssImage/icon/{0}") %>'
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>' CssClass="txtIcon"></asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="False" ForeColor="Black"
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>' CssClass="txtIcon"></asp:HyperLink><br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>

<div id="Div_cat2" runat="server" style=" float: right; margin-bottom: 10px;" visible="true">
    <div style="float: right; width: 120px; font-family: tahoma; text-align: center">
        <img src="../core/themeCP/Bitrix/CssImage/icon/page_services.gif" /><br />
        <span style="font-size: 8pt">خدمات</span></div>
    <div style="float: right; ; width: 850px;
        background-repeat: repeat-y; direction: rtl; text-align: right;">
        
        
        
       <asp:DataList ID="DataList2" runat="server" DataKeyField="id"
            RepeatColumns="9" CssClass="main_desktop_item" 
            RepeatDirection="Horizontal">
            <ItemStyle Width="89px" HorizontalAlign="Center" VerticalAlign="Top" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%# Eval("image","~/core/themeCP/Bitrix/CssImage/icon/{0}") %>'
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>' CssClass="txtIcon"></asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="False" ForeColor="Black"
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>' CssClass="txtIcon"></asp:HyperLink><br />
                <br />
            </ItemTemplate>
        </asp:DataList>








    </div>
</div>

<div id="Div_cat3" runat="server" style=" float: right; margin-bottom: 10px;" visible="true">
    <div style="float: right; width: 120px; font-family: tahoma; text-align: center">
        <img src="../core/themeCP/Bitrix/CssImage/icon/page_store.gif" /><br />
        <span style="font-size: 8pt">فروشگاه الکترونیک</span>&nbsp;</div>
    <div style="float: right;  width: 850px;
        background-repeat: repeat-y; direction: rtl; text-align: right;">
<asp:DataList ID="DataList3" runat="server" DataKeyField="id"
            RepeatColumns="9" CssClass="main_desktop_item" 
            RepeatDirection="Horizontal">
            <ItemStyle Width="89px" HorizontalAlign="Center" VerticalAlign="Top" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%# Eval("image","~/core/themeCP/Bitrix/CssImage/icon/{0}") %>'
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>'></asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="False" ForeColor="Black"
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>'></asp:HyperLink><br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>

<div id="Div_cat4" runat="server" style="  float: right; margin-bottom: 10px;" visible="true">
    <div style="float: right; width: 120px; font-family: tahoma; text-align: center">
        <img src="../core/themeCP/Bitrix/CssImage/icon/page_statistics.gif" /><br />
        <span style="font-size: 8pt">تحلیل آماری</span>&nbsp;</div>
    <div style="float: right;  width: 850px;
        background-repeat: repeat-y; direction: rtl; text-align: right;">
        
        
<asp:DataList ID="DataList4" runat="server" DataKeyField="id"
            RepeatColumns="9" CssClass="main_desktop_item" 
            RepeatDirection="Horizontal">
            <ItemStyle Width="89px" HorizontalAlign="Center" VerticalAlign="Top" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%# Eval("image","~/core/themeCP/Bitrix/CssImage/icon/{0}") %>'
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>'></asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="False" ForeColor="Black"
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>'></asp:HyperLink><br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>

<div id="Div_cat5" runat="server" style=" float: right; margin-bottom: 10px;" visible="true">
    <div style="float: right; width: 120px; font-family: tahoma; text-align: center">
        <img src="../core/themeCP/Bitrix/CssImage/icon/page_settings.gif" /><br />
        <span style="font-size: 8pt">تنظیمات</span></div>
    <div style="float: right;  width: 850px;
        background-repeat: repeat-y; direction: rtl; text-align: right;">
        
        
        <asp:DataList ID="DataList5" runat="server" DataKeyField="id"
            RepeatColumns="9" CssClass="main_desktop_item" 
            RepeatDirection="Horizontal">
            <ItemStyle Width="89px" HorizontalAlign="Center" VerticalAlign="Top" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%# Eval("image","~/core/themeCP/Bitrix/CssImage/icon/{0}") %>'
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>'></asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink8" runat="server" Font-Underline="False" ForeColor="Black"
                    NavigateUrl='<%# Eval("title", "~/manage/?mode=redirect&autolink={0}") %>'
                    Text='<%# Eval("title_main") %>' CssClass="txtIcon"></asp:HyperLink><br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>


</div>

