using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //El objetivo es que cada vez que se presione el botón se actualice 
    //el contenido de la Label con el valor actual más uno.

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "El valor acumulado es: ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int acum = int.Parse(Label2.Text) + 1;
        Label2.Text = acum.ToString();
    }
}