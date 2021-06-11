<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_class_scheme_add.ascx.vb" Inherits="C_school_class_scheme_add" %>
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px" id="DIV3" runat="server" visible="false">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left">
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
            <div style="margin-top: 2px; font-size: 9pt; float: left; width: 100px; height: 20px;
                text-align: center">
                کلاس بندی</div>
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
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 250px; height: 26px">
                <strong><span>مشخصات کلاس</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div class="from_div_title">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
                <div class="from_div_title">
                    <asp:Label ID="Label2" runat="server"></asp:Label></div>
                <div class="from_div_title">
                    <asp:Label ID="Label3" runat="server"></asp:Label></div>
                &nbsp;&nbsp;
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" class="from_div_title">
                    <span>شماره دانش آموزی</span></div>
                <div class="from_div_title">
                    نام</div>
                <div class="from_div_title">
                    نام خانوادگی</div>
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
<asp:GridView ID="GridViewschool_student" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
    DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display."
    Visible="False">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ids" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="Fname" HeaderText="Fname" SortExpression="Fname" />
        <asp:BoundField DataField="Lname" HeaderText="Lname" SortExpression="Lname" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
    DeleteCommand="DELETE FROM [school_student] WHERE [ids] = @ids" InsertCommand="INSERT INTO [school_student] ([ids], [Fname], [Lname]) VALUES (@ids, @Fname, @Lname)"
     SelectCommand="SELECT [id], [Fname], [Lname] FROM [school_student] WHERE ([id] = @ids)"
    UpdateCommand="UPDATE [school_student] SET [Fname] = @Fname, [Lname] = @Lname WHERE [ids] = @ids">
    <DeleteParameters>
        <asp:Parameter Name="ids" Type="String" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="Fname" Type="String" />
        <asp:Parameter Name="Lname" Type="String" />
        <asp:Parameter Name="ids" Type="String" />
    </UpdateParameters>
    <SelectParameters>
        <asp:QueryStringParameter Name="ids" QueryStringField="ids" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ids" Type="String" />
        <asp:Parameter Name="Fname" Type="String" />
        <asp:Parameter Name="Lname" Type="String" />
    </InsertParameters>
</asp:SqlDataSource>
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
        <DIV style="MARGIN-TOP: 4px; FONT-SIZE: 9pt; HEIGHT: 18px; float: left;" >
            لیست دانش آموزان این کلاس</div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton_Remove" runat="server" ImageUrl="~/images/silverbar_btn_remove.gif" /></div>
</div>
&nbsp;<div id="MSG5" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با حذف دانش آموز از کلاس نمرات مرتبط نیز حذف می گردد. آیا برای
            حذف&nbsp;
            مطمئن هستید؟<br />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" Text="هزینه اخذ گردیده برای این واحد ها باز پرداخت شود" Visible="False" /><br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />&nbsp;<asp:Button ID="Button2" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            واحد های مورد نظر حذف گردید</span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;"><asp:GridView ID="GridView_Remove" runat="server" AllowPaging="True" AllowSorting="True"
       AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource3" Width="742px" PageSize="150">
    <FooterStyle BackColor="#F1F3FA" />
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="id" HeaderText="کد" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="realname" HeaderText="نام" SortExpression="realname" />
        
    </Columns>
    <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server"  SelectCommand="SELECT     users.id, users.lname + ' , ' + users.lname AS realname
FROM         school_Student_class INNER JOIN
                      users ON school_Student_class.id_school_student = users.id
WHERE     (school_Student_class.id_school_class = @id_school_class)" 
        >
        <SelectParameters>
            <asp:QueryStringParameter Name="id_school_class" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
</div><div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <DIV style="MARGIN-TOP: 4px; FONT-SIZE: 9pt; HEIGHT: 18px; float: left;" >لیست دانش آموزان بدون گروه&nbsp;</DIV>
   
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_add.gif" /></div>
</div>
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
                                <asp:ListItem Value="0">کد درس</asp:ListItem>
                                <asp:ListItem Value="1">کد کلاس</asp:ListItem>
                                <asp:ListItem Value="2">کد کلاس</asp:ListItem>
                                <asp:ListItem Value="3">کد معلم</asp:ListItem>
                                <asp:ListItem Selected="True">نام درس</asp:ListItem>
                                <asp:ListItem>واحد</asp:ListItem>
                                <asp:ListItem>همه موارد</asp:ListItem>
                            </asp:DropDownList></div>
                </div>
                <div dir="rtl" style="margin: 6px 9px 3px 5px; width: 295px; text-align: left">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Text="بیاب" Width="70px" /></div>
            </div>
        </div>
    </div>
</div>
<br />
<div id="MSG6" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            واحد های مورد نظر اضافه گردید</span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px" DataSourceID="SqlDataSource1" Width="742px" PageSize="150">
        <FooterStyle BackColor="#F1F3FA" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id" HeaderText="شماره دانش آموزی" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="realname" HeaderText="نام خانوادگی" SortExpression="realname" />
        </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />
    </asp:GridView>
    
    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" 
        AutoGenerateColumns="False" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                SortExpression="id" />
            <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" 
                SortExpression="email" />
            <asp:BoundField DataField="realname" HeaderText="realname" ReadOnly="True" 
                SortExpression="realname" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
      
        SelectCommand="SELECT     id, email, realname
FROM         (SELECT DISTINCT users.id, users.email, users.lname + ' ,  ' + users.fname AS realname
                       FROM          corePermission INNER JOIN
                                              corePermissionRefUser ON corePermission.id = corePermissionRefUser.idPermission INNER JOIN
                                              users ON corePermissionRefUser.idUser = users.id
                       WHERE      (corePermission.title = N'school_View_ClassGrade_linked_student') OR
                                              (corePermission.title = N'school_View_reportCard_linked_student')
                       UNION
                       SELECT DISTINCT users_1.id, users_1.email, users_1.lname + ' ,  ' + users_1.fname AS realname
                       FROM         coreRoleRefUser INNER JOIN
                                             coreRole ON coreRoleRefUser.idRole = coreRole.id INNER JOIN
                                             users AS users_1 ON coreRoleRefUser.idUser = users_1.id INNER JOIN
                                             corePermissionRefRole ON coreRole.id = corePermissionRefRole.idRole INNER JOIN
                                             corePermission AS corePermission_1 ON corePermissionRefRole.idPermission = corePermission_1.id
                       WHERE     (corePermission_1.title = N'school_View_ClassGrade_linked_student') OR
                                             (corePermission_1.title = N'school_View_reportCard_linked_student')) AS derivedtbl_1
WHERE     (id NOT IN
                          (SELECT     users_1.id
                            FROM          school_Student_class AS school_Student_class_1 INNER JOIN
                                                   users AS users_1 ON school_Student_class_1.id_school_student = users_1.id))">
        <SelectParameters>
            <asp:QueryStringParameter Name="id_school_class" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
</div>