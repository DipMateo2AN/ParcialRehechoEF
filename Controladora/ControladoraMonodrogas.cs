using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraMonodrogas
    {
        private readonly static Lazy<ControladoraMonodrogas> instancia = new(() => new ControladoraMonodrogas());
        public static ControladoraMonodrogas Instancia = instancia.Value;

        public bool Agregar(Monodroga nuevaMonodrga)
        {
            var monodrogaDuplicada = Monodrogas().FirstOrDefault(x => x.Nombre == nuevaMonodrga.Nombre);
            if (monodrogaDuplicada == null)
            {
                RepositorioMonodrogas.Instancia.Agregar(nuevaMonodrga);
                return true;
            }
            return false;
        }

        public bool Eliminar(Monodroga monodrogaAEliminar)
        {
            var monodrogaDuplicada = Monodrogas().FirstOrDefault(x => x.Nombre == monodrogaAEliminar.Nombre);
            if (monodrogaDuplicada != null)
            {
                RepositorioMonodrogas.Instancia.Eliminar(monodrogaAEliminar);
                return true;
            }
            return false;
        }

        public bool Modificar(Monodroga monodrogaModificada, Monodroga monodrogaSelec)
        {
            var monodrogaDuplicada = Monodrogas().FirstOrDefault(x => x.Nombre == monodrogaModificada.Nombre);
            if (monodrogaDuplicada == null)
            {
                RepositorioMonodrogas.Instancia.Modificar(monodrogaModificada, monodrogaSelec);
                return true;
            }
            return false;
        }

        public List<Monodroga> Monodrogas()
        {
            return RepositorioMonodrogas.Instancia.ListarMonodrogas();
        }
    }
}
