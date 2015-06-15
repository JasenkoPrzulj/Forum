<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Forum.Web.Category" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" DataKeyNames="Id" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True" CellPadding="8" ShowFooter="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Spara" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Avbryt" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Button ID="Button3" runat="server" CausesValidation="False" CommandName="Edit" Text="Ändra" />
                    &nbsp;<asp:Button ID="Button4" runat="server" CausesValidation="False" CommandName="Delete" Text="Ta Bort" />
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnInsert" OnClick="btnInsert_Click" runat="server" Text="Lägg Till" />
                </FooterTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="Id" ReadOnly="true" HeaderText="Id" SortExpression="Id" Visible="False" />

            <asp:TemplateField HeaderText="Name" SortExpression="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteCategory" InsertMethod="InsertCategory" SelectMethod="GetCategories" TypeName="Forum.DataLayer.Business_Logic_Layer.CategoryManager" UpdateMethod="UpdateCategory">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Id" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>


