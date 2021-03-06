<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Classroom_Personal_Calendar_list.ascx.vb" Inherits="C_school_Classroom_Personal_Calendar_list" %>
<div style="margin-left: 10px; width: 742px; margin-right: 10px; height: 100px" id="DIV1" runat="server">
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
                                <asp:ListItem Value="3">گروه</asp:ListItem>
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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_new.gif" />
        
        
         
        </div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="50" Width="742px">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" ReadOnly="True" SortExpression="id">
                <ItemStyle HorizontalAlign="Right" Width="75px" />
            </asp:BoundField>
            <asp:BoundField DataField="Fname" HeaderText="نام" ReadOnly="True" SortExpression="Fname">
                <ItemStyle HorizontalAlign="Right" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="Lname" HeaderText="نام خانوادگی" ReadOnly="True" SortExpression="Lname">
                <ItemStyle HorizontalAlign="Right" Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="groupid" HeaderText="گروه" SortExpression="groupid" ReadOnly="True" />
            <asp:ButtonField CommandName="student_account" Text="تراکنش مالی" />
            <asp:CommandField SelectText="ویرایش" ShowSelectButton="True" />
            <asp:ButtonField CommandName="student_del" Text="حذف" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
        ProviderName="<%$ ConnectionStrings:Khatam_Site.ProviderName %>" SelectCommand="SELECT * FROM [school_student] ORDER BY [id] DESC" DeleteCommand="DELETE FROM [student]  WHERE [id] = @id&#13;&#10;&#13;&#10;" UpdateCommand="UPDATE [student]  SET  [Enable] = @Enable WHERE [id] = @id&#13;&#10;&#13;&#10;">
        <DeleteParameters>
            <asp:Parameter Name="id" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Enable" />
            <asp:Parameter Name="id" />
        </UpdateParameters>
    </asp:SqlDataSource>
</div>
