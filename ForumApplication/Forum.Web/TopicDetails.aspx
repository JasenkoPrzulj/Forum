<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TopicDetails.aspx.cs" Inherits="Forum.Web.TopicDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    TopicDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <%--Navigering--%>
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
                <h5><asp:Literal ID="litTopicContent" runat="server"></asp:Literal></h5>
            </th>
        </tr>
        <%--Ny post--%>
        <asp:ListView ID="lvReplies" runat="server">
            <LayoutTemplate>
                <div class="topic-replies">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr class="post">
                    <td class="reg-user">
                        <b>Anonym</b><br />
                        New guy<br />
                        Stockholm
                    </td>
                    <th class="post" colspan="1">
                        <div class="reply-details">
                            <h5>
                                <%# Eval ("Content") %>
                            </h5>
                        </div>
                    </th>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <tr>
            <th class="head" colspan="2">
                <asp:HyperLink ID="lnkAddComment" runat="server" Text="Kommentera" ForeColor="#000" Font-Underline="false"></asp:HyperLink>
            </th>
        </tr>
    </div>
</asp:Content>
