<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_Trouble_ticket_request_add_select_product.ascx.vb" Inherits="manage_c_Trouble_ticket_request_add_select_product" %>
<div id="MSG2" runat="server" dir="rtl" style=" float:left ;  border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; text-align: right; margin-bottom: 10px;">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/images/msg_icon/icon_info.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; margin-bottom: 10px;">
        <span style="color: black">انتخاب سفارش<br />
            <span style="font-size: 9pt">در ابتدا محصولی یا سرویسی که نیاز به ارسال تیکت پشتیبانی دارد از لیست ذیل انتخاب نمایید</span></span></div>
    <br />
</div>
<div runat="server" visible="false"  style="margin-left: 10px; Width: 742px; margin-right: 10px; height: 100px"  >
    <div title="window">
        <div>
            <div style="background-image: url(images/win1_bg.gif); Width: 316px; background-repeat: repeat-x;
                height: 25px; text-align: left">
                <div style="float: left; background-image: url(images/win1_left_bg.gif); Width: 11px;
                    height: 25px">
                </div>
                <div style="float: right; background-image: url(images/win1_right_bg.gif); Width: 2px;
                    height: 25px">
                </div>
                <div id="Div1" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                    padding-top: 1px">
                    جستجو
                </div>
            </div>
            <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                Width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                <div dir="rtl" style="margin: 6px 9px 3px 10px; Width: 295px; text-align: left">
                    <div style="Width: 295px">
                        <strong>عبارت:</strong>
                        <asp:TextBox ID="Txt_Search" runat="server" Font-Names="Tahoma" Font-Size="10pt"
                            Width="127px"></asp:TextBox>&nbsp;<asp:DropDownList ID="DDL_Search" runat="server"
                                Font-Names="Tahoma" Font-Size="10pt" Width="100px">
                                <asp:ListItem Value="0">کد</asp:ListItem>
                                <asp:ListItem Value="1">نام</asp:ListItem>
                                <asp:ListItem Selected="True" Value="2">نام خانوادگی</asp:ListItem>
                                <asp:ListItem Value="3">ایمیل</asp:ListItem>
                                <asp:ListItem Value="4">همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; Width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div dir="rtl" runat="server" visible="false"  style="margin-left: 10px; Width: 742px; margin-right: 10px" >
    <div style="background-image: url(images/win2_bg.gif); Width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); Width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            Width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); Width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_new.gif" /></div>
        
</div>
<br />
<div dir="rtl" 
    style=" float:left;margin-left: 10px; Width: 742px; margin-right: 10px; text-align: justify;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" Width="742px" 
        PageSize="25" EnableModelValidation="True">
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد سفارش" ReadOnly="True" 
                SortExpression="id" InsertVisible="False">
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="order_id" HeaderText="کد صورتحساب" 
                SortExpression="order_id">
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="product_id" HeaderText="کد محصول" 
                SortExpression="product_id">
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="comments" HeaderText="عنوان" 
                SortExpression="comments" >
            <ItemStyle Width="400px" />
            </asp:BoundField>
            <asp:ButtonField CommandName="select" Text="انتخاب" />
        </Columns>
        <EmptyDataTemplate>
            <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; margin-left: 70px;
                border-left: red 2px solid; Width: 652px; margin-right: 10px; border-bottom: red 2px solid;
                height: 45px; text-align: right">
                <div style="margin-top: 5px; float: right; Width: 38px; margin-right: 10px; height: 26px">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                <div style="padding-right: 5px; margin-top: 5px; float: right; Width: 560px; color: red;
                    padding-top: 5px; height: 26px">
                    توجه!<br />
                    هیچ موردی برای نمایش یافت نشد.</div>
                <br />
            </div>
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        ProviderName="<%$ ConnectionStrings:Khatam_Site.ProviderName %>" 
        
        
        SelectCommand="SELECT Customer_Orders_Products.id, Customer_Orders_Products.order_id, Customer_Orders_Products.product_id, Customer_Orders_Products.quantity, Customer_Orders_Products.price_rials, Customer_Orders_Products.comments, Customer_Orders_Products.status, Customer_Orders_Products.expire_date FROM Customer_Orders_Products INNER JOIN Customer_Orders ON Customer_Orders_Products.order_id = Customer_Orders.order_id WHERE (Customer_Orders.customer_id = @customer_id) ORDER BY Customer_Orders_Products.id DESC">
        <SelectParameters>
            <asp:SessionParameter Name="customer_id" SessionField="user_id" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
