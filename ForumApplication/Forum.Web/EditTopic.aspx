<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTopic.aspx.cs" Inherits="Forum.Web.EditTopic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Topic
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <div class="topic-details">
        <tr class="board-row">
            <th class="board-category" colspan="2">
                <h4 class="category">
                    <asp:HyperLink ID="lnkReturnToForum" runat="server" Text="Forum" ForeColor="#000" Font-Underline="false"></asp:HyperLink>
                    >
                    <asp:HyperLink ID="lnkReturn" runat="server" Text="SharePoint" ForeColor="#000" Font-Underline="false"></asp:HyperLink>
                    > 
                    <asp:Literal ID="litTopicTitle" runat="server"></asp:Literal>
                </h4>
            </th>
        </tr>
        <%--Kommentarsruta--%>
        <tr>
            <th class="head" colspan="2">
                <asp:HyperLink ID="lnkAddComment" runat="server" Text="Kommentera" ForeColor="#000" Font-Underline="false"></asp:HyperLink>
            </th>
        </tr>
        <tr class="post">
            <td class="reg-user">
                <b>Skapare</b><br />
                New guy<br />
                Stockholm
            </td>
            <th class="post" colspan="1">
                <p>
                    <asp:Literal ID="litTopicTitleInside" runat="server"></asp:Literal>
                </p>
                <h5>
                    <asp:Literal ID="litTopicContent" runat="server"></asp:Literal></h5>
            </th>
        </tr>
    </div>
    <%--Redigering--%>
    <tr class="post">
        <th class="post" colspan="2">
            <h3>Redigera Ämnet
            </h3>
            <p>
                Titel<br />
                <asp:TextBox ID="tbTopicTitle" runat="server"></asp:TextBox>
            </p>
            <p>
                Innehåll<br />
                <asp:TextBox ID="tbTopicContent" TextMode="MultiLine" Columns="50" Rows="7" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Spara" />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Återvänd" />
        </th>
    </tr>
</asp:Content>
