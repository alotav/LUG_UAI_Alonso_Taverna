using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoDeportesBusiness
    {
        private TipoDeportesData tipoDeportesDatos = new TipoDeportesData();
        public List<Deporte> getAll()
        {
            try
            {
                return tipoDeportesDatos.getAll();
            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}
