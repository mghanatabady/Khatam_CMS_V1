<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default15.aspx.cs" Inherits="Default15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                      <div class="row">
                            <div class="field">
                                 کشور:</div>
                            <div class="fieldInputArea">
                                <asp:DropDownList ID="ddl_country" runat="server" DataSourceID="SqlDataSource1" 
                                    DataTextField="title" DataValueField="country_id" Font-Names="tahoma">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                   
                                    SelectCommand="SELECT core_country.country_id, Dictionary_Lang.title FROM Dictionary_Lang INNER JOIN core_country ON Dictionary_Lang.id_dictionary = core_country.dictionary_id WHERE  (Dictionary_Lang.id_language = 1)">
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
    </form>
</body>
</html>
