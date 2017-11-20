﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timestables.aspx.cs" Inherits="_3pageTimestables.timestables" %>

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
                             int Range = Int32.Parse(Request.QueryString["R"]);

                             Response.Write("<h1> Times table of " + Table + " with range of " + Range + "</h1>");

                             for(int i = 1; i <= Range; i++)
                             {
                                 Response.Write(Table + " x " + i + " = " + (i * Table));
                                 Response.Write("<br>");
                             }
            %>
        </div>
    </form>
</body>
</html>
