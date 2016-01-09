<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SnNetworkWebSite.UI.Home" MasterPageFile="~/MasterPage.Master" %>

<asp:Content runat="server" ID="content2" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <div>
        <asp:Button runat="server" ID="signOutButton" Text="Sign Out" OnClick="signOutButton_Click"/>
   <asp:Label runat="server" ID="messageLabel"></asp:Label>
    </div>
</asp:Content>