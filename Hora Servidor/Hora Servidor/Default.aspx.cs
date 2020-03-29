using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Este programa muestra la hora actual del servidor al momento de cargar la página
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "La fecha de hoy es: " + DateTime.Today.ToString("d");
    }
}