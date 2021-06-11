<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_comment.ascx.cs" Inherits="Manage_c_comment" %>


      
                                            <div style= " width:995px; float:right ">

<div id="div_search"  runat="server"  visible="false"  style="margin-left: 10px; Width: 742px; margin-right: 10px; height: 100px; "   >
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
<br />
<div dir="rtl" style=" Width: 995px;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource1" Width="995px" 
        PageSize="50">
        <FooterStyle BackColor="#F1F3FA" />
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" ReadOnly="True" 
                SortExpression="id" InsertVisible="False">
            </asp:BoundField>
            <asp:BoundField DataField="name" HeaderText="نام" 
                SortExpression="name" ReadOnly="True">
            </asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="ایمیل" 
                SortExpression="email" ReadOnly="True">
            </asp:BoundField>
            <asp:BoundField DataField="website" HeaderText="وب سایت" 
                SortExpression="website" ReadOnly="True" />
            <asp:BoundField DataField="memo" HeaderText="شرح" 
                SortExpression="memo" ReadOnly="True" HtmlEncode="False" />
            <asp:BoundField DataField="type_content" HeaderText="نوع محتوا" 
                SortExpression="type_content" ReadOnly="True" />
            <asp:BoundField DataField="id_content" HeaderText="کد محتوا" ReadOnly="True" 
                SortExpression="id_content" />
            <asp:BoundField DataField="pub_date" HeaderText="زمان درج" ReadOnly="True" 
                SortExpression="pub_date" />
            <asp:CheckBoxField DataField="valid" HeaderText="تایید" 
                SortExpression="valid" />
            <asp:CommandField ShowEditButton="True" CancelText="انصراف" EditText="ویرایش" 
                UpdateText="بروز رسانی" />
        </Columns>
        <EmptyDataTemplate>
            <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; margin-left: 70px;
                border-left: red 2px solid; Width: 852px; margin-right: 10px; border-bottom: red 2px solid;
                height: 45px; text-align: right">
                <div style="margin-top: 5px; float: right; Width: 38px; margin-right: 10px; height: 26px">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                <div style="padding-right: 5px; margin-top: 5px; float: right; Width: 560px; color: red;
                    padding-top: 5px; height: 26px">
                    توجه!<br />هیچ موردی برای نمایش یافت نشد.</div>
                <br />
            </div>
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  
        
        
        
        
        
        SelectCommand="SELECT id, name, email, website, memo, type_content, id_content, pub_date, valid FROM comment ORDER BY id DESC" 
        DeleteCommand="DELETE FROM [comment] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [comment] ([name], [email], [website], [memo], [type_content], [id_content], [pub_date], [valid]) VALUES (@name, @email, @website, @memo, @type_content, @id_content, @pub_date, @valid)" 
        UpdateCommand="UPDATE [comment] SET  [valid] = @valid WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="website" Type="String" />
            <asp:Parameter Name="memo" Type="String" />
            <asp:Parameter Name="type_content" Type="String" />
            <asp:Parameter Name="id_content" Type="Int32" />
            <asp:Parameter Name="pub_date" Type="DateTime" />
            <asp:Parameter Name="valid" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="valid" Type="Boolean" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</div>


</div> 