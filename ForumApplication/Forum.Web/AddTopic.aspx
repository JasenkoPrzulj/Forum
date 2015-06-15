<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTopic.aspx.cs" Inherits="Forum.Web.AddTopic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Add Topic
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <div>
        <h1>Nytt ämne</h1>
        <p>
            Titel<br />
            <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
        </p>
        <p>
            Innehåll<br />
            <asp:TextBox ID="tbContent" TextMode="MultiLine" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSave" OnClick="btnSave_Click" Text="Spara" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnReturn" OnClick="btnReturn_Click" Text="Återvänd" runat="server" />
        </p>
    </div>
</asp:Content>
