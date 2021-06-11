using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;


/// <summary>
/// Summary description for loadercore
/// </summary>

namespace khatam
{
    namespace core
    {
    
                public static class License
                {
                    
             


                       public static bool ValidModule(string ModuleName)
                    {
                           /*add free madule*/
                        string[] moduleArr = khatam.core.ConfigurationManager.License.moduleArr;

                        return moduleArr.Contains(ModuleName);
                    }





                    public static bool LicenceValidator()
                    {
                        bool Licence = true;

                        //host detail
                     
                        string hostip = khatam.core.ConfigurationManager.License.hostip ;
                        DateTime ExpireTime = khatam.core.ConfigurationManager.License.ExpireTime;

                        DateTime NowTime = DateTime.UtcNow;


                      
                        
                        if (khatam.core.ConfigurationManager.License.domainsArr.Contains(khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()))
                        {

                        }
                        else
                        {
                            Licence = false;
                        }

                        if (HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"] == hostip)
                        {

                        }
                        else
                        {
                            Licence = false;
                        }

                        if (ExpireTime > NowTime)
                        {

                        }
                        else
                        {
                            Licence = false;
                        }



                     
                        return Licence;
                    }


                    public static bool LicenceValidatorUser(Int16 userNumber)
                    {
                        //host user
                        
                        if (userNumber < khatam.core.ConfigurationManager.License.userLimit)
                        {

                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    }

                }
            

            
        
    }
}



