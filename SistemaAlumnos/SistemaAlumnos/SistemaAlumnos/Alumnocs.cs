using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Alumnocs
    {
        public Int16 claveUnica { get; set; }
        public String nombre { get; set; }

        public String sexo { get; set; }

        public String correo { get; set; }

        public Int16 semestre { get; set; }

        public int programa { get; set; }

        public Alumnocs()
        {
        }

        public Alumnocs(short claveUnica, string nombre, string sexo, string correo, short semestre, int programa)
        {
            this.claveUnica = claveUnica;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.programa = programa;
        }

        public Alumnocs(short claveUnica)
        {
            this.claveUnica = claveUnica;
        }

        public Alumnocs(string nombre)
        {
            this.nombre = nombre;
        }

        public Alumnocs(short claveUnica, string correo) : this(claveUnica)
        {
            this.correo = correo;
        }

        public int alta(Alumnocs a)
        {
            int res = 0;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("insert into alumno(claveUnica, nombre, sexo, correo, semestre, idPrograma) values({0},'{1}','{2}','{3}',{4},{5}))", a.claveUnica, a.nombre, a.sexo, a.correo, a.semestre, a.programa), con);


            res=cmd.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public int baja(Alumnocs a)
        {
            int res = 0;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("delete from alumno where claveUnica={0}",a.claveUnica), con);


            res=cmd.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public int modifica(Alumnocs a)
        {
            int res = 0;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("update alumno set correo = '{0}' where claveUnica={1}",a.correo,a.claveUnica),con);


            res=cmd.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public List<Alumnocs> busca(Alumnocs a)
        {
            List<Alumnocs> lis = new List<Alumnocs>();
            Alumnocs b;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", a.nombre), con);
            SqlDataReader drd = cmd.ExecuteReader();

            while (drd.Read())
            {
                b = new Alumnocs();
                b.claveUnica = drd.GetInt16(0);
                b.nombre = drd.GetString(1);
                b.sexo = drd.GetString(2);
                b.correo = drd.GetString(3);
                b.semestre = drd.GetInt16(4);
                b.programa = drd.GetInt16(5);

                lis.Add(a);
            }

            con.Close();

            return lis;
        }
    } 
}
