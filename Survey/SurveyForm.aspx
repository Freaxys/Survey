<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SurveyForm.aspx.cs" Inherits="Survey.SurveyForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 1128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <div>
            <table align="center">

                <tr>
                    <td style="text-align:center" class="auto-style8">
            <br />
            <br />
            <asp:Label ID="lblWelcome" runat="server" Font-Bold="False" Font-Names="Calibri" Font-Size="Larger" Text="Welcome, please share your feedback"></asp:Label>
            <br />
            <br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
            Rate your overall experience using our service:
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
                <asp:RadioButtonList align="center" ID="radioScale" runat="server" Font-Names="Calibri">
                <asp:ListItem Selected="True">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
            Did you get what you were looking for?
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center; width:100%" class="auto-style8">
                <asp:RadioButtonList ID="radioBool" runat="server" Font-Names="Calibri" TextAlign="Left" align="center">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOpen" ForeColor="Red">Please leave a short comment.</asp:RequiredFieldValidator>
            <br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
            Share with us your thoughts about our service:<br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
            <asp:TextBox ID="txtOpen" runat="server" Font-Names="Calibri" Height="132px" TextMode="MultiLine" Width="521px"></asp:TextBox>
            <br />
            <br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align:center" class="auto-style8">
            <asp:Button ID="btnSubmit" runat="server" Font-Names="Calibri" Text="Submit" Width="113px" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                </table>
        </div>
</asp:Content>
