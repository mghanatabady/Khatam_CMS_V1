<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_Trouble_ticket_Response_item.ascx.vb" Inherits="manage_c_Trouble_ticket_Response_item" %>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px">
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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" /></div>
</div><br>


<div style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px; " dir="rtl" visible="false"   runat="server"  >
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left">
        <div style="float: left; background-image: url(images/form1_left_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div id="Div4" style="margin-top: 9px; float: left; background-image: url(images/Tab1_bg.gif);
            margin-left: 4px; width: 115px; height: 22px">
            <div style="float: left; background-image: url(images/Tab1_left_bg.gif); width: 2px;
                height: 22px">
            </div>
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                تیکت</div>
            <div style="float: right; background-image: url(images/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div id="DIV5" style="margin-top: 15px; float: left; margin-left: 5px; width: 400px;
                height: 26px">
                <strong><span>انتخاب / تغییر پشتیبان برای این تیکت</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div style="width: 340px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Tahoma" 
                        Width="176px">
                    </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:khatam_site %>"
                        SelectCommand="SELECT iduser, username, password, realname, schoolname, mode, cat_id FROM users WHERE (cat_id = 5)">
                    </asp:SqlDataSource>
                </div>
                <div id="Div6" runat="server" style="width: 340px" visible="true">
                </div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div style="width: 300px">
                    لیست کارشناسان فنی</div>
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button5" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="40px" />
            <asp:Button ID="Button4" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
        DataSourceID="SqlDataSource1" GridLines="None" ShowHeader="False" Font-Bold="True">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    کد تیکت:
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label><br />
                    عنوان:
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        
        SelectCommand="SELECT id, id_customer, title, status, date_insert, date_update FROM Trouble_ticket WHERE (id = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    &nbsp;<asp:GridView ID="GridView4" runat="server" 
        AutoGenerateColumns="False" DataKeyNames="id"
        DataSourceID="SqlDataSource1" Visible="False" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="id_customer" HeaderText="id_customer" SortExpression="id_customer" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            <asp:BoundField DataField="date_insert" HeaderText="date_insert" SortExpression="date_insert" />
            <asp:BoundField DataField="date_update" HeaderText="date_update" SortExpression="date_update" />
        </Columns>
    </asp:GridView>
</div>
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify" id="DIV2" runat="server">
    &nbsp;<asp:GridView ID="GridView2" runat="server" 
        AutoGenerateColumns="False" BorderColor="#BDC6E0"
        BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource2" ShowHeader="False"
        Width="742px" EnableModelValidation="True">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="Lbl_date" runat="server"></asp:Label>،
                    <asp:Label ID="Lbl_RealName" runat="server"></asp:Label>
                    نوشتند:<br />
                    <br />
                    &nbsp;<asp:Label ID="Label3" runat="server" Text='<%# Eval("page") %>'></asp:Label><br />
                    <br />
                    <asp:Label ID="Lbl_link" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
</div>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
    DataSourceID="SqlDataSource2" Visible="False" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="user_mode" HeaderText="user_mode" SortExpression="user_mode" />
            <asp:BoundField DataField="date_insert" HeaderText="date_insert" SortExpression="date_insert" />
            <asp:BoundField DataField="realname" HeaderText="realname" SortExpression="realname" />
            <asp:BoundField DataField="page" HeaderText="page" HtmlEncode="False" SortExpression="page" />
        </Columns>
    </asp:GridView>
<br />
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
    DeleteCommand="DELETE FROM [trouble_ticket_Line] WHERE [id] = @id" InsertCommand="INSERT INTO [trouble_ticket_Line] ([date_insert], [page], [type]) VALUES (@date_insert, @page, @type)"
    ProviderName="<%$ ConnectionStrings:Khatam_site.ProviderName %>" SelectCommand="SELECT Trouble_Ticket_Line.date_insert, Trouble_Ticket_Line.page, Trouble_Ticket_Line.id_ticket, Trouble_Ticket_Line.id, Customers.fname + N' ' + Customers.lname AS realname, Trouble_Ticket_Line.user_mode FROM Trouble_Ticket_Line INNER JOIN Trouble_ticket ON Trouble_Ticket_Line.id_ticket = Trouble_ticket.id INNER JOIN Customers ON Trouble_ticket.id_customer = Customers.id WHERE (Trouble_ticket.id = @id_trouble_ticket)"
    
    UpdateCommand="UPDATE [trouble_ticket_Line] SET [date_insert] = @date_insert, [page] = @page, [type] = @type WHERE [id] = @id">
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter DbType="Date" Name="date_insert" />
        <asp:Parameter Name="page" Type="String" />
        <asp:Parameter Name="type" Type="Int32" />
        <asp:Parameter Name="id" Type="Int32" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter DbType="Date" Name="date_insert" />
        <asp:Parameter Name="page" Type="String" />
        <asp:Parameter Name="type" Type="Int32" />
    </InsertParameters>
    <SelectParameters>
        <asp:QueryStringParameter Name="id_trouble_ticket" QueryStringField="id" />
    </SelectParameters>
</asp:SqlDataSource>
<br />
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px; margin-bottom:10px; float:left">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left; float:left ">
        <div style="float: left; background-image: url(images/form1_left_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div id="test" style="margin-top: 9px; float: left; background-image: url(images/Tab1_bg.gif);
            margin-left: 4px; width: 115px; height: 22px">
            <div style="float: left; background-image: url(images/Tab1_left_bg.gif); width: 2px;
                height: 22px">
            </div>
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                تیکت</div>
            <div style="float: right; background-image: url(images/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left;float:left ">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 400px; height: 26px">
                <strong><span>اضافه نمودن یادداشت بیشتر به این تیکت</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div style="width: 340px">
                    <asp:TextBox ID="Txt_Page" runat="server" Font-Names="Tahoma" Height="200px" MaxLength="299"
                        TextMode="MultiLine" Width="336px"></asp:TextBox></div>
                <div id="Div3" runat="server" style="width: 340px" visible="true">
                    <br />
                    <img src="../images/Main_Desktop/icon_attach_16_16_transpare.gif" />
                    <asp:Label ID="Label3" runat="server" Font-Size="8pt" Text="الصاق فایل به پیوست"></asp:Label><br />
                    &nbsp;<asp:GridView ID="GridView_Attach" runat="server" AutoGenerateColumns="False"
                        Font-Size="8pt">
                        <Columns>
                            <asp:BoundField DataField="filename" HeaderText="نام فایل">
                                <ItemStyle Width="150px" />
                            </asp:BoundField>
                            <asp:CommandField SelectText="حذف" ShowSelectButton="True" />
                        </Columns>
                        <EmptyDataTemplate>
                            فایلی پیوست نگردیده است
                        </EmptyDataTemplate>
                    </asp:GridView>
                    <br />
                </div>
                <div style="width: 340px">
                    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Height="24px" Text="Upload" /><br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Size="8pt"></asp:Label></div>
                <div id="DIV1" runat="server" style="width: 340px" visible="true">
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" meta:resourcekey="CheckBox1Resource1"
                        Text="پایان فرآیند پشتیبانی فنی، مشکل حل شده است" /><br />
                </div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div style="width: 300px">
                    یادداشت</div>
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left ">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left;float:left ">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="40px" />
            <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left ">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />
