<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelFirstNumber" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBoxFirstNumber" runat="server"></asp:TextBox>
        </div>
        <div>
           </br>
        </div>
        <div>
            <asp:Label ID="LabelSecondNumber" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        </div>
        <div>
        <div>
           </br>
        </div>
            <asp:Label ID="LabelOperation" runat="server"></asp:Label>
        </div>
         <div>
             <asp:RadioButton ID="RadioButtonAdd" runat="server" Text="Sumar" OnCheckedChanged="RadioButtonAdd_CheckedChanged" />
             <asp:RadioButton ID="RadioButtonSubtract" runat="server" Text="Restar" OnCheckedChanged="RadioButtonSubtract_CheckedChanged" />
        </div>
        <div>
        <div>
           </br>
        </div>
            <asp:Button ID="ButtonResult" runat="server" Text="Resultado" OnClick="ButtonResult_Click" />  
        </div>
        <div>
            <asp:Label ID="TextResult" runat="server" ></asp:Label>
            <asp:Label ID="LabelResult" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
