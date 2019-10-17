using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usoControles
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("rojo");
                DropDownList1.Items.Add("verde");
                DropDownList1.Items.Add("azul");
                DropDownList1.Items.Add("rosa");
            }

            if (RadioButtonList1.Items.Count == 0)
            {
                RadioButtonList1.Items.Add("vainilla");
                RadioButtonList1.Items.Add("fresa");
                RadioButtonList1.Items.Add("limón");
                RadioButtonList1.Items.Add("chocolate");
            }

            if (CheckBoxList1.Items.Count == 0)
            {
                CheckBoxList1.Items.Add("capuchino");
                CheckBoxList1.Items.Add("latte");
                CheckBoxList1.Items.Add("americano");
                CheckBoxList1.Items.Add("té");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = DropDownList1.SelectedIndex;
            Label1.Text = "índice seleccionado =" + seleccion.ToString();
            Session["controles"] = "cambió a DropDownList";
            lblSession.Text = Session["controles"].ToString();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "indice seleccionado" + RadioButtonList1.SelectedIndex.ToString();
            Label3.Text = "valor seleccionado" + RadioButtonList1.SelectedValue.ToString();
            Session["controles"] = "cambió a RadioButtonList";
            lblSession.Text = Session["controles"].ToString();
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            for(int i=0; i<CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    ListBox1.Items.Add(i.ToString());
                    ListBox2.Items.Add(CheckBoxList1.Items[i].Value.ToString());
                }
            }
            Session["controles"] = "cambió a CheckBoxList";
            lblSession.Text = Session["controles"].ToString();
        }
    }
}