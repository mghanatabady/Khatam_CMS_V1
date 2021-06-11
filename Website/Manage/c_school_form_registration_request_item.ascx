<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_form_registration_request_item.ascx.vb" Inherits="manage_c_school_form_registration_request_item" %>
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
<div id="DIV3" runat="server" style="width: 742px; font-size: 12pt; margin-left: 10px; margin-right: 10px; text-align: right;" dir="rtl" visible="false">
</div>
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
<div dir="rtl" style="margin-left: 10px; width: 742px; margin-right: 10px; font-size: 12pt; text-align: justify;">
    &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
        DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" 
        Width="740px" EnableModelValidation="True">
        <Fields>
            <asp:BoundField DataField="id" HeaderText="کد فرم" InsertVisible="False" ReadOnly="True"
                SortExpression="id" />
            <asp:BoundField DataField="national_code" HeaderText="شماره ملی" 
                SortExpression="national_code" />
            <asp:BoundField DataField="Fname" HeaderText="نام" SortExpression="Fname" />
            <asp:BoundField DataField="Lname" HeaderText="نام خانوادگی" 
                SortExpression="Lname" />
            <asp:BoundField DataField="shsh" HeaderText="شماره شناسنامه" 
                SortExpression="shsh" />
            <asp:BoundField DataField="shregplace" HeaderText="محل صدور" 
                SortExpression="shregplace" />
            <asp:BoundField DataField="birthday" HeaderText="تاریخ تولد" 
                SortExpression="birthday" />
            <asp:BoundField DataField="current_school_type" HeaderText="نوع مدرسه فعلی" 
                SortExpression="current_school_type" />
            <asp:BoundField DataField="current_school_name" HeaderText="نام مدرسه فعلی" 
                SortExpression="current_school_name" />
            <asp:BoundField DataField="current_school_address" HeaderText="آدرس مدرسه فعلی" 
                SortExpression="current_school_address" />
            <asp:BoundField DataField="current_avrage" HeaderText="معدل فعلی" 
                SortExpression="current_avrage" />
            <asp:BoundField DataField="current_math_score" HeaderText="نمره فعلی ریاضی" 
                SortExpression="current_math_score" />
            <asp:BoundField DataField="current_discipline_Score" 
                HeaderText="نمره انضباط فعلی" SortExpression="current_discipline_Score" />
            <asp:BoundField DataField="father_fnmae" HeaderText="نام پدر" 
                SortExpression="father_fnmae" />
            <asp:BoundField DataField="father_age" HeaderText="سن پدر" 
                SortExpression="father_age" />
            <asp:BoundField DataField="father_job" HeaderText="شغل مادر" 
                SortExpression="father_job" />
            <asp:BoundField DataField="father_Education_grade" 
                HeaderText="میزان تحصیلات پدر" SortExpression="father_Education_grade" />
            <asp:BoundField DataField="father_mobile" HeaderText="تلفن همراه پدر" 
                SortExpression="father_mobile" />
            <asp:BoundField DataField="father_job_tel" HeaderText="تلفن محل کار پدر" 
                SortExpression="father_job_tel" />
            <asp:BoundField DataField="father_email" HeaderText="ایمیل پدر" 
                SortExpression="father_email" />
            <asp:BoundField DataField="mother_job" HeaderText="شغل مادر" 
                SortExpression="mother_job" />
            <asp:BoundField DataField="mother_Education_grade" 
                HeaderText="میزان تحصیلات مادر" SortExpression="mother_Education_grade" />
        </Fields>
        <FieldHeaderStyle Width="200px" />
    </asp:DetailsView>
    &nbsp;<br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_site %>"
        
        SelectCommand="SELECT school_form_registration_request.* FROM school_form_registration_request WHERE (id = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
 <br />