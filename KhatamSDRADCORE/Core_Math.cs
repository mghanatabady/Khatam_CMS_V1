using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace khatam
{
    namespace core
    {
        public static class Math
        {

          public  static int DivideRoundUp(int p1, int p2)
            {
                return (int)System.Math.Ceiling((double)p1 / p2);
            } 


        }
    
    }
}