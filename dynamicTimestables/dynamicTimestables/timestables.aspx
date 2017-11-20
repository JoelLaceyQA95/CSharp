<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timestables.aspx.cs" Inherits="dynamicTimestables.timestables_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <%
                int Table = Int32.Parse(Request.QueryString["T"]);
                Response.Write("<h1> Times table of " + Table + "</h1>");

                for(int i = 1; i <= 10; i++)
                {
                    Response.Write(Table + " x " + i + " = " + (i * Table));
                    Response.Write("<br>");
                }
            %>
        </div>
    </form>
</body>
</html>
