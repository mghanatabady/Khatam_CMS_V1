<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_News_List.ascx.vb" Inherits="C_News_List" %>
<div style="margin-left: 10px; width: 742px; margin-right: 10px; height: 100px">
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
                <div id="Div1" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
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
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
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
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataSourceID="SqlDataSource1" Width="742px">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                SortExpression="id">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="عنوان" SortExpression="title">
                <ItemStyle Width="300px" />
            </asp:BoundField>
            <asp:BoundField DataField="pubdate" HeaderText="زمان درج خبر" SortExpression="pubdate">
                <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:CommandField SelectText="ویرایش" ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        DeleteCommand="DELETE FROM [teacher] WHERE [idt] = @idt" InsertCommand="INSERT INTO [teacher] ([page], [Enable]) VALUES (@page, @Enable)"
        ProviderName="<%$ ConnectionStrings:Khatam_Site.ProviderName %>" SelectCommand="SELECT  id, title, pubdate FROM News"
        UpdateCommand="UPDATE [teacher] SET [page] = @page, [Enable] = @Enable WHERE [idt] = @idt">
        <DeleteParameters>
            <asp:Parameter Name="idt" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
            <asp:Parameter Name="idt" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
        </InsertParameters>
    </asp:SqlDataSource>
    &nbsp; &nbsp; &nbsp; &nbsp;
</div>
