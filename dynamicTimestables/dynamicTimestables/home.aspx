<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="dynamicTimestables.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                for(int i = 1; i <= 20000; i++)
                {
                    Response.Write("<a href='timestables.aspx?T=" + i + "'>" + i + "</a>");
                    Response.Write("<br>");

                }
            %>
        </div>
    </form>
</body>
</html>
