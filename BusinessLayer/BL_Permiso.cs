using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Permiso
    {
        private DL_Permiso objdl_permiso = new DL_Permiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objdl_permiso.Listar(IdUsuario);
        }
    }
}
