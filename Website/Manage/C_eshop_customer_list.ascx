<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_eshop_customer_list.ascx.vb" Inherits="C_shop_customer_list" %>
<div style="margin-left: 10px; width: 742px; margin-right: 10px; height: 100px" id="DIV1" runat="server" visible="true">
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
                                <asp:ListItem Value="1">نام</asp:ListItem>
                                <asp:ListItem Selected="True" Value="2">نام خانوادگی</asp:ListItem>
                                <asp:ListItem Value="3">شماره شناسنامه</asp:ListItem>
                                <asp:ListItem Value="4">همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px" id="DIV3" runat="server" visible="false">
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
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="50">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="customer_id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="customer_id">
                <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="first_name" HeaderText="نام" SortExpression="first_name">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="last_name" HeaderText="نام خانوادگی" SortExpression="last_name">
                <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="customer_company" HeaderText="شرکت" SortExpression="customer_company">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="customer_phone" HeaderText="تلفن" SortExpression="customer_phone">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="customer_mobile" HeaderText="موبایل" SortExpression="customer_mobile">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="customer_email" HeaderText="ایمیل" SortExpression="customer_email">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:CommandField SelectText="نمایش" ShowSelectButton="True">
                <ItemStyle Width="50px" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        ProviderName="<%$ ConnectionStrings:Khatam_Site.ProviderName %>" SelectCommand="SELECT customer_id, first_name, last_name, customer_company, degree, customer_state, customer_city, custumer_addresses, customer_postcode, customer_phone, customer_mobile, customer_fax, customer_email, customer_username, customer_pass, other_customer_details FROM Customers ORDER BY customer_id DESC" DeleteCommand="DELETE FROM message WHERE (idm = @idm)">
        <DeleteParameters>
            <asp:Parameter Name="idm" />
        </DeleteParameters>
    </asp:SqlDataSource>
    &nbsp;

</div>