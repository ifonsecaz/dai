using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSpot
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=cc101-20\\SA;Uid=sa;Pwd=adminadmin;Database=GameSpot";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lbContador.Text = "conexion exitosa";
                return conexion;
            }
            catch (Exception ex)
            {
                lbContador.Text = ex.StackTrace.ToString();
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                String query = String.Format("select nombre,edad,sexo from usuario where claveU='{0}'",Session["claveUnica"].ToString());
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    txNombre.Text=rd.GetString(0);
                    txEdad.Text = rd.GetString(1);
                    txSexo.Text = rd.GetString(2);
                }
                else
                {
                    lbContador.Text = "Error";
                }
                rd.Close();
                miConexion.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["nombre"] = txNombre.Text;
            Response.Redirect("Pagina3.aspx");
        }
    }
}