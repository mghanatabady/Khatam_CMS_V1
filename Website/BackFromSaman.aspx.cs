using System;
using System.Data;
using System.Collections.Generic;
using System.Web.Configuration;

public partial class BackFromSaman : System.Web.UI.Page
{
    #region fields
    public double t_lAmount = 0;
    public string message = string.Empty;
    public string t_strRefNum = string.Empty;
    public string t_strResNum = string.Empty;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        #region fields
        t_lAmount = double.Parse(Session["Amount"].ToString());
		bool isError = false;
        string strMsg = string.Empty;
        // وب سرویس بانک سامان
        com.samanepay.acquirer.PaymentIFBinding samanBankServices = new com.samanepay.acquirer.PaymentIFBinding();
/*=>*/  // sb24.acquirer.ReferencePayment samanBankServices = new com.sb24.acquirer.ReferencePayment();
        #endregion
        if (Request.Form["State"].Equals("OK"))
        {
            double Result = -1000;
            t_strRefNum = Request.Form["RefNum"].ToString();
           
            

            t_strResNum = Request.Form["ResNum"].ToString().Replace(
                khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_" ,"");


            if (t_strRefNum.Equals(string.Empty))
            {
                isError = true;
                strMsg = "گويا خريد شما توسط بانک تاييد شده است اما رسيد ديجيتالي شما تاييد نگشت";
                t_strResNum = "مشکلي در فرايند رزرو خريد شما پيش آمده است";
            }
            else
            {
                Session["RefNum"] = Request.Form["RefNum"].ToString();
                try
                {
                    string MID = "10004898";
                    Result = samanBankServices.verifyTransaction(t_strRefNum, MID);
                    double strTempRes = Result;
                    string strNodeType;
                    if (strTempRes > 0)
                    {
                        strTempRes = 1;
                    }
                    switch ((int)strTempRes)
                    {
                        case 1:		//VERIFIED
                            //connection.Open()
                            if (Result < t_lAmount) //Total Amount of Basket
                            {
                                strMsg = "مبلغ انتقالي کمتر از مبلغ کل فاکتور ميباشد";
                                isError = true;
                            }
                            else
                                if (Result.Equals(t_lAmount)) //Total Amount of Basket
                                {
                                    isError = false;
                                    strMsg = "بانک صحت رسيد ديجيتالي شما را تصديق نمود. فرايند خريد تکميل گشت";
                                }
                                else
                                    if (Result > t_lAmount) //Total Amount of Basket
                                    {
                                        isError = false;
                                        strMsg = string.Format("خريد شما تاييد و نهايي گشت اما مبلغ انتقالي {0} ريال بيش از مبلغ خريد ميباشد", Result);
                                    }
                            break;
                        case -1:		//TP_ERROR
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "بروز خطا درهنگام بررسي صحت رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -2:		//ACCOUNTS_DONT_MATCH
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "بروز خطا در هنگام تاييد رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -3:		//BAD_INPUT
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -4:		//INVALID_PASSWORD_OR_ACCOUNT
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطاي دروني سيستم درهنگام بررسي صحت رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -5:		//DATABASE_EXCEPTION
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطاي دروني سيستم درهنگام بررسي صحت رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -7:		//ERROR_STR_NULL
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -8:		//ERROR_STR_TOO_LONG
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -9:		//ERROR_STR_NOT_AL_NUM
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -10:	//ERROR_STR_NOT_BASE64
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        case -11:	//ERROR_STR_TOO_SHORT
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "خطا در پردازش رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            break;
                        default:
                           // isError = false;
                            
                            isError = true;
                            strNodeType = "errornode";
                            strMsg = "بروز خطا درهنگام بررسي صحت رسيد ديجيتالي در نتيجه خريد شما تاييد نگرييد";
                            // * */
                            break;
                    }
                }
                catch (Exception ex)
                {
                    isError = true;
                    strMsg = "سرور بانک براي تاييد رسيد ديجيتالي در دسترس نيست<br><br><div dir ='ltr' align='left'>" + ex.Message + "</div>";
                }
            }
            if (t_strRefNum.Equals(string.Empty))
            {
                isError = true;
                strMsg = "گويا فرايند انتقال وجه با موفقيت انجام شده است اما فرايند تاييد رسيد ديجيتالي با خطا مواجه گشت";
                t_strRefNum = "مشکلي در خريد شما پيش آمده است";
            }
            if (isError)
                message = string.Format("<P><font color=\"#DD0000\">{0}{1}</font></P>", strMsg, Request.Form["State"]);
            else
                message = string.Format("<P><font color=\"#009900\">{0}</font></P>", strMsg);
        }
        else
        {
            strMsg = string.Format("{0} متاسفانه بانک خريد شما را تاييد نکرده است", Request.Form["State"]);
            isError = true;
            t_strRefNum = "خريد شما تاييد نگشته است";
            t_strResNum = string.Format("ديگر معتبر نيست {0} شماره خريد", Request.Form["ResNum"]);
            message = string.Format("<P><font color=\"#ff3300\">{0}</font></P>", strMsg);
        }
        //update database
        int t_intState;
        if (isError)
            t_intState = 2;
        else
            t_intState = 1;
        if (Request.Form["ResNum"].Equals(string.Empty))
        {
            strMsg = "خطا در برقرار ارتباط با بانک";
            isError = false;
        }
        else
        {
            Dictionary<string, object> parameters = new Dictionary<string,object>();
            parameters.Add("RefNum", Request.Form["RefNum"]);
            parameters.Add("State", t_intState);
            parameters.Add("backDate", DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));            
            parameters.Add("ResNum", Request.Form["ResNum"].ToString().Replace(
                khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_" ,""));
            /*=>*/
            if (DBFunctions.ExecuteNonQuery("UPDATE SBT SET RefNum = @RefNum, State = @State,backDate = @backDate WHERE ResNum = @ResNum", parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) != 1)
                strMsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد";

            string invoiceId = khatam.core.data.sql.getField( "id_core_invoice", "resnum", Request.Form["ResNum"].ToString().Replace(
              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_", ""), "sbt");

            if (t_intState == 1)
            {            
                khatam.core.data.sql.updateField("payStatus","2","id",invoiceId,"core_invoice",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                khatam.core.data.sql.updateField("sendStatus", "2", "id", invoiceId, "core_invoice", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }

            string idRandom = khatam.core.data.sql.getField( "idRandom", "id", invoiceId, "core_invoice");

         Hl1.NavigateUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                + "&pass=" + idRandom;

        }
    }
   // private void RedirectTo(string url)
   // {
        //url is in pattern "~myblog/mypage.aspx"
      //  string redirectURL = Page.ResolveClientUrl(url);
     //   string script = "window.location = '" + redirectURL + "';";
      //  ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
  //  }

}