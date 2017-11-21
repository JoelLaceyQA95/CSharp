<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitEmail.aspx.cs" Inherits="emailApp.submitEmail" %>
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
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\C#Work\\CSharp\\emailApp\\emailApp\\App_Data\\emailDatabase.mdf';Integrated Security=True";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"insert into emails values('{Request.Form["to"]}', '{Session["user"]}', '{Request.Form["subject"]}', '{Request.Form["body"]}', getdate(), 'N', 'F')";
                int rowsEffected = cmd.ExecuteNonQuery();

                if (rowsEffected == 0)
                {
                    Response.Write("email could not be sent");
                    Response.Write("<a href='authenticated.aspx'>Go Back </a>");
                }
                else
                {
                    Response.Write("email sent");
                    Response.Write("<a href='authenticated.aspx'>Go Back </a>");
                }

            %>
        </div>
    </form>
</body>
</html>
