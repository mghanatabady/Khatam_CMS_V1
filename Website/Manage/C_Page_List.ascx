<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_Page_List.ascx.vb" Inherits="C_Page_List" %>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="25" Width="742px">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" ReadOnly="True" SortExpression="id">
                <ItemStyle HorizontalAlign="Right" Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="عنوان" ReadOnly="True" SortExpression="title">
                <ItemStyle HorizontalAlign="Right" Width="250px" />
            </asp:BoundField>
            <asp:CommandField CancelText="انصراف" DeleteText="حذف" EditText="تغییر وضعیت" SelectText="ویرایش"
                ShowSelectButton="True" UpdateText="تایید">
                <ItemStyle Width="50px" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        DeleteCommand="DELETE FROM [teacher] WHERE [idt] = @idt" InsertCommand="INSERT INTO [teacher] ([page], [Enable]) VALUES (@page, @Enable)"
        ProviderName="<%$ ConnectionStrings:Khatam_Site.ProviderName %>" SelectCommand="SELECT id, title, Enable, mode FROM [content] WHERE (Enable = 1) AND (mode = N'base')"
        UpdateCommand="UPDATE [teacher] SET [page] = @page, [Enable] = @Enable WHERE [idt] = @idt">
        <InsertParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
            <asp:Parameter Name="idt" Type="String" />
        </UpdateParameters>
        <DeleteParameters>
            <asp:Parameter Name="idt" Type="String" />
        </DeleteParameters>
    </asp:SqlDataSource>
</div>

