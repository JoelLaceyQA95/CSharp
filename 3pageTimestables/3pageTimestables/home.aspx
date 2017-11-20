<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="_3pageTimestables.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                Response.Write("<h1> Select times table </h1>");

                for(int i = 1; i < 1000; i++)
                {
                    Response.Write("<a href='range.aspx?T=" + i + "'>" + i + "</a>");
                    Response.Write("<br>");
                }

                %>
        </div>
    </form>
</body>
</html>
