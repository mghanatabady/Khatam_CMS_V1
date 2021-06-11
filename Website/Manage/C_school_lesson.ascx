<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_lesson.ascx.vb" Inherits="C_school_lesson_list" %>
<div style="margin-left: 10px; Width: 742px; margin-right: 10px; height: 100px">
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
                                <asp:ListItem Value="0" Selected="True">کد درس</asp:ListItem>
                                <asp:ListItem Value="1">نام درس</asp:ListItem>
                                <asp:ListItem Value="2">همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; Width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; Width: 742px; margin-right: 10px">
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
<div dir="rtl" style="margin-left: 10px; Width: 742px; margin-right: 10px; text-align: right;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" Width="742px" PageSize="25">
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد درس" ReadOnly="True" SortExpression="id">
                <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="نام درس" SortExpression="title" />
            <asp:CommandField CancelText="انصراف" DeleteText="حذف" EditText="تغییر وضعیت" SelectText="ویرایش" UpdateText="تایید" ShowSelectButton="True" Visible="False">
                <ItemStyle Width="100px" />
            </asp:CommandField>
            <asp:ButtonField CommandName="school_Lesson_del" Text="حذف" >
                <ItemStyle Width="100px" />
            </asp:ButtonField>
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        DeleteCommand="DELETE FROM [teacher] WHERE [id] = @id" InsertCommand="INSERT INTO [teacher] ([page], [Enable]) VALUES (@page, @Enable)"
        SelectCommand="SELECT school_lesson.* FROM school_lesson ORDER BY id"
        UpdateCommand="UPDATE [teacher] SET [page] = @page, [Enable] = @Enable WHERE [id] = @id">
        <InsertParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="page" Type="Boolean" />
            <asp:Parameter Name="Enable" Type="Boolean" />
            <asp:Parameter Name="id" Type="String" />
        </UpdateParameters>
        <DeleteParameters>
            <asp:Parameter Name="id" Type="String" />
        </DeleteParameters>
    </asp:SqlDataSource>
</div>
