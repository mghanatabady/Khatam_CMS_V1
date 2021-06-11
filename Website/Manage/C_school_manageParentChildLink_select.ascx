<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_school_manageParentChildLink_select.ascx.cs" Inherits="Manage_C_school_manageParentChildLink_select" %>




<div style= " width:995px; float:right ">
                      

                      <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>

<br />




<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


                                                 <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
مدیریت ارتباط ولی و دانش آموزان
    </div></div></div></div></div></div></div></div>

    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="ltr" style="text-align: left; height:330px;  ">
                                    
                                    <div style="text-align:right; direction:rtl " >
                                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                    </div>
                                    <div style=" margin-right:50px; margin-top:20px">
                                    <div style=" float:right; direction:rtl  ">
                                    لیست دانش آموزان
                                    <br />
                                      <asp:ListBox ID="ListBoxAdd" runat="server" Width="350px" Height="250px" 
                                            SelectionMode="Multiple" Font-Names="Tahoma" DataSourceID="SqlDataSource3" 
                                            DataTextField="realname" DataValueField="id"></asp:ListBox>
                                      </div>
                                       <div style=" float:right ;margin-left:25px;   ">
                                       <br />
                                       <br />
                                       <asp:Button ID="BtnAdd" runat="server" Text="<<" Width="50px" onclick="BtnAdd_Click" 
                                               />

                                           
                                           <br />
                                           <asp:Button ID="BtnRemove" runat="server" Text=">>" Width="50px" 
                                               onclick="Button4_Click" />
                                           
                                       </div>
                                      <div style=" float:right ; direction:rtl  "> 
                                      دانش آموزان مرتبط با ولی
                                      <br />
                                      <asp:ListBox ID="ListBoxRemove" runat="server" Width="350px" Height="250px" 
                                              DataSourceID="SqlDataSource1" DataTextField="realname" DataValueField="idStudent" 
                                              SelectionMode="Multiple" Font-Names="Tahoma"></asp:ListBox>
                                      </div>
                                      </div>
                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
                  <asp:HyperLink ID="HyperLink1" NavigateUrl="~/manage/?mode=school_manageParentChildLink" runat="server">بازگشت</asp:HyperLink>
               

    </div></div></div></div></div></div></div></div>

						
                        </div>




<br />



    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:khatam_site %>" SelectCommand="SELECT     id, realname
FROM         View_Student
WHERE     (id NOT IN
                          (SELECT     idStudent AS id
                            FROM          school_StudentRefParent
                            WHERE      (IdParent = @id)))" >
      
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="" Name="id" QueryStringField="id" />
        </SelectParameters>
      
    </asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:khatam_site %>" SelectCommand="SELECT     school_StudentRefParent.idStudent, users.fname + ' ' + users.lname AS realname
FROM         school_StudentRefParent INNER JOIN
                      users ON school_StudentRefParent.idStudent = users.id
WHERE     (school_StudentRefParent.IdParent = @id)"       >
        
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
        
    </asp:SqlDataSource>



    
    </ContentTemplate>
</asp:UpdatePanel>

</div> 