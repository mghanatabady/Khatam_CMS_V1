<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_update.ascx.cs" Inherits="Manage_c_update" %>
           
           
                    <DotNetAge:Tabs ID="Tabs1" runat="server" AsyncLoad="true" EnabledContentCache="true">
    
        <Views>
            <DotNetAge:View Text="بروز رسانی" runat="server" ID="overView" >
       
    
       
                <asp:Label ID="Label2" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label1" runat="server"></asp:Label>

                                    <div id="Div1" 
                                                    style="padding: 10px; background-color: #f8f9fc; direction: rtl; margin-bottom: 10px; text-align: right; border-style: none;" >
           
   

                           <asp:Button ID="Button1"  runat="server" Text="بروز رسانی" 
                   onclick="Button1_Click" CssClass="button1" BorderStyle="Solid"  />
								         
    </div>

            </DotNetAge:View>
         
         
        </Views>
    </DotNetAge:Tabs>          
                   




        <br />
           
           
                               








                  