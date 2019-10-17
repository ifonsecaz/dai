using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesiones
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verficar todook
            if (Session["usuario"] != null)
            {
                String s = Session["usuario"].ToString();
                Label1.Text = "Bienvenido" + s;
                HttpCookie cookieIni = new HttpCookie("oreo");
                s = cookieIni.Value;
                Response.Write(s);
            }

            else
            {
                Session.Abandon();
                Response.Redirect("Login.aspx");

            }
        }
    }
}