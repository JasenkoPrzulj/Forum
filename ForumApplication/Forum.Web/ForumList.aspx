<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForumList.aspx.cs" Inherits="Forum.Web.ForumList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Forum</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">

    <asp:ListView ID="lvCategories" runat="server" OnSelectedIndexChanged="lvCategories_SelectedIndexChanged">
        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            <th class="board-category" colspan="7">
                <h4 class="category"><%# Eval("Name") %></h4>
            </th>
            <tr class="head">
                <td>
                    <img class="status-head"
                        src="http://cdn.arstechnica.net/civis/ars/theme/images/pages.png" />
                </td>
                <th class="board-head">Forum</th>
                <th class="topics-head">Topics</th>
                <th class="posts-head">Posts</th>
                <th class="last-post-head">Last Post</th>
            </tr>
            <asp:ListView runat="server" DataSource='<%# Eval("Fora") %>'>
                <LayoutTemplate>
                    <ul>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </ul>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr class="board-row">
                        <td class="board-icon">
                            <img class="board-icon"
                                src="http://turullegion.org/images/plain-letter.png" />
                        </td>
                        <th class="board-info">
                                <asp:HyperLink Text='<%# Eval("Name") %>'
                                    runat="server" ForeColor="#000" Font-Underline="false"
                                    NavigateUrl='<%# "~/ForumDetails.aspx?id=" + Eval("Id") %>' />
                        </th>
                        <td class="board-topics">20</td>
                        <td class="board-posted">278</td>
                        <td class="board-last-posted">Wed Mar 26, 2015 6:00pm<br />
                            By <a href="#">Jasenko</a></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
