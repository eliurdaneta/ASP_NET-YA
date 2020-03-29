using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Ingrese Primer Valor ";
        Label2.Text = "Ingrese Segundo Valor ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int NumberOne = int.Parse(TextBox1.Text);
        int NumberTwo = int.Parse(TextBox2.Text);
        int suma = NumberOne + NumberTwo;
        Label3.Text = "El resultado de la Operación es: ";
        resultado.Text = suma.ToString();
    }
}