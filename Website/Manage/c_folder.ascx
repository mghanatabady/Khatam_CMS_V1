<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_folder.ascx.cs" Inherits="Manage_c_folder" %>

<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </ProgressTemplate>
</asp:UpdateProgress>

<br />




<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


    <div style=" width:995px; float:right  ; ">
       
    <div dir="rtl" style=" width: 100%; margin-top:20px; margin-bottom: 20px; float:right ">
    <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_bg.gif); width: 100%; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>

            <div style="float: left;  height: 31px" id="toolbar_newfolder" runat="server">
           <asp:LinkButton ID="ImgBtn_Newfolder" CommandArgument='<%# Eval("OrganisationID") %>' 
            CommandName="Delete" runat="server" Font-Underline="false" onclick="ImgBtn_Newfolder_Click" ForeColor="Black"  Font-Size="8pt">
            <span style=" vertical-align:middle; text-decoration: none;"> فولدر جدید</span><asp:Image ID="Image10" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/silverbar_btn_new_cat.gif" style="border-width: 0px:" ImageAlign="Middle" /> 
            </asp:LinkButton>  
            </div>


        <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>


              <div style="float: left;  height: 31px" id="Div1" runat="server">
           <asp:LinkButton ID="imgBtnAdd" CommandArgument='<%# Eval("OrganisationID") %>' 
            CommandName="Delete" runat="server" Font-Underline="false" onclick="imgBtnAdd_Click" ForeColor="Black"  Font-Size="8pt">
            <span style=" vertical-align:middle; text-decoration: none;"> فایل جدید</span><asp:Image ID="Image11" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/silverbar_btn_New_File.gif" style="border-width: 0px:" ImageAlign="Middle" /> 
            </asp:LinkButton>  
            </div>
        
                <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>

                      <div style="float: left; width: 100px; height: 31px" id="Div2" runat="server">
           <asp:LinkButton ID="ImgBtnMove" CommandArgument='<%# Eval("OrganisationID") %>' 
            CommandName="Delete" runat="server" Font-Underline="false" onclick="ImgBtnMove_Click" ForeColor="Black"  Font-Size="8pt">
            <span style=" vertical-align:middle; text-decoration: none;"> انتقال</span><asp:Image ID="Image12" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/cpButtonCut.gif" style="border-width: 0px:" ImageAlign="Middle" /> 
            </asp:LinkButton>  
            </div>

        
  
        </div>
</div>




<div id="msgAddFile" runat="server"  style=" float:right; width:995px;">
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        ایجاد فایل جدید
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">

                                                                دسته بندی موضوعی
                                  <br />
                                     <asp:DropDownList ID="DDL_ADDfilecat" runat="server" CssClass="txtBox"  Width="700px"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />

                                     عنوان
                                  <br />
                                          <asp:TextBox ID="txtNewFileName" runat="server" MaxLength="150" CssClass="txtBox"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                    ControlToValidate="txtNewFileName" ErrorMessage="*" 
                                                                    ValidationGroup="formAddFile"></asp:RequiredFieldValidator>
                                      <br />
                                      <br />
                   
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
                     <asp:Button ID="btnFileAdd" runat="server" CssClass="Cpbtn" 
                                    onclick="btnFileAdd_Click"  Text="تایید" ValidationGroup="formAddFile" />
                                &nbsp;<asp:Button ID="Button3" runat="server" CssClass="Cpbtn" 
                                    onclick="BtnCancel_Click" Text="انصراف" />
    </div></div></div></div></div></div></div></div>
  

  </div>


  <div id="msgAddFolder" runat="server"  style=" float:right; width:995px;">
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
                                                          ایجاد فولدر جدید
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">



                                دسته بندی موضوعی
                                  <br />
                                     <asp:DropDownList ID="DDL_ADDFolderCat" runat="server" CssClass="txtBox"  Width="700px"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />

                                     عنوان
                                  <br />
                                          <asp:TextBox ID="txtNewFolderName" runat="server" MaxLength="60" 
                                          CssClass="txtBox"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                          ControlToValidate="txtNewFolderName" ErrorMessage="*" 
                                          ValidationGroup="formAddFolder"></asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="Button1" CssClass="Cpbtn" runat="server" Text="تایید" 
                      onclick="btnFolderAdd_Click" ValidationGroup="formAddFolder" 
                       />
								         
