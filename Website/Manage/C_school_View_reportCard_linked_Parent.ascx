<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_school_View_reportCard_linked_Parent.ascx.cs" Inherits="Manage_C_school_View_reportCard_linked_Parent" %>
<div dir="rtl" style=" margin-left: 10px; width: 742px; margin-right: 10px">
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
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                اعلام نمرات</div>
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
            <div class="from_div_maintitle ">
                <strong><span>کارنامه مرتبط با اولیا</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="width: 720px; text-align: justify;" dir="rtl">
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1" 
                    
                     AllowPaging="True" AllowSorting="True"
         BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" PageSize="50" Width="717px"
        
                    
                    >

                     
                    <EmptyDataTemplate>
                        هیچ موردی برای نمایش یافت نشد.
                    </EmptyDataTemplate>

                     
        <FooterStyle BackColor="#F1F3FA" />
                    <Columns>
                          <asp:BoundField DataField="school_lesson_id" HeaderText="کد درس" 
                            SortExpression="school_lesson_id" />
                        <asp:BoundField DataField="title" HeaderText="درس" SortExpression="title" />

                        <asp:BoundField DataField="value" HeaderText="نمره" SortExpression="value" />
                  
                        <asp:BoundField DataField="teachername" HeaderText="نام معلم" 
                            ReadOnly="True" SortExpression="teachername" />

                             
                            <asp:BoundField DataField="studentID" HeaderText="دانش آموز" 
                            ReadOnly="True" SortExpression="studentID" />
                                 <asp:BoundField DataField="realname" HeaderText="نام دانش آموز" 
                            ReadOnly="True" SortExpression="realname" />
                        <asp:BoundField DataField="unit" HeaderText="واحد" SortExpression="unit" />
                        <asp:BoundField DataField="ScoreTypeTitle" HeaderText="نوبت امتحان" 
                            SortExpression="ScoreTypeTitle" />
                    </Columns>
        <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" />

                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"  ></asp:SqlDataSource>
                <br />
                <br />
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
