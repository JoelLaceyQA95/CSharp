<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="authenticated.aspx.cs" Inherits="emailApp.authenticated" %>
<%@import namespace="System.Data.SqlClient"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                Response.Write(Request.QueryString["name"] + " is logged in");

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\source\\repos\\emailApp\\emailApp\\App_Data\\emailDatabase.mdf';Integrated Security=True";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from emails where to ='" + Request.QueryString["name"] + "'";
                SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                {
                    Response.Write("From: " + R["from"] + "<br>" + R["body"]);
                }

                %>
        </div>
    </form>
</body>
</html>
