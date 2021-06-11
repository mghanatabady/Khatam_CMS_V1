Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.Web.UI
Imports System.IO
Imports System.IO.Compression
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography
Imports System.Web.UI.HtmlControls


Namespace Khatam_Functions
    Namespace KUI
        Namespace Database




            Public Class sql
                'Public Shared Function ConvertString(ByVal value As String) As String





                Public Shared Function Sql_Get_sum(ByVal col_target As String, ByVal table As String, ByVal ConnectionString As String) As String
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    'str_sql = "SELECT  " & field_target & "   FROM  " & table & "   WHERE     (" & field_where & " = @field_where_value)"
                    str_sql = "SELECT     SUM( " & col_target & ") AS total_price   FROM    " & table

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_Get_sum_with_where(ByVal col_target As String, ByVal field_where As String, ByVal field_where_value As String, ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_where_value", field_where_value)
                    'str_sql = "SELECT  " & field_target & "   FROM  " & table & "   WHERE     (" & field_where & " = @field_where_value)"
                    str_sql = "SELECT     SUM( " & col_target & ") AS total_price   FROM    " & table & "   WHERE     (" & field_where & " = @field_where_value)"

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_count(ByVal field_where As String, ByVal field_where_value As String, ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_where_value", field_where_value)
                    str_sql = "SELECT   COUNT(*) AS Count_result    FROM  " & table & "   WHERE     (" & field_where & " = @field_where_value)"

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function





                Public Shared Function Sql_get_last_id(ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    'parameters.Add("field_where_value", field_where_value)
                    str_sql = "select top(1) id from " & table & " ORDER BY id DESC"

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_Get_Col(ByVal field_target As String, ByVal field_where As String, ByVal field_where_value As String, ByVal enable As Boolean, ByVal table As String, ByVal ConnectionString As String) As DataTable
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add(field_where, field_where_value)
                    parameters.Add("enable", enable)



                    str_sql = "SELECT     " & field_target & "   FROM " & table & "  WHERE     (" & field_where & " = @" & field_where & ") AND (enable = @enable)"

                    Return DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_Get_Col(ByVal field_target As String, ByVal field_where As String, ByVal field_where_value As String, ByVal table As String, ByVal ConnectionString As String) As DataTable
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add(field_where, field_where_value)




                    str_sql = "SELECT     " & field_target & "   FROM " & table & "  WHERE     (" & field_where & " = @" & field_where & ") "

                    Return DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function


                Public Shared Function Sql_load_table(ByVal table As String, ByVal ConnectionString As String) As DataTable
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    'parameters.Add(field_where, field_where_value)
                    'parameters.Add("enable", enable)

                    str_sql = "SELECT     *   FROM " & table

                    Return DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function


                Public Shared Function Sql_load_table(ByVal table As String, ByVal field_where As String, ByVal field_where_value As String, ByVal ConnectionString As String) As DataTable
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    'parameters.Add(field_where, field_where_value)
                    parameters.Add(field_where, field_where_value)

                    str_sql = "SELECT     *   FROM " & table & " where " & field_where & "=@" & field_where

                    Return DBFunctions.ExecuteReader(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_copy_table(ByVal table_source As String, ByVal table_target As String, ByVal ConnectionString_source As String, ByVal ConnectionString_target As String, ByVal identity_specification As Boolean) As Boolean
                    Dim dt As New DataTable
                    dt = Sql_load_table(table_source, ConnectionString_source)

                    'Me.GridView1.DataBind()

                    Dim item_name, item_value As New ArrayList

                    Dim i, j As Integer
                    For i = 0 To dt.Rows.Count - 1

                        For j = 0 To dt.Columns.Count - 1

                            If identity_specification = True Then
                                If dt.Columns(j).ColumnName <> "id" Then
                                    item_name.Add(dt.Columns(j).ColumnName)
                                    item_value.Add(dt.Rows(i).Item(j))
                                End If
                            Else
                                item_name.Add(dt.Columns(j).ColumnName)
                                item_value.Add(dt.Rows(i).Item(j))
                            End If
                        Next j


                        'khatam.core.data.sql.Add(item_name, item_value, table_target, ConnectionString_target)

                        item_name.Clear()
                        item_value.Clear()
                    Next i
                    Return True
                End Function

                Public Shared Function Sql_Del_Row(ByVal field_where As String, ByVal field_where_value As String, ByVal table As String, ByVal ConnectionString As String) As String
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add(field_where, field_where_value)



                    str_sql = " DELETE FROM " & table & "  WHERE     (" & field_where & " = @" & field_where & ") "

                    Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_Del_all_Row(ByVal table As String, ByVal ConnectionString As String) As String
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    'parameters.Add(field_where, field_where_value)



                    str_sql = " DELETE FROM " & table

                    Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_update_field(ByVal field_target_name As String, ByVal field_target_value As String, ByVal field_where_name As String, ByVal field_where_value As String, ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add(field_target_name, field_target_value)

                    parameters.Add(field_where_name, field_where_value)


                    str_sql = "UPDATE    " & table & "    SET              " & field_target_name & " = @" & field_target_name & "   WHERE     (" & field_where_name & " = @" & field_where_name & ")"

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function Sql_update_field(ByVal field_target_name As String, ByVal field_target_value As String, ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add(field_target_name, field_target_value)

                    str_sql = "UPDATE    " & table & "    SET              " & field_target_name & " = @" & field_target_name

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                Public Shared Function SQL_Run_TSql_File(ByVal fileurl As String, ByVal connectionString As String, ByVal timeout As Integer, ByVal return_have_error As Boolean)

                    'SqlConnection conn = null;                   
                    Dim conn As SqlConnection = Nothing
                    Dim str_response As String = ""
                    'Try
                    '{
                    Try

                        ''this.Response.Write(String.Format("Opening url {0}<BR>", fileUrl));
                        str_response = str_response & String.Format("Opening url {0}<BR>", fileurl)


                        '// read file
                        'WebRequest request = WebRequest.Create(fileUrl);
                        Dim request2 As WebRequest = WebRequest.Create(fileurl)
                        ''using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
                        '{
                        Dim sr As StreamReader = New StreamReader(request2.GetResponse().GetResponseStream())
                        Using sr

                            'this.Response.Write("Connecting to SQL Server database...<BR>");
                            str_response = str_response & "Connecting to SQL Server database...<BR>"

                            '// Create new connection to database
                            ''conn = new SqlConnection(connectionString);  
                            conn = New SqlConnection(connectionString)

                            conn.Open()

                            'While (!sr.EndOfStream)
                            While Not sr.EndOfStream
                                '{
                                ' StringBuilder sb = new StringBuilder();
                                Dim sb As Text.StringBuilder = New Text.StringBuilder()
                                'SqlCommand cmd = conn.CreateCommand();
                                Dim cmd As SqlCommand = conn.CreateCommand()

                                'While (!sr.EndOfStream)
                                While Not sr.EndOfStream
                                    '{
                                    'string s = sr.ReadLine();
                                    Dim s As String = sr.ReadLine()
                                    'if (s != null && s.ToUpper().Trim().Equals("GO"))
                                    If (s IsNot DBNull.Value) And (s.ToUpper().Trim().Equals("GO")) Then
                                        '{
                                        ''break;
                                        '''''GoTo break
                                        Exit While
                                    End If


                                    sb.AppendLine(s)
                                    ''}
                                End While

                                '// Execute T-SQL against the target database
                                'cmd.CommandText = sb.ToString();
                                cmd.CommandText = sb.ToString()
                                'cmd.CommandTimeout = timeout;
                                cmd.CommandTimeout = timeout
                                'cmd.ExecuteNonQuery();
                                cmd.ExecuteNonQuery()
                                ''}
                            End While

                            ''}
                        End Using
                        'this.Response.Write("T-SQL file executed successfully");
                        str_response = str_response & "T-SQL file executed successfully<br>"
                        '}
                        'catch (Exception ex)
                    Catch ex As Exception


                        '{
                        'this.Response.Write(String.Format("An error occured: {0}", ex.ToString()));
                        If return_have_error = True Then
                            str_response = str_response & String.Format("An error occured: {0}<br>", ex.ToString())
                        End If
                        ''}
                        'Finally
                    Finally
                        '{
                        '// Close out the connection
                        '//
                        'if (conn != null)
                        If conn IsNot DBNull.Value Then

                            '{
                            'Try
                            Try
                                '{
                                'conn.Close();
                                conn.Close()
                                'conn.Dispose();
                                conn.Dispose()
                                '}
                                ''catch (Exception e)
                            Catch ex As Exception

                                ''{
                                ''this.Response.Write(String.Format(@"Could not close the connection.  Error was {0}", e.ToString()));
                                str_response = str_response & String.Format("Could not close the connection.  Error was {0}", ex.ToString())
                                '}
                            End Try
                            '}
                        End If
                        '}
                    End Try

                    Return str_response

                End Function


            End Class


            Public Class ConnectionString

                Public Shared Function Generate_local(ByVal db_name As String) As String
                    Return "Data Source=localhost\sqlexpress;Initial Catalog=" & db_name & ";Integrated Security=True"

                End Function

                Public Shared Function Generate_host(ByVal ip As String, ByVal catalog As String, ByVal id_dba As String, ByVal password_dba As String) As String

                    Return "Data Source=" & ip & ";Initial Catalog=" & catalog & ";Persist Security Info=True;User ID=" & id_dba & ";Password=" & password_dba

                End Function

            End Class





        End Namespace

        Namespace Explorer
            Public Class cat

                Function get_sortid_by_id(ByVal id_cat As Integer, ByVal ConnectionString As String) As String
                    Dim str_sql As String
                    Dim sortid As String

                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("id", Replace(id_cat, "'", ""))

                    str_sql = "SELECT     sortid   FROM         Cat  WHERE     (id = @id)"
                    '(id = @id) AND

                    sortid = DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                    If (sortid = "") Or (sortid = Nothing) Or (sortid = 1) Or (sortid.Contains("#") = False) Then
                        sortid = 99999
                    End If

                    Return sortid

                End Function

                Function check_type_cat(ByVal cname As String, ByVal type_content As String, ByVal height As String) As String




                    Try


                        Dim str_sql As String
                        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)




                        parameters.Add("type_content", type_content)
                        parameters.Add("height", height)
                        parameters.Add("cname", cname)

                        str_sql = "SELECT     id   FROM         Cat   WHERE    (height = @height)  AND   (type_content = @type_content) AND  (cname = @cname)  "

                        Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())

                    Catch ex As Exception

                    End Try

                    Return Nothing
                End Function

                Function get_lastorder_id_of_parent(ByVal parent_id As String) As String




                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)




                    parameters.Add("parent_id", parent_id)

                    str_sql = "SELECT    top(1) orderid   FROM         Cat   WHERE    (pid = @parent_id)  ORDER BY orderid DESC "

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())


                End Function

                Sub insert_type_content(ByVal cname As String, ByVal type_content As String)
                    If check_type_cat(cname, type_content, 2) = Nothing Then
                        'Me.Label1.Text = "نداره"

                        Dim orderid, pid As String
                        pid = get_main_parent_id()
                        orderid = get_lastorder_id_of_parent(pid) + 1


                        Dim sortchar As String
                        If orderid.ToString.Length > 1 Then
                            sortchar = ChrW(63 + orderid.ToString.Length)
                        Else
                            sortchar = ""
                        End If

                        Dim sortid As String
                        sortid = get_sortid(pid)

                        Dim new_cat_id As String
                        Dim new_cat_sort_id As String

                        new_cat_sort_id = sortid & "." & sortchar & orderid
                        new_cat_id = insert_cat(orderid, cname, pid, new_cat_sort_id, 2, 1, type_content, 8)
                        insert_cat(1, "فارسی", new_cat_id, new_cat_sort_id & ".1", 3, 1, type_content, 8)
                        insert_cat(2, "English", new_cat_id, new_cat_sort_id & ".2", 3, 1, type_content, 8)


                    Else
                        ' Me.Label1.Text = "داره"

                    End If

                End Sub

                Function get_last_orderid_of_parent(ByVal orderid As String, ByVal cname As String, ByVal height As String, ByVal sortid As String, ByVal type As String, ByVal type_content As String, _
                             ByVal id_content As String, ByVal id_setting_image_standard As String, ByVal lang As String, ByVal Delete_possible_self As String, _
    ByVal Delete_possible_subset_file As String, ByVal Delete_possible_subset_folder As String, ByVal insert_possible_subset_file As String, _
    ByVal insert_possible_subset_folder As String, ByVal rename_possible_subset_file As String, ByVal rename_possible_subset_folder As String) As String
                    ' ( 1, N'هاست', 1, 2, N'#.1.A19', 1, N'Host', NULL, NULL, NULL, 1, 1, 1, 1, 1, 1, 1)

                    'type 1 for folder
                    'type 2 for file

                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("id", orderid)
                    parameters.Add("cname", cname)
                    ' parameters.Add("pid", pid)
                    parameters.Add("sortid", sortid)
                    parameters.Add("height", height)
                    parameters.Add("type", type)
                    parameters.Add("type_content", type_content)
                    parameters.Add("id_setting_image_standard", id_setting_image_standard)

                    'id_setting_image_standard

                    'str_sql = "INSERT INTO cat (orderid,cname,pid,sortid,height) VALUES (1,'first dir',0,'#.1',1)"
                    str_sql = "INSERT INTO cat (orderid,cname,pid,sortid,height, type, type_content,id_setting_image_standard) VALUES (@orderid,@cname,@pid,@sortid,@height,@type, @type_content,@id_setting_image_standard)"


                    If DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) <> 1 Then
                        'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
                    End If
                End Function

                Function get_sortid(ByVal id As String) As String




                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)




                    parameters.Add("id", id)

                    str_sql = "SELECT    sortid   FROM         Cat   WHERE    (id = @id) "

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())


                End Function

                Function insert_cat(ByVal orderid As Integer, ByVal cname As String, ByVal pid As Integer, ByVal sortid As String, ByVal height As Integer, ByVal type As Integer, ByVal type_content As String, ByVal id_setting_image_standard As String) As String
                    'type 1 for folder
                    'type 2 for file

                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("orderid", orderid)
                    parameters.Add("cname", cname)
                    parameters.Add("pid", pid)
                    parameters.Add("sortid", sortid)
                    parameters.Add("height", height)
                    parameters.Add("type", type)
                    parameters.Add("type_content", type_content)
                    parameters.Add("id_setting_image_standard", id_setting_image_standard)

                    'id_setting_image_standard

                    'str_sql = "INSERT INTO cat (orderid,cname,pid,sortid,height) VALUES (1,'first dir',0,'#.1',1)"
                    str_sql = "INSERT INTO cat (orderid,cname,pid,sortid,height, type, type_content,id_setting_image_standard) VALUES (@orderid,@cname,@pid,@sortid,@height,@type, @type_content,@id_setting_image_standard);SELECT SCOPE_IDENTITY();"


                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
                End Function


                Function get_main_parent_id() As String


                    Return khatam.core.data.sql.getField("id", "pid", "0", "cat")
                End Function

            End Class





            Public Class ConnectionString

                Public Shared Function Generate_local(ByVal db_name As String) As String
                    Return "Data Source=localhost\sqlexpress;Initial Catalog=" & db_name & ";Integrated Security=True"

                End Function

                Public Shared Function Generate_host(ByVal ip As String, ByVal catalog As String, ByVal id_dba As String, ByVal password_dba As String) As String

                    Return "Data Source=" & ip & ";Initial Catalog=" & catalog & ";Persist Security Info=True;User ID=" & id_dba & ";Password=" & password_dba

                End Function

            End Class





        End Namespace

        Namespace Account
            Public Class Transaction

                Public Shared Function add(ByVal id_customer As String, ByVal Text As String, ByVal value As String, ByVal Positive As Boolean, _
                ByVal Insert_user_id As String, ByVal Insert_ip As String, ByVal Insert_User_mode As String, _
                ByVal request As Boolean, ByVal Delete_feasible_customer As Boolean, ByVal date_event As Date, ByVal ConnectionString As String) As Boolean



                    Dim item_name, item_value As New ArrayList

                    item_name.Add("id_customer")
                    item_value.Add(id_customer)

                    item_name.Add("text")
                    item_value.Add(Text)

                    item_name.Add("value")
                    If Positive = True Then
                        item_value.Add(Int(value))
                    Else
                        item_value.Add(Int(value) * -1)
                    End If

                    item_name.Add("Insert_user_id")
                    item_value.Add(Insert_user_id)

                    item_name.Add("Insert_ip")
                    item_value.Add(Insert_ip)

                    item_name.Add("Insert_User_mode")
                    item_value.Add(Insert_User_mode)

                    item_name.Add("request")
                    item_value.Add(request)

                    item_name.Add("Delete_feasible_customer")
                    item_value.Add(Delete_feasible_customer)

                    item_name.Add("date_reg")
                    item_value.Add(DateTime.UtcNow())

                    item_name.Add("date_event")
                    item_value.Add(date_event)

                    ' khatam.core.data.sql.Add(item_name, item_value, "account", ConnectionString)


                    Return 0
                End Function

                Public Shared Function get_account_mode(ByVal status_id As Integer)
                    Dim keyword_string As String

                    Select Case status_id
                        Case 1 : keyword_string = "فیش بانکی"
                        Case 2 : keyword_string = "پرداخت اینرنتی"
                        Case 3 : keyword_string = "اتمام یافته"
                        Case 4 : keyword_string = "در انتظار تایید مالی"
                        Case 5 : keyword_string = "منقضی"


                        Case Else : keyword_string = ""
                    End Select




                    Return keyword_string
                End Function

            End Class

        End Namespace

        Namespace DateTimeKUI

            Public Class Convert_Date

                Public Shared Function Global_To_Persian(ByVal Golbal_Datetime As Date)
                    Dim Per As String
                    Dim ps As New PersianCalendar

                    Per = ps.GetDayOfMonth(Golbal_Datetime) & "/" & ps.GetMonth(Golbal_Datetime) & "/" & ps.GetYear(Golbal_Datetime)
                    Return Per
                End Function


            End Class




        End Namespace

        Namespace Strings

            Public Class keywords

                Public Shared Function get_status(ByVal status_id As Integer)
                    Dim keyword_string As String

                    Select Case status_id
                        Case 1 : keyword_string = "فعال"
                        Case 2 : keyword_string = "غیر فعال"
                        Case 3 : keyword_string = "اتمام یافته"
                        Case 4 : keyword_string = "در انتظار تایید مالی"
                        Case 5 : keyword_string = "منقضی"


                        Case Else : keyword_string = ""
                    End Select




                    Return keyword_string
                End Function

                Public Shared Function MakeInt(ByVal stringint As String) As String
                    Dim lngCount As Long
                    Dim strOut As String = ""
                    If Len(stringint) > 0 Then
                        For lngCount = 1 To Len(stringint)
                            If IsNumeric(Mid$(stringint, lngCount, 1)) Then
                                strOut = strOut & Mid$(stringint, lngCount, 1)
                            End If
                        Next lngCount
                    End If
                    MakeInt = strOut
                End Function


            End Class




        End Namespace

        Namespace support

            Public Class Online_msg


                Public Shared Function Gen_Yahoo_Status(ByVal Mode As Integer, ByVal type As Integer, ByVal language As Integer, ByVal ConnectionString As String)




                    Dim str As String = ""

                    Dim dt As DataTable
                    dt = KUI.Database.sql.Sql_Get_Col("yahoo_id", "language", language, True, "Support_Online_msg", ConnectionString)



                    Dim i As Integer

                    For i = 0 To dt.Rows.Count - 1
                        Select Case Mode
                            Case 1
                                str = str + " <a href=""ymsgr:sendIM?" & dt.Rows(i).Item(0).ToString.ToLower & """> <img border=0 src=http://opi.yahoo.com/online?u=" & dt.Rows(i).Item(0).ToString.ToLower & "&m=g&t=" & type & " /></a>"
                            Case 2
                                str = str + "<script language=""javascript"" src=""http://www.parstools.net/yahoo_status/?id=" & dt.Rows(i).Item(0).ToString.ToLower & "&type=" & type & """></script>"
                            Case Else

                        End Select
                    Next i

                    Return str

                End Function



            End Class




        End Namespace

        Namespace security
            Public Class anti_attack

                Public Shared Function remove_injection_chars(ByVal str As String) As String
                    str = str.Replace("'", "").Replace("<", "").Replace(">", "")

                    Return str
                End Function


            End Class

            Public Class gen_hash



                Public Shared Function GenerateHash(ByVal SourceText As String) As String
                    'kui source text and salt
                    SourceText = SourceText & ("Kui_a@bc1^6352gg")
                    'Create an encoding object to ensure the encoding standard for the source text
                    Dim Ue As New UnicodeEncoding()
                    'Retrieve a byte array based on the source text
                    Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
                    'Instantiate an MD5 Provider object
                    Dim Md5 As New MD5CryptoServiceProvider()
                    'Compute the hash value from the source
                    Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
                    'And convert it to String format for return
                    Return Convert.ToBase64String(ByteHash)
                End Function




            End Class

            Public Class users




                Public Shared Function user_detail_Get_field(ByVal field_target As String, ByVal field_user As String, ByVal field_user_value As String, ByVal field_pass As String, ByVal field_pass_value As String, ByVal table As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_user", Replace(field_user_value, "'", ""))

                    'parameters.Add("field_user", field_user)



                    str_sql = "SELECT  " & field_target & "   FROM  " & table & "   WHERE     (" & field_user & " = @field_user )"

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)



                End Function

                Public Shared Function user_validator(ByVal field_user As String, ByVal field_user_value As String, ByVal field_pass As String, ByVal field_pass_value As String, ByVal table As String, ByVal ConnectionString As String) As Boolean

                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_user", Replace(field_user_value, "'", ""))
                    parameters.Add("field_pass", Replace(field_pass_value, "'", ""))

                    str_sql = "SELECT  *   FROM  " & table & "   WHERE     (" & field_user & " = @field_user AND  " & field_pass & " = @field_pass )"

                    If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString) = Nothing Then
                        Return False
                    Else
                        Return True
                    End If

                End Function

                Public Shared Function user_validator_users(ByVal field_user As String, ByVal field_user_value As String, ByVal field_pass As String, ByVal field_pass_value As String, ByVal user_cat_id As String, ByVal table As String, ByVal ConnectionString As String, ByVal hashpass As String)

                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_user", Replace(field_user_value, "'", ""))
                    'parameters.Add("field_pass", Replace(field_pass_value, "'", ""))
                    parameters.Add("user_cat_id", Replace(user_cat_id, "'", ""))

                    If table = "users" Then
                        str_sql = "SELECT   " & field_pass & "   FROM  " & table & "   WHERE     (" & field_user & " = @field_user AND id_user_cat = @user_cat_id )"
                    Else
                        str_sql = "SELECT   " & field_pass & "   FROM  " & table & "   WHERE     (" & field_user & " = @field_user)"
                    End If

                    Dim password As String = DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)
                    'KUI.security.gen_hash.GenerateHash(password) = field_pass_value
                    If KUI.security.gen_hash.GenerateHash(password) = hashpass Then  ' field_pass_value Then
                        Return True
                    Else
                        Return False
                    End If

                End Function


                Public Shared Function user_validator_users_old(ByVal field_user As String, ByVal field_user_value As String, ByVal field_pass As String, ByVal field_pass_value As String, ByVal user_cat_id As String, ByVal table As String, ByVal ConnectionString As String)

                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("field_user", Replace(field_user_value, "'", ""))
                    parameters.Add("field_pass", Replace(field_pass_value, "'", ""))
                    parameters.Add("user_cat_id", Replace(user_cat_id, "'", ""))

                    str_sql = "SELECT  *   FROM  " & table & "   WHERE     (" & field_user & " = @field_user AND  " & field_pass & " = @field_pass  AND id_user_cat = @user_cat_id )"

                    If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString) = Nothing Then
                        Return False
                    Else
                        Return True
                    End If

                End Function
                Public Shared Function webcontrol_validator(ByVal id_user As String, ByVal id_user_cat As String, ByVal WebUserControl_title As String, ByVal ConnectionString As String)

                    Select Case id_user_cat

                        Case 2, 3, 4, 18, 19, 9
                            Dim str_sql As String
                            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                            parameters.Add("id_user_cat", Replace(id_user_cat, "'", ""))
                            parameters.Add("title", Replace(WebUserControl_title, "'", ""))

                            str_sql = "SELECT     Setting_WebUserControl.title, Setting_WebUserControl_Ref_User_Cat.id_user_cat, Setting_WebUserControl_Ref_User_Cat.id " & _
                            " FROM         Setting_WebUserControl INNER JOIN " & _
                            " Setting_WebUserControl_Ref_User_Cat ON Setting_WebUserControl.id = Setting_WebUserControl_Ref_User_Cat.id_setting_webusercontrol " & _
                            " WHERE     (Setting_WebUserControl.title = @title) AND (Setting_WebUserControl_Ref_User_Cat.id_user_cat = @id_user_cat) "
                            If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString) = Nothing Then
                                Return False
                            Else
                                Return True
                            End If

                            Return True

                        Case Else
                            Dim str_sql As String
                            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                            parameters.Add("id_user", Replace(id_user, "'", ""))
                            parameters.Add("title", Replace(WebUserControl_title, "'", ""))

                            'str_sql = "SELECT  *   FROM  " & table & "   WHERE     (" & field_user & " = @field_user AND  " & field_pass & " = @field_pass )"

                            str_sql = "SELECT     Setting_WebUserControl_Ref_Users.id, Setting_WebUserControl.title, Setting_WebUserControl_Ref_Users.id_user " & _
                            "FROM         Setting_WebUserControl_Ref_Users INNER JOIN " & _
                            "Setting_WebUserControl ON Setting_WebUserControl_Ref_Users.id_webusercontrol = Setting_WebUserControl.id " & _
                            "WHERE     (Setting_WebUserControl.title = @title) AND (Setting_WebUserControl_Ref_Users.id_user = @id_user) "


                            If DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString) = Nothing Then
                                Return False
                            Else
                                Return True
                            End If

                    End Select


                End Function

                Public Shared Function user_Get_field_cat_title(ByVal id_user_cat As String, ByVal id_language As String, ByVal ConnectionString As String)
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("id_language", Replace(id_language, "'", ""))
                    parameters.Add("id_user_cat", Replace(id_user_cat, "'", ""))
                    'parameters.Add("field_user", field_user)



                    'str_sql = "SELECT        Dictionary_Lang.title   FROM            user_cat INNER JOIN " & _
                    '          "Dictionary_Lang ON user_cat.id_dictionary = Dictionary_Lang.id_dictionary " & _
                    '          "WHERE        (Dictionary_Lang.id_language = @id_language) AND (user_cat.id = @id_user_cat) "

                    str_sql = "SELECT        Dictionary_Lang.title   FROM            user_cat INNER JOIN " & _
                              "Dictionary_Lang ON user_cat.id_dictionary = Dictionary_Lang.id_dictionary " & _
                              "WHERE        (Dictionary_Lang.id_language = @id_language) AND (user_cat.id = @id_user_cat) "

                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)

                End Function

                '    Function login_1(ByVal me_page As Page) As String

                'If KUI.security.users.user_validator_users("username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, Me.DropDownList1.SelectedValue, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) = True Then

                'me_page.Session("realname") = KUI.security.users.user_detail_Get_field("fname", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString) & " " & KUI.security.users.user_detail_Get_field("lname", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("id_language") = KUI.security.users.user_detail_Get_field("id_language", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("id_user_cat") = KUI.security.users.user_detail_Get_field("id_user_cat", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("mode") = KUI.security.users.user_Get_field_cat_title(me_page.Session("id_user_cat"), Me.Session("id_language"), ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("Username") = KUI.security.users.user_detail_Get_field("Username", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("user_id") = KUI.security.users.user_detail_Get_field("id", "username", Me.Txt_username.Text, "password", Me.Txt_Password.Text, "users ", ConfigurationManager.ConnectionStrings("Khatam_Site").ConnectionString)
                'me_page.Session("year_active") = KUI.setting.setting_base.Get_Setting_base("school_active_year", 0, 0)
                'me_page.Response.Redirect("~/manage/default.aspx")
                'End If

                'Dim Counter As Integer
                'If ViewState("Counter") Is Nothing Then
                'Counter = 1
                'Else
                'Counter = CType(ViewState("Counter"), Integer) + 1

                'End If
                'ViewState("Counter") = Counter

                'Label2.Text = "نام کاربری یا کلمه عبور اشتباه است لطفا دوباره سعی نمایید"

                'Return 0
                'End Function



            End Class




        End Namespace

        Namespace setting

            Public Class setting_base

                Public Shared Function Get_Setting_base(ByVal cname As String, ByVal language As Integer, ByVal ConnectionString As String) As String
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("cname", Replace(cname, "'", ""))
                    parameters.Add("language", Replace(language, "'", ""))

                    str_sql = "SELECT     memo     FROM         Setting_Base      WHERE     (cname = @cname) AND (Language = @Language) "
                    '(id = @id) AND


                    Return DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, ConnectionString)


                End Function

                Public Shared Function set_Setting_base(ByVal cname As String, ByVal memo As String, ByVal language As Integer, ByVal ConnectionString As String) As Boolean
                    Dim str_sql As String
                    Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    parameters.Add("cname", Replace(cname, "'", ""))
                    parameters.Add("language", Replace(language, "'", ""))
                    parameters.Add("memo", Replace(memo, "'", ""))


                    'str_sql = "SELECT     memo     FROM         Setting_Base      WHERE     (cname = @cname) AND (Language = @Language) "
                    '(id = @id) AND

                    str_sql = "UPDATE  setting_base SET   memo = @memo   WHERE     (cname = @cname) AND (Language = @Language)"

                    Return DBFunctions.ExecuteNonQuery(str_sql, parameters, Data.CommandType.Text, ConnectionString)


                End Function





            End Class




        End Namespace

        Namespace HTML


            Public Class Generator

                Public Shared Function get_email_form(ByVal status_id As Integer)
                    Dim keyword_string As String

                    Select Case status_id
                        Case 1 : keyword_string = "فعال"
                        Case 2 : keyword_string = "غیر فعال"
                        Case 3 : keyword_string = "اتمام یافته"
                        Case 4 : keyword_string = "در انتظار تایید مالی"
                        Case 5 : keyword_string = "منقضی"


                        Case Else : keyword_string = ""
                    End Select




                    Return keyword_string
                End Function

            End Class

        End Namespace

        Namespace Modules


            Public Class shop

                Public Class Customer_Orders


                    Public Shared Function Add(ByVal paymode As Integer, ByVal sendmode As Integer, ByVal userno As Integer, ByVal payment_status As Integer, ByVal conStr As String) As String
                        Dim sql_str As String
                        sql_str = "INSERT INTO Customer_Orders  (customer_id,customer_payment_method_id,customer_send_method_id, " & _
                        " date_order_placed,payment_status) VALUES  (@customer_id, @customer_payment_method_id, " & _
                        " @customer_send_method_id, @date_order_placed, @payment_status); SELECT SCOPE_IDENTITY();"





                        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                        parameters.Add("customer_id", userno)
                        parameters.Add("customer_payment_method_id", paymode)
                        parameters.Add("customer_send_method_id", sendmode)
                        parameters.Add("date_order_placed", Date.UtcNow())
                        parameters.Add("payment_status", payment_status)

                        Return DBFunctions.ExecuteScaler(sql_str, parameters, CommandType.Text, conStr)

                    End Function

                End Class


                Public Class Customer_Orders_Products


                    Public Shared Function Add(ByVal order_id As Integer, ByVal product_id As String, ByVal quantity As String, ByVal price_rials As String, _
                                               ByVal comments As String, ByVal status As String, ByVal expire_date As String, ByVal product_type As String, _
                                              ByVal product_type_id As String, ByVal domain_name As String, ByVal renew_from As String, ByVal rennew_ordered As Boolean, _
                                               ByVal product_status As String, ByVal conStr As String) As String

                        Dim item_name, item_value As New ArrayList




                        item_name.Add("order_id")
                        item_value.Add(order_id)

                        item_name.Add("product_id")
                        item_value.Add(product_id)

                        item_name.Add("quantity")
                        item_value.Add(quantity)

                        item_name.Add("price_rials")
                        item_value.Add(price_rials)

                        item_name.Add("comments")
                        item_value.Add(comments)

                        item_name.Add("status")
                        item_value.Add(status)

                        item_name.Add("expire_date")
                        item_value.Add(expire_date)

                        item_name.Add("product_type")
                        item_value.Add(product_type)

                        item_name.Add("product_type_id")
                        item_value.Add(product_type_id)


                        item_name.Add("domain_name")
                        item_value.Add(domain_name)

                        item_name.Add("renew_from")
                        item_value.Add(renew_from)

                        item_name.Add("rennew_ordered")
                        item_value.Add(rennew_ordered)

                        item_name.Add("product_status")
                        item_value.Add(product_status)


                        '  khatam.core.data.sql.Add(item_name, item_value, "Customer_Orders_Products", conStr)

                        Return True
                    End Function

                    Public Shared Function getTotalPrice(ByVal order_id As Integer, ByVal conStr As String) As String

                        Dim sql_str As String

                        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                        parameters.Add("order_id", order_id)

                        sql_str = "SELECT     SUM(price_rials) AS sumPrice_rials  FROM         Customer_Orders_Products WHERE     (order_id = @order_id)"

                        Return DBFunctions.ExecuteScaler(sql_str, parameters, CommandType.Text, conStr)

                        Return True
                    End Function

                End Class



            End Class


            Public Class seo

                Public Class tags

                    Public Class keyword

                        Public Shared Function Add(ByVal Page As Page, ByVal Value As String) As String
                            Dim meta As New HtmlMeta()
                            meta.Name = "keywords"
                            meta.Content = Value
                            Page.Header.Controls.Add(meta)
                            Return 0
                        End Function

                    End Class


                    Public Class Description

                        Public Shared Function Add(ByVal Page As Page, ByVal Value As String) As String
                            Dim meta As New HtmlMeta()
                            meta.Name = "Description"
                            meta.Content = Value
                            Page.Header.Controls.Add(meta)
                            Return 0
                        End Function

                    End Class

                    Public Class Author

                        Public Shared Function Add(ByVal Page As Page, ByVal Value As String) As String
                            Dim meta As New HtmlMeta()
                            meta.Name = "Author"
                            meta.Content = Value
                            Page.Header.Controls.Add(meta)
                            Return 0
                        End Function

                    End Class

                    Public Class ROBOTS

                        Public Shared Function setIndexFollow(ByVal Page As Page, ByVal INDEX As Boolean, ByVal FOLLOW As Boolean) As String
                            Dim meta As New HtmlMeta()
                            Dim value As String = "INDEX, FOLLOW"
                            '<META NAME="ROBOTS" CONTENT="NOINDEX, NOFOLLOW">

                            meta.Name = "ROBOTS"

                            Select Case INDEX
                                Case True
                                    Select Case FOLLOW
                                        Case True
                                            value = "INDEX, FOLLOW"
                                        Case False
                                            value = "INDEX, NOFOLLOW"
                                    End Select
                                Case False
                                    Select Case FOLLOW
                                        Case True
                                            value = "NOINDEX, FOLLOW"
                                        Case False
                                            value = "NOINDEX, NOFOLLOW"
                                    End Select
                            End Select


                            meta.Content = value

                            Page.Header.Controls.Add(meta)
                            Return 0
                        End Function


                        Public Shared Function setIndexFollow(ByVal page As Page) As String
                            Dim meta As New HtmlMeta()
                            Dim value As String = "INDEX, FOLLOW"
                            '<META NAME="ROBOTS" CONTENT="NOINDEX, NOFOLLOW">

                            meta.Name = "ROBOTS"
                            value = "INDEX, FOLLOW"
                            meta.Content = value

                            page.Header.Controls.Add(meta)
                            Return 0
                        End Function
                    End Class

                End Class





            End Class

        End Namespace

        Namespace modular


            Public Class ui




            End Class




        End Namespace

    End Namespace

End Namespace