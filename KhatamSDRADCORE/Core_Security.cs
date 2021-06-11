using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Web.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace khatam
{
    namespace core
    {
        namespace Security
        {
            public static class Users
            {

                public struct user
                {
                    public string returnCode;
                    public string returnMessage;

                    public string  id;
                    public string email;
                    public string fname;
                    public string lname;
                    public string id_language;
                    public string company;
                    public string tel;
                    public string fax;
                    public string cellphone;
                    public string country;
                    public string stats;
                    public string city;
                    public string address;
                    public string zipcode;
                    public string active;
                    public string suspended;


               }



                public static user getUser(string user_id)
                {
                    user ci = new user();
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("user_id", user_id );


                    DataTable dt = new DataTable();

                
                    dt = DBFunctions.ExecuteReader("uspGetUser", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            

                    ci.id = dt.Rows[0].ItemArray[0].ToString();
                    ci.email = dt.Rows[0].ItemArray[1].ToString();
                    ci.fname = dt.Rows[0].ItemArray[2].ToString();
                    ci.lname = dt.Rows[0].ItemArray[3].ToString();
                    ci.id_language = dt.Rows[0].ItemArray[4].ToString();
                    ci.company = dt.Rows[0].ItemArray[5].ToString();
                    ci.tel = dt.Rows[0].ItemArray[6].ToString();
                    ci.fax  = dt.Rows[0].ItemArray[7].ToString();
                    ci.cellphone = dt.Rows[0].ItemArray[8].ToString();
                    ci.country = dt.Rows[0].ItemArray[9].ToString();
                    ci.stats = dt.Rows[0].ItemArray[10].ToString();
                    ci.city = dt.Rows[0].ItemArray[11].ToString();
                    ci.address = dt.Rows[0].ItemArray[12].ToString();
                    ci.zipcode = dt.Rows[0].ItemArray[13].ToString();
                    ci.active = dt.Rows[0].ItemArray[14].ToString();
                    ci.suspended = dt.Rows[0].ItemArray[15].ToString();



                    return ci;

                    //Error Table
                    // 1 right
                    // -1 Database Error
                    // -2 Item Not found
                    // -3 Disable
                    // -4 Deleted
                    // -5 Not Valid
                }


               public  static  int login(string userName, string password)
                {

                    //valid by email
                    string userId = khatam.core.data.sql.getField("id", "email", userName, "users");

                    if ((userId != "") && (userId != "-1"))
                    {
                        string active = khatam.core.data.sql.getField("active", "id", userId, "users");


                        if (active == "-1")
                        {
                            khatam.core.support.sendToSupport("login user id " + userId + " found but active " + active + "  fieled not found");
                            return -3;
                        }

                        if (active != "")
                        {
                            if (bool.Parse(active))
                            {
                                string passwordSalt = khatam.core.data.sql.getField("PasswordSalt", "id", userId, "users");
                                if ((passwordSalt == "") || (passwordSalt == "-1"))
                                {
                                    khatam.core.support.sendToSupport("can't get password salt " + userId + " value " + passwordSalt + "  fieled not found");
                                }
                               string  _password = khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt);


                                string loginResult = khatam.core.data.sql.getField("id", "id", userId, "password", _password, "users");
                                if ((loginResult == "") || (loginResult == "-1"))
                                {
                                    return -2;
                                }
                                else
                                {
                                    HttpContext.Current.Response.Cookies["topbar"].Value = "true";
                                    set_cookie(userName, password, false);
                                    return int.Parse(loginResult);
                                }


                            }
                            else
                            {
                                return -3;
                            }
                        }
                        else
                        {
                            return -3;
                        }


                    }


                    //**************** second try by student id
                    if (khatam.core.License.ValidModule("uniproj"))
                    {
                        userId = khatam.core.data.sql.getField("id", "uniProjStudentId", userName, "users");

                        if ((userId != "") && (userId != "-1"))
                        {


                            string passwordSalt = khatam.core.data.sql.getField("PasswordSalt", "id", userId, "users");
                            if ((passwordSalt == "") || (passwordSalt == "-1"))
                            {
                                khatam.core.support.sendToSupport("can't get password salt " + userId + " value " + passwordSalt + "  fieled not found");
                            }
                            password = khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt);

                            string loginResult = khatam.core.data.sql.getField("id", "id", userId, "password", password, "users");
                            if ((loginResult == "") || (loginResult == "-1"))
                            {
                                //khatam.core.support.sendToSupport("lr:" + loginResult  + "user " + userId + " paasword salt " + passwordSalt + " password" + password );
                               // HttpContext.Current.Response.Write("lr:" + loginResult + "user " + userId + " paasword salt " + passwordSalt + " password" + password);

                                return -2;
                            }
                            else
                            {
                                return int.Parse(loginResult);
                            }


                        }
                        else
                        {
                            return -2;
                        }


                    }

                    return -2;


                }

               public static bool set_cookie(string userName, string password, bool remember)
               {
                   HttpContext.Current.Response.Cookies["UID"].Value = userName;
                   HttpContext.Current.Response.Cookies["PID"].Value = password;
                   if (remember)
                   {
                       HttpContext.Current.Response.Cookies["UID"].Expires = DateTime.Now.AddDays(10);
                       HttpContext.Current.Response.Cookies["PID"].Expires = DateTime.Now.AddDays(10);
                   }
                   return true;
               }


               public static int login()
               {
                   string userName = "";
                   string password = "";
                   //bool? webcontrol_validator= true  ;


                   try
                   {

                       
                       userName = HttpContext.Current.Request.Cookies["UID"].Value;
                       password = HttpContext.Current.Request.Cookies["PID"].Value;

                   }
                   catch
                   {
                   }

                   //valid by email
                   string userId = khatam.core.data.sql.getField("id", "email", userName, "users");

                   if ((userId != "") && (userId != "-1"))
                   {
                       string active = khatam.core.data.sql.getField("active", "id", userId, "users");


                       if (active == "-1")
                       {
                           khatam.core.support.sendToSupport("login user id " + userId + " found but active " + active + "  fieled not found");
                           return -3;
                       }

                       if (active != "")
                       {
                           if (bool.Parse(active))
                           {
                               string passwordSalt = khatam.core.data.sql.getField("PasswordSalt", "id", userId, "users");
                               if ((passwordSalt == "") || (passwordSalt == "-1"))
                               {
                                   khatam.core.support.sendToSupport("can't get password salt " + userId + " value " + passwordSalt + "  fieled not found");
                               }
                               password = khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt);


                               string loginResult = khatam.core.data.sql.getField("id", "id", userId, "password", password, "users");
                               if ((loginResult == "") || (loginResult == "-1"))
                               {
                                   return -2;
                               }
                               else
                               {
                                   HttpContext.Current.Response.Cookies["topbar"].Value = "true";

                                   return int.Parse(loginResult);
                               }


                           }
                           else
                           {
                               return -3;
                           }
                       }
                       else
                       {
                           return -3;
                       }


                   }


                   //**************** second try by student id
                   if (khatam.core.License.ValidModule("uniproj"))
                   {
                       userId = khatam.core.data.sql.getField("id", "uniProjStudentId", userName, "users");

                       if ((userId != "") && (userId != "-1"))
                       {


                           string passwordSalt = khatam.core.data.sql.getField("PasswordSalt", "id", userId, "users");
                           if ((passwordSalt == "") || (passwordSalt == "-1"))
                           {
                               khatam.core.support.sendToSupport("can't get password salt " + userId + " value " + passwordSalt + "  fieled not found");
                           }
                           password = khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt);

                           string loginResult = khatam.core.data.sql.getField("id", "id", userId, "password", password, "users");
                           if ((loginResult == "") || (loginResult == "-1"))
                           {
                               return -2;
                           }
                           else
                           {
                               return int.Parse(loginResult);
                           }


                       }
                       else
                       {
                           return -2;
                       }


                   }

                   return -2;


               }


               public static void logOut()
               {
                   HttpCookie objuid, objpid, objtopbar;
                   objuid = HttpContext.Current.Request.Cookies["UID"];
                   objpid = HttpContext.Current.Request.Cookies["PID"];
                   objtopbar = HttpContext.Current.Request.Cookies["topbar"];



                   if (objuid == null)
                   {
                       //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                   }
                   else
                   {
                       objuid.Expires = DateTime.UtcNow.AddDays(-60);
                       HttpContext.Current.Response.Cookies.Add(objuid);
                       //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                   }


                   if (objpid == null)
                   {
                       //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                   }
                   else
                   {
                       objpid.Expires = DateTime.UtcNow.AddDays(-60);
                       HttpContext.Current.Response.Cookies.Add(objpid);
                       //  this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                   }

                   if (objtopbar == null)
                   {
                       // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                   }
                   else
                   {
                       objtopbar.Expires = DateTime.UtcNow.AddDays(-60);
                       HttpContext.Current.Response.Cookies.Add(objtopbar);
                       // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                   }



                   HttpCookie aCookie = new HttpCookie("lastVisit");

                   aCookie.Value = DateTime.UtcNow.ToString();
                   aCookie.Expires = DateTime.UtcNow.AddDays(-60);
                   HttpContext.Current.Response.Cookies.Add(aCookie);
                   HttpContext.Current.Session["State"] = false;
                   HttpContext.Current.Session.Abandon();
               }



                public static string Add(string email, string fname, string lname, string tel, string fax,
                  string company, string CellPhone, string country, string Stats, string city, string address,string zipCode, string password, string idRole, bool gotoCP, bool Needchekindentity, string EmailSalt)
                {
                    string idUsers;
                    bool checkIdentity = false;
                    if (Needchekindentity == true)
                    {


                        checkIdentity = khatam.core.data.sql.Sql_Check_identity("email", email, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }
                    else
                    {

                         checkIdentity = true;
                    }



                    if (checkIdentity == false)
                    {
                        return "-1";
                    }
                    {

                        ArrayList a = new ArrayList();
                        ArrayList b = new ArrayList();

                        a.Add("username");
                        b.Add("a");

                        a.Add("fname");
                        b.Add(fname);

                        a.Add("lname");
                        b.Add(lname);

                        a.Add("company");
                        b.Add(company);

                        a.Add("tel");
                        b.Add(tel);

                        a.Add("fax");
                        b.Add(fax);

                        a.Add("CellPhone");
                        b.Add(CellPhone);

                        a.Add("country");
                        b.Add(country );

                        a.Add("Stats");
                        b.Add(Stats);

                        a.Add("City");
                        b.Add(city);

                        a.Add("Address");
                        b.Add(address);

                        a.Add("ZipCode");
                        b.Add(zipCode);



                        string passwordSalt = khatam.core.Security.Users.CreateSalt(10);
                        a.Add("passwordSalt");
                        b.Add(passwordSalt);

                      
                        a.Add("password");
                        b.Add(khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt));



                        a.Add("email");
                        b.Add(email);

                       
                        a.Add("activeEmailSalt");
                        b.Add(EmailSalt);

                        a.Add("active");
                        b.Add(false);

                       

                        idUsers = khatam.core.data.sql.AddScope(a, b, "users");



                        if (idRole != null)
                        {
                            ArrayList aa = new ArrayList();
                            ArrayList bb = new ArrayList();

                            aa.Add("idRole");
                            bb.Add(idRole);

                            aa.Add("idUser");
                            bb.Add(idUsers);



                            khatam.core.data.sql.Add(aa, bb, "coreRoleRefUser");

                        }
               
                    }

                    return idUsers;

                }


                public static string changePasswordRecovery(string email)
                {

                    ArrayList a = new ArrayList();
                    ArrayList b = new ArrayList();




                    string passwordSalt = khatam.core.Security.Users.CreateSalt(10);
                    a.Add("passwordSalt");
                    b.Add(passwordSalt);

                    string pass=MakePassword(10);

                    a.Add("password");
                    b.Add(khatam.core.Security.Users.CreatePasswordHash(pass, passwordSalt));

                    
                    khatam.core.data.sql.update(a, b, "users", "email",email );

                    return pass;

              

                }

                public static string changePassword(string id,string password )
                {

                 
                    ArrayList a = new ArrayList();
                    ArrayList b = new ArrayList();




                    string passwordSalt = khatam.core.Security.Users.CreateSalt(10);
                    a.Add("passwordSalt");
                    b.Add(passwordSalt);

                    //string pass = MakePassword(10);

                    a.Add("password");
                    b.Add(khatam.core.Security.Users.CreatePasswordHash(password, passwordSalt));


                    khatam.core.data.sql.update(a, b, "users", "id", id);

                    return "pass";

                    
                }


           

                public static string validatorPassOnlyUserFromCookies(string passwordNotSalt)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    string userName = "";
                    
               


                    try
                    {


                        userName = HttpContext.Current.Request.Cookies["UID"].Value;
                    

                    }
                    catch
                    {
                    }


                    string passwordSalt = "";
                    //    try 
                    //    {
                    passwordSalt = khatam.core.data.sql.getField( "PasswordSalt", "email", userName, "users");
                    //   }
                    //catch 
                    //   {
                    //     passwordSalt ="" ;
                    // }
                    string password;

                    password = khatam.core.Security.Users.CreatePasswordHash(passwordNotSalt , passwordSalt);



                    parameters.Add("field_user", userName.Replace("'", ""));
                    parameters.Add("field_pass", password.Replace("'", ""));


                    str_sql = "SELECT  id   FROM  users   WHERE     (email = @field_user AND  password = @field_pass )";

                    string UserId = "0";

                    try
                    {
                        UserId = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    //## error
                    if (UserId == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return UserId;
                    }



                }

                public static bool ValidEmailOnly(string userEmail)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                   
                    parameters.Add("field_user", userEmail.Replace("'", ""));
                    


                    str_sql = "SELECT  id   FROM  users   WHERE     (email = @field_user)";

                    string UserId = "0" ;

                    try
                    {
                        UserId = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (UserId == "0")
                    {
                        return false ;
                    }
                    else
                    {

                        return true ;
                    }



                }


                public static bool ValidActiveByEmail(string userEmail)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("field_user", userEmail.Replace("'", ""));



                    str_sql = "SELECT  active   FROM  users   WHERE     (email = @field_user)";
                    
                    bool  active = false ;

                    try
                    {
                        active = Convert.ToBoolean( DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString());
                    }
                    catch
                    {

                    }

                    return active;


                }

                public static string getRealName(string id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
                                        
                    parameters.Add("id", id.Replace("'", ""));
                    
                    str_sql = "SELECT  fname + ' ' + lname   FROM  users   WHERE     (id = @id  )";

                    string RealName = "0";

                    try
                    {
                        RealName = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (RealName == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return   RealName;
                    }



                }

                public static string getEmail(string id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("id", id.Replace("'", ""));

                    str_sql = "SELECT  email   FROM  users   WHERE     (id = @id  )";

                    string RealName = "0";

                    try
                    {
                        RealName = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (RealName == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return RealName;
                    }



                }

                public static string getCellphone(string id)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("id", id.Replace("'", ""));

                    str_sql = "SELECT  cellphone   FROM  users   WHERE     (id = @id  )";

                    string RealName = "0";

                    try
                    {
                        RealName = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (RealName == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return RealName;
                    }



                }

                public static string getRealNameByEmail(string Email)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("Email", Email.Replace("'", ""));

                    str_sql = "SELECT  fname + ' ' + lname   FROM  users   WHERE     (Email = @Email  )";

                    string RealName = "0";

                    try
                    {
                        RealName = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (RealName == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return RealName;
                    }



                }

                        public static  string MakePassword(int length){ 
                        Random ran = new Random(DateTime.Now.Second); 
                        char[] password = new char[length]; 
 
                        for (int i = 0; i < length; i++){ 
                                int[] n = {ran.Next(48, 57), ran.Next(65, 90), ran.Next(97, 122)}; 
                                //int[] n = {ran.Next(33, 57), ran.Next(65, 90), ran.Next(97, 122)}; 
                                int picker = ran.Next(0, 3); 
 
                                if (picker == 3)//if i make the maxvalue 2 it "never" appears... dunno whats going on there 
                                        picker = 2; 
                                password[i] = (char)n[picker]; 
                        } 
 
                        return new string(password); 
                }

                   
                public static string getIdByEmail(string Email)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("Email", Email.Replace("'", ""));

                    str_sql = "SELECT  id   FROM  users   WHERE     (Email = @Email  )";

                    string RealName = "0";

                    try
                    {
                        RealName = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch
                    {

                    }
                    if (RealName == null)
                    {
                        return "0";
                    }
                    else
                    {

                        return RealName;
                    }



                }


                public static bool validator_old(string field_user, string field_user_value, string field_pass, string field_pass_value, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("field_user", field_user_value.Replace("'", ""));
                    parameters.Add("field_pass", field_pass_value.Replace("'", ""));


                    str_sql = "SELECT  *   FROM  " + table + "   WHERE     (" + field_user + " = @field_user) AND  (" + field_pass + " = @field_pass )";

                    if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) == null)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }



                }

                public static bool validatorWithActive(string field_user, string field_user_value, string field_pass, string field_pass_value, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("field_user", field_user_value.Replace("'", ""));
                    parameters.Add("field_pass", field_pass_value.Replace("'", ""));


                    str_sql = "SELECT  *   FROM  " + table + "   WHERE     (" + field_user + " = @field_user ) AND ( " + field_pass + " = @field_pass)  AND (Active = 1 )";

                    if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) == null)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }



                }


                public static  DataTable  getUserPermissionIdTitle(string userId)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                

                    parameters.Add("user_id", userId.Replace("'", ""));
                    


               str_sql="SELECT corePermission.id, corePermission.title"
                +" FROM corePermissionRefUser INNER JOIN"
                +" corePermission ON corePermissionRefUser.idPermission = corePermission.id"
                +" WHERE (corePermissionRefUser.idUser = @user_id)"
                +" UNION"
                +" SELECT corePermission_1.id, corePermission_1.title"
                +" FROM corePermission AS corePermission_1 INNER JOIN"
                +" coreRoleRefUser INNER JOIN"
                +" corePermissionRefRole ON coreRoleRefUser.idRole = corePermissionRefRole.idRole ON corePermission_1.id = corePermissionRefRole.idPermission"
                +" WHERE (coreRoleRefUser.idUser = @user_id)";

                   

                    return  DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) ;
                    


                }


                public static bool  validUserPermission(string userId,string corePermissonTitle)
                {
                    string str_sql, str_sql2;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("userId", userId.Replace("'", ""));
                    parameters.Add("title", corePermissonTitle.Replace("'", ""));


                    str_sql = "SELECT     corePermission.id   FROM         corePermission INNER JOIN          "  +
                        "              corePermissionRefUser ON corePermission.id = corePermissionRefUser.idPermission INNER JOIN       "  +
                        "                users ON corePermissionRefUser.idUser = users.id   WHERE     (corePermission.title = @title) AND (users.id = @userId)";
                    bool finded = false;

                    str_sql2 = "SELECT     corePermission.id   FROM         corePermission INNER JOIN                         users INNER JOIN                        coreRoleRefUser ON users.id = coreRoleRefUser.idUser INNER JOIN                        corePermissionRefRole ON coreRoleRefUser.idRole = corePermissionRefRole.idRole ON corePermission.id = corePermissionRefRole.idPermission  WHERE     (corePermission.title = @title) AND (users.id = @userId)";

                    //try
                   // {
                        if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                        {
                            finded = true;
                        }

                        if (finded != true)
                        {
                            if (DBFunctions.ExecuteScaler(str_sql2, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                            {
                                finded = true;
                            }
                        }
                    //}
                    //catch
                    //{

                    //}

                        //


                    return finded;


                }


         

                public static bool validUserPermission(string corePermissonTitle)
                {
                    string str_sql, str_sql2;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    

                    if (corePermissonTitle == "corePermissionRefUser_list") corePermissonTitle = "ManagerUsers";
                    if (corePermissonTitle == "eshop_sendMode_setting") corePermissonTitle = "eshop_sendMode";
                    if (corePermissonTitle == "eshop_sendMode_instance") corePermissonTitle = "eshop_sendMode";
                    

                    if (corePermissonTitle == "corePermissionRefRole_list") corePermissonTitle = "ManageUsersGroups";
                    if (corePermissonTitle == "coreRoleRefUserList") corePermissonTitle = "ManageUsersGroups";
                    if (corePermissonTitle == "forms_list") corePermissonTitle = "forms";
                    if (corePermissonTitle == "forms_item") corePermissonTitle = "forms";
                    if (corePermissonTitle == "formsFieldEdit") corePermissonTitle = "forms";
                    if (corePermissonTitle == "forms_list") corePermissonTitle = "forms";
                    if (corePermissonTitle == "forms_list") corePermissonTitle = "forms";

                    string userId = khatam.core.Security.Users.login().ToString();

                    parameters.Add("userId", userId );
                    parameters.Add("title", corePermissonTitle.Replace("'", ""));


                    str_sql = "SELECT     corePermission.id   FROM         corePermission INNER JOIN          " +
                        "              corePermissionRefUser ON corePermission.id = corePermissionRefUser.idPermission INNER JOIN       " +
                        "                users ON corePermissionRefUser.idUser = users.id   WHERE     (corePermission.title = @title) AND (users.id = @userId)";
                    bool finded = false;

                    str_sql2 = "SELECT     corePermission.id   FROM         corePermission INNER JOIN                         users INNER JOIN                        coreRoleRefUser ON users.id = coreRoleRefUser.idUser INNER JOIN                        corePermissionRefRole ON coreRoleRefUser.idRole = corePermissionRefRole.idRole ON corePermission.id = corePermissionRefRole.idPermission  WHERE     (corePermission.title = @title) AND (users.id = @userId)";

                    //try
                    // {
                    if (DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                    {
                        finded = true;
                    }

                    if (finded != true)
                    {
                        if (DBFunctions.ExecuteScaler(str_sql2, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()) != null)
                        {
                            finded = true;
                        }
                    }
                    //}
                    //catch
                    //{

                    //}

                    //


                    return finded;


                }


            
                public static string CreateSalt(int size)
                {
                    //Generate a cryptographic random number.
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    byte[] buff = new byte[size];
                    rng.GetBytes(buff);

                    // Return a Base64 string representation of the random number.
                    return Convert.ToBase64String(buff);
                }

                public static string CreatePasswordHash(string pwd, string salt)
                {
                    string saltAndPwd = String.Concat(pwd, salt);
                    string hashedPwd =
                     FormsAuthentication.HashPasswordForStoringInConfigFile(
                     saltAndPwd, "sha1");

                    return hashedPwd;
                }
            }

            public static class file
            {
                internal static string[] fileType_pic_Arr = {".jpg", ".bmp", ".png", ".gif", ".jpeg"};

                internal static string[] fileType_docPic_Arr = { ".jpg", ".bmp", ".png", ".gif", ".jpeg", ".doc", ".docx", ".pdf", ".xls", ".xlsx" };

                public static  bool typeValidator_docPic(string FileName)
                {
                  
                        foreach (string element in fileType_docPic_Arr)
                        {
                            if (System.IO.Path.GetExtension(FileName).ToLower() ==element )
                            return true;
                        }

                        return false;   
   
                	} 
                 

             public static  bool typeValidator_pic(string FileName)
                {
                  
                        foreach (string element in fileType_pic_Arr)
                        {
                            if (System.IO.Path.GetExtension(FileName).ToLower() ==element )
                            return true;
                        }

                        return false;   
   
                	} 
                 }
            

            public static class input
            {

                public static string removeInjectionChars(string str)
                {

                    if (str!=null)
                    str = str.Replace("'", "").Replace("<", "").Replace(">", "");


                    return str;
                }
                
            }
            

        }
    }
}
