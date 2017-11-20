<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="range.aspx.cs" Inherits="_3pageTimestables.range" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                Response.Write("<h1> Select range </h1>");
                string table = Request.QueryString["T"];

                for(int i = 10; i <= 100; i++)
                {
                    Response.Write("<a href='timestables.aspx?T=" + table + "&R=" + i + "'>" + i + "</a>");
                    Response.Write("<br>");
                }
                %>
        </div>
    </form>
</body>
</html>
