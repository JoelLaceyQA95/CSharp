<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newEmail.aspx.cs" Inherits="emailApp.newEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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

        <div id ="newEmail">
            <form action="submitEmail.aspx" method="post" runat="server">
                Compose your email
                <br />
                <input type="text" placeholder="To:" name="to"/>
                <br />
                <input type="text" placeholder="Subject:" name="subject"/>
                <br />
                <input type="text" placeholder="Message:" name="body"/>
                <br />
                <input type="submit" value="Send"/>
            </form>
        </div>
</body>
</html>
