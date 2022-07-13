<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SMSTest.aspx.cs" Inherits="SMSTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" style="text-align: center; font-weight: 700; text-decoration: underline; color: #0066CC;" 
            Text="Send Message"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtSMS" runat="server" Width="457px"></asp:TextBox>
        
        <asp:Button ID="btnSMS" runat="server" Text="Send" onclick="btnSMS_Click" />
        
        <br />
        <br />
        <br />
        
        <asp:Label ID="lblSMS" runat="server" Text="Label" 
            style="font-weight: 700; font-size: medium"></asp:Label>

    </div>
    </form>
</body>
</html>
