using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default26 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label1.Text= 
        AddTypeContent("estate","املاک");
    }

    void AddTypeContent(string type_content,string cname)
    {
        string typeContentIdentity;
        typeContentIdentity=  khatam.core.data.sql.getField("id", "height", "2", "type_content", type_content , "cat");
        if ((typeContentIdentity == "") || ((typeContentIdentity == "-1")))
        {
            // have not
          
           string rootid = khatam.core.data.sql.getField("id", "height", "1", "cat");
            if ((rootid == "") || ((rootid == "-1")))   khatam.core.support.sendToSupport("not root cat id found");

            string orderid = khatam.core.explorer.getOrderid(rootid);
          
            if ((orderid == "") || ((orderid == "-1")))
            {
                khatam.core.support.sendToSupport("in error in found orderid in addType Content ");
            }
            else
            {
                orderid = (int.Parse(orderid) + 1).ToString() ;

                string sortchar;
                     if (   orderid.Length > 1 )
                     {
                         sortchar = char.ConvertFromUtf32(63 + orderid.ToString().Length);                             
                             // ChrW(63 + orderid.ToString.Length);
                     }
                     else
                     {
                            sortchar = "";
                     }

                  string  sortid= khatam.core.data.sql.getField("sortid", "id", rootid , "cat");
            if ((sortid == "") || ((sortid == "-1")))   khatam.core.support.sendToSupport("not root sortid found");

                        string  new_cat_id, new_cat_sort_id;

                        new_cat_sort_id = sortid + "." + sortchar + orderid;

                        Label1.Text = new_cat_sort_id;
                        new_cat_id = insert_cat(orderid, cname, rootid , new_cat_sort_id, 2, 1, type_content, "8");
                        insert_cat("1", "فارسی", new_cat_id, new_cat_sort_id + ".1", 3, 1, type_content, "8");
                        insert_cat("2", "English", new_cat_id, new_cat_sort_id + ".2", 3, 1, type_content, "8");
                        
                        
                        //}
        }
     //   else
     //   {
           // have
       // }
           
      
       }             
    }


           string   insert_cat(string  orderid , string  cname , string  pid ,string   sortid ,int height, int type ,string  type_content ,string  id_setting_image_standard )
           {
               //type 1 for folder
                    //type 2 for file

                    
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("orderid", orderid);
                    parameters.Add("cname", cname);
                    parameters.Add("pid", pid);
                    parameters.Add("sortid", sortid);
                    parameters.Add("height", height);
                    parameters.Add("type", type);
                    parameters.Add("type_content", type_content);
                    parameters.Add("id_setting_image_standard", id_setting_image_standard);


                    str_sql = "INSERT INTO cat (orderid,cname,pid,sortid,height, type, type_content,id_setting_image_standard) VALUES (@orderid,@cname,@pid,@sortid,@height,@type, @type_content,@id_setting_image_standard);SELECT SCOPE_IDENTITY();";


                    //return  DBFunctions.ExecuteScaler(str_sql, parameters, Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())

                    object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    if (_obj == null)
                    {
                        return "-1" ;
                    }
                    else
                    {
                        return _obj.ToString();
                    }

           }

}