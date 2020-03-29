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
        LabelFisrtNumber.Text = "Ingrese Primer Valor: ";
        LabelSecondNumber.Text = "Ingrese Segundo valor: ";
        CheckBoxAdd.Text = "Sumar";
        CheckBoxSubtract.Text = "Restar";
    }

    protected void ButtonOperacion_Click(object sender, EventArgs e)
    {
        if(TextBoxFirstNumber.Text != " " || TextBoxSecondNumber.Text != " ")
        {
            if (CheckBoxAdd.Checked)
            {
                int suma = int.Parse(TextBoxFirstNumber.Text) + int.Parse(TextBoxSecondNumber.Text);
                LabelResultAdd.Text = "El resultado de la suma es: " + suma.ToString();

            }
            if(CheckBoxSubtract.Checked)
            {
                int resta = int.Parse(TextBoxFirstNumber.Text) - int.Parse(TextBoxSecondNumber.Text);

               LabelResultSubtract.Text = "El resultado de la resta es: " + resta.ToString();

            }
        }
        else
        {
            LabelResultAdd .Text = "Debe Ingresar Valores para realizar la operación";
        }
    }
}