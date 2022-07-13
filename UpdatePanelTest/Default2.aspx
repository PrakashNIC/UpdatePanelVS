<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="OuterPanel" UpdateMode="Conditional" runat="server">
            <ContentTemplate>
                <div>
                    <fieldset>
                        <legend>Outer Panel </legend>
                        <br />
                        <asp:Button ID="OPButton1" Text="Outer Panel Button" runat="server" />
                        <br />
                        Last updated on
                        <%= DateTime.Now.ToString() %>
                        <br />
                        <br />
                        <asp:UpdatePanel ID="NestedPanel1" UpdateMode="Conditional" runat="server">
                            <ContentTemplate>
                                <div class="NestedPanel">
                                    <fieldset>
                                        <legend>Nested Panel 1</legend>
                                        <br />
                                        Last updated on
                                        <%= DateTime.Now.ToString() %>
                                        <br />
                                        <asp:Button ID="NPButton1" Text="Nested Panel 1 Button" runat="server" />
                                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                                            <asp:ListItem>Hello1</asp:ListItem>
                                            <asp:ListItem>Hello2</asp:ListItem>
                                            <asp:ListItem>Hello3</asp:ListItem>
                                            <asp:ListItem>Hello4</asp:ListItem>
                                        </asp:DropDownList>
                                    </fieldset>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </fieldset>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
