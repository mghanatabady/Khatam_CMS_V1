<%@ Control Language="C#" AutoEventWireup="true" CodeFile="c_shopcart.ascx.cs" Inherits="c_shopcart" %>

<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
    <div style=" text-align:center">
        <asp:Image ID="imgLoading" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/ajax/loading1.gif" />
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>


<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>



    <table style=" border: 1px solid #aaaaaa; width:944px">
        <tr>
       
            <td width="120px" 
                
                style=" padding-right:10px ;font-size:9pt;background-color: #edeff7; border-width: 1px; border-color: #abb6d7; border-style: solid" 
                valign="top">
                    <br />
                <asp:Label ID="LinkButton1" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="سبد خرید"></asp:Label>    
    <br />
    <br />
          <asp:Label ID="LinkButton2" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="لاگین"></asp:Label>    
    <br />
    <br />
          <asp:Label ID="LinkButton3" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="محدوده جغرافیایی"></asp:Label>    
    <br />
    <br />
          <asp:Label ID="LinkButton4" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="شیوه های ارسال"></asp:Label>    
    <br />
    <br />
          <asp:Label ID="LinkButton5" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="اطلاعات ارسال"></asp:Label>    
    <br />
    <br />
              <asp:Label ID="LinkButton6" ForeColor="#000000" Font-Bold="true"  runat="server"  Text="تایید نهایی"></asp:Label>    
    <br />
    <br />
</td>
                     <td style="background-color: #f8f9fc" valign="top" width="804px"   >
                         <div id="tab1" runat="server" style=" padding:10px; font-size:9pt; "   >
                                            <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" 
                                                CssClass="col2" GridLines="None" OnRowCommand="gv1_RowCommand" 
                                                OnSelectedIndexChanged="gv1_SelectedIndexChanged" Width="750px" 
                                                CellPadding="4" ForeColor="#333333" BorderColor="#ABB6D7" 
                                                BorderStyle="Solid" BorderWidth="1px" >
                                                <AlternatingRowStyle BackColor="White" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="ردیف" />
                                                    <asp:BoundField DataField="catid" HeaderText="کد" />
                                                    <asp:BoundField DataField="productname" HeaderText="شرح کالا / خدمات"  />
                                                    <asp:BoundField DataField="quantity" HeaderText=" تعداد" />
                                                    <asp:BoundField DataField="price" HeaderText="قیمت" />
                                                    <asp:BoundField DataField="sum" HeaderText="جمع" />
                                                    <asp:ButtonField CommandName="quantity" Text="تغییر تعداد" Visible="False" />
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <span style="font-family: Tahoma">
                                                            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Tahoma" Width="18px"></asp:TextBox>
                                                            <asp:Button ID="Button3" runat="server" BackColor="#36B701" 
                                                                BorderColor="#AACCEE" CssClass="button" Font-Names="Tahoma" Font-Size="8pt" 
                                                                ForeColor="White" Height="20px" OnClick="Button3_Click" Text="تایید" 
                                                                Width="26px" />
                                                            <asp:Button ID="Button2" runat="server" BackColor="#36B701" 
                                                                BorderColor="#AACCEE" CssClass="button" Font-Names="Tahoma" Font-Size="8pt" 
                                                                ForeColor="White" Height="20px" OnClick="Button2_Click1" Text="لغو" 
                                                                Width="24px" />
                                                            </span>
                                                        </ItemTemplate>
                                                        <HeaderStyle BorderStyle="None" />
                                                    </asp:TemplateField>
                                                    <asp:ButtonField CommandName="del" Text="حذف" />
                                                  

                                                    
                                      

                                                </Columns>
                                                <EditRowStyle BackColor="#2461BF" />
                                                <EmptyDataTemplate>
                                                    هیچ کالایی در سبد خرید شما یافت نگردید.
                                                </EmptyDataTemplate>
                                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#507CD1" BorderColor="#003300" BorderStyle="Solid" 
                                                    BorderWidth="1px" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                            </asp:GridView>
                                            <br />

                                                <span style="font-family: Tahoma">
                                    <br />
                                    مجموع مبالغ:</span>
                                <asp:Label ID="lbl_totalPrice" runat="server" Font-Names="Tahoma" 
                             Font-Size="12pt" ForeColor="Black"
                                    Text="0" style="font-weight: 700"></asp:Label>
                                <span style="font-family: Tahoma">ریال<br />                                          
                                    <br />
                                </span>

                               


                                <span style="font-family: Tahoma">
                                   
                                    جمع مبلغ کالای فیزیکی:</span>
                                <asp:Label ID="lbl_totalPrice_phisical" runat="server" Font-Names="Tahoma" Font-Size="12pt" ForeColor="Black"
                                    Text="0"></asp:Label>
                                <span style="font-family: Tahoma">ریال<br />                                          
                                    <br />
                                </span>

                                  <span style="font-family: Tahoma">
                                 
                                    جمع مبلغ کالای مجازی:</span>
                                <asp:Label ID="lbl_totalPrice_virtual" runat="server" Font-Names="Tahoma" Font-Size="12pt" ForeColor="Black"
                                    Text="0"></asp:Label>
                                <span style="font-family: Tahoma">ریال<br />                                          
                                    <br />
                                </span>

                                  <div id="div_totalweight" runat="server">
                                <span style="font-family: Tahoma">
                                         مجموع وزن:</span>
                                <asp:Label ID="lbl_totalweight" runat="server" Font-Names="Tahoma" Font-Size="12pt" ForeColor="Black"
                                    Text="0"></asp:Label>
                                <span style="font-family: Tahoma">گرم<br />
                                    <br />
                                </span>
                              </div>


                              
                             

                                         
                               
                               <br />

                          
                                
                                <blockquote id="div_msg_session" runat="server">

        <span style="font-size: 11px; font-family: Tahoma; color:Black;">مدت زمان نگهداری سبد خرید شما در
            سیستم 60 دقیقه می باشد، لطفا برای انجام ادامه مراحل خرید روی دکمه مرحله بعدی کلیک کنید.</span>
