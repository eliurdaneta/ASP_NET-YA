<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Carga.aspx.cs" Inherits="Carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelName" runat="server"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:Label ID="LabelPais" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBoxPais" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
           <div>
               <asp:Label ID="LabelComments" runat="server"></asp:Label>
        </div>
         <div>
            </br>
        </div>
           <div>
               <asp:TextBox ID="TextBoxComments" runat="server" TextMode="MultiLine" Height="93px" Width="326px"></asp:TextBox>
        </div>
         <div>
            </br>
        </div>
           <div>
               <asp:Button ID="ButtonConfirm" runat="server" Text="Confirmar" OnClick="ButtonConfirm_Click" />
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:Label ID="LabelResult" runat="server" ></asp:Label>
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:HyperLink ID="HyperLinkReturn" runat="server"></asp:HyperLink>  
        </div>
    </form>
</body>
</html>
