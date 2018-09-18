<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="usersearch.aspx.cs" Inherits="Controls_usersearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    &nbsp;&nbsp;&nbsp; 
    First Name: <asp:TextBox ID="txtUname" runat="server" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button runat="server" ID="btnSearch" Text="Search" 
        onclick="btnSearch_Click" />
    <br /><br />  

    <asp:GridView runat="server" ID="gvpost" AutoGenerateColumns="false" >
         <Columns>
           <asp:BoundField DataField="Uname" HeaderText="Title"  />
             <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="userEdit.aspx?Per_ID={0}" DataNavigateUrlFields="User_ID" />
            
        </Columns>
     </asp:GridView>
    </center>           
</asp:Content>

