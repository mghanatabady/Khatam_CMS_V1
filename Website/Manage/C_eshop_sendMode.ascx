<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_sendMode.ascx.cs" Inherits="Manage_C_shop_sendMode" %>




<div  dir="rtl"  style=" width: 100%;   ">
    &nbsp;<asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource2" PageSize="50" 
        Width="100%"   OnRowCommand="GridView2_RowCommand" 
        onselectedindexchanged="GridView2_SelectedIndexChanged" >
        <FooterStyle BackColor="#F1F3FA" />
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
         
            <asp:BoundField DataField="title" HeaderText="نوع شی" SortExpression="title" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:ButtonField CommandName="setAddress" Text="شهر ها / مناطق" />
            <asp:ButtonField CommandName="setting" Text="تنظیمات" />
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





<asp:SqlDataSource ID="SqlDataSource2" runat="server"   SelectCommand="SELECT     id, title, needPaymode  FROM         core_sendMode where (id<5) ">
</asp:SqlDataSource>

