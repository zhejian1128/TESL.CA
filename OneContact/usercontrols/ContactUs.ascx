<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.ascx.cs" Inherits="OneContact.usercontrols.ContactUs" %>

<asp:PlaceHolder runat="server" ID="Form">
    <asp:Label runat="server" AssociatedControlID="ContactType">Type of inquiry</asp:Label><br/>
    <asp:DropDownList ID="ContactType" runat="server"></asp:DropDownList><br />

    <asp:Label runat="server" AssociatedControlID="Name">Name</asp:Label><br/>
    <asp:TextBox ID="Name" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Name" Display="Dynamic" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
    <br />

    <asp:Label runat="server" AssociatedControlID="Email">Email</asp:Label><br/>
    <asp:TextBox ID="Email" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" ErrorMessage="Email is required" Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator runat="server" ControlToValidate="Email" ErrorMessage="Email is not valid" Display="Dynamic" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
    <br />

    <asp:Label runat="server" AssociatedControlID="Message">Message</asp:Label><br/>
    <asp:TextBox TextMode="MultiLine" ID="Message" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Message" ErrorMessage="Message is required" Display="Dynamic"></asp:RequiredFieldValidator>
    <br />

    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="SendMail" />
</asp:PlaceHolder>

<asp:PlaceHolder runat="server" ID="Thanks" Visible="False">
    <p>Thanks, we'll get back to you soon!</p>
</asp:PlaceHolder>