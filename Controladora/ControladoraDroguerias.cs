using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class ControladoraDroguerias
    {
        private readonly static Lazy<ControladoraDroguerias> instancia = new(() => new ControladoraDroguerias());
        public static ControladoraDroguerias Instancia = instancia.Value;
        public bool Agregar(Drogueria nuevaDrogueria)
        {
            var drogueriaDuplicada = Droguerias().FirstOrDefault(x => x.DrogueriaId == nuevaDrogueria.DrogueriaId);
            if (drogueriaDuplicada == null)
            {
                RepositorioDroguerias.Instancia.Agregar(nuevaDrogueria);
                return true;
            }
            return false;
        }

        public bool Eliminar(Drogueria drogueriaAEliminar)
        {
            var drogueriaDuplicada = Droguerias().FirstOrDefault(x => x.DrogueriaId == drogueriaAEliminar.DrogueriaId);
            if (drogueriaDuplicada != null)
            {
                RepositorioDroguerias.Instancia.Eliminar(drogueriaAEliminar);
                return true;
            }
            return false;
        }

        public bool Modificar(Drogueria drogueriaModificada)
        {
            var drogueriaDuplicada = Droguerias().FirstOrDefault(x => x.DrogueriaId == drogueriaModificada.DrogueriaId);
            if (drogueriaDuplicada == null)
            {
                RepositorioDroguerias.Instancia.Modificar(drogueriaModificada);
                return true;
            }
            return false;
        }

        public List<Drogueria> Droguerias()
        {
            return RepositorioDroguerias.Instancia.ListarDroguerias();
        }
    }
}
