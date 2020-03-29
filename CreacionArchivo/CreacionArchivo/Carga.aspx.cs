using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Carga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            LabelName.Text = "Nombre ";
            LabelPais.Text = "Pais ";
            LabelComments.Text = "Comentarios: ";
            HyperLinkReturn.NavigateUrl = "~/Default.aspx";
     }


    protected void ButtonConfirm_Click(object sender, EventArgs e)
    {
        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/visita.txt", true);
        arch.WriteLine("Nombre: " + TextBoxName.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("País: " + TextBoxPais.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Comentarios: <br>");
        arch.WriteLine(TextBoxComments.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<hr>");
        arch.Close();
        LabelResult.Text = "Datos Registrados de Forma Exitosa";
    }
}