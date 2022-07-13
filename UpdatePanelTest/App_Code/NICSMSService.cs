using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;

using System.Net.Security;
using System.Security.Policy;
using System.IO;
using System.Net;
using System.Text;
using System.Data;

/// <summary>
/// Summary description for NICSMSService
/// </summary>
public class NICSMSService
{
	String username = "BIHAREDISTRICT-nic";

    String password = "Nic@1234";

    String senderid = "BRGOVT";

    String PWD = "67890";

    //static String message = "message";
    //static String mobileNo = "9856XXXXX";
    //static String mobileNos = "9856XXXXX, 9856XXXXX ";
    //static String scheduledTime = "20110819 13:26:00";

    static HttpWebRequest request;
    static Stream dataStream;
    public NICSMSService()
	{
        
    }

    public string SendSMSunicodeNew(string Msg, string Dest, string Password, string UserId)
    {
        if (Password != PWD) return "Authentication Failed";

        String finalmessage = "";

        String sss = "";

        foreach (char c in Msg)
        {

            int j = (int)c;

            sss = "&#" + j + ";";

            finalmessage = finalmessage + sss;

        }

        Msg = finalmessage;

        request = (HttpWebRequest)WebRequest.Create("http://msdgweb.mgov.gov.in/esms/sendsmsrequest");
        request.ProtocolVersion = HttpVersion.Version10;

        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0(compatible; MSIE 5.0; Windows 98; DigExt)";
        request.Method = "POST";

        String smsservicetype = "unicodemsg";
        String query = "username=" +
        HttpUtility.UrlEncode(username) +
        "&password=" + HttpUtility.UrlEncode(password) +
        "&smsservicetype=" +
        HttpUtility.UrlEncode(smsservicetype) +
        "&content=" + HttpUtility.UrlEncode(Msg) +
        "&mobileno=" + HttpUtility.UrlEncode(Dest) +
        "&senderid=" + HttpUtility.UrlEncode(senderid);
        byte[] byteArray = Encoding.ASCII.GetBytes(query);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        //dataStream.Close();
        WebResponse response = request.GetResponse();
        String Status =
        ((HttpWebResponse)response).StatusDescription;
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();

        string mesg = "";

        if (responseFromServer.Substring(0, 3) == "402")
        {
            mesg = "Message Sent Successfully...";
        }
        else
            mesg = "There is some problem in sending message...";


        return mesg;
    }
    public string SendSMSNew(string Msg, string Dest, string Password, string UserId)
    {
        if (Password != PWD) return "Authentication Failed";

        request = (HttpWebRequest)WebRequest.Create("http://msdgweb.mgov.gov.in/esms/sendsmsrequest");
        request.ProtocolVersion = HttpVersion.Version10;

        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0(compatible; MSIE 5.0; Windows 98; DigExt)";
        request.Method = "POST";

        String smsservicetype = "singlemsg"; //For single message.

        String query = "username=" +
        HttpUtility.UrlEncode(username) +
        "&password=" + HttpUtility.UrlEncode(password) +
        "&smsservicetype=" +
        HttpUtility.UrlEncode(smsservicetype) +
        "&content=" + HttpUtility.UrlEncode(Msg) +
        "&mobileno=" + HttpUtility.UrlEncode(Dest) +
        "&senderid=" + HttpUtility.UrlEncode(senderid);
        byte[] byteArray = Encoding.ASCII.GetBytes(query);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        //dataStream.Close();
        WebResponse response = request.GetResponse();
        String Status =
        ((HttpWebResponse)response).StatusDescription;
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();

        string mesg = "";
        if (responseFromServer.Substring(0, 3) == "402")
        {
            mesg = "Message Sent Successfully...";
        }
        else
            mesg = "There is some problem in sending message...";
        return mesg;
    }

    public string SendSMS(string Msg, string Dest, string Password)
    {
        if (Password != PWD) return "Authentication Failed";

        request = (HttpWebRequest)WebRequest.Create("http://msdgweb.mgov.gov.in/esms/sendsmsrequest");
        request.ProtocolVersion = HttpVersion.Version10;

        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0(compatible; MSIE 5.0; Windows 98; DigExt)";
        request.Method = "POST";

        String smsservicetype = "singlemsg"; //For single message.

        String query = "username=" +
        HttpUtility.UrlEncode(username) +
        "&password=" + HttpUtility.UrlEncode(password) +
        "&smsservicetype=" +
        HttpUtility.UrlEncode(smsservicetype) +
        "&content=" + HttpUtility.UrlEncode(Msg) +
        "&mobileno=" + HttpUtility.UrlEncode(Dest) +
        "&senderid=" + HttpUtility.UrlEncode(senderid);
        byte[] byteArray = Encoding.ASCII.GetBytes(query);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        //dataStream.Close();
        WebResponse response = request.GetResponse();
        String Status =
        ((HttpWebResponse)response).StatusDescription;
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();

        string mesg = "";
        if (responseFromServer.Substring(0, 3) == "402")
            mesg = "Message Sent Successfully...";
        else
            mesg = "There is some problem in sending message...";
        return mesg;
    }

    public string SendSMSunicode(string Msg, string Dest, string Password)
    {
        if (Password != PWD) return "Authentication Failed";

        String finalmessage = "";

        String sss = "";

        foreach (char c in Msg)
        {
            int j = (int)c;
            sss = "&#" + j + ";";
            finalmessage = finalmessage + sss;
        }

        Msg = finalmessage;

        request = (HttpWebRequest)WebRequest.Create("http://msdgweb.mgov.gov.in/esms/sendsmsrequest");
        request.ProtocolVersion = HttpVersion.Version10;

        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0(compatible; MSIE 5.0; Windows 98; DigExt)";
        request.Method = "POST";

        String smsservicetype = "unicodemsg";
        String query = "username=" +
        HttpUtility.UrlEncode(username) +
        "&password=" + HttpUtility.UrlEncode(password) +
        "&smsservicetype=" +
        HttpUtility.UrlEncode(smsservicetype) +
        "&content=" + HttpUtility.UrlEncode(Msg) +
        "&mobileno=" + HttpUtility.UrlEncode(Dest) +
        "&senderid=" + HttpUtility.UrlEncode(senderid);
        byte[] byteArray = Encoding.ASCII.GetBytes(query);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        //dataStream.Close();
        WebResponse response = request.GetResponse();
        String Status =
        ((HttpWebResponse)response).StatusDescription;
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();

        string mesg = "";
        if (responseFromServer.Substring(0, 3) == "402")
            mesg = "Message Sent Successfully...";
        else
            mesg = "There is some problem in sending message...";

        return mesg;
    }
}