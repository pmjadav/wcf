<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcForm.aspx.cs" Inherits="CalcWebClient.CalcForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% Response.Write("Calculator Client for WCF Service"); %>
        </div>
        <br />
        <asp:TextBox ID="txtOp1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtOp2" runat="server"></asp:TextBox>
        <asp:Label ID="lblResult" runat="server" Text="0.00"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnMul" runat="server" OnClick="btnMul_Click" Text="Multiply" />
    </form>
</body>
</html>
