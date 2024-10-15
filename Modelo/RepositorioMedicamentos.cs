namespace Modelo
{
    public class RepositorioMedicamentos
    {

        private readonly static Lazy<RepositorioMedicamentos> instancia = new(() => new RepositorioMedicamentos());
        public static RepositorioMedicamentos Instancia = instancia.Value;
        public List<Medicamento> ListarMedicamentos()
        {
            return Contexto.Instancia.Medicamentos.ToList();
        }

        public Medicamento ObtenerPorId(int id)
        {
            return Contexto.Instancia.Medicamentos.Find(id);
        }

        public void Agregar(Medicamento nuevoMedicamento)
        {
            Contexto.Instancia.Medicamentos.Add(nuevoMedicamento);
            Contexto.Instancia.SaveChanges();
        }

        public void Modificar(Medicamento medicamento)
        {
            var medicamentoDupli = ObtenerPorId(medicamento.MedicamentoId);
            if (medicamentoDupli != null)
            {
                medicamentoDupli = medicamento;
                Contexto.Instancia.SaveChanges();
            }
        }

        public void Eliminar(Medicamento medicamento)
        {

            Contexto.Instancia.Medicamentos.Remove(medicamento);
            Contexto.Instancia.SaveChanges();

        }
    }
}
