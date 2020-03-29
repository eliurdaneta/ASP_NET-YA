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
        if (!IsPostBack)
        {
            LabelFirstNumber.Text = "Ingrese Primer Valor ";
            LabelSecoundNumber.Text = "Ingrese Segundo valor ";
            LabelOperac.Text = "Seleccione Operación a Relizar";
            DropDownList.Items.Add("Suma");
            DropDownList.Items.Add("Resta");
            DropDownList.Items.Add("Multiplicación");
            DropDownList.Items.Add("División");
        }
       
       
    }

    protected void ButtonOperac_Click(object sender, EventArgs e)
    {
        if(TextFirstNumber.Text != "" && TextSecoundNumber.Text!= "")
        {
            int operac;
            if(DropDownList.Items[0].Selected)
            {
                operac = int.Parse(TextFirstNumber.Text) + int.Parse(TextSecoundNumber.Text);
                LabelResultAdd.Text = "El resultado de la suma es: " + operac.ToString();
            }
            if (DropDownList.Items[1].Selected)
            {
                operac = int.Parse(TextFirstNumber.Text) - int.Parse(TextSecoundNumber.Text);
                LabelResultAdd.Text = "El resultado de la resta es: " + operac.ToString();
            }

            if (DropDownList.Items[2].Selected)
            {
                operac = int.Parse(TextFirstNumber.Text) * int.Parse(TextSecoundNumber.Text);
                LabelResultAdd.Text = "El resultado de la multiplicación es: " + operac.ToString();
            }
            if (DropDownList.Items[3].Selected)
            {
                operac = int.Parse(TextFirstNumber.Text) / int.Parse(TextSecoundNumber.Text);
                LabelResultAdd.Text = "El resultado de la división es: " + operac.ToString();
            }
        }
        else
        {
            LabelResultAdd.Text = "Debe ingresar el Primer Valor y el Segundo valor";
        }
    }
}