<asp:Button ID="Button2" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>


  <div id="msgRenameFolder" runat="server"  style=" float:right; width:995px;">
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        تغییر نام فولدر
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">


                                     عنوان
                                  <br />
                                          <asp:TextBox ID="txtFolderRename" runat="server" MaxLength="60" 
                                          CssClass="txtBox"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                          ControlToValidate="txtFolderRename" ErrorMessage="*" 
                                          ValidationGroup="formRename"></asp:RequiredFieldValidator>
                                      <br />
                                      <br />


                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="btnFolderRename" CssClass="Cpbtn" runat="server" Text="تایید" 
                       ValidationGroup="formRename" onclick="btnFolderRename_Click" 
                       />
								         
<asp:Button ID="Button6" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>


  <div id="msgMove" runat="server"  style=" float:right; width:995px;">
                                                      <div class="CPWin1t_tb"><div class="CPWin1b_tb"><div class="CPWin1l_tb"><div class="CPWin1r_tb"><div class="CPWin1bl_tb"><div class="CPWin1br_tb"><div class="CPWin1tl_tb"><div class="CPWin1tr_tb">
        انتقال
    </div></div></div></div></div></div></div></div>
    
    <div class="CPWin1t"><div class="CPWin1b"><div class="CPWin1l"><div class="CPWin1r"><div class="CPWin1bl"><div class="CPWin1br"><div class="CPWin1tl"><div class="CPWin1tr">
                                  <div dir="rtl" style="text-align: right">



                                شاخه مقصد
                                  <br />
                                     <asp:DropDownList ID="DDL_Move" runat="server" CssClass="txtBox"  Width="700px"
        >
    </asp:DropDownList>
                                      <br />
                                      <br />

                        

                                    </div>
    </div></div></div></div></div></div></div></div>


              <div class="CPWin1t_bb"><div class="CPWin1b_bb"><div class="CPWin1l_bb"><div class="CPWin1r_bb"><div class="CPWin1bl_bb"><div class="CPWin1br_bb"><div class="CPWin1tl_bb"><div class="CPWin1tr_bb">
        
               <asp:Button ID="btnMove" CssClass="Cpbtn" runat="server" Text="تایید" onclick="btnMove_Click" 
                       />
								         
<asp:Button ID="Button5" CssClass="Cpbtn" runat="server" Text="انصراف" onclick="BtnCancel_Click" />

    </div></div></div></div></div></div></div></div>
  

  </div>

<div id="MsgDelVirtual" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid;  float:right; width:990px;
    border-bottom: red 2px solid; text-align: right; margin-top:10px; margin-bottom:10px">
    <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif"  />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">آیا برای عمل حذف مطمئن هستید؟
        <br />
            <br />
            <asp:Button ID="BtnVirtualDel" runat="server" Font-Names="Tahoma" 
            Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" 
            onclick="BtnVirtualDel_Click"  />&nbsp;<asp:Button 
            ID="Button7" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" 
            onclick="BtnCancel_Click" /><br />
            <br />
        </span>
    </div>
    <br />
</div>


  <div id="MsgDel" runat="server" dir="rtl" 
            style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid;  float:right; width:990px;
    border-bottom: red 2px solid; text-align: right; margin-top:10px; margin-bottom:10px; border-color: #C0C0C0;">
    <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px;  width: 493px; color: red;
        padding-top: 5px">
        اخطار!<br />
        <span style="font-size: 9pt">با حذف شاخه تمام زیر مجموعه ها و محتوای صفحات آنها پاک می گردند آیا برای عمل حذف مطمئن هستید؟
            <br />
            <br />
            <asp:Button ID="btnDel" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" onclick="btnDel_Click"  />&nbsp;<asp:Button 
            ID="Button8" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" 
            onclick="BtnCancel_Click" /><br />
            <br />
        </span>
    </div>
    <br />
