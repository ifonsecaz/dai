using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesiones
{
    public partial class LogIn : System.Web.UI.Page
    {
        String[] usuarios = { "Paco", "Valentina", "Montse", "Bernardo", "Alex" };
        String[] paswords = { "Paco","Vale","Mon","Ber","Ale"};
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String us = TextBox1.Text;
            String pw = TextBox2.Text;
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (us == usuarios[i] && pw == paswords[i])
                {
                    Session.Timeout = 15;
                    Session.Add("usuario", us);
                    HttpCookie cookie = new HttpCookie("oreo");
                    cookie.Value = "prueba, soy una galleta";
                    //return pues
                    Response.Redirect("Inicio.aspx");
                }
            }
            Label1.Text = "Ususario incorecto";
            TextBox1.Text = "";
            TextBox2.Text = "";
            Session.Abandon();

        }


    }
    }
