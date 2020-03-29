using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Confeccionaremos un libro de visitas de un sitio web.
    //Crear un sitio web llamado CreacionArchivo y luego agregar tres web 
    //form(Default.aspx, carga.aspx y listado.aspx), en la página
    //principal(Default.axpx) dispondremos de dos hipervínculos(HyperLink)
    //que sacamos del Cuadro de herramientas, el primero irá al formulario
    //de carga y el segundo al listado del contenido del archivo

    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLinkCarga.NavigateUrl = "~/Carga.aspx";
        HyperLinkListado.NavigateUrl = "~/Listado.aspx";
    }
}