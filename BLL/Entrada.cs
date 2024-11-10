using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Entrada
    {
        private PartidoData partidoData = new PartidoData();
        private Partido partido = new Partido();
        
        public void guardarEntrada(Partido partido)
        {
            try
            {
                if (partido.EquipoLocal.Length <= 5 || partido.EquipoVisitante.Length <= 5)
                {
                    throw new Exception("Complete correctamente Equipo Local y Visitante");
                }
                if (partido.FechaPartido < DateTime.Now)
                {
                    throw new Exception("La fecha indicada ya paso");
                }
                if( partido.Deporte.IdDeporte != null)
                {
                    partidoData.GuardarPartido(partido);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Partido> getAll()
        {
            try
            {
                return partidoData.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarPartido(int idPartido)
        {
            try
            {
                partidoData.EliminarPartido(idPartido);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        

        public void ModificarMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                partidoData.ModificarMarcador(idPartido, marcadorLocal, marcadorVisitante);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
