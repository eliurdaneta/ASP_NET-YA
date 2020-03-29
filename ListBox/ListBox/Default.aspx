<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<%--El control ListBox permite crear una lista de valores.
La propiedad Item permite definir los miembros de la lista (cada item define las propiedades Text (valor a mostrar),
Value (valor a retornar en caso de estar seleccionado), Selected (con un valor lógico))
Otra propiedad muy importante del control ListBox es SelectionMode, esta admite dos valores: Single o Multiple.--%>

<%--Crearemos un sitio web que permita cargar dos valores y mediante un control ListBox poder seleccionar si
queremos sumar, restar, multiplicar o dividir dichos valores 
(como podemos seleccionar varias operaciones en forma simultánea configuraremos la propiedad SelectionMode del ListBox con el valor Multiple)
cargamos en la propiedad Items las cuatro operaciones posibles.--%>
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
          </br>
        </div>
        <div>
            <asp:Label ID="LabelOperac" runat="server" ></asp:Label>
        </div>
         <div>
          </br>
        </div>
        <div>
            <asp:ListBox ID="ListBoxOperac" runat="server" SelectionMode="Multiple"></asp:ListBox>
        </div>
        <div>
          </br>
        </div>
         <div>
             <asp:Button ID="ButtonOperac" runat="server" Text="Resultado" OnClick="ButtonOperac_Click" />
        </div>
        <div>
          </br>
        </div>
        <div>
             <asp:Label ID="LabelResultAdd" runat="server"></asp:Label> 
        </div>
        <div>
             <asp:Label ID="LabelResultSubtract" runat="server"></asp:Label> 
        </div>
        <div>
             <asp:Label ID="LabelResultMulti" runat="server"></asp:Label> 
        </div>
        <div>
             <asp:Label ID="LabelResulDiv" runat="server"></asp:Label> 
        </div>


    </form>
</body>
</html>
