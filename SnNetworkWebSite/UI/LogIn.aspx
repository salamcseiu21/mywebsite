<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="SnNetworkWebSite.UI.LogIn1" MasterPageFile="~/MasterPage.Master"%>

<asp:Content runat="server" ID="content3" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/UI/Home.aspx" FailureText="User Name or Password is incorred" OnAuthenticate="Login1_Authenticate"></asp:Login>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/UI/Registration.aspx">Need an Account</asp:LinkButton>
  </div>
 </asp:Content>