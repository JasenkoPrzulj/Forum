<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForumDetails.aspx.cs" Inherits="Forum.Web.ForumDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    ForumDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <div class="forum-details">
        <tr class="board-row">
            <th class="board-category" colspan="2">
                <h4 class="category">
                    <asp:HyperLink ID="lnkReturn" runat="server" Text="Forum" ForeColor="#000" Font-Underline="false"></asp:HyperLink> >
                <asp:Literal ID="litForumTitle" runat="server"></asp:Literal>
                </h4>
            </th>
            <th class="board-category" colspan="3">
                <asp:HyperLink CssClass="add-topic" ID="lnkAddTopic" runat="server" Text="Nytt ämne" ForeColor="#000" Font-Underline="false"></asp:HyperLink>
            </th>
        </tr>
        <tr class="head">
            <td>
                <img class="status-head"
                    src="http://cdn.arstechnica.net/civis/ars/theme/images/pages.png" />
            </td>
            <th class="board-head">Topic</th>
            <th class="topics-head">Topic Starter</th>
            <th class="posts-head">Replies</th>
            <th class="last-post-head">Last Post</th>
        </tr>
        <asp:ListView ID="lvTopics" runat="server">
            <LayoutTemplate>
                <div class="forum-topics">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>

            </LayoutTemplate>
            <ItemTemplate>
                <tr class="board-row">
                    <td class="board-icon">
                        <img class="board-icon"
                            src="http://turullegion.org/images/plain-letter.png" />
                    </td>
                    <th class="board-info">
                        <asp:HyperLink ID="lnkTopic" runat="server" ForeColor="#000" Font-Bold="true" Font-Underline="false"
                            NavigateUrl='<%# "~/TopicDetails.aspx?Id=" + Eval("Id") %>'
                            Text='<%# Eval("Title") %>'></asp:HyperLink>
                        <div class="topic">
                            <asp:LinkButton ID="lbtnDeleteTopic" runat="server"
                                OnClick="lbtnDeleteTopic_Click"
                                Text="Ta bort"
                                CssClass="remove-topic-link"
                                CommandArgument='<%# Eval("Id") %>'
                                OnClientClick='javascript: return confirm("Är du säker?");' />

                            <asp:HyperLink ID="lnkEditTopic" runat="server"
                                Text="Redigera"
                                CssClass="edit-topic-link"
                                NavigateUrl='<%# "~/EditTopic.aspx?Id=" + Eval("Id") %>'>
                            </asp:HyperLink>
                        </div>
                    </th>
                    <td class="board-topics">Jasenko</td>
                    <td class="board-posted">27875</td>
                    <td class="board-last-posted">Wed Mar 26, 2015 6:00pm<br />
                        By <a href="#">Jasenko</a></td>
                </tr>

            </ItemTemplate>
        </asp:ListView>
    </div>
    
</td>
    </td>
    
</asp:Content>