</blockquote>            




                                            <asp:Button ID="Button1"  runat="server" Text="مرحله بعدی" 
                   onclick="LinkButton2_Click" CssClass="button1" BorderStyle="Solid"  />

                                          


                                </div>   
                                              
                
                           
                            
                                      

                                              <div id="tab2" runat="server" style=" padding:10px; font-size:9pt"   >
                  <asp:PlaceHolder ID="Ph_login" runat="server"></asp:PlaceHolder>
                                            </div>

                                            <div id="tab3" runat="server" style=" padding:10px; font-size:9pt"  >
                                               <div id="rows" runat="server">
                        <div class="row">
                            <div class="field">
                                 کشور:</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_country" runat="server" DataSourceID="SqlDataSource1" 
                                    DataTextField="title" DataValueField="country_id" Font-Names="tahoma">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                   
                                    SelectCommand="SELECT core_country.country_id, Dictionary_Lang.title FROM Dictionary_Lang INNER JOIN core_country ON Dictionary_Lang.id_dictionary = core_country.dictionary_id WHERE (core_country.country_id = 104) AND (Dictionary_Lang.id_language = 1)">
                                </asp:SqlDataSource>
                            </div>
                        </div>

                    

                        <div class="row">
                            <div class="field">
                                استان / ایالت:</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_state" runat="server" 
                                    DataSourceID="SqlDataSource2" DataTextField="title" 
                                    DataValueField="country_state_id" Font-Names="Tahoma" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                  
                                    SelectCommand="SELECT Dictionary_Lang.title, core_country_state.country_state_id FROM core_country_state INNER JOIN Dictionary_Lang ON core_country_state.dictionary_id = Dictionary_Lang.id_dictionary WHERE (core_country_state.country_country_id = 104)">
                                </asp:SqlDataSource>
                            </div>
                        </div>

                             <div class="row">
                            <div class="field">
                                شهر / شهرستان:</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_city" runat="server" 
                                    DataSourceID="SqlDataSource3" DataTextField="title" 
                                    DataValueField="country_state_city_id" Font-Names="Tahoma">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                   
                                    SelectCommand="SELECT core_country_state_city.country_state_city_id, Dictionary_Lang.title FROM core_country_state_city INNER JOIN Dictionary_Lang ON core_country_state_city.dictionary_id = Dictionary_Lang.id_dictionary WHERE (core_country_state_city.country_state_id = @stateid)">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="ddl_state" Name="stateid" 
                                            PropertyName="SelectedValue" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div>
                        </div>

                                <div class="row" style= " display:none">
                            <div class="field">
                                منطقه / بخش:</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="DropDownList4" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                   
                    </div>
                                                
                    <br />

                          <asp:Button ID="Button3"  runat="server" Text="مرحله بعدی" 
                   onclick="LinkButton3_Click" CssClass="button1" BorderStyle="Solid"  />
                                            
                                            </div>

                                              <div id="tab4" runat="server" style=" padding:10px; font-size:9pt"  >
                                           








                                            <div id="stylized" class="myform">
          
 <h1>شیوه های ارسال سفارش</h1>
 <p>لطفا فرم ذیل را با دقت کامل نمایید:</p>




       <div id="selectSendMode1" class="selectSendMode" style="width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden" >

 <div class="icon"  >
     <asp:Image ID="Image1" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/sendMode/pishtaz.jpg" />
