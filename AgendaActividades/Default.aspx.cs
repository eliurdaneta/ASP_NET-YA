using System;
using System.IO;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { 
            string fecha = Calendar1.TodaysDate.Day.ToString() + Calendar1.TodaysDate.Month.ToString() +
                           Calendar1.TodaysDate.Year.ToString();

            if (File.Exists(Server.MapPath(".") + "/" + fecha))
            {
                StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha);
                TextBoxDairy.Text = arch.ReadToEnd();
                arch.Close();
            }
            else
            {
                TextBoxDairy.Text = "";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string fecha = Calendar1.SelectedDate.Day.ToString() + Calendar1.SelectedDate.Month.ToString() + Calendar1.SelectedDate.Year.ToString();

        if (fecha == "111")
        {
            fecha = Calendar1.TodaysDate.Day.ToString() + Calendar1.TodaysDate.Month.ToString() + Calendar1.TodaysDate.Year.ToString();
        }
         
        string prueba = TextBoxDairy.Text;
        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/" + fecha, true);
        arch.WriteLine(TextBoxDairy.Text);
        arch.Close();
        LabelResult.Text = "Agenda actualizada";
    }


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        string fecha = Calendar1.SelectedDate.Day.ToString() + Calendar1.SelectedDate.Month.ToString() + Calendar1.SelectedDate.Year.ToString();

        if (File.Exists(Server.MapPath(".") + "/" +fecha))
        {
            StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha);
            TextBoxDairy.Text = arch.ReadToEnd();
            arch.Close();

        }
        else
        {
            TextBoxDairy.Text = "";
        }

        LabelResult.Text = " ";
    }
}