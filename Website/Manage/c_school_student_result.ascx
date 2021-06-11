<%@ Control Language="VB" AutoEventWireup="false" CodeFile="c_school_student_result.ascx.vb" Inherits="c_school_student_result" %>
<br />
<div id="MSG1" runat="server" dir="rtl" style="border-right: red 2px solid; border-top: red 2px solid;
    margin-left: 96px; border-left: red 2px solid; width: 652px; margin-right: 10px;
    border-bottom: red 2px solid; height: 45px; text-align: right" visible="false">
    <div style="margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif" />&nbsp;</div>
    <div style="padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;
        padding-top: 5px; height: 26px">
        توجه!<br />
        <span style="font-size: 9pt">کد انتخاب شده برای معلم تکراری است، لطفا کد دیگری را درج
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
            <span style="font-size: 9pt">مقادیر مورد نظر شما ثبت گردید.</span></span></div>
    <br />
</div>
<br />
<div dir="rtl" style="font-size: 12pt; margin-left: 10px; width: 742px; margin-right: 10px">
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
                اعلام نمرات</div>
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
            <div class="from_div_maintitle ">
                <strong><span>کارنامه</span></strong></div>
        </div>
        <div style="margin-left: 9px; width: 724px; margin-right: 9px; background-repeat: repeat-x">
            <div style="margin-top: 5px; float: left; width: 395px; margin-right: 5px; text-align: right">
                <div class="from_div_title">
                    &nbsp;</div>
                <div class="from_div_title">
                    &nbsp;</div>
            </div>
            <div style="margin-top: 5px; width: 320px">
                <div dir="rtl" class="from_div_title">
                    &nbsp;</div>
            </div>
            <div style="width: 720px; text-align: justify;" dir="rtl">
                <br />
                <asp:GridView ID="GridView_Result" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"
                    Width="720px">
                    <Columns>
                        <asp:TemplateField HeaderText="نام درس">
                            <ItemTemplate>
                                <asp:Label ID="Lbl_Lesson_name" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره مستمر نوبت اول">
                            <ItemTemplate>
                                <asp:Label ID="sc1m" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت اول">
                            <ItemTemplate>
                            
                                <asp:Label ID="sc1p" runat="server" ></asp:Label>
  
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره مستمر نوبت دوم">
                            <ItemTemplate>
                                <asp:Label ID="sc2m" runat="server" ></asp:Label>
                              
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت دوم">
                            <ItemTemplate>
                                 <asp:Label ID="sc2p" runat="server" ></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره شهریور">
                            <ItemTemplate>
                   
                                         <asp:Label ID="scsh" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        هنوز نمره برای شما درج نگردیده است.
                    </EmptyDataTemplate>
                </asp:GridView><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                    SelectCommand="SELECT DISTINCT school_Lesson.id, school_Lesson.title, school_Classroom_select.id AS school_classroom_select, school_Student_class.id_school_student FROM school_Student_class INNER JOIN school_Score ON school_Student_class.id_school_student = school_Score.student_id INNER JOIN school_Classroom_select ON school_Student_class.id_school_class = school_Classroom_select.school_class_id INNER JOIN school_Lesson ON school_Classroom_select.school_lesson_id = school_Lesson.id INNER JOIN school_Class ON school_Student_class.id_school_class = school_Class.id WHERE (school_Student_class.id_school_student = @id_school_student) AND (school_Class.id_school_year = @id_school_year) ORDER BY school_Lesson.id">
                    <SelectParameters>
                        <asp:SessionParameter Name="id_school_student" SessionField="user_id" />
                        <asp:SessionParameter Name="id_school_year" SessionField="year_active" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id,school_classroom_select"
                    DataSourceID="SqlDataSource2" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="school_classroom_select" HeaderText="school_classroom_select"
                            InsertVisible="False" ReadOnly="True" SortExpression="school_classroom_select" />
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                    </Columns>
                </asp:GridView>
                <br />
                &nbsp;<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    DataSourceID="SqlDataSource1" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="classroom_select" HeaderText="classroom_select" SortExpression="classroom_select" />
                        <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
                        <asp:BoundField DataField="score_type_type" HeaderText="score_type_type" SortExpression="score_type_type" />
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" />
                        <asp:BoundField DataField="score_cat_id" HeaderText="score_cat_id" SortExpression="score_cat_id" />
                        <asp:BoundField DataField="student_id" HeaderText="student_id" SortExpression="student_id" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                    SelectCommand="SELECT school_Score.id, school_Score.value, school_Score.score_cat_id, school_Score.score_type_type, school_Score.classroom_select, school_Score.student_id, school_Class.id_school_year FROM school_Score INNER JOIN school_Classroom_select ON school_Score.classroom_select = school_Classroom_select.id INNER JOIN school_Class ON school_Classroom_select.school_class_id = school_Class.id WHERE (school_Score.student_id = @student_id) AND (school_Class.id_school_year = @id_school_year)">
                    <SelectParameters>
                        <asp:SessionParameter Name="student_id" SessionField="user_id" Type="String" />
                        <asp:SessionParameter DefaultValue="" Name="id_school_year" SessionField="year_active" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <br />
                <asp:GridView ID="GridView_Result2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3"
                    Width="720px">
                    <Columns>
                        <asp:TemplateField HeaderText="نام درس">
                            <ItemTemplate>
                                <asp:Label ID="Lbl_Lesson_name" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره مستمر نوبت اول">
                            <ItemTemplate>
                                <asp:Label ID="sc1m" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت اول">
                            <ItemTemplate>
                                <asp:Label ID="sc1p" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره مستمر نوبت دوم">
                            <ItemTemplate>
                                <asp:Label ID="sc2m" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره پایانی نوبت دوم">
                            <ItemTemplate>
                                <asp:Label ID="sc2p" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="نمره شهریور">
                            <ItemTemplate>
                                <asp:Label ID="scsh" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Size="8pt" Width="40px" />
                            <ItemStyle Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        هنوز نمره برای شما درج نگردیده است.
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                    SelectCommand="SELECT DISTINCT school_Lesson.id, school_Lesson.title, school_course_personal_student.school_course_personal_id AS school_course_personal_student_id FROM school_course_personal INNER JOIN school_course_personal_student ON school_course_personal.id = school_course_personal_student.school_course_personal_id INNER JOIN school_Lesson ON school_course_personal.school_lesson_id = school_Lesson.id WHERE (school_course_personal_student.school_student_id = @school_student_id) AND (school_course_personal.school_year_id = @school_year_id)">
                    <SelectParameters>
                        <asp:SessionParameter Name="school_student_id" SessionField="user_id" />
                        <asp:SessionParameter Name="school_year_id" SessionField="year_active" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False"
                    DataSourceID="SqlDataSource3" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="school_course_personal_student_id" HeaderText="school_course_personal_student_id"
                            InsertVisible="False" ReadOnly="True" SortExpression="school_course_personal_student_id" />
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                    </Columns>
                </asp:GridView>
                <asp:GridView ID="GridView22" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    DataSourceID="SqlDataSource4" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="school_course_personal" HeaderText="school_course_personal"
                            SortExpression="school_course_personal" />
                        <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
                        <asp:BoundField DataField="score_type_type" HeaderText="score_type_type" SortExpression="score_type_type" />
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" />
                        <asp:BoundField DataField="score_cat_id" HeaderText="score_cat_id" SortExpression="score_cat_id" />
                        <asp:BoundField DataField="student_id" HeaderText="student_id" SortExpression="student_id" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Khatam_Site %>"
                    SelectCommand="SELECT id, value, score_cat_id, score_type_type, student_id, school_course_personal FROM school_Score WHERE (student_id = @student_id)">
                    <SelectParameters>
                        <asp:SessionParameter Name="student_id" SessionField="user_id" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
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
    </div>
    <div style="background-image: url(images/Form1_bottom_bg.gif); width: 742px; background-repeat: repeat-x;
        height: 5px; text-align: left">
        <div style="float: left; background-image: url(images/Form1_left_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
        <div style="float: right; background-image: url(images/Form1_right_bottom_bg.gif);
            width: 5px; height: 5px">
        </div>
    </div>
</div>
<br />
&nbsp;
