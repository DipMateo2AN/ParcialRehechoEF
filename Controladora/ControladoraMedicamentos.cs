using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class ControladoraMedicamentos
    {
        private readonly static Lazy<ControladoraMedicamentos> instancia = new(() => new ControladoraMedicamentos());
        public static ControladoraMedicamentos Instancia = instancia.Value;
        public bool Agregar(Medicamento nuevoMedicamento)
        {
            var medicamentoDuplicada = Medicamentos().FirstOrDefault(x => x.NombreComercial == nuevoMedicamento.NombreComercial);
            if (medicamentoDuplicada == null)
            {
                RepositorioMedicamentos.Instancia.Agregar(nuevoMedicamento);
                return true;
            }
            return false;
        }

        public Monodroga BuscarMonodroga(string id)
        {
            var monodroga = ControladoraMonodrogas.Instancia.Monodrogas().FirstOrDefault(z => z.MonodrogaId == id);
            return monodroga;
        }

        public bool Eliminar(Medicamento medicamentoAEliminar)
        {
            var medicamentoDuplicado = Medicamentos().FirstOrDefault(x => x.NombreComercial == medicamentoAEliminar.NombreComercial);
            if (medicamentoDuplicado != null)
            {
                RepositorioMedicamentos.Instancia.Eliminar(medicamentoAEliminar);
                return true;
            }
            return false;
        }

        public bool Modificar(Medicamento medicamentoModificado)
        {
            var medicamentoDuplicado = Medicamentos().FirstOrDefault(x => x.NombreComercial == medicamentoModificado.NombreComercial);
            if (medicamentoDuplicado != null)
            {
                RepositorioMedicamentos.Instancia.Modificar(medicamentoModificado);
                return true;
            }
            return false;
        }

        public List<Medicamento> Medicamentos()
        {
            return RepositorioMedicamentos.Instancia.ListarMedicamentos();
        }
    }
}
