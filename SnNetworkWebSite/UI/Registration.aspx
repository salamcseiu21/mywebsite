<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SnNetworkWebSite.UI.LogIn" MasterPageFile="~/MasterPage.Master"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="ContentPlaceHolder1">
        
    <div class="logInPage">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                
       
        <table>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
            <tr>
                <td colspan="3" style="text-align: center">
                    <h2><strong>Register Now</strong></h2>
                </td>
            </tr>
            <tr>
                <td >UserName</td>
                <td>
                    <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="userNameRequirdFiledValidator" runat="server" ErrorMessage="User Name is required!" ControlToValidate="userNameTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>E-mail</td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator2" runat="server" ErrorMessage="E-mail is required!" ControlToValidate="emailTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ErrorMessage="Please! Enter a valid Email address" ControlToValidate="emailTextBox" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="passwordRequiredFieldValidator" runat="server" ErrorMessage="Password is required!" ControlToValidate="passwordTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confiram Password</td>
                <td>
                    <asp:TextBox ID="confirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="confirmPasswordRequiredFieldValidator" runat="server" ErrorMessage="Enter the password again!" ControlToValidate="confirmPasswordTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="passwordCompareValidator" runat="server" ControlToCompare="passwordTextBox" ControlToValidate="confirmPasswordTextBox" ErrorMessage="Password not match!" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td></td>
             
                <td>
                    <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
                    <asp:Button ID="resetButton" runat="server" Text="Reset" OnClick="resetButton_Click" CausesValidation="False"/>
                    
                </td>
                <tr>
                    <td colspan="3"><asp:Label runat="server" ID="messageLabel"></asp:Label></td>
                </tr>
            </tr>
        </table>
          </ContentTemplate>
        </asp:UpdatePanel>
   </div>
 </asp:Content>
