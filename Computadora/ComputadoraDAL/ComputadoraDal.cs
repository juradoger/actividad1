using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputadoraDAL;
using ComputadoraModelo;

namespace ComputadoraDAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "insert into cliente values('" + computadora.idcomputadora + "' ," +
                                                          "'" + computadora.nombre + "' ," +
                                                          "'" + computadora.descripcion + "' ," +
                                                           "'" + computadora.precio + "' ," +
                                                            "'" + computadora.fechafabricacion + "')";
            conexion.Ejecutar(consulta);
        }
        public Computadora ObtenerCompId(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Computadora cp = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                cp.idcomputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                cp.nombre = tabla.Rows[0]["nombre"].ToString();
                cp.descripcion = tabla.Rows[0]["descripcion"].ToString();
                cp.precio =Convert.ToDecimal(tabla.Rows[0]["precio"]);
                cp.fechafabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafabricacion"].ToString());
            }
            return cp;

        }
        public void EditarCompDal(Computadora p)
        {
            string consulta = $"update computadora set nombre= '{p.nombre.ToString()}', descripcion= '{p.descripcion.ToString()}', precio='{p.precio}', fechafabricacion='{p.fechafabricacion.ToString()}' where idcomputadora='{p.idcomputadora}'";
            conexion.Ejecutar(consulta);
        }
        public void EliminarCompDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora=" + id;
            conexion.Ejecutar(consulta);

        }
    }
}
