using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLinkReturn.NavigateUrl = "~/Default.aspx";
        StreamReader arch = new StreamReader(Server.MapPath(".") + "/visita.txt");
        LabelArchive.Text = arch.ReadToEnd();
        arch.Close();
    }
}