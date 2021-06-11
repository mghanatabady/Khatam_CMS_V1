using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Globalization;

namespace khatam
{
    namespace core
    {
        namespace globalization
        {
            public static class country
            {
                public static DataTable getCountryList()
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT     core_country.country_id, Dictionary_Lang.title AS country_title " +
" FROM         Dictionary_Lang INNER JOIN " +
                      " core_country ON Dictionary_Lang.id_dictionary = core_country.dictionary_id INNER JOIN " +
                      " Language ON Dictionary_Lang.id_language = Language.id "  +
" WHERE     ((core_country.country_id <> 0) and (Language.id <> 2)) ";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }
                public static string getCountryTitle(string country_id,string LangId)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("country_id", country_id);
                    parameters.Add("LangId", LangId);
                    str_sql =" SELECT     Dictionary_Lang.title " +
" FROM         core_country INNER JOIN " +
  "                    Dictionary_Lang ON core_country.dictionary_id = Dictionary_Lang.id_dictionary " +
" WHERE     (core_country.country_id = @country_id) AND (Dictionary_Lang.id_language = @LangId)";
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                }
            }

        

            public static class state
            {
                public static DataTable getStateListByCountry(string  country_country_id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("country_country_id", country_country_id);

                    str_sql = "SELECT  [country_state_id] AS state_id    ,[country_state_title] AS state_title " +

                    " FROM [dbo].[core_country_state] where ([country_country_id] = @country_country_id) ";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static string getStateTitle(string country_id, string LangId)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("State_id", country_id);
                    parameters.Add("LangId", LangId);
                    str_sql = " SELECT     Dictionary_Lang.title " +
" FROM         core_country_State INNER JOIN " +
  "                    Dictionary_Lang ON core_country_State.dictionary_id = Dictionary_Lang.id_dictionary " +
" WHERE     (core_country_State.country_State_id = @State_id) AND (Dictionary_Lang.id_language = @LangId)";
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                }

            }

            public static class city
            {
                public static DataTable getCityListByState(string country_state_id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("country_state_id", country_state_id);
                    str_sql = "SELECT  [country_state_city_id] AS city_id    ,[country_state_city_title] AS city_title " +

                    " FROM [core_country_state_city] where ([country_state_id] = @country_state_id) ";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }


                public static string getCityTitle(string city_id, string LangId)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("city_id", city_id);
                    parameters.Add("LangId", LangId);
                    str_sql = " SELECT     Dictionary_Lang.title " +
" FROM         core_country_State_city INNER JOIN " +
  "                    Dictionary_Lang ON core_country_State_city.dictionary_id = Dictionary_Lang.id_dictionary " +
" WHERE     (core_country_State_city.country_State_city_id = @city_id) AND (Dictionary_Lang.id_language = @LangId)";
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                }

            }

            public static class area
            {
                public static DataTable getAreaListByCity(string country_city_id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("country_city_id", country_city_id);

                    str_sql = "SELECT  [country_state_city_area_id] AS area_id "+
       " ,[country_state_city_area_title] AS area_title " +
   " FROM [core_country_state_city_area]  where ([country_state_city_id] = @country_city_id) ";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

            }

            public static class dateTime
            {


                public static String GetPersianDateTime(DateTime dateTimeParam)
                {

                   // TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Utc.Id, "Iran Standard Time");
                    DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeParam, TimeZoneInfo.Utc.Id, "Iran Standard Time");


                    PersianCalendar persianCalendar = new PersianCalendar();

                    String persianDateTimeResult =
                    persianCalendar.GetYear(dtLocal) + "/" + persianCalendar.GetMonth(dtLocal) + "/" + persianCalendar.GetDayOfMonth(dtLocal) +
                     " " +
                    persianCalendar.GetHour(dtLocal) + ":" + persianCalendar.GetMinute(dtLocal) + ":" + persianCalendar.GetSecond(dtLocal);
                    
                  


                    return persianDateTimeResult;
                }

     
               

                public static String GetPersianDate(DateTime dateTimeParam)
                {

                    // TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Utc.Id, "Iran Standard Time");
                    DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeParam, TimeZoneInfo.Utc.Id, "Iran Standard Time");


                    PersianCalendar persianCalendar = new PersianCalendar();

                    String persianDateTimeResult =
                    persianCalendar.GetYear(dtLocal) + "/" + persianCalendar.GetMonth(dtLocal) + "/" + persianCalendar.GetDayOfMonth(dtLocal);
                     


                    return persianDateTimeResult;
                }


                public static DateTime  GetGregorianDateFromPersianDate(string  dateStr)
                {
                    DateTime dateTimeParam = new DateTime();
                    dateTimeParam=  DateTime.Parse(dateStr);

                    PersianCalendar persianCalendar = new PersianCalendar();
                    DateTime dt = new DateTime(dateTimeParam.Year, dateTimeParam.Month, dateTimeParam.Day ,
                          persianCalendar);

                    // TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Utc.Id, "Iran Standard Time");
                    DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, "Iran Standard Time", TimeZoneInfo.Utc.Id);
 

                   // PersianCalendar persianCalendar = new PersianCalendar();
                   // DateTime dt = new DateTime(1390, 1, 1, persianCalendar);
                    // Console.WriteLine(dt.ToString(CultureInfo.InvariantCulture));
                  


                    return dtLocal;
                }

                public static DateTime GetGregorianDateTimeFromPersianTime(string dateTimeStr)
                {
                    DateTime dateTimeParam = new DateTime();
                    dateTimeParam = DateTime.Parse(dateTimeStr);

                    PersianCalendar persianCalendar = new PersianCalendar();
                    DateTime dt = new DateTime(dateTimeParam.Year, dateTimeParam.Month, dateTimeParam.Day,
                          dateTimeParam.Hour, dateTimeParam.Minute , dateTimeParam.Second , persianCalendar);

                    // TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Utc.Id, "Iran Standard Time");
                    DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, "Iran Standard Time", TimeZoneInfo.Utc.Id);


                    // PersianCalendar persianCalendar = new PersianCalendar();
                    // DateTime dt = new DateTime(1390, 1, 1, persianCalendar);
                    // Console.WriteLine(dt.ToString(CultureInfo.InvariantCulture));



                    return dtLocal;
                }

       

            }

            public static class numbers
            {


                public static String GetPersianNumbers(string source)
                {
                    source = source.Replace("1", "۱").Replace("2", "۲")
                       .Replace("3", "۳").Replace("4", "۴").Replace("5", "۵").Replace("6", "۶")
                       .Replace("7", "۷").Replace("8", "۸").Replace("9", "۹").Replace("0", "۰");
                    return source;
                }

                public static String GetGeorgianNumbers(string source)
                {
                    source = source.Replace("۱", "1").Replace("۲", "2")
                       .Replace("۳", "3").Replace("۴", "4").Replace("۵", "5").Replace("۶", "6")
                       .Replace("۷", "7").Replace("۸", "8").Replace("۹", "9").Replace("۰", "0");
                    return source;
                }

            }

        }
    }
}
