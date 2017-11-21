<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="openEmail.aspx.cs" Inherits="emailApp.openEmail" %>
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
            <a href="deletedEmails.aspx"> Deleted</a>
            <br />
            <a href="sentEmails.aspx">Sent</a>
            <br />
        </div>

        <div id ="emails">
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
                    cmd.CommandText = "select * from emails where recipient = '" + Session["user"] + "' and emailID ='" + Request.QueryString["no"] + "'";
                    SqlDataReader R = cmd.ExecuteReader();

                    if (R.Read())
                    {
                        Response.Write("From: " +R["from"]+ "<br> Subject: "+R["subject"]+ "<br>" + R["body"]);
                    }
                    R.Close();

                    cmd.CommandText="update emails set status = 'R' where  recipient = '" + Session["user"] + "' and emailID ='" + Request.QueryString["no"] + "'";
                    cmd.ExecuteNonQuery();
                }
                %>
        </div>
    </form>
</body>
</html>
