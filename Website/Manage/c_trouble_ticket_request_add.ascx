<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_trouble_ticket_request_add.ascx.vb" Inherits="manage_c_trouble_ticket_request_add" %>

<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px; margin-bottom: 17px;">
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
</div>

<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px; float:left ; margin-bottom:10px ">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left;float:left">
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
                تیکت جدید</div>
            <div style="float: right; background-image: url(images/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left;float:left">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 250px; height: 26px">
                <strong><span>مشخصات درخواست</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x; float:left;">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right; ">
                <div style="width: 340px; height: 34px; float: right;">
               
                </div>
                <div style="width: 340px; height: 34px; float: right;">
                    <asp:TextBox ID="Txt_Title" runat="server" MaxLength="119" Font-Names="Tahoma"></asp:TextBox>&nbsp;</div>
                <div style="width: 340px; float: right;">
                    <asp:TextBox ID="Txt_Page" runat="server" MaxLength="299" Height="200px" TextMode="MultiLine" Width="336px" Font-Names="Tahoma"></asp:TextBox></div>
                <div style="width: 340px; float: right;" id="DIV1" runat="server" 
                    visible="true">
                        <br />
                        <img src="../images/Main_Desktop/icon_attach_16_16_transpare.gif" 
                            style="height: 16px" />
                        <asp:Label ID="Label3" runat="server" Font-Size="8pt" Text="الصاق فایل به پیوست"></asp:Label><br />
                        &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Font-Size="8pt">
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
                        </div><div style="width: 340px; float: right;">
                            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                            <br />
                            
                            <asp:RequiredFieldValidator ID="valReq" runat="server" ControlToValidate="FileUpload1" ValidationGroup="up" ErrorMessage="لطفا فایل مورد نظر را انتخاب نمایید" /><br />
                            <br />
<asp:RegularExpressionValidator runat="server" ID="valUpTest" ControlToValidate="FileUpload1" ValidationGroup="up"
            ErrorMessage="فایل های قابل الصاق :  (.docx, .doc, .jpg, .zip, pdf)"
            ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$" /><br />
    <br />
    <asp:Button ID="Button3" runat="server" Height="24px" Text="Upload" ValidationGroup="up" />
                            <asp:Button ID="Button5" runat="server" Text="Button" />
                            <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="8pt"></asp:Label></div>
                <div style="width: 340px; height: 34px">
                    </div>
            </div>
            <div style="margin-top: 5px; width: 320px; float: left;">
   
                <div dir="rtl" style="width: 300px; height: 34px">
                    <span>
                        دسته
                        بندی </span></div>
                <div style="width: 300px; height: 34px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Title"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>عنوان</div>
                <div style="width: 300px">
                    شرح درخواست پشتیبانی</div>
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left;float:left">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="40px" />
            <asp:Button ID="Button4" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left;float:left">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />

