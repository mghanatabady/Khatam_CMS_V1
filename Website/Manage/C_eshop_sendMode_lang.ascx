<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_eshop_sendMode_lang.ascx.cs" Inherits="Manage_C_shop_sendMode_lang" %>

<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>

<br />




<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div dir="rtl" >
        
    <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
        height: 30px; text-align: left; overflow:none   ">
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/silverbar_btn_new.gif" onclick="ImageButton1_Click" />
        
        
         
        </div>
</div>

<div id="msgAdd" runat="server"  style=" width:250px ; float:right" >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        ایجاد قانون ارسال جدید
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">



              

                                 
                                        کشور
                                  <br />
                                     <asp:DropDownList ID="add_ddl_country" runat="server" 
         CssClass="txtBox" onselectedindexchanged="add_ddl_country_SelectedIndexChanged"  AutoPostBack="true"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />


                                        استان
                                  <br />
                                     <asp:DropDownList ID="add_ddl_state" runat="server" 
         CssClass="txtBox" onselectedindexchanged="add_ddl_state_SelectedIndexChanged"  AutoPostBack="true"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />

                                        شهر
                                  <br />
                                     <asp:DropDownList ID="add_ddl_city" runat="server" 
        CssClass="txtBox" onselectedindexchanged="add_ddl_city_SelectedIndexChanged"  AutoPostBack="true"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />


                                        منطقه
                                  <br />
                                     <asp:DropDownList ID="add_ddl_area" runat="server" 
         CssClass="txtBox" onselectedindexchanged="add_ddl_area_SelectedIndexChanged" 
        >
    </asp:DropDownList>
                                      <br />
                                      <br />


                                                        شیوه ارسال
                                  <br />
                                     <asp:DropDownList ID="add_ddl_sendMode" runat="server" 
         CssClass="txtBox"         >
    </asp:DropDownList>
                                      <br />
                                      <br />






                                                        هزینه حمل و نقل قبل دریافتی در فاکتور
                                  <br />
                      
                       <asp:TextBox ID="TextBox2" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>




                                      <br />
                                      <br />

                                    شرح هزینه دریافتی در فاکتور
                                  <br />
                      
                       <asp:TextBox ID="TextBox3" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="TextBox3" ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>



                                      <br />
                                      <br />


                                      هزینه حمل و نقل هنگام دریافت کالا - پس کرایه
                                  <br />
                      
                       <asp:TextBox ID="TextBox4" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="TextBox4" ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>



                                      <br />
                                      <br />

                                             شرح هزینه پس کرایه
                                  <br />
                      
                       <asp:TextBox ID="TextBox5" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ControlToValidate="TextBox5" ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>



                                      <br />
                                      <br />

                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="Button2" CssClass="Cpbtn" runat="server" Text="تایید" 
                      onclick="Button2_Click" />
								         
<asp:Button ID="Button3" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>

  <div id="msgEdit" runat="server" >
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        ویرایش شی
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">


                                        کد شی
                                  <br />
                                      <asp:Label ID="LblEditCode" runat="server" Text="Label"></asp:Label>
                                      <br />
                                      <br />


                                نوع شی
                                  <br />
                                      <asp:Label ID="LblEditType" runat="server" Text="Label"></asp:Label>
                                      <br />
                                      <br />

                                     عنوان
                                  <br />
                                          <asp:TextBox ID="txtEditTitle" runat="server" MaxLength="49" CssClass="txtBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtEditTitle" ErrorMessage="*" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="Button1" CssClass="Cpbtn" runat="server" Text="تایید" 
                      onclick="Button1_Click" />
								         
<asp:Button ID="Button6" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>

  <div id="MSG3" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid; width: 100%;
    border-bottom: red 2px solid; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با عمل حذف تمام مشخصات مرتبط با شی نیز حذف خواهد گردید، آیا برای عملیات حذف شی شماره 
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;مطمئن
        هستید؟ 
            <br />
            <asp:Button ID="Button4" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" onclick="Button4_Click" />&nbsp;<asp:Button 
            ID="Button5" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" 
            onclick="BtnCancel_Click" /><br />
            <br />
        </span>
    </div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    border-left: teal 2px solid; width: 100%; 
    border-bottom: teal 2px solid; height: 45px; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>


<div  dir="rtl"  style=" width: 100%;   ">
    &nbsp;<asp:GridView 
        ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderColor="#BDC6E0" BorderStyle="Solid" BorderWidth="1px"
        DataKeyNames="id" DataSourceID="SqlDataSource2" PageSize="50" 
        Width="100%" onselectedindexchanged="GridView2_SelectedIndexChanged"  OnRowCommand="GridView2_RowCommand" >
        <FooterStyle BackColor="#F1F3FA" />
  
        <Columns>
            <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Expr1" HeaderText="عنوان" SortExpression="Expr1" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="title" HeaderText="نوع شی" SortExpression="title" 
                HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:ButtonField Text="حذف" CommandName="del" />
            <asp:ButtonField CommandName="editcom" Text="ویرایش" />
        </Columns>
        <EmptyDataTemplate>
            <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; 
                border-left: red 2px solid; width: 100%;  border-bottom: red 2px solid;
                height: 45px; text-align: right; border-style: none;">
                <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
                <div style=" margin-top: 5px; float: right; width: 560px; color: red;
                   height: 26px">
                    توجه!<br />هیچ موردی برای نمایش یافت نشد.</div>
                <br />
            </div>
        </EmptyDataTemplate>
        <RowStyle HorizontalAlign="Right" />
              <HeaderStyle BackColor="#F1F3FA" BorderColor="#BDC6E0" 
            HorizontalAlign="Right" />
    </asp:GridView>
</div>


<p>
    &nbsp;</p>

<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
 
    
    
    SelectCommand="SELECT core_serverControlsInstance.id, core_serverControlsInstance.title AS Expr1, Dictionary_Lang.title FROM core_serverControlsInstance INNER JOIN core_serverControls ON core_serverControlsInstance.id_core_serverControl = core_serverControls.id INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary">
</asp:SqlDataSource>

    </ContentTemplate>
</asp:UpdatePanel>










