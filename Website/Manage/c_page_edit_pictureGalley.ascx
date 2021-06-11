<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_page_edit_pictureGalley.ascx.cs" Inherits="Manage_c_page_edit_pictureGalley" %>
<script type="text/javascript">

    function pageLoad(sender, args) {

        

            
                
        if (args.get_isPartialLoad()) {

         
            if ($("#pictureGallery_win1").length != 0) {
                //$(document).on('click', '#Button2', function () {
                $("#pictureGallery_dialog").dialog({
                    modal: true,
                    resizable: false,
                    /*  height: 600,*/
                    width: 495
                });
               // });

            }
            else {
                $("#pictureGallery_dialog").dialog("destroy");
            }
           
        }
    

    }
</script>





<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>



          <!--win-->
                  <div id="pictureGallery_win1"  runat="server"  visible="false"  >
                      <div id="pictureGallery_dialog" class="allDialog" title="درج تصویر جدید">                     
                                                    
                          <div id="msgActive" style="width: 475px">
             
                              
                    <asp:UpdateProgress ID="UpdateProgress6" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="../core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <div style="border: 1px solid #dce7ed; width: 450px; display: inline-block; background-color: #f5f9f9;
                        margin: 10px; padding-bottom: 20px">
                        <div id="Div44" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                عنوان تصویر</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                <asp:TextBox ID="TextBox17" CssClass="txt_dialog_medium_rtl" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div45" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                شرح</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
                                         <asp:TextBox ID="txt_tag_Description" runat="server" CssClass="txtBox" Height="60px"
                                    TextMode="MultiLine"
                                    MaxLength="10"
                                    ClientIDMode="Static"
                                    Width="300px"></asp:TextBox>
                            </div>
                        </div>
                        <div id="Div46" style="margin-top: 10px; width: 100%; display: inline-block">
                            <div style="float: right; width: 120px; text-align: left; padding-left: 5px">
                                انتخاب فایل</div>
                            <div style="float: right; width: 200px; text-align: right; direction: rtl">
             <asp:FileUpload ID="fu_tour" runat="server" />
                       
                            </div>
                        </div>
                        
                    </div>

             
                    <div style="text-align: right; padding-right: 10px; padding-bottom: 10px">
                        <asp:Button ID="Button3" runat="server" Font-Bold="true" Text="انصراف" Width="58px"
                            Height="31px" BackColor="#dfe9ec" Font-Names="tahoma" BorderStyle="Solid" BorderColor="#959C9D"
                            BorderWidth="1px" OnClientClick=" $( '.allDialog' ).dialog( 'destroy' );$('#pictureGallery_win1').remove();" />
                        <asp:Button ID="Button4" runat="server" Text="تایید" Width="88px" Height="31px"
                            BackColor="#9DC023" Font-Bold="true" ForeColor="White" BorderStyle="Solid" BorderColor="#74991A"
                            BorderWidth="1px" Font-Names="tahoma"    />
                    </div>
              
            </div>










                      </div>
                  </div>



<asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button1_Click" />

    </ContentTemplate>

</asp:UpdatePanel>













     <div dir="rtl" style="width: 100%;">
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
            <div dir="rtl" style="width: 952px; border: 1px solid #AEBBC0; padding-right: 1px">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    DataKeyNames="id" DataSourceID="SqlDataSource2" SortedAscendingHeaderStyle-CssClass="sortasc-header"
                    SortedDescendingHeaderStyle-CssClass="sortdesc-header" Width="950px" 
           
                     PageSize="20"

                              OnDataBound ="GridView2_OnDataBound"


                    GridLines="None" AllowPaging="True">
                    <AlternatingRowStyle CssClass="DataRowAlt" />
                    <Columns>
                  <asp:BoundField DataField="id" HeaderText="کد" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" HeaderStyle-HorizontalAlign="Right" >
            <HeaderStyle HorizontalAlign="Right" />
            </asp:BoundField>

                                  
        
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                            <asp:ImageButton ID="btn_small_edit" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_edit.gif" 
                                                    onclick="btn_small_edit_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('ویرایش ظرفیت پروژه','ویرایش','direction:rtl,width:100');" 
                                                    RowIndex="<%# Container.DisplayIndex %>" Text="ویرایش"   />
                                            
        

                                                <asp:ImageButton ID="btn_small_del" runat="server" 
                                                    ImageUrl="~/core/themeCP/Bitrix/CssImage/btn/btn_small_del.gif" 
                                                    onclick="btn_small_del_Click" OnClientClick="return hideTip();" 
                                                    onmouseout="return hideTip();" 
                                                    onmouseover="return tooltip('حذف ظرفیت اختصاصی','حذف','direction:rtl,width:100');" 
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