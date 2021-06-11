<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_forms_list.ascx.cs" Inherits="Manage_c_forms_list" %>
<div  dir="rtl"  style=" width: 100%;   ">
    &nbsp;<asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" PageSize="50" 
        Width="100%" onselectedindexchanged="GridView2_SelectedIndexChanged"  OnRowCommand="GridView2_RowCommand" 
        DataSourceID="SqlDataSource1"   >
        <FooterStyle BackColor="#F1F3FA" />
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="create_date" HeaderText="زمان درج" 
                SortExpression="create_date" />
            <asp:BoundField DataField="ip" HeaderText="IP" SortExpression="ip" />
            <asp:ButtonField CommandName="cmd_show" Text="نمایش" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" >
    </asp:SqlDataSource>
</div>