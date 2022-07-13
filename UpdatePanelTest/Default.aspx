<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
        <ContentTemplate>
            <fieldset>
                <legend>UpdatePane Conditional</legend>
                <!-- Other content in the panel. -->
                <%=DateTime.Now.ToString() %>
                <br />
                <asp:Button ID="Button1" Text="Refresh Panel" runat="server" />
                <asp:Button ID="Button6" Text="Inside Postback" runat="server" />
                <asp:Button ID="Button7" Text="Ansync Postback" runat="server" />
                <asp:Button ID="Button9" runat="server" Text="No Action" Width="115px" />
            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button7" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="Button8" EventName="Click" />
            <asp:PostBackTrigger ControlID="Button6" />
        </Triggers>       
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Always" runat="server">
        <ContentTemplate>
            <fieldset>
                <legend>UpdatePanel Always</legend>
                <!-- Other content in the panel. -->
                <%=DateTime.Now.ToString() %>
                <br />
                <asp:Button ID="Button2" Text="Refresh Panel" runat="server" />
                <asp:Button ID="Button5" Text="Inside Post Back" runat="server" />

            </fieldset>
        </ContentTemplate>
         <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            <asp:PostBackTrigger ControlID="Button5" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:Panel runat="server" GroupingText="Other content in the panel. ">

        <%=DateTime.Now.ToString() %>
        <br />
        <asp:Button ID="Button3" Text="Complete Post Back" runat="server" />
        <asp:Button ID="Button4" Text="Outside Asyn Post Back-Always" runat="server" />
        <asp:Button ID="Button8" Text="Outside Asyn Post Back-Conditional" runat="server" />
    </asp:Panel>
</asp:Content>
