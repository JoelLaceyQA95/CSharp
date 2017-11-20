<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="process.aspx.cs" Inherits="formRequest.process" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form  id="form1" runat="server">
        <div>
            <%
                   int A = Int32.Parse(Request.Form["numOne"]);
                   int B = Int32.Parse(Request.Form["numTwo"]);
                   Response.Write("The result is: " + (A + B));
                %>
        </div>
    </form>
</body>
</html>
