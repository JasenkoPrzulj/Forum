<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteTopic.aspx.cs" Inherits="Forum.Web.DeleteTopic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Radera ämne
            </h1>
            <p>
                Ämne<br />
                <asp:DropDownList ID="ddlTitle" runat="server">
                    <asp:ListItem Text="Titlar" value=""></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="btnDelete" OnClick="btnDelete_Click" Text="Radera ämne" runat="server" />
            </p>
            <p>
                <asp:Button ID="btnReturn" OnClick="btnReturn_Click" Text="Återvänd" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
