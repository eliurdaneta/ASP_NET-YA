﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
           </br>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
           </br>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" />
        </div>
        <div>
           </br>
        </div>
          <div>
              <asp:Label ID="Label3" runat="server" ></asp:Label>
              <asp:Label ID="resultado" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
