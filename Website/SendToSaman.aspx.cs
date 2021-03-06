using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Web.Configuration;

public partial class SendToSaman : System.Web.UI.Page
{
    #region field
    public string Amount = string.Empty, ResNum = string.Empty, MID = string.Empty, RedirectURL = string.Empty;
    public string strMsg = string.Empty;
    #endregion

    khatam.shop.invoiceManager.invoice invoice = new khatam.shop.invoiceManager.invoice();

    protected void Page_Load(object sender, EventArgs e)
    {
        invoice = khatam.shop.invoiceManager.getInvoiceVirtual(this.Request.QueryString["id"].ToString(), this.Request.QueryString["pass"].ToString(), "1");

        lbl_id.Text = invoice.id.ToString();
        this.lbl_price.Text = invoice.price.ToString();

        if (invoice.payStatus == "2")
        {
          mainArea.Visible = false;
        }
        else
        {
            msg_earlyPaid.Visible = false;
            #region Sending Parameters
            // .خوانده می شوند Session از (Reservation Code) rsCode و Amount
            // آدرس صفحه ای است که RedirectURL فروشنده و Merchant Id همان MID
            //  Redirect پس از انجام عملیات بانکی از صفحه بانک سامان به آن جا
            //                                                      .می گردد
            Session["Amount"] = invoice.price  ;
            Amount = Session["Amount"].ToString();

            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("id_core_invoice");
            b.Add(invoice.id);

            a.Add("regDate");
            b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));
            /*error*/
            Session["rscode"] = khatam.core.data.sql.AddScope(a, b, "sbt");

            ResNum = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") + "_" + Session["rscode"].ToString();

            //khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".","_") + "_" + Session["rscode"].ToString();
            /*=>*/
            //MID = "02108787-104758";
            MID = "10004898";
           
            /*=>*/
            RedirectURL =khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "BackFromSaman.aspx";


            #endregion
        }
      /*  #region Register reservation information in database
        // .عملیات رزواسیون در بانک اطلاعاتی ثبت می گردد
        Dictionary<string, object> parameters = new Dictionary<string,object>();
        parameters.Add("ResNum", ResNum);
/*=>*/  //parameters.Add("Your field name", Your field value);
/*=>*/ // if (DBFunctions.ExecuteNonQuery("INSERT INTO SBT (ResNum, Your field names) VALUES (@ResNum, Your field parameters)",
//        if (DBFunctions.ExecuteNonQuery("INSERT INTO SBT (ResNum) VALUES (@ResNum)", 
  //  parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) != 1)
    // ###       strMsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد";*/
      //  #endregion
    }
}