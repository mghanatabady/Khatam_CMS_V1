<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_uniproj_eduGrroup_list_all.ascx.cs" Inherits="Manage_C_uniproj_eduGrroup_list_all" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<script type="text/javascript">
    function fnDisable(object) {
        object.disabled = 1;
        var cancelBtn = document.getElementById("<%= add_dialog_save.ClientID %>");
        cancelBtn.disabled = 1;

        return true;
    }


</script>
<script type="text/javascript" language="javascript">

    var lastPostBackId = '';

    var pageReqMan = Sys.WebForms.PageRequestManager.getInstance();

    pageReqMan.add_initializeRequest(checkSubmitButton);




    function checkSubmitButton(sender, args) {

        if (pageReqMan.get_isInAsyncPostBack() && args.get_postBackElement().id == lastPostBackId) {

            args.set_cancel(true);

        }

        else {

            lastPostBackId = args.get_postBackElement().id;

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



        
                                        <asp:BoundField DataField="title" 
                            HeaderText="عنوان" />




        
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                            <asp:ImageButton ID="btn_small_edit" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_edit.gif" 
                                                    onclick="btn_small_edit_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('ویرایش ظرفیت پروژه','ویرایش','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="ویرایش" Visible="False" />
                                            
        

                                                <asp:ImageButton ID="btn_small_del" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif" 
                                                    onclick="btn_small_del_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('حذف ظرفیت اختصاصی','حذف','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="حذف" />

                                                    
                                                <asp:ImageButton ID="btn_small_per" runat="server"  
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_users.gif"  
                        Text="اساتید"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('انقیاد اساتید و گروه آموزشی','اساتید','direction:rtl,width:170');" 
                        onclick="btn_small_group_Click"  />
                                                    

                                                    
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
            <div id="msgAdd" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                   تعریف گروه آموزشی جدید
                </div>
                <div style="background-color: White; width: 475px; display: inline-block; border-top-color: #e5e5e5;">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div7" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                عنوان<a class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                    onmouseover="return tooltip('عنوان گروه آموزشی');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_title" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                               
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="درج فیلد عنوان الزامی است" ControlToValidate="add_txt_title" ValidationGroup="add">*</asp:RequiredFieldValidator>
                         
                                
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
                            Width="88px" Font-Names="tahoma" BorderStyle="None" />
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
                    
                    
                     خطا در تعریف گروه آموزشی جدید 

                    
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
                                <span style="font-size: 9pt">عنوان گروه آموزشی تکراری است.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button7" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                            OnClick="add2_dialog_save_Click" />
                    </div>
                </div>
            </div>

            <div id="msgHaveChild" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    
                    
                     عدم امکان حذف گروه آموزشی 

                    
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
                                <span style="font-size: 9pt">با توجه به تعریف ظرفیت برای این گروه آموزشی امکان حذف آن وجود ندارد، ابتدا ظرفیت های مرتبط با این گروه آموزشی را حذف نمایید.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button25" runat="server" Text="بازگشت" Width="88px" ValidationGroup="add2" Font-Bold="true"
                            BorderStyle="None" Font-Names="tahoma"
                             />
                    </div>
                </div>
            </div>

            <div id="msgOk" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    ایجاد گروه آموزشی جدید</div>
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
                        <asp:Button ID="Button9" runat="server" Text="تایید" Width="58px" Height="31px" BackColor="#9DC023"
                            ValidationGroup="add2" Font-Bold="true" ForeColor="White" BorderStyle="Solid"
                            BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma" />
                    </div>
                </div>
            </div>
            <div id="msgError" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    ایجاد کاربر جدید
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
                        <asp:Button ID="Button12" runat="server" Text="تایید" Width="58px" Height="31px"
                            BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"
                            BorderStyle="Solid" BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma" />
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
                        <asp:Button ID="Button8" runat="server" Text="تایید" Width="88px" Height="31px"
                            ValidationGroup="add" Font-Bold="true" BorderStyle="None" Font-Names="tahoma" OnClick="add_dialog_save_Click"
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
                        <div id="Div17" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                عنوان</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_title" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
     
    
                 



                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button10" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button_filter_ok" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="if (Page_ClientValidate('filter')){   this.value = 'بروز رسانی...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
            <div id="msgDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف&nbsp;
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg3_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black"><br />
                                <span style="font-size: 9pt">آیا برای حذف گروه آموزشی با کد 
                                    <asp:Label ID="del_lbl_code" runat="server" Text="Label"></asp:Label> مطمئن هستید؟</span></span></div>
                        <br /> 
 
 


  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="Button21" runat="server" Font-Bold="true" Text="خیر" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />

                <asp:Button ID="Button22" runat="server"  Text="بله" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="del_dialog_yes_Click"
           OnClientClick = "  this.value = 'حذف...'; this.style.background = 'silver';"
           />
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

            <div style="visibility: hidden">
                        <asp:HiddenField ID="hiddenField" runat="server" />

                <asp:Button ID="Button1" runat="server" Text="Button" />
                <asp:Button ID="Button11" runat="server" Text="Button" />
                <asp:Button ID="Button111" runat="server" Text="Button" />
                <asp:Button ID="Button1111" runat="server" Text="Button" />
                <asp:Button ID="Button11111" runat="server" Text="Button" />
                <asp:Button ID="Button111111" runat="server" Text="Button" />
                <asp:Button ID="ButtonH1" runat="server" Text="Button" />
                <asp:Button ID="ButtonH2" runat="server" Text="Button" />
                <asp:Button ID="ButtonH3" runat="server" Text="Button" />
                <asp:Button ID="ButtonH4" runat="server" Text="Button" />
                <asp:Button ID="ButtonH5" runat="server" Text="Button" />
                <asp:Button ID="ButtonH6" runat="server" Text="Button" />
                <asp:Button ID="ButtonH7" runat="server" Text="Button" />
                <asp:Button ID="ButtonH8" runat="server" Text="Button" />
                <asp:Button ID="ButtonH9" runat="server" Text="Button" />



                



                <asp:Button ID="Button1112" runat="server" OnClick="Button1112_Click1" Text="Button" />
            </div>


            <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button1" PopupControlID="msgAdd">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender2" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button11" PopupControlID="msgIdentityError">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender3" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button111" PopupControlID="msgOk">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_ModalPopupExtender4" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button1111" PopupControlID="msgError">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_gridSetting" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button11111" PopupControlID="gridSetting">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_gridFilter" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="Button111111" PopupControlID="gridFilter">
            </cc1:ModalPopupExtender>
            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgDel" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH1" PopupControlID="msgDel">
            </cc1:ModalPopupExtender>



            <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgEdit" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH4" PopupControlID="msgEdit">
            </cc1:ModalPopupExtender>

                        <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgPass" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH5" PopupControlID="msgPass">
            </cc1:ModalPopupExtender>


                        <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgInfo" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH6" PopupControlID="msgInfo">
            </cc1:ModalPopupExtender>

                                    <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgStatus" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH7" PopupControlID="msgStatus">
            </cc1:ModalPopupExtender>

                                    <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msg_invoice_user" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH8" PopupControlID="msg_invoice_user">
            </cc1:ModalPopupExtender>

                        <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msg_HaveChild" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH9" PopupControlID="msgHaveChild">
            </cc1:ModalPopupExtender>


            
            
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
<br />
<br />

