﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSpot
{
    public partial class Pagina1 : System.Web.UI.Page
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

        }

        protected void btPagina2_Click(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            String query;
            if (miConexion != null)
            {
                query = "select claveU from usuario where email='" + txUsuario.Text +"' and password='" +txContraseña.Text;
                OdbcCommand cmd = new OdbcCommand(query,miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
            }
        }
    }
}