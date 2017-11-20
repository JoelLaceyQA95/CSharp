<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="formRequest.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
            <div>
            <form action="process.aspx" method="post" runat="server">
                First no: <input type="text" name="numOne"/><br/>

                Second no:<input type="text" name="numTwo"/><br/>
                <input type="submit" value="click"/>
            </form>
        </div>
</body>
</html>
