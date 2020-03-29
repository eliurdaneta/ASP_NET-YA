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
        LabelOperation.Text = "Seleccione el Tipo de Operación";

    }

    protected void ButtonResult_Click(object sender, EventArgs e)
    {
        if (TextBoxFirstNumber != null && TextBoxSecondNumber != null)
        {
            if (RadioButtonAdd.Checked)
            {
                LabelResult.Text = (int.Parse(TextBoxFirstNumber.Text) + int.Parse(TextBoxSecondNumber.Text)).ToString();
            }
            else
            {
                if (RadioButtonSubtract.Checked)
                {
                    LabelResult.Text = (int.Parse(TextBoxFirstNumber.Text) - int.Parse(TextBoxSecondNumber.Text)).ToString();
                }
            }
        }
        else
        {
            LabelResult.Text = "Debe ingresar Primer Valor y Segundo Valor";
        }
    }

    protected void RadioButtonAdd_CheckedChanged(object sender, EventArgs e)
    {
       RadioButtonSubtract.Checked = false;
              
    }

    protected void RadioButtonSubtract_CheckedChanged(object sender, EventArgs e)
    {
        RadioButtonAdd.Checked = false;
    }
}