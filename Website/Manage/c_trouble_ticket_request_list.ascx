<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_trouble_ticket_request_list.ascx.vb" Inherits="manage_c_trouble_ticket_request_list" %>
<br />
<div style="margin-left: 10px; width: 742px; margin-right: 10px; height: 100px" id="DIV1" runat="server" visible="false">
    <div title="window">
        <div>
            <div style="background-image: url(images/win1_bg.gif); width: 316px; background-repeat: repeat-x;
                height: 25px; text-align: left">
                <div style="float: left; background-image: url(images/win1_left_bg.gif); width: 11px;
                    height: 25px">
                </div>
                <div style="float: right; background-image: url(images/win1_right_bg.gif); width: 2px;
                    height: 25px">
                </div>
                <div id="Div2" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                    padding-top: 1px">
                    جستجو
                </div>
            </div>
            <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                <div dir="rtl" style="margin: 6px 9px 3px 10px; width: 295px; text-align: left">
                    <div style="width: 295px">
                        <strong>عبارت:</strong>
                        <asp:TextBox ID="Txt_Search" runat="server" Font-Names="Tahoma" Font-Size="10pt"
                            Width="127px"></asp:TextBox>&nbsp;<asp:DropDownList ID="DDL_Search" runat="server"
                                Font-Names="Tahoma" Font-Size="10pt" Width="100px">
                                <asp:ListItem Value="0">کد</asp:ListItem>
                                <asp:ListItem Value="1" Selected="True">عنوان</asp:ListItem>
                                <asp:ListItem Value="3">همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px" id="DIV3" runat="server" visible="true">
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
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="50" 
        DataKeyNames="id" EnableModelValidation="True">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id">
                <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="عنوان" SortExpression="title">
                <ItemStyle Width="250px" />
            </asp:BoundField>
            <asp:BoundField DataField="Ticket_title" HeaderText="وضعیت" SortExpression="Ticket_title">
                <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="date_insert" HeaderText="زمان درج" SortExpression="date_insert">
                <ItemStyle Font-Size="7pt" Width="120px" />
            </asp:BoundField>
            <asp:BoundField DataField="date_update" HeaderText="آخرین بروز رسانی" SortExpression="date_update">
                <ItemStyle Font-Size="7pt" Width="120px" />
            </asp:BoundField>
            <asp:ButtonField CommandName="select" Text="انتخاب" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <EmptyDataTemplate>
            هنوز درخواست پشتیبانی درج نگردیده است
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        ProviderName="<%$ ConnectionStrings:Khatam_site.ProviderName %>" 
        SelectCommand="SELECT Trouble_ticket.id, Trouble_ticket.id_customer, Trouble_ticket.title, Trouble_ticket.date_insert, Trouble_ticket.date_update, Trouble_Ticket_Status.title AS ticket_title FROM Trouble_ticket INNER JOIN Trouble_Ticket_Status ON Trouble_ticket.status = Trouble_Ticket_Status.id WHERE (Trouble_ticket.id_customer = @user_id) ORDER BY Trouble_ticket.id DESC" 
        DeleteCommand="DELETE FROM message WHERE (idm = @idm)">
        <DeleteParameters>
            <asp:Parameter Name="idm" />
        </DeleteParameters>
        <SelectParameters>
            <asp:SessionParameter Name="user_id" SessionField="user_id" />
        </SelectParameters>
    </asp:SqlDataSource>
    &nbsp;

</div>