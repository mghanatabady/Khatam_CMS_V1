<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_trasactions_offline_my.ascx.cs" Inherits="Manage_C_shop_trasactions_offline_my" %>
 <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>

<br />




<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
   

<div  dir="rtl"  style=" width: 100%;   ">
    &nbsp;<asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource2" PageSize="50" 
        Width="100%" onselectedindexchanged="GridView2_SelectedIndexChanged"  
        OnDataBound="gv_sbt_bound" >
        <FooterStyle BackColor="#F1F3FA" />
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="idInvoice" HeaderText="شماره فاکتور" SortExpression="idInvoice" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="accontsDesc" HeaderText="شرح" SortExpression="accontsDesc" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="fishNo" HeaderText="شماره فیش" 
                SortExpression="fishNo">
            </asp:BoundField>
            <asp:BoundField DataField="FishDateTime" HeaderText="تاریخ" 
                SortExpression="FishDateTime"></asp:BoundField>
            <asp:BoundField DataField="amount" HeaderText="مبلغ" 
                SortExpression="amount"></asp:BoundField>
            <asp:BoundField DataField="regDate" HeaderText="تاریخ درج" 
                SortExpression="regDate" />
            <asp:BoundField DataField="state" HeaderText="وضعیت" SortExpression="state" />
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


<asp:SqlDataSource ID="SqlDataSource1" runat="server" >
  
    
    </asp:SqlDataSource>
<p>
    &nbsp;</p>

<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
 
    
    
   >
</asp:SqlDataSource>

    </ContentTemplate>
</asp:UpdatePanel>
