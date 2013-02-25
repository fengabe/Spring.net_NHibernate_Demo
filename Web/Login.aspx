<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        用户名</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtLoginName"
                            ErrorMessage="请输入用户名"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        密码</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtLoginPwd" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RequiredFieldValidator ID="rfvPws" runat="server" ControlToValidate="txtLoginPwd"
                            ErrorMessage="请输入密码"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="  Login  " /></td>
                    <td style="width: 100px">
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