</div>

  <div id="MsgUnDel" runat="server" dir="rtl" 
            
            style="border-right: red 2px solid; border-top: red 2px solid;
    border-left: red 2px solid;  float:right; width:990px;
    border-bottom: red 2px solid; text-align: right; margin-top:10px; margin-bottom:10px; border-color: #0066FF;">
    <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
        <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px;  width: 493px; padding-top: 5px">
        توجه!<br />
        <span style="font-size: 9pt">برای باز گرداندن فایل های انتخابی مطمئن هستید؟
            <br />
            <br />
            <asp:Button ID="btnUnDel" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                 Width="42px" onclick="btnUnDel_Click"   />&nbsp;<asp:Button 
            ID="Button10" runat="server"
                    Font-Names="Tahoma" Height="24px" Text="انصراف" Width="60px" 
            onclick="BtnCancel_Click" /><br />
            <br />
        </span>
    </div>
    <br />
</div>




<div id="MsgOK" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    border-left: teal 2px solid; width: 100%; 
    border-bottom: teal 2px solid; height: 45px; text-align: right; margin-top:10px">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>


<div id="tree" style=" float:right; text-align:right; width:299px; direction: rtl;">
    <asp:TreeView ID="OtreeView" runat="server" 
        onselectednodechanged="OtreeView_SelectedNodeChanged">
    </asp:TreeView>
    </div> 
