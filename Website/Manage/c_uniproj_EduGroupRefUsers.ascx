<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_uniproj_EduGroupRefUsers.ascx.cs" Inherits="Manage_c_uniproj_EduGroupRefUsers" %>
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
        مدیریت انقیاد اساتید و گروه آموزشی
    </div></div></div></div></div></div></div></div>

    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="ltr" style="text-align: left; height:330px;  ">
                                    
                                    <div style="text-align:right; direction:rtl " >
                                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                    </div>
                                    <div style=" margin-right:50px; margin-top:20px">
                                    <div style=" float:right; direction:rtl  ">
                                    لیست اساتید
                                    <br />
                                      <asp:ListBox ID="ListBoxAdd" runat="server" Width="350px" Height="250px" 
                                            DataSourceID="SqlDataSourceAll" DataTextField="title" DataValueField="id" 
                                            SelectionMode="Multiple" Font-Names="Tahoma"></asp:ListBox>
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
                                      اساتید مرتبط با این گروه آموزشی
                                      <br />
                                      <asp:ListBox ID="ListBoxRemove" runat="server" Width="350px" Height="250px" 
                                              DataSourceID="SqlDataSourceSelected" DataTextField="title" DataValueField="id" 
                                              SelectionMode="Multiple" Font-Names="Tahoma"></asp:ListBox>
                                      </div>
                                      </div>
                                    </div>
    </div></div></div></div></div></div></div></div>

     </ContentTemplate>
</asp:UpdatePanel>

              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
                  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Manage/?mode=uniproj_eduGrroup_list_all">بازگشت</asp:HyperLink>
                  

    </div></div></div></div></div></div></div></div>

      
						
                        </div>




<br />



    <asp:SqlDataSource ID="SqlDataSourceAll" runat="server" >
      
    </asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSourceSelected" runat="server"       >
        
    </asp:SqlDataSource>



    
 

</div> 