<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="authenticated.aspx.cs" Inherits="emailApp.authenticated" %>
<%@import namespace="System.Data.SqlClient"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="title">
            <% Response.Write("<h1>" + Session["user"] + " is logged in </h1> <a href='logout.aspx'>Log out</a> <br>");%>
        </div>

        <div id="sideBar">
            <a href="newEmail.aspx">Compose email</a>
            <br />
            <a href="authenticated.aspx">Inbox</a>
            <br />
            <a href="deletedEmails.aspx">Deleted</a>
            <br />
            <a href="sentEmails.aspx">Sent</a>
            <br />
        </div>

        <div id="emailTable">
            <table border='2'>
                <tr>
                    <td> From </td>
                    <td> Subject </td>
                    <td> Date </td>
                </tr>
            <%
                if (Session["user"] == null)
                {
                    Response.Redirect("home.aspx");
                }
                else
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\C#Work\\CSharp\\emailApp\\emailApp\\App_Data\\emailDatabase.mdf';Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from emails where recipient = '" + Session["user"] + "'";
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        if (R["status"].ToString() == "N")
                        {
                            Response.Write("<tr>");
                            Response.Write("<td> <a href ='openEmail.aspx?no=" + R["emailID"] + "'>" + R["from"] + "</a> </td><td> <a href ='openEmail.aspx?no=" + R["emailID"] + "'>" + R["subject"] + "</a> </b> </td> <td>" + R["date"] + "</td>");
                            Response.Write("</tr>");
                        }
                        else
                        {
                            Response.Write("<tr>");
                            Response.Write("<td> <a href ='openEmail.aspx?no=" + R["emailID"] + "'>" + R["from"] + "</a> </td><td> <a href ='openEmail.aspx?no=" + R["emailID"] + "'>" + R["subject"] + "</a> </td> <td>" + R["date"] + "</td>");
                            Response.Write("</tr>");
                        }
                    }
                    R.Close();
                }
                %>
                </table>
        </div>
    </form>
</body>
</html>
