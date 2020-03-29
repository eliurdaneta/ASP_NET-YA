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
        LabelFirstNumber.Text = "Ingrese Primer Valor: ";
        LabelSecondNumber.Text = "Ingrese Segundo Valor: ";
        ListBoxOperac.Items.Add("Suma");
        ListBoxOperac.Items.Add("Resta");
        ListBoxOperac.Items.Add("Multiplicación");
        ListBoxOperac.Items.Add("División");
        LabelOperac.Text = "Seleccione la Operación";
    }

    protected void ButtonOperac_Click(object sender, EventArgs e)
    {
        if(TextBoxFirstNumber.Text != "" && TextBoxSecondNumber.Text != "")
        { 
            if(ListBoxOperac.Items[0].Selected)
            {
                int add = int.Parse(TextBoxFirstNumber.Text) + int.Parse(TextBoxSecondNumber.Text);

                LabelResultAdd.Text = "El resultado de la suma es: " + add.ToString();

            }
            if (ListBoxOperac.Items[1].Selected)
            {
                int subtract = int.Parse(TextBoxFirstNumber.Text) - int.Parse(TextBoxSecondNumber.Text);

                LabelResultSubtract.Text = "El resultado de la resta es: " + subtract.ToString();

            }

            if (ListBoxOperac.Items[2].Selected)
            {
                int mult  = int.Parse(TextBoxFirstNumber.Text) * int.Parse(TextBoxSecondNumber.Text);

                LabelResultMulti.Text = "El resultado de la multiplicación es: " + mult.ToString();
            }

            if (ListBoxOperac.Items[3].Selected)
            {
                int div = int.Parse(TextBoxFirstNumber.Text) / int.Parse(TextBoxSecondNumber.Text);

                LabelResulDiv.Text = "El resultado de la multiplicación es: " + div.ToString();
            }
        }
        else
        {
            LabelResultAdd.Text = "Debe ingresar el primer valor y el segundo valor";
        }
    }
}