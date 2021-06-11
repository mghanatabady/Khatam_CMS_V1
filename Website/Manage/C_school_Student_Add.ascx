<%@ Control Language="VB" AutoEventWireup="false" CodeFile="C_school_Student_Add.ascx.vb" Inherits="C_school_Student_Add" %>
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای دانش آموز تکراری است، لطفا کد دیگری را درج
            نمایید</span></div>
    <br />
</div>
<div id="MSG2" runat="server" dir="rtl" style="border-right: teal 2px solid; border-top: teal 2px solid;
    margin-left: 96px; border-left: teal 2px solid; width: 652px; margin-right: 10px;
    border-bottom: teal 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/msg2_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        <span style="color: black">عملیات موفقیت آمیز<br />
            <span style="font-size: 9pt">مشخصات مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt;">
    <div style="background-image: url(images/win2_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 30px; text-align: left">
        <div style="float: left; background-image: url(images/win2_left_bg.gif); width: 2px;
            height: 30px">
        </div>
        <div style="float: left; background-image: url(images/win2_spacer.gif); margin-left: 5px;
            width: 3px; margin-right: 5px; height: 30px">
        </div>
        <div style="float: right; background-image: url(images/win2_right_bg.gif); width: 2px;
            height: 30px">
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/silverbar_btn_list.gif" /></div>
</div>
<br />
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt;">
    <div style="background-image: url(images/form1_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 31px; text-align: left">
        <div style="float: left; background-image: url(images/form1_left_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bg.gif); width: 5px;
            height: 31px">
        </div>
        <div id="test" style="margin-top: 9px; float: left; background-image: url(images/Tab1_bg.gif);
            margin-left: 4px; width: 115px; height: 22px">
            <div style="float: left; background-image: url(images/Tab1_left_bg.gif); width: 2px;
                height: 22px">
            </div>
            <div style="margin-top: 2px; float: left; width: 100px; height: 20px; text-align: center">
                دانش آموز جدید</div>
            <div style="float: right; background-image: url(images/Tab1_right_bg.gif); width: 10px;
                height: 22px">
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_left_body.gif); width: 742px; background-repeat: repeat-y;
        text-align: left">
        <div style="background-image: url(images/Form1_icon_Spacer.gif); margin-left: 9px;
            width: 724px; margin-right: 9px; background-repeat: repeat-x; height: 47px">
            <div style="margin-top: 10px; float: left; margin-left: 5px; width: 27px; height: 31px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Form1_icon1.gif" /></div>
            <div style="margin-top: 15px; float: left; margin-left: 5px; width: 250px; height: 26px">
                <strong><span>مشخصات دانش آموز</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
