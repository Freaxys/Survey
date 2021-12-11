<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyForm.aspx.cs" Inherits="Survey.SurveyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" Text="Welcome, please share your feedback"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            Rate your overall experience using our service:<asp:RadioButtonList ID="radioScale" runat="server" Font-Names="Calibri">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Did you get what you were looking for?<asp:RadioButtonList ID="radioBool" runat="server" Font-Names="Calibri">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOpen" ForeColor="Red">Please leave a short comment.</asp:RequiredFieldValidator>
            <br />
            Share with us your thoughts about our service:<br />
            <asp:TextBox ID="txtOpen" runat="server" Font-Names="Calibri" Height="132px" TextMode="MultiLine" Width="521px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Font-Names="Calibri" Text="Submit" Width="113px" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
