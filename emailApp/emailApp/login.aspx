<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="emailApp.login" %>
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

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\source\\repos\\emailApp\\emailApp\\App_Data\\emailDatabase.mdf';Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from Users where username ='" + Request.Form["username"] + "' and password ='" + Request.Form["password"] + "'";
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        Session["user"] = R["username"];
                        Response.Redirect("authenticated.aspx");
                    }
                    else
                    {
                        Response.Redirect("invalidUser.aspx");
                    }
                    R.Close();
                %>
        </div>
    </form>
</body>
</html>
