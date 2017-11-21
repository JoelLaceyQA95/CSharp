<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="emailApp.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="login.aspx" method="post">
        <div>
                Username: <input type="text" name="username" />
                <br />
                Password: <input type="password" name="password" />
                <br />
                <input type="submit" value="submit" />
        </div>
    </form>
</body>
</html>
