<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="addressBook.homePage" %>
<%@import namespace="System.Data.SqlClient"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>No.</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Change</th>
                </tr>
            <%
                SqlCommand cmd =  addressBook.homePage.connectToDB();
                cmd.CommandText = "select * from personalInfo";
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    Response.Write("<tr>");
                    Response.Write("<td>"+R["name"]+"</td> <td>"+R["address"]+"</td>");
                    Response.Write("</tr>");

                }




                %>
             </table>
        </div>
    </form>
</body>
</html>