<div class="from_div_title">
                    <asp:TextBox ID="Txt_Code" runat="server" MaxLength="20" CssClass="from_txt"></asp:TextBox></div>
                    
                    <div class="from_div_title">
                        <asp:DropDownList ID="DDL_school_base_id" runat="server" DataSourceID="SqlDataSource2" DataTextField="title" DataValueField="id" Font-Names="Tahoma" Width="165px">
                        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                            SelectCommand="SELECT school_base_cat.title + '  ' + school_branch.title + '  ' + school_category.title AS title, school_base.id FROM school_branch INNER JOIN school_category ON school_branch.id = school_category.id_school_branch INNER JOIN school_base ON school_category.id = school_base.id_school_category INNER JOIN school_base_cat ON school_base.year_number = school_base_cat.id ORDER BY school_base.year_number, title, school_category.title"></asp:SqlDataSource>
                    </div>
                    
                                                      <div class="from_div_title" runat="server"  visible="false" >
                    <asp:DropDownList ID="DDL_class_id" runat="server" Font-Names="Tahoma" Width="165px" AppendDataBoundItems="True">
                        <asp:ListItem Value="99999">بدون کلاس - انفرادی</asp:ListItem>
                    </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                        SelectCommand="SELECT [id], [title] FROM [school_class]"></asp:SqlDataSource>
                </div>
                    
                <div class="from_div_title">
                    <asp:TextBox ID="txt_national_code" runat="server" MaxLength="20" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Fname" runat="server" MaxLength="50" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Lname" runat="server" MaxLength="60" CssClass="from_txt"></asp:TextBox></div>
                    <div class="from_div_title">
                    <asp:TextBox ID="Txt_fathername" runat="server" MaxLength="60" CssClass="from_txt"></asp:TextBox></div>
                    
                                        <div class="from_div_title">
                    <asp:TextBox ID="Txt_shsh" runat="server" MaxLength="60" CssClass="from_txt"></asp:TextBox></div>
                    
                                        <div class="from_div_title">
                    <asp:TextBox ID="Txt_shsh_sn" runat="server" MaxLength="60" CssClass="from_txt"></asp:TextBox></div>
                    
                                        <div class="from_div_title">
                    <asp:TextBox ID="Txt_shregplace" runat="server" MaxLength="60" CssClass="from_txt"></asp:TextBox></div>
                    <div class="from_div_title">
                    روز
                    <asp:DropDownList ID="DropDownList1_day" runat="server" BackColor="#FFFFC0" CssClass="from_txt">
                        <asp:ListItem Value="01">1</asp:ListItem>
                        <asp:ListItem Value="02">2</asp:ListItem>
                        <asp:ListItem Value="03">3</asp:ListItem>
                        <asp:ListItem Value="04">4</asp:ListItem>
                        <asp:ListItem Value="05">5</asp:ListItem>
                        <asp:ListItem Value="06">6</asp:ListItem>
                        <asp:ListItem Value="07">7</asp:ListItem>
                        <asp:ListItem Value="08">8</asp:ListItem>
                        <asp:ListItem Value="09">9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                    ماه
                    <asp:DropDownList ID="DropDownList2_month" runat="server" BackColor="#FFFFC0" CssClass="from_txt">
                        <asp:ListItem Value="01">1</asp:ListItem>
                        <asp:ListItem Value="02">2</asp:ListItem>
                        <asp:ListItem Value="03">3</asp:ListItem>
                        <asp:ListItem Value="04">4</asp:ListItem>
                        <asp:ListItem Value="05">5</asp:ListItem>
                        <asp:ListItem Value="06">6</asp:ListItem>
                        <asp:ListItem Value="07">7</asp:ListItem>
                        <asp:ListItem Value="08">8</asp:ListItem>
                        <asp:ListItem Value="09">9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    سال
                    <asp:TextBox ID="txt_year" runat="server" BackColor="#FFFFC0" Font-Names="Tahoma"
                        MaxLength="4" Width="50px" CssClass="from_txt"></asp:TextBox></div>
                                    
         
                                    
                                             
                                                <div class="from_div_title">
                    <asp:TextBox ID="Txt_password" runat="server" MaxLength="30" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_ppassword" runat="server" MaxLength="30" CssClass="from_txt"></asp:TextBox></div><div class="from_div_title">
                        <asp:RadioButton ID="Rb_status_Enable" runat="server" Checked="True" GroupName="Personal_Page"
                            Text="فعال" />
                        /<asp:RadioButton ID="Rb_status_Disable" runat="server" GroupName="Personal_Page"
                            Text="غیر فعال" /></div>
         
