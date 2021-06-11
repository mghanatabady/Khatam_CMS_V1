<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_trouble_ticket_request_item.ascx.vb" Inherits="manage_c_trouble_ticket_request_item" %>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" meta:resourcekey="Image3Resource1" />&nbsp;</div>
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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" meta:resourcekey="ImageButton1Resource1" /></div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
        DataSourceID="SqlDataSource1" GridLines="None" ShowHeader="False" Font-Bold="True" meta:resourcekey="GridView1Resource1">
        <Columns>
            <asp:TemplateField meta:resourcekey="TemplateFieldResource1">
                <ItemTemplate>
                    کد تیکت:
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>' meta:resourcekey="Label1Resource1"></asp:Label><br />
                    عنوان:
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>' meta:resourcekey="Label2Resource1"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        
        SelectCommand="SELECT id, id_customer, title, status, date_insert, date_update  FROM Trouble_ticket WHERE (id = @id) AND (id_customer = @id_customer)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
            <asp:SessionParameter Name="id_customer" SessionField="user_id" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
        DataSourceID="SqlDataSource1" meta:resourcekey="GridView4Resource1" 
        EnableModelValidation="True" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                SortExpression="id" meta:resourcekey="BoundFieldResource1" />
            <asp:BoundField DataField="id_customer" HeaderText="id_customer" SortExpression="id_customer" meta:resourcekey="BoundFieldResource2" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" meta:resourcekey="BoundFieldResource3" />
            <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" meta:resourcekey="BoundFieldResource4" />
            <asp:BoundField DataField="date_insert" HeaderText="date_insert" SortExpression="date_insert" meta:resourcekey="BoundFieldResource5" />
            <asp:BoundField DataField="date_update" HeaderText="date_update" SortExpression="date_update" meta:resourcekey="BoundFieldResource6" />
        </Columns>
    </asp:GridView>
</div>
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: justify" id="DIV2" runat="server">
    &nbsp;<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BorderColor="#BDC6E0"
        BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource2" ShowHeader="False"
        Width="742px" meta:resourcekey="GridView2Resource1" 
        EnableModelValidation="True">
        <Columns>
            <asp:TemplateField meta:resourcekey="TemplateFieldResource2">
                <ItemTemplate>
                    <asp:Label ID="Lbl_date" runat="server" meta:resourcekey="Lbl_dateResource1"></asp:Label>،
                    <asp:Label ID="Lbl_RealName" runat="server" meta:resourcekey="Lbl_RealNameResource1"></asp:Label>
                    نوشتند:<br />
                    <br />
                    &nbsp;<asp:Label ID="Label3" runat="server" Text='<%# Eval("page") %>' meta:resourcekey="Label3Resource1"></asp:Label><br />
                    <br />
                    <asp:Label ID="Lbl_link" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    &nbsp;&nbsp;<br />
</div>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
    DataSourceID="SqlDataSource2" meta:resourcekey="GridView3Resource1" 
    EnableModelValidation="True" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                SortExpression="id" meta:resourcekey="BoundFieldResource8" />
            <asp:BoundField DataField="user_mode" HeaderText="user_mode" SortExpression="user_mode" meta:resourcekey="BoundFieldResource9" />
            <asp:BoundField DataField="date_insert" HeaderText="date_insert" SortExpression="date_insert" meta:resourcekey="BoundFieldResource10" />
            <asp:BoundField DataField="realname" HeaderText="realname" SortExpression="realname" meta:resourcekey="BoundFieldResource11" />
            <asp:BoundField DataField="page" HeaderText="page" HtmlEncode="False" SortExpression="page" meta:resourcekey="BoundFieldResource12" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        DeleteCommand="DELETE FROM [Ticket_Line] WHERE [id] = @id" ProviderName="<%$ ConnectionStrings:Khatam_site.ProviderName %>"
        
    SelectCommand="SELECT Trouble_Ticket_Line.date_insert, Trouble_Ticket_Line.page, Trouble_Ticket_Line.id AS id_trouble_ticket, Trouble_Ticket_Line.id, Customers.fname + N' ' + Customers.lname AS realname, Trouble_Ticket_Line.user_mode FROM Trouble_Ticket_Line INNER JOIN Trouble_ticket ON Trouble_Ticket_Line.id_ticket = Trouble_ticket.id INNER JOIN Customers ON Trouble_ticket.id_customer = Customers.id WHERE (Trouble_ticket.id = @id_trouble_ticket) AND (Trouble_ticket.id_customer = @id_customer)" 
    InsertCommand="INSERT INTO [Ticket_Line] ([date_insert], [page], [type]) VALUES (@date_insert, @page, @type)" 
    
    UpdateCommand="UPDATE [Ticket_Line] SET [date_insert] = @date_insert, [page] = @page, [type] = @type WHERE [id] = @id">
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
            <asp:SessionParameter Name="id_customer" SessionField="user_id" />
        </SelectParameters>
    </asp:SqlDataSource>
<br />
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left; float:left;">
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
        text-align: left;float:left;">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" meta:resourcekey="Image1Resource1" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 400px; height: 26px">
                <strong><span>اضافه نمودن یادداشت بیشتر به این تیکت</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div style="width: 340px">
                    <asp:TextBox ID="Txt_Page" runat="server" Font-Names="Tahoma" Height="200px" MaxLength="299"
                        TextMode="MultiLine" Width="336px" meta:resourcekey="Txt_PageResource1"></asp:TextBox></div>
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
                    <asp:RequiredFieldValidator ID="valReq" runat="server" ControlToValidate="FileUpload1"
                        ErrorMessage="لطفا فایل مورد نظر را انتخاب نمایید" ValidationGroup="up"></asp:RequiredFieldValidator><br />
                    <br />
                    <asp:RegularExpressionValidator ID="valUpTest" runat="server" ControlToValidate="FileUpload1"
                        ErrorMessage="فایل های قابل الصاق :  (.docx, .doc, .jpg, .zip, pdf)" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$"
                        ValidationGroup="up"></asp:RegularExpressionValidator><br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Height="24px" Text="Upload" ValidationGroup="up" /><br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Size="8pt"></asp:Label></div>
                <div id="DIV1" runat="server" style="width: 340px" visible="true">
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="پایان فرآیند پشتیبانی فنی، مشکل حل شده است" meta:resourcekey="CheckBox1Resource1" /><br />
                </div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div style="width: 300px">
                    یادداشت</div>
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left;">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left;float:left;">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="40px" meta:resourcekey="Button1Resource2" />
            <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" meta:resourcekey="Button2Resource1" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left;">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />
