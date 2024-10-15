namespace Modelo
{
    public class RepositorioMonodrogas
    {
        private readonly static Lazy<RepositorioMonodrogas> instancia = new(() => new RepositorioMonodrogas());
        public static RepositorioMonodrogas Instancia = instancia.Value;
        public List<Monodroga> ListarMonodrogas()
        {
            return Contexto.Instancia.Monodrogas.ToList();
        }

        public Monodroga ObtenerPorNombre(string nombre)
        {
            return Contexto.Instancia.Monodrogas.FirstOrDefault(x => x.Nombre == nombre);
        }

        public void Agregar(Monodroga nuevaMonodroga)
        {
            Contexto.Instancia.Monodrogas.Add(nuevaMonodroga);
            Contexto.Instancia.SaveChanges();
        }

        public void Modificar(Monodroga monodroga, Monodroga monodrogaSelec)
        {
            var monodrogaDupli = ObtenerPorNombre(monodroga.Nombre);
            if (monodrogaDupli == null)
            {
                Contexto.Instancia.Monodrogas.Add(monodroga);
                Contexto.Instancia.Monodrogas.Remove(monodrogaSelec);
                Contexto.Instancia.SaveChanges();
            }
        }

        public void Eliminar(Monodroga monodrogaAEliminar)
        {

            Contexto.Instancia.Monodrogas.Remove(monodrogaAEliminar);
            Contexto.Instancia.SaveChanges();

        }
    }
}
