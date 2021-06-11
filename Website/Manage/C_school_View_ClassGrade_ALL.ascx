<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_school_View_ClassGrade_ALL.ascx.cs" Inherits="Manage_C_school_View_ClassGrade_ALL" %>
<div style="margin-left: 10px; width: 742px;  margin-right: 10px; height: 100px" id="DIV1" runat="server" visible="false" >
    <div title="window">
        <div>
            <div style="background-image: url(../images/manage/win1_bg.gif); width: 316px; background-repeat: repeat-x;
                height: 25px; text-align: left">
                <div style="float: left; background-image: url(../images/manage/win1_left_bg.gif); width: 11px;
                    height: 25px">
                </div>
                <div style="float: right; background-image: url(../images/manage/win1_right_bg.gif); width: 2px;
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
<div dir="rtl" 
    style="margin-left: 10px; width: 742px; margin-right: 10px; text-align: right;">
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
                        <asp:BoundField DataField="baseOfScore" HeaderText="پایه نمره" SortExpression="baseOfScore" />
                  
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
</div>
