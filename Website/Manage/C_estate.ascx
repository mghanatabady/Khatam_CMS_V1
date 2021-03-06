<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_estate.ascx.cs" Inherits="Manage_C_estate" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>


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
                                    <asp:ImageButton ID="ImageButton_fillter" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_setting.gif"
                                        OnClick="ImageButton_fillter_Click" />
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
                            OnClick="ImageButton1_Click1" />
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
                    SortedDescendingHeaderStyle-CssClass="sortdesc-header" Width="990px" 
                 
                    OnRowDataBound="GridView2_RowDataBound" PageSize="20"
                    GridLines="None" AllowPaging="True">
                    <AlternatingRowStyle CssClass="DataRowAlt" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" HeaderStyle-HorizontalAlign="Right">
                            <HeaderStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="email" HeaderText="نام کاربری" SortExpression="email"
                            HeaderStyle-HorizontalAlign="Right">
                            <HeaderStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fname" HeaderText="نام" SortExpression="fname" />
                        <asp:BoundField DataField="lname" HeaderText="نام خانوادگی" SortExpression="lname" />
                        <asp:BoundField DataField="company" HeaderText="شرکت" SortExpression="company" />
                        <asp:BoundField DataField="tel" HeaderText="تلفن" SortExpression="tel" />
                        <asp:BoundField DataField="cellphone" HeaderText="موبایل" SortExpression="cellphone" />
                        <asp:ButtonField Text="حذف" CommandName="del" Visible="False" />
                        <asp:ButtonField CommandName="editcom" Text="ویرایش" Visible="False" />                        


            <asp:TemplateField>

                                            <ItemTemplate>
        
                        <asp:ImageButton ID="btn_small_per" runat="server"  
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_per.gif"  
                        Text="پرمیشن ها"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('تنظیم دسترسی های کاربر','پرمیشن ها','direction:rtl,width:170');" 
                        onclick="btn_small_per_Click"  />

                        <asp:ImageButton ID="btn_small_del" runat="server"  
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif"  
                        Text="حذف"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('حذف کاربر','حذف','direction:rtl,width:100');" 
                        onclick="btn_small_del_Click"  />

                        <asp:ImageButton ID="btn_small_Announcement" runat="server"  
                        ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_Announcement.gif"  
                        Text="پیام"   RowIndex='<%# Container.DisplayIndex %>'  
                        onmouseout="return hideTip();"
                        OnClientClick="return hideTip();"   
                        onmouseover="return tooltip('نوشتن پیام برای نمایش در کنترل پنل کاربر','پیام','direction:rtl,width:100');" 
                        onclick="btn_small_Announcement_Click"  />             



                </ItemTemplate>
                <ItemStyle Width="120px" />
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
            <div id="msgAdd"  style="width: 475px">
                            <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    ایجاد کاربر جدید
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
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right;">
                                <asp:TextBox ID="add_txt_fname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div3" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                    ControlToValidate="add_txt_lname" ValidationGroup="add" ErrorMessage="لطفا نام خانوادگی را درج نمایید">*</asp:RequiredFieldValidator></div>
                            <div style="float: right; width: 200px; text-align: right">
                                <asp:TextBox ID="add_txt_lname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>

                        <div id="add_div_teacher_code" runat="server"  style="margin-top: 10px; width: 100%; display: inline-block" visible="false" >
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کد استاد</div>
                            <div style="float: right; width: 200px; text-align: right">
                                <asp:TextBox ID="add_txt_teacher_code" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>

                        <div id="Div4" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت / موسسه</div>
                            <div style="float: right; width: 200px; text-align: right">
                                <asp:TextBox ID="add_txt_company" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>


                        <div id="Div5" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن<a class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                    onmouseover="return tooltip('همراه با کد شهر');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_tel" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div6" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                فکس<a class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                    onmouseover="return tooltip('همراه با کد شهر');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_fax" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div7" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل<a class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                    onmouseover="return tooltip('به صورت 11 رقمی مانند: 09127710277');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_cellphone" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div8" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کشور</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_country" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div9" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                استان / ایالت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_stats" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div10" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شهر</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_city" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div11" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                آدرس</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_address" CssClass="txt_dialog_large_rlt" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div12" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کدپستی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_zipcode" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div13" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                ایمیل<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="add_txt_email"
                                    ValidationGroup="add" ErrorMessage="لطفا ایمیل کاربر را درج نمایید">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                
                                    ValidationGroup="add" 
                                  Text = "*"  ValidationExpression ="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"   ErrorMessage="لطفا ایمیل را به صورت صحیح درج کنید" 
                  ControlToValidate="add_txt_email"
                                
                                ></asp:RegularExpressionValidator>
                                    
                                    <a
                                        class="tooltipA" href="#" onclick="return false;" onmouseout="return hideTip();"
                                        onmouseover="return tooltip('ایمیل معتبر');">[?]</a></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_email" CssClass="txt_dialog_medium_ltr" runat="server"></asp:TextBox></div>
                        </div>
                        <div id="Div14" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                کلمه عبور<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="add_txt_password" ValidationGroup="add" ErrorMessage="لطفا کلمه عبور را درج نمایید">*</asp:RequiredFieldValidator></div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="add_txt_password" CssClass="txt_dialog_medium_ltr" TextMode="Password"
                                    runat="server"></asp:TextBox></div>
                 

                        </div>

                                   <div id="Div23" style="margin-top: 10px; width: 100%; display: inline-block">
                    
                            <div style="float: right; width: 400px; padding-right:125px; text-align: right; direction: rtl">
                                <asp:CheckBox ID="add_chbox_sendPassword" Checked="true"  Text="همراه با ایمیل فعال سازی کلمه عبور نیز ارسال شود" runat="server" />
                               </div>
                        </div>

                        <div id="Div16" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                گروه کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
                                    DataTextField="title" DataValueField="id" Font-Names="Tahoma">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server">
                                </asp:SqlDataSource>
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
                            Width="58px" Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid"
                            BorderColor="#959C9D" BorderWidth="1px" />
                        <asp:Button ID="add_dialog_save" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" ValidationGroup="add" Font-Bold="true" ForeColor="White"
                            BorderStyle="Solid" BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma"
                            OnClick="add_dialog_save_Click" OnClientClick=" if (Page_ClientValidate('add')){ this.value = 'ذخیره...'; this.style.background = 'silver';};" />
                    </div>
                </div>
            </div>
            <div id="msgIdentityError" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    ایجاد کاربر جدید
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
                                <span style="font-size: 9pt">ایمیل وارد شده تکراری است.</span></span></div>
                        <br />
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button7" runat="server" Text="بازگشت" Width="58px" Height="31px"
                            BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"
                            BorderStyle="Solid" BorderColor="#74991A" BorderWidth="1px" Font-Names="tahoma"
                            OnClick="add2_dialog_save_Click" />
                    </div>
                </div>
            </div>
            <div id="msgOk" style="width: 475px">
                <div style="background-color: #e2ebee; color: #282a2c; font-weight: bold; cursor: default;
                    height: 30px; padding: 10px; font-size: 12pt; text-align: right; border-bottom-style: solid;
                    border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
                    ایجاد کاربر جدید
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
                        <div id="Div17" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام کاربری</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_email" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div19" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_fname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div20" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                نام خانوادگی</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_lname" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div21" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرکت</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_company" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div22" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                تلفن</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_tel" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                              <div id="Div24" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                موبایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="filter_txt_cellphone" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button10" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" />
                        <asp:Button ID="Button_filter_ok" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma" OnClick="Button_filter_ok_Click" OnClientClick="  this.value = 'بروز رسانی...'; this.style.background = 'silver';" />
                    </div>
                </div>
            </div>
            <div id="msgDel"   style=" width:475px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        حذف کاربر
  </div>

  <div style=" background-color:White ;  width:475px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :450px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
               <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg3_icon1.gif" />
                            &nbsp;</div>
                        <div style="padding-right: 5px; margin-top: 5px; float: right; direction:rtl ; text-align:right  ; color: red;
                            padding-top: 5px; height: 26px">
                            <span style="color: black">تایید برای حذف<br />
                                <span style="font-size: 9pt">آیا برای حذف نام کاربری کد 
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
 

 <div id="msgAnnouncement"   style=" width:875px   "  >
  <div  style=" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;">
        پیام برای نمایش در کنترل پنل - کاربر 
      <asp:Label ID="msgAnnouncement_lbl_id" runat="server" Text="Label"></asp:Label>
      <asp:Label ID="msgAnnouncement_lbl_titleRealname" runat="server" Text="Label"></asp:Label>
  </div>

  <div style=" background-color:White ;  width:875px ; display:inline-block  ; border-top-color: #e5e5e5;">
  
    <div style=" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin:10px ; padding-bottom:20px">
  
 
 
                         <div dir="rtl" style="text-align: right">
                              	<CKEditor:CKEditorControl ID="CKEditor1" runat="server" Height="200"   FilebrowserBrowseUrl="../core/ckfinder/ckfinder.html"  BasePath="~/core/ckeditor" TemplatesFiles="~/core/ckeditor/plugins/templates/templates/default.js"></CKEditor:CKEditorControl>
                        </div>
     

  </div>

  <div style=" text-align:right ; padding-right:10px ; padding-bottom:10px ">
      


        <asp:Button ID="msgAnnouncement_cancel" runat="server" Font-Bold="true" Text="انصراف" Width ="58px" 
          Height="31px" BackColor="#dfe9ec" Font-Names="tahoma"  BorderStyle="Solid" 
          BorderColor="#959C9D" BorderWidth="1px"   />

                <asp:Button ID="msgAnnouncement_ok" runat="server"  Text="تایید" Width ="58px" 
          Height="31px" BackColor="#9DC023" ValidationGroup="add2" Font-Bold="true" ForeColor="White"    
          BorderStyle="Solid" BorderColor="#74991A" 
          BorderWidth="1px"  Font-Names="tahoma" onclick="msgAnnouncement_ok_Click"
           OnClientClick = "  this.value = 'بروز رسانی...'; this.style.background = 'silver';"
           />
  </div>
  
  </div>
    
  

  </div>


          

            <div style="visibility: hidden">
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




                <asp:Button ID="Button1112" runat="server" OnClick="Button1112_Click1" Text="Button" />
            </div>
            <cc1:ModalPopupExtender ID="UpdatePanel1_msgAnnouncement" runat="server" BackgroundCssClass="ModalPopupBG"
                DynamicServicePath="" Enabled="True" TargetControlID="ButtonH7" PopupControlID="msgAnnouncement">
            </cc1:ModalPopupExtender>

            

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





            
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
<br />
<br />
