<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<%--Los controles CheckBox permiten que más de uno sea seleccionado. 
Similar a los controles RadioButton tiene dos estados (seleccionado o no seleccionado)
y esto lo sabemos según el estado de la propiedad Checked.
Codificaremos un nuevo sitio web que permita cargar dos valores y luego calcule la suma
y/o resta de los valores ingresados. Como podemos seleccionar ambas operaciones 
utilizaremos los controles de tipo CheckBox. La interfaz visual es la siguiente:--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelFisrtNumber" runat="server"></asp:Label>
            <asp:TextBox ID="TextBoxFirstNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:Label ID="LabelSecondNumber" runat="server"></asp:Label>
            <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:CheckBox ID="CheckBoxAdd" runat="server" />
            <asp:CheckBox ID="CheckBoxSubtract" runat="server" />
        </div>
        <div>
            </br>
        </div>
        <div>
            <asp:Button ID="ButtonOperacion" runat="server" Text="Operacion" OnClick="ButtonOperacion_Click" />
        </div>
        <div>
            </br>
        </div>
        <div>
             <asp:Label ID="LabelResultAdd" runat="server" ></asp:Label>
        </div>
         <div>
            </br>
        </div>
        <div>
             <asp:Label ID="LabelSubtract" runat="server" ></asp:Label>
             <asp:Label ID="LabelResultSubtract" runat="server" ></asp:Label>
        </div>
        
    </form>
</body>
</html>
