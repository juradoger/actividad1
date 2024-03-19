using System;
using System.Collections.Generic;
using System.Data;
using ComputadoraDAL;
using ComputadoraModelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputadoraBSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadorasBss()
        {
            return dal.ListarComputadorasDal();
        }
        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
        public Computadora ObtenerIdBss(int id)
        {
            return dal.ObtenerCompId(id);
        }
        public void EditarPersonaBss(Computadora persona)
        {
            dal.EditarCompDal(persona);
        }
        public void EliminarCompBss(int id)
        {
            dal.EliminarCompDal(id);
        }
    }
}
