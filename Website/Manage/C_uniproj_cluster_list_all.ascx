﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_uniproj_cluster_list_all.ascx.cs" Inherits="Manage_C_uniproj_cluster_list_all" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<script type="text/javascript">

    function pageLoad(sender, args) {

       //alert($("#win1").html());
        if ($("#win1").length != 0) {
            if (args.get_isPartialLoad()) {
                $("#dialog").dialog({
                    // autoOpen: false,
                    modal: true

                });
            }
        }
        else {
            $("#dialog").dialog("destroy");

        }


    }

</script>



<div style="width: 995px; float: right">


          <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
    <div style=" text-align:center ">
      <img 
    src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
    </div>
    </ProgressTemplate>
</asp:UpdateProgress>

<br />


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div style="width: 995px; margin-right: 10px; display: inline-block" id="DIV1" runat="server">
                <div title="window" style="float: right; margin-bottom: 10px">
                    <div>
                        <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_bg.gif);
                            width: 316px; background-repeat: repeat-x; height: 25px; text-align: left">
                            <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_left_bg.gif);
                                width: 11px; height: 25px">
                            </div>
                            <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/win1_right_bg.gif);
                                width: 2px; height: 25px">
                            </div>
                            <div id="Div2" style="float: right; color: #5556ab; direction: rtl; margin-right: 10px;
                                padding-top: 1px">
                                فیلتر
                            </div>
                        </div>
                        <div style="border-right: #bdc6e0 1px solid; float: left; border-left: #bdc6e0 1px solid;
                            width: 314px; border-bottom: #bdc6e0 1px solid; background-color: #f9fafd">
                            <div dir="rtl" style="margin: 6px 9px 3px 10px; width: 295px; text-align: right">
                                <div style="width: 295px">
                                    <asp:ImageButton ID="ImageButton_fillter" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_setting.gif" OnClick="ImageButton_fillter_Click1"
                                         />
                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_delete_wide.gif"
                                        OnClick="ImageButton_fillter_del_Click" />
                                    <strong>عبارت جستجو:</strong>
                                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div dir="rtl" style="width: 995px;">
                <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg.gif);
                    display: block; width: 100%; background-repeat: repeat-x; height: 48px; text-align: left">
                    <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg.gif);
                        width: 5px; height: 48px">
                    </div>
                    <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg.gif);
                        width: 5px; height: 48px">
                    </div>
                    <div style="float: right; padding-right: 10px; padding-top: 10px">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/toolbar/Addnew.gif"
                            OnClick="ImageButton1_Click1"   />
                    </div>
                    <div style="float: left; padding-right: 10px; padding-top: 10px">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_setting.gif"
                            OnClick="ImageButton2_Click1" Visible="false" />
                    </div>
                </div>
            </div>
            <div dir="rtl" style="width: 992px; border: 1px solid #AEBBC0; padding-right: 1px">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    DataKeyNames="id" DataSourceID="SqlDataSource2" SortedAscendingHeaderStyle-CssClass="sortasc-header"
                    SortedDescendingHeaderStyle-CssClass="sortdesc-header" Width="990px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
           
                     PageSize="20"

                              OnDataBound ="GridView2_OnDataBound"


                    GridLines="None" AllowPaging="True">
                    <AlternatingRowStyle CssClass="DataRowAlt" />
                    <Columns>
                  <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>

                                        <asp:BoundField DataField="uniproj_sections_title" 
                                             HeaderText="مقطع" />

        
                                        <asp:BoundField DataField="uniproj_year_title" 
                            HeaderText="سال تحصیلی" />
                        <asp:BoundField DataField="uniproj_termType_title" HeaderText="ترم" />
                        <asp:BoundField DataField="uniproj_eduGroup_title" HeaderText="گروه آموزشی" />

                        <asp:BoundField DataField="uniGroupUserId" HeaderText="کد کاربری مدیر گروه" />
                        <asp:BoundField DataField="uniGroupUserFname" HeaderText="نام مدیر گروه" />
                        <asp:BoundField DataField="uniGroupUserLname" 
                            HeaderText="نام خانوادگی مدیر گروه" />
                              <asp:BoundField DataField="capacity" 
                            HeaderText="ظرفیت" />



        
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                            <asp:ImageButton ID="btn_small_edit" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_edit.gif" 
                                                    onclick="btn_small_edit_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('ویرایش ظرفیت پروژه','ویرایش','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="ویرایش" Visible="false"  />
                                            
        

                                                <asp:ImageButton ID="btn_small_del" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif" 
                                                    onclick="btn_small_del_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('حذف ظرفیت اختصاصی','حذف','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="حذف" />

                                                <asp:ImageButton ID="btn_small_student" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_users.gif" 
                                                    onclick="btn_small_student_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('لیست دانشجویان این ظرفیت','دانشجویان','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="حذف" />
                                                    
                                                    

                                                    
                                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <SortedAscendingHeaderStyle CssClass="sortasc-header" />
                    <SortedDescendingHeaderStyle CssClass="sortdesc-header" />
                    <RowStyle HorizontalAlign="Right" BorderColor="White" BorderStyle="Solid" BorderWidth="2px"
                        CssClass="DataRow" ForeColor="#1C53A2" />
                    <EmptyDataTemplate>
                        <div dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid; border-left: red 2px solid;
                            width: 100%; border-bottom: red 2px solid; height: 45px; text-align: right; border-style: none;">
                            <div style="margin-top: 5px; float: right; width: 38px; height: 26px">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                                &nbsp;</div>
                            <div style="margin-top: 5px; float: right; width: 560px; color: red; height: 26px">
                                توجه!<br />
                                هیچ موردی برای نمایش یافت نشد.</div>
                            <br />
                        </div>
                    </EmptyDataTemplate>
                    <HeaderStyle HorizontalAlign="Right" CssClass="cell-header" BackColor="#AEBBC0" BorderStyle="None"
                        ForeColor="Black" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server"
                    SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
            </div>
            <div dir="rtl" style="width: 100%; margin-top: -13px">
                <div style="background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbarBg_footer.gif);
                    display: block; width: 100%; background-repeat: repeat-x; height: 47px; text-align: left">
                    <div style="float: left; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_left_bg_footer.gif);
                        width: 4px; height: 47px">
                    </div>
                    <div style="float: right; background-image: url(../core/themeCP/Bitrix/CssImage/toolbar/toolbar_right_bg_footer.gif);
                        width: 4px; height: 47px">
                    </div>
                    <div style="float: right; padding-right: 10px; padding-top: 10px">
                    </div>
                </div>
            </div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>

                      <div id="win1"     visible="false" runat="server" style="display:none "  ><div id="dialog" title="Basic dialog" >  <p>This is the default dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p>

                               <asp:Button ID="Button28" runat="server" Text="Button" OnClientClick="$('#win1').remove();$('#dialog').dialog('close');" OnClick="Button4_Click" />


                                                                             </div></div>




            <div id="msgAdd" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                   تعریف ترم جدید/ ظرفیت پروژه
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="row" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مقطع</div>
                            <div style="float: right; width: 200px; text-align: right; direction:rtl; ">
                                <asp:DropDownList ID="add_ddl_uniSection" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="id" 
                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                   
                                    SelectCommand="SELECT [id], [title] FROM [uniproj_sections]">
                                </asp:SqlDataSource>
                            </div>
                        </div>
                        <div id="Div3" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                سال تحصیلی</div>
                            <div style="float: right; width: 200px; text-align: right; direction:rtl; ">
                                <asp:DropDownList ID="add_ddl_year" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource4" DataTextField="title" DataValueField="id" 
                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                                
                                    SelectCommand="SELECT [id], [title] FROM [uniproj_year]">
                                </asp:SqlDataSource>
                            </div>

                        </div>
                        <div id="Div4" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نوع ترم</div>
                            <div style="float: right; width: 200px; text-align: right; direction:rtl ">
                                       <asp:DropDownList ID="add_dll_termType" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource5" DataTextField="title" DataValueField="id" 
                                           CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                                  
                                    SelectCommand="SELECT [id], [title] FROM [uniproj_termType]">
                                </asp:SqlDataSource>
                            </div>
                        </div>
                        <div id="Div5" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                گروه آموزشی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                                <asp:DropDownList ID="add_dll_EduGroupId" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource6" DataTextField="title" DataValueField="id" 
                                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                              
                                    SelectCommand="SELECT [id], [title] FROM [uniproj_eduGroup]">
                                </asp:SqlDataSource>
                                
                                </div>
                        </div>
                        <div id="Div6" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مدیر گروه</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                                         <asp:DropDownList ID="add_dll_uniGroupUserId" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource7" DataTextField="title" DataValueField="id" 
                                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                                    
                                    SelectCommand="SELECT     users.id, users.fname + ' ' + users.lname AS title  FROM         coreRoleRefUser INNER JOIN                       users ON coreRoleRefUser.idUser = users.id WHERE     (coreRoleRefUser.idRole = 10002)">
                                </asp:SqlDataSource>
                                
                                </div>
                        </div>
                        <div id="Div7" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                ظرفیت<a class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                    onmouseover="return tooltip('به صورت عددی');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_capacity" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox>
                                 <asp:RangeValidator ID="RangeValidator4" runat="server"  Type="Integer"  MinimumValue="1" MaximumValue="10000"
                                    ErrorMessage="لطفا فیلد ظرفیت را به صورت عددی و در بازه ی 1 تا 10000 وارد نمایید" 
                                    ValidationGroup="add" ControlToValidate="add_txt_capacity">*</asp:RangeValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="لطفا فیلد ظرفیت را تکمیل فرمایید" ControlToValidate="add_txt_capacity" ValidationGroup="add">*</asp:RequiredFieldValidator>
                         
                                
                                </div>
                        </div>
                 
                        <div id="Div15" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                            </div>
                            <div style="float: right; width: 300px; text-align: right; direction: rtl">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="add" />
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="msgAdd_btn_cancel" runat="server" Font-Bold="true" Text="انصراف"
                            Width="88px" Font-Names="tahoma" BorderStyle="None" BorderWidth="1px" />
                        <asp:Button ID="add_dialog_save" runat="server" Text="تایید" Width="88px" ValidationGroup="add" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                            OnClick="add_dialog_save_Click" OnClientClick=" if (Page_ClientValidate('add')){ this.value = 'ذخیره...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
            <div id="msgIdentityError" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    
                    
                     خطا در تعریف ترم جدید/ ظرفیت پروژه 

                    
                    </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px; height: 26px">
                            <span style="color: black">عملیات ناموفق<br />
                                <span style="font-size: 9pt">ترکیب مقطع - سال تحصیلی - نوع ترم و گروه آموزشی قبلا ثبت گردیده است.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button7" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                            OnClick="add2_dialog_save_Click" />
                    </div>
                </div>
            </div>

             <div id="msgHaveNotGroupUser" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    
                    
                     خطا در تعریف ترم جدید/ ظرفیت پروژه 

                    
                    </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image6" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px; height: 26px">
                            <span style="color: black">کاربر مدیر گروه یافت نگردید<br />
                                <span style="font-size: 9pt">در گروه کاربری مرتبط با مدیر گروه هیچ کاربری وجود ندارد .</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button26" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                           />
                    </div>
                </div>
            </div>

              <div id="msgHaveNotEduGroup" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    
                    
                     خطا در تعریف ترم جدید/ ظرفیت پروژه 

                    
                    </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image7" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px; height: 26px">
                            <span style="color: black">گروه آموزشی یافت نگردید<br />
                                <span style="font-size: 9pt">هیچ گروه آموزشی در سیستم وجود ندارد .</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button27" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                           />
                    </div>
                </div>
            </div>

            <div id="msgHaveChild" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    
                    
                     عدم امکان حذف ظرفیت 

                    
                    </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px; height: 26px">
                            <span style="color: black">توجه!<br />
                                <span style="font-size: 9pt">با توجه به تعریف پروژه در این ظرفیت امکان حذف آن وجود ندارد، ابتدا پروژه های مرتبط با این ظرفیت را حذف نمایید.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button25" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" BorderWidth="1px" Font-Names="tahoma"
                             />
                    </div>
                </div>
            </div>

            <div id="msgOk" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تعریف ترم جدید/ ظرفیت پروژه
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image12" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px; height: 26px">
                            <span style="color: black">عملیات موفقیت آمیز<br />
                                <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button9" runat="server" Text="تایید" Width="88px"
                            ValidationGroup="add2" Font-Bold="true" BorderStyle="None" Font-Names="tahoma" />
                    </div>
                </div>
            </div>
            <div id="msgError" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    خطا در تعریف ترم جدید/ ظرفیت پروژه
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction: rtl; text-align: right;
                            color: red; padding-top: 5px;">
                            <span style="color: black">عملیات ناموفق<br />
                                <span style="font-size: 9pt">خطای سیستمی، این خطا برای گروه پیشتیبانی ارسال گردید و
                                    در اسرع وقت به آن رسیدگی می شود.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button12" runat="server" Text="تایید" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma" />
                    </div>
                </div>
            </div>
            <div id="gridSetting" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تنظیمات لیست
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div31" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مرتب سازی بر اساس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="title" DataValueField="id"
                                    Font-Names="Tahoma">
                                    <asp:ListItem Value="code">کد</asp:ListItem>
                                    <asp:ListItem>نام</asp:ListItem>
                                    <asp:ListItem>نام خانوادگی</asp:ListItem>
                                </asp:DropDownList>
                                <asp:DropDownList ID="DropDownList3" runat="server" DataTextField="title" DataValueField="id"
                                    Font-Names="Tahoma">
                                    <asp:ListItem>صعودی</asp:ListItem>
                                    <asp:ListItem>نزولی</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div id="Div32" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                            </div>
                            <div style="float: right; width: 300px; text-align: right; direction: rtl">
                                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="add" />
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button2" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button8" runat="server" Text="تایید" Width="88px" Height="31px" BackColor="#9DC023"
                            ValidationGroup="add" Font-Bold="true" ForeColor="White" BorderStyle="Solid"
                            BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma" OnClick="add_dialog_save_Click"
                            OnClientClick=" if (Page_ClientValidate('add')){ this.value = 'ذخیره...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
            <div id="gridFilter" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    فیلتر
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div18" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_id" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>


                                          <div id="Div12" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مقطع</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                     <asp:DropDownList ID="filter_ddl_uniSection" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="id" 
                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                            
                            </div>
                        </div>

                     

                        <div id="Div17" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                سال تحصیلی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="filter_ddl_year" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource4" DataTextField="title" DataValueField="id" 
                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div id="Div19" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نوع ترم</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="filter_dll_termType" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource5" DataTextField="title" DataValueField="id" 
                                           CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div id="Div20" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                گروه آموزشی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                                                                <asp:DropDownList ID="filter_dll_EduGroup" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource6" DataTextField="title" DataValueField="id" 
                                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                                
                            </div>
                        </div>

                        <div id="Div8" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                مدیر گروه</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="filter_ddl_groupId" runat="server" Font-Names="tahoma" 
                                    DataSourceID="SqlDataSource7" DataTextField="title" DataValueField="id" 
                                                    CssClass="txt_dialog_medium_rtl">
                                </asp:DropDownList>
                            </div>
                        </div>

                                             
                

                 

                                                   <div id="Div23" style=" margin-top:10px ;  width:100%; display:inline-block  ">
  <div style=" float: right ; width : 120px ; text-align:left ; padding-left:5px"></div>
  <div style=" float: right; width : 300px ; text-align:right; direction:rtl">
      <asp:ValidationSummary ID="ValidationSummary4" runat="server" 
          ValidationGroup="filter" />
      </div>
  </div>

                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button10" runat="server" Font-Bold="true" Text="انصراف" Width="88px" Font-Names="tahoma" BorderStyle="None" />
                        <asp:Button ID="Button_filter_ok" runat="server" Text="تایید" Width="88px" Font-Bold="true" BorderStyle="None"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="if (Page_ClientValidate('filter')){   this.value = 'بروز رسانی...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
            <div id="msgDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف ظرفیت اختصاصی
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg3_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black"><br />
                                <span style="font-size: 9pt">آیا برای حذف ظرفیت اختصاص پروژه با کد 
                                    <asp:Label ID="del_lbl_code" runat="server" Text="Label"></asp:Label> مطمئن هستید؟</span></span></div>
                        <br /> 
 
 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="Button21" runat="server" Font-Bold="true" Text="خیر" Width ="88px" Font-Names="tahoma"  BorderStyle="None" BorderWidth="1px"   />

                <asp:Button ID="Button22" runat="server"  Text="بله" Width ="88px" ValidationGroup="add2" Font-Bold="true"    
          BorderStyle="None"  Font-Names="tahoma" onclick="del_dialog_yes_Click"
           OnClientClick = "  this.value = 'حذف...'; this.style.background = 'silver';"
           />
  </div>
  
  </div>
    
  

  </div>

              <div id="msgSusbend" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    مسدود نمودن / رفع مسدودی
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress5" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div36" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox9" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div37" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox10" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div38" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox11" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div39" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox12" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div40" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox13" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div41" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox14" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div42" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                فکس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox15" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div43" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox16" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button5" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button6" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

            <div id="msgActive" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                   وضعیت اعتبار ایمیل کاربر
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress6" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div44" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox17" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div45" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox18" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div46" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox19" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div47" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox20" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div48" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox21" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div49" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox22" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div50" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                فکس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox23" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div51" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox24" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button13" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button14" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

            <div id="msgEdit" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                   ویرایش اطلاعات کاربر
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress7" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                     

                        <div id="Div66" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                            </div>
                            <div style="float: right; width: 300px; text-align: right; direction: rtl">
                                <asp:ValidationSummary ID="ValidationSummary3" runat="server" ValidationGroup="add" />
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button15" runat="server" Font-Bold="true" Text="انصراف"
                            Width="58px" Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid"
                            BorderColor="#959C9D" BorderWidth="1px" />
                        <asp:Button ID="Button16" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" ValidationGroup="add" Font-Bold="true" ForeColor="White"
                            BorderStyle="Solid" BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma"
                            OnClick="add_dialog_save_Click" OnClientClick=" if (Page_ClientValidate('add')){ this.value = 'ذخیره...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>

            <div id="msgPass" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    بازنشانی و ارسال مجدد کلمه عبور
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress8" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div67" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox38" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div68" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox39" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div69" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox40" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div70" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox41" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div71" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox42" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div72" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox43" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div73" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                فکس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox44" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div74" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox45" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button17" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button18" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

            <div id="msgInfo" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    اطلاعات
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress9" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div75" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox46" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div76" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox47" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div77" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox48" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div78" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox49" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div79" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox50" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div80" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox51" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div81" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                فکس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox52" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div82" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox53" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button19" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button20" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

            <div id="msgStatus" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تغییر وضعیت
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress10" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">

                        <div id="Div24" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                وضعیت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="ddl_status" runat="server" Font-Names="tahoma">
                                <asp:ListItem Text="در انتظار پرداخت" Value="1"></asp:ListItem>
                                <asp:ListItem Text="آماده به ارسال" Value="2"></asp:ListItem>
                                <asp:ListItem Text="ارسال  شده" Value="3"></asp:ListItem>
                                <asp:ListItem Text="برگشتی" Value="4"></asp:ListItem>
                                <asp:ListItem Text="انصرافی" Value="5"></asp:ListItem>                

                                </asp:DropDownList>
                            </div>
                        </div>
                 
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button3" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button4" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_status_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

                <div id="msg_invoice_user" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    تغییر کاربر مرتبط
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress11" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">

                        <div id="Div26" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد کاربر</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="txt_msg_invoice_user_user_id" runat="server"></asp:TextBox>
                            </div>
                        </div>
                 
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button23" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button24" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="btn_msg_invoice_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>

   

            
            
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
<br />
<br />

