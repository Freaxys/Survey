<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="Survey.ResultPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView align="center" ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="674px">
            <Columns>
                <asp:BoundField DataField="Answer1" HeaderText="1st Question" SortExpression="Answer1" />
                <asp:BoundField DataField="Answer2" HeaderText="2nd Question" SortExpression="Answer2" />
                <asp:BoundField DataField="Answer3" HeaderText="3rd Question" SortExpression="Answer3" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SurveyAppConnectionString %>" SelectCommand="SELECT [Answer1], [Answer2], [Answer3] FROM [AnswerSet]"></asp:SqlDataSource>
    </p>
</asp:Content>
