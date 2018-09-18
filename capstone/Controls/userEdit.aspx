<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="userEdit.aspx.cs" Inherits="Controls_userEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:Label ID="lbluser_ID" runat="server" /><br />
    UserName:<asp:TextBox ID="txtUname" CssClass="barslong3" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPword" CssClass="barslong3" runat="server"></asp:TextBox>
          
         <br />

        <br />
        Confirm Password:<asp:TextBox ID="txtPword2" CssClass="barslong3" runat="server"></asp:TextBox>
        
        <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

    <asp:Label ID="lblFeedback" runat="server" />

        <br />
        <br />
        
</asp:Content>

