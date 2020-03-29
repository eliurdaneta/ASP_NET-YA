<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<%--Crearemos un sitio web que permita cargar dos valores y mediante un control DropDrownList
    poder seleccionar si queremos sumar, restar, multiplicar o dividir dichos valores 
    (En este caso no se puede seleccionar varios valores al mismo tiempo; puesto que esa es la
    diferencia entre el ListBox y el DropDronwList) cargamos en la propiedad Items las cuatro
    operaciones posibles.--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelFirstNumber" runat="server"></asp:Label>
            <asp:TextBox ID="TextFirstNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
         <div>
            <asp:Label ID="LabelSecoundNumber" runat="server"></asp:Label>
            <asp:TextBox ID="TextSecoundNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
         <div>
            <asp:Label ID="LabelOperac" runat="server"></asp:Label>
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList" runat="server"></asp:DropDownList>
        </div>
        <div>
            </br>
        </div>
         <div>
             <asp:Button ID="ButtonOperac" runat="server" Text="Operación" OnClick="ButtonOperac_Click" />
        </div>
        <div>
            </br>
        </div>
         <div>
             <asp:Label ID="LabelResultAdd" runat="server" ></asp:Label>
             </br>
             <asp:Label ID="LabelResultSubtrac" runat="server" ></asp:Label>
             </br>
             <asp:Label ID="LabelResultMult" runat="server" ></asp:Label>
             </br>
             <asp:Label ID="LabelResultDiv" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
