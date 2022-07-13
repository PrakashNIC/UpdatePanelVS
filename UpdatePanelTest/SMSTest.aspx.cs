using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;

public partial class SMSTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSMS_Click(object sender, EventArgs e)
    {
        try
        {
            NICSMSService nicsms = new NICSMSService();

            nicsms.SendSMS("Hello", "9122467396", "67890");
        }


//        NICSMSService
    }
}