<div id="divFolder" 
        style="float:right; width:696px; direction: rtl; text-align: right;">
        

         <div style="padding: 5px 10px 5px 10px; border: 1px solid #bdc6e0; width: 674px; height: 20px; background-color: #f1f3fa; text-align: right;">
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       </div>


 
    <asp:GridView ID="GridFolder" runat="server" AutoGenerateColumns="False" 
             GridLines="None" PageSize="5" 
        ShowHeader="False" Width="696px" 
        CellPadding="4" ForeColor="#333333" BorderColor="#BDC6E0" BorderStyle="Solid" 
             BorderWidth="1px"  OnRowCommand="GridFolder_RowCommand" onselectedindexchanged="GridFolder_SelectedIndexChanged" 
             >
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField >
                <ItemStyle Width="30px" />
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id" />
            <asp:TemplateField>
                <ItemStyle Width="22px" />
            </asp:TemplateField>
            <asp:ButtonField ButtonType="Image" CommandName="rename_cmd" 
                ImageUrl="../core/themeCP/Bitrix/CssImage/btn/file_rename.gif" Text="تغییر نام">
            <ItemStyle Width="20px" />
            </asp:ButtonField>
            <asp:TemplateField>
                <ItemStyle Width="20px" />
                <ItemTemplate>
                    <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Folder_Icon.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemStyle Width="595px" />
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Overline="False" 
                        Font-Underline="False" ForeColor="#2747BF" 
                        NavigateUrl='<%# Eval("id", "default.aspx?mode=folder&cat={0}") %>' 
                        Text='<%# Eval("cname") %>'></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
        <HeaderStyle BackColor="#507CD1" BorderColor="#BDC6E0" Font-Bold="True" 
            ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle    />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    
    </asp:GridView>
    <div style="width: 694px">
        <asp:ImageButton ID="btn_end" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/paging/btn_end.jpg" 
            onclick="btn_end_Click" />
        <asp:ImageButton ID="btn_next" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/paging/btn_next.jpg" 
            onclick="btn_next_Click" style="width: 18px" />
        &nbsp;
        <asp:Label ID="lblPage" runat="server" Text="1"></asp:Label>
        &nbsp;<asp:ImageButton ID="btn_back" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/paging/btn_back.jpg" 
            onclick="btn_back_Click" />
        <asp:ImageButton ID="btn_first" runat="server" 
            ImageUrl="~/core/themeCP/Bitrix/CssImage/paging/btn_first.jpg" 
            onclick="btn_first_Click" />
        &nbsp;| تعداد سطر
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem Selected="True">20</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>100</asp:ListItem>
        </asp:DropDownList>
    </div>
 


    <asp:GridView ID="GV_File" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="id" PageSize="5" 
        ShowHeader="False" Width="696px" CellPadding="4" ForeColor="#333333" 
            GridLines="None" BorderColor="#BDC6E0" BorderStyle="Solid" 
        BorderWidth="1px" onselectedindexchanged="GV_File_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemStyle Width="30px" />
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id" />
            <asp:TemplateField>
                <ItemStyle Width="22px" />
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemStyle Width="20px" />
                <ItemTemplate>
                    <asp:Image ID="Image4" runat="server" ImageUrl="../core/themeCP/Bitrix/CssImage/icon/File_icon.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemStyle Width="20px" />
                <ItemTemplate>
                    <asp:Image ID="Image7" runat="server" 
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/EnableIcon.gif" 
                        Visible='<%# Eval("Enable") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
            <ItemStyle Width="20px" />
                <ItemTemplate>
                    <asp:Image ID="Image8" runat="server" 
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/Valid.gif" 
                        Visible='<%# Eval("Valid") %>' />
                </ItemTemplate>
            </asp:TemplateField>



                     <asp:TemplateField>
            <ItemStyle Width="20px" />
                <ItemTemplate>
                    <asp:Image ID="Image9" runat="server" 
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/DeleteIcon.gif" 
                        Visible='<%# Eval("deleted") %>' />
                </ItemTemplate>
            </asp:TemplateField>





            <asp:TemplateField>
                <ItemStyle Width="495px" />
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Overline="False" 
                        ForeColor="#2747BF" 
                        NavigateUrl='<%# Eval("table_name","~/manage/default.aspx?mode=page_edit&") + Eval("id","id={0}" ) %>' 
                        Text='<%# Eval("cname") %>'></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
         
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BorderColor="#BDC6E0" BackColor="#507CD1" Font-Bold="True" 
            ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle  />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
   
    </asp:GridView>




        <br />
 
 <div style="border: 1px solid #bdc6e0; width: 694px; height: 30px; background-color: #f1f3fa">
        <div style="float: right; width: 30px; height: 33px">
        </div>
        <div style="float: right; width: 42px; height: 33px">
        </div>
        <div style="float: right; width: 216px; height: 15px">
         

                    <div style="margin-top: 5px;
                width: 25px; height: 21px; float: right;">
                <asp:ImageButton ID="Img_Btn_DelVirtual" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/delBTNred.gif"
                    ToolTip="حذف" onclick="Img_Btn_DelVirtual_Click" Visible="False"  /></div>

                       <div style="margin-top: 5px;
                width: 25px; height: 21px; float: right;">
                <asp:ImageButton ID="Img_Btn_Del" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/delBTNblack.gif"
                    ToolTip="حذف قطعی" onclick="Img_Btn_Del_Click" style="width: 20px" Visible="False" /></div>

                    <div style="margin-top: 5px;
                width: 25px; height: 21px; float: right;">
                <asp:ImageButton ID="Img_Btn_UnDel" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/undelete.gif"
                    ToolTip="بازگردانی فایل حذف شده" onclick="Img_Btn_UnDel_Click" style="width: 20px" 
                            Visible="False" /></div>
        </div>

        <asp:Label ID="Label2" runat="server"></asp:Label>

    </div>
    <br /><br /><br /><br /><br /><br />
    </div>
</div>

<br /><br /><br /><br /><br /><br />
    </ContentTemplate>
</asp:UpdatePanel>