<div class="from_div_title">
                    <asp:TextBox ID="Txt_Tel" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_mobile" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                    <div class="from_div_title">
                    <asp:TextBox ID="Txt_pmobile" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                <div class="from_div_title">
                    <asp:TextBox ID="Txt_Email" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                    <div class="from_div_title">
                    <asp:TextBox ID="Txt_pEmail" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                    
                    <div class="from_div_title">
                    <asp:TextBox ID="Txt_Address" runat="server" MaxLength="80" CssClass="from_txt" Width="300px"></asp:TextBox></div>
                    
                    <div class="from_div_title">
                    <asp:TextBox ID="Txt_postal_code" runat="server" MaxLength="80" CssClass="from_txt"></asp:TextBox></div>
                    
                    
                <div class="from_div_title">
                    <asp:TextBox ID="txt_picname" runat="server" BorderStyle="None" MaxLength="50" ReadOnly="True"
                        Width="300px" CssClass="from_txt" BackColor="#F8F9FC"></asp:TextBox></div>
                <div class="from_div_title" style="height:480px">
                    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                    <p>
                        <asp:Button ID="Button3" runat="server" OnClick="Button2_Click" Text="Upload" />&nbsp;</p>
                    <p>
                        <asp:Image ID="Img_Student" runat="server" />&nbsp;</p>
                    <p class="from_div_title">
                        <asp:Label ID="Label1" runat="server"></asp:Label>&nbsp;</p>
                </div>
            </div>
            <div style="margin-top: 5px; width: 320px">
        
                 
                
                <div dir="rtl" class="from_div_title">
                    <span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_Code"
                            ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>شماره
                        دانش آموزی</span></div>
                   <div dir="rtl" class="from_div_title">
                    <span>پایه</span></div>
                   
                             <div class="from_div_title" runat="server" visible="false"  >
                                 کلاس</div>
                   
                               <div dir="rtl" class="from_div_title">
                    <span>شماره ملی</span></div>
        
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Fname"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>نام</div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txt_Lname"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>نام
                    خانوادگی</div>
                    
                                <div class="from_div_title">
                    نام پدر</div>
                        
                                                        <div class="from_div_title">
                    شماره شناسنامه</div>
                        
                                                        <div class="from_div_title">
                    سریال شناسنامه</div>
                        
                        <div class="from_div_title">
                    محل صدور</div>
                                         <div class="from_div_title">
                                             <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_year"
                                                 ErrorMessage="لطفا تاریخ تولد معتبر و چهار رقمی به صورت 1363 وارد نمایید" MaximumValue="1390"
                                                 MinimumValue="1340">*</asp:RangeValidator>تاریخ تولد</div>
  
               
  
  

                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="Txt_Password"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>کلمه
                    عبور</div>
                <div class="from_div_title">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Txt_ppassword"
                        ErrorMessage="*" ValidationGroup="Teacher_Add"></asp:RequiredFieldValidator>کلمه
                    عبور والدین</div><div class="from_div_title">
                        وضعیت</div>
       
<div class="from_div_title">
                    تلفن</div>
                                    <div class="from_div_title">
                    موبایل</div>
                                    <div class="from_div_title">
                    موبایل اولیا
                   </div>
                <div class="from_div_title">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txt_Email"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Teacher_Add">*</asp:RegularExpressionValidator>ایمیل</div>
                        <div class="from_div_title">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txt_pEmail"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Teacher_Add">*</asp:RegularExpressionValidator>ایمیل اولیا</div>
                        

                        
                            <div class="from_div_title">
                    آدرس
                            </div>
                        
                        
                                                <div class="from_div_title">
                    کد پستی</div>
                        
                <div class="from_div_title">
                    </div>
                <div class="from_div_title" style="height: 350px">
                    تصویر<br />
                    سایز تصویر دانش آموزی 225*300 پیکسل می باشد.<br />
                    <br />
                    <br />
                    <br />
                </div>
            </div>
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_midlebar.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_Left_midlebar.gif); width: 5px;
            height: 6px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_midlebar.gif);
            width: 5px; height: 6px">
        </div>
    </div>
    <div style="background-image: url(images/Form1_bg_Body_Footer.gif); width: 742px;
        background-repeat: repeat-y; height: 34px; text-align: left">
        <div style="margin-top: 5px; float: right; width: 125px; margin-right: 7px; height: 24px">
            <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Height="24px" Text="تایید"
                ValidationGroup="Teacher_Add" Width="42px" />
            <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Height="24px" Text="انصراف"
                Width="60px" />
            &nbsp;
        </div>
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right ; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
 <br />