</div>
<div class="memo" >
<strong>پست پیشتاز</strong><br />
    ارسال توسط پست پیشتاز و پرداخت الکترونیک یا واریز فیش بانکی<br />
    مرسولات سفارشی معمولا بین 48 ساعت تا 72 ساعت توزیع می شوند
    <br />
    +کد رهگیری  وضعیت مرسوله
    <br />

هزینه پست پیشتاز:
<strong>
    <asp:Label ID="lbl_sendmode1" runat="server" Text="Label"></asp:Label></strong> ریال 
 </div>
<div style="  float:right;" >
    <asp:Button ID="btnSendMode1" CssClass="btnSelect" runat="server" Text="انتخاب" 
        onclick="btnSendMode1_Click" />

<!--        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);-->

      </div></div>

       <div id="selectSendMode10" class="selectSendMode" style="width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden" >

 <div class="icon"  >
     <asp:Image ID="Image5" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/sendMode/sefareshi.gif" />
</div>
<div class="memo" >
<strong>پست سفارشی</strong><br />
    ارسال توسط پست سفارشی  و پرداخت الکترونیک یا واریز فیش بانکی<br />
    <br />
    مرسولات سفارشی معمولا بین 3 تا 5 روز توزیع می گردند
        <br />
    +کد رهگیری  وضعیت مرسوله
    <br />
هزینه پست سفارشی:

<strong>
    <asp:Label ID="lbl_sendmode10" runat="server" Text="Label"></asp:Label></strong> ریال 
 </div>
<div style="  float:right;" >
    <asp:Button ID="Button4" CssClass="btnSelect" runat="server" Text="انتخاب" 
        onclick="btnSendMode10_Click" />

<!--        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);-->

      </div></div>

       
       <div id="selectSendMode2" runat="server" class="selectSendMode" style="width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden" >

 <div class="icon"  >
     <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/sendMode/iranmc.jpg" />
</div>
<div class="memo" >
<strong>ایران مارکت سنتر</strong><br />
ارسال توسط سیستم ایران مارکت سنتر و پرداخت وجه به مامور پست
<br />
هزینه ارسال:
<strong>    <asp:Label ID="lbl_sendmode2" runat="server" Text="Label"></asp:Label></strong> ریال 
</strong>
 </div>
<div style="  float:right;" >
    <asp:Button ID="btnSendMode2" CssClass="btnSelect" runat="server" Text="انتخاب" 
        onclick="btnSendMode2_Click" />

<!--        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);-->

      </div></div>




      <div id="selectSendMode3" runat="server" class="selectSendMode" style="width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden" >

 <div class="icon"  >
     <asp:Image ID="Image3" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/sendMode/bus.jpg" />
</div>
<div class="memo" >
<strong>ترمینال اتوبوس رانی</strong><br />
ارسال توسط ناوگان اتوبوس مسافربری بین شهری، تحویل در ترمینال، پرداخت هزینه صورتحساب الکترونیک یا فیش بانکی 
<br />
هزینه ارسال: 
<strong>پس کرایه + هزینه حمل تا ترمینال <asp:Label ID="lbl_sendmode3_by_agent" 
        runat="server"></asp:Label> ریال 
    </strong>
 </div>
<div style="  float:right;" >
    <asp:Button ID="btnSendMode3" CssClass="btnSelect" runat="server" Text="انتخاب" 
        onclick="btnSendMode3_Click" />

<!--        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);-->

      </div></div>



            <div id="selectSendMode4" runat="server" class="selectSendMode" style="width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden" >

 <div class="icon"  >
     <asp:Image ID="Image4" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/sendMode/cmc.jpg" />
</div>
<div class="memo" >
<strong>آژانس / پیک موتوری</strong><br />
ارسال توسط پیک موتوری یا آژانس - قبل از ارسال مرسوله هزینه ارسال به اطلاع شما خواهد رسید و پس از تایید ارسال می گردد، پرداخت هزینه صورتحساب به صورت الکترونیک یا فیش بانکی می باشد.
<br />
هزینه ارسال: 
<strong>پس کرایه</strong>
 </div>
<div style="  float:right;" >
    <asp:Button ID="btnSendMode4" CssClass="btnSelect" runat="server" Text="انتخاب" 
        onclick="btnSendMode4_Click" />

<!--        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);-->

      </div></div>







                                            </div>
                                            </div>

                                                 <div id="tab5" runat="server" style=" padding:10px; font-size:9pt"  >
                                                 
                                               <div id="rows2" runat="server">
                                               <div id="div_Address"  runat="server">
                        <div class="row">
                            <div class="field"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txt_address" runat="server" Text="*" 
                                    ErrorMessage="لطفا آدرس محل تحویل را درج نمایید"  ValidationGroup="sendInfo"></asp:RequiredFieldValidator>
                                آدرس محل تحویل:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_address" runat="server" Width="200px" Height="45px" Font-Names="tahoma" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>

                      <div class="row">
                            <div class="field">
                                کدپستی محل تحویل:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_ZipCode" runat="server"  Font-Names="tahoma" ></asp:TextBox>
                            </div>
                        </div>
                        </div>

                          <div class="row">
                            <div class="field">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txt_tel" runat="server" Text="*" 
                                    ErrorMessage="لطفا تلفن ثابت تحویل گیرنده را درج نمایید"  ValidationGroup="sendInfo"></asp:RequiredFieldValidator>تلفن ثابت تحویل گیرنده:</div>
                            <div class="fieldInputArea">
                        
                                <asp:TextBox ID="txt_tel" runat="server" Font-Names="tahoma" ></asp:TextBox>
                                    
                            </div>
                        </div>

                           <div class="row">
                            <div class="field">  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txt_cellPhone" runat="server" Text="*" 
                                    ErrorMessage="لطفا موبایل تحویل گیرنده را درج نمایید"  ValidationGroup="sendInfo"></asp:RequiredFieldValidator>
                                موبایل تحویل گیرنده:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_cellPhone" runat="server" Font-Names="tahoma"  ></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">
                            <div class="field">
                                پیام:</div>
                            <div class="fieldInputArea">
                                <asp:TextBox ID="txt_message" runat="server" Width="200px" Height="45px" Font-Names="tahoma" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                                                   
                                                   <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="sendInfo" runat="server" />
                             
                   
                    </div>



                                                
                    <br />

                          <asp:Button ID="Button5"  runat="server" Text="مرحله بعدی" 
                   onclick="Button5_Click" CssClass="button1" ValidationGroup="sendInfo" BorderStyle="Solid"  />





                                                 </div>
                                                      <div id="tab6" runat="server" style=" padding:10px; font-size:9pt"  >
                                                      

    <asp:GridView ID="gv1_mirror" runat="server" AutoGenerateColumns="False" 
                                                CssClass="col2" GridLines="Vertical" OnRowCommand="gv1_RowCommand" 
                                                OnSelectedIndexChanged="gv1_SelectedIndexChanged" Width="750px" BackColor="White" 
                                                              BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                              ForeColor="Black">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="ردیف" />
                                                    <asp:BoundField DataField="catid" HeaderText="کد" />
                                                    <asp:BoundField DataField="productname" HeaderText="شرح کالا / خدمات"  />
                                                    <asp:BoundField DataField="quantity" HeaderText=" تعداد" />
                                                    <asp:BoundField DataField="price" HeaderText="قیمت" />
                                                    <asp:BoundField DataField="sum" HeaderText="جمع" />
                                                  

                                                    
                                      

                                                </Columns>
                                                <EmptyDataTemplate>
                                                    هیچ کالایی در سبد خرید شما یافت نگردید.
                                                </EmptyDataTemplate>
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" BorderColor="#003300" BorderStyle="Solid" 
                                                    BorderWidth="1px" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>

                                            <div id="rows3" runat="server">

                                                                                        <div id="Div2" runat="server">
                        <div class="row">
                            <div class="field">
                               جمع مبلغ قابل پرداخت:</div>
                            <div class="fieldInputArea">
                                <asp:Label ID="lbl_total_order_and_send_price" runat="server" Text="Label" Font-Bold="True"></asp:Label>                            
                                &nbsp;ریال</div>
                        </div>
                        </div>

        

                         <div id="rows_finalOk_physical" runat="server">

                                         <div class="row">
                            <div class="field">
                               جمع مبلغ سفارش:</div>
                            <div class="fieldInputArea">
                                <asp:Label ID="lbl_Miror_totalPrice" runat="server" Text="Label"></asp:Label> ریال
                            </div>
                        </div>


                                                             <div class="row" >
                            <div class="field">
                                شیوه ارسال سفارش:</div>
                            <div class="fieldInputArea">
                                 <asp:Label ID="lbl_mirror_sendMode" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>

                                                 <div id="Div1" runat="server">
                        <div class="row">
                            <div class="field">
                              هزینه ارسال سفارش:</div>
                            <div class="fieldInputArea">
                                <asp:Label ID="lbl_mirror_sendmode2_by_agent" runat="server" Text="Label"></asp:Label>
                              
                            </div>
                        </div>
                        </div>

                                      
     

                              <div class="row">
                            <div class="field">
                                مجموع وزنی:</div>
                            <div class="fieldInputArea">
                                  <asp:Label ID="lbl_Miror_totalWeight" runat="server" Text="Label"></asp:Label> گرم
                            </div>
                        </div>
                    
                        <div class="row">
                            <div class="field">
                               کشور:</div>
                            <div class="fieldInputArea">
                               <asp:Label ID="lbl_mirror_country" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="field">
                                استان / ایالت:</div>
                            <div class="fieldInputArea">
                              <asp:Label ID="lbl_mirror_state" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>

                             <div class="row">
                            <div class="field">
                                شهر / شهرستان:</div>
                            <div class="fieldInputArea">
                               <asp:Label ID="lbl_mirror_city" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>

                

                         <div id="div_mirror_Address"  runat="server">
                        <div class="row">
                            <div class="field">آدرس محل تحویل:</div>
                            <div class="fieldInputArea">
                                <asp:Label ID="lbl_mirror_Address" runat="server" Text="Label"></asp:Label>

                            </div>
                        </div>

                      <div class="row">
                            <div class="field">
                                کدپستی محل تحویل:</div>
                            <div class="fieldInputArea">
                                 <asp:Label ID="lbl_mirror_zipCode" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        </div>

                          <div class="row">
                            <div class="field">
                                تلفن ثابت تحویل گیرنده:</div>
                            <div class="fieldInputArea">
                          <asp:Label ID="lbl_mirror_tel" runat="server" Text="Label"></asp:Label>
                                                                    
                            </div>
                        </div>

                           <div class="row">
                            <div class="field">موبایل تحویل گیرنده:</div>
                            <div class="fieldInputArea">
                               <asp:Label ID="lbl_mirror_cellPhone" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="field">
                                پیام:</div>
                            <div class="fieldInputArea">
                             <asp:Label ID="lbl_mirror_msg" runat="server" Text="Label"></asp:Label>

                            </div>
                        </div>
                           
                           </div>                  
                           
                        </div>
                             <br />
                                  <br />
                                                          <asp:Label ID="lbl_trace" runat="server" ></asp:Label>
                                                         
                                                      <br />


                        <asp:Button ID="btnOK"  runat="server" Text="تایید نهایی" 
                   onclick="btnOK_Click" CssClass="button1" 
    BorderStyle="Solid"  />
                   
                                                          &nbsp;<asp:Button ID="btn_cancel"  runat="server" Text="بازگشت" 
                   onclick="btn_Cancel_Click" CssClass="button1" 
    BorderStyle="Solid"  />
                    </div>


                                                      <br />
                          






                                                 
                                                      </div>
                </td>
        </tr>
    </table>



<br />

<br />
<br />
<br />

      </ContentTemplate>
</asp:UpdatePanel>
