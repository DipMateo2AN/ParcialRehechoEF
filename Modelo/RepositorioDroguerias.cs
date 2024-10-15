namespace Modelo
{
    public class RepositorioDroguerias
    {
        private readonly static Lazy<RepositorioDroguerias> instancia = new(() => new RepositorioDroguerias());
        public static RepositorioDroguerias Instancia = instancia.Value;

        public List<Drogueria> ListarDroguerias()
        {
            return Contexto.Instancia.Droguerias.ToList();
        }

        public Drogueria ObtenerPorCuit(int cuit)
        {
            return Contexto.Instancia.Droguerias.Find(cuit);
        }
        public Drogueria ObtenerPorId(int id)
        {
            return Contexto.Instancia.Droguerias.Find(id);
        }

        public void Agregar(Drogueria nuevaDrogueria)
        {
            Contexto.Instancia.Droguerias.Add(nuevaDrogueria);
            Contexto.Instancia.SaveChanges();
        }

        public void Modificar(Drogueria drogueria)
        {
            var drogueriaDupli = ObtenerPorCuit(drogueria.DrogueriaId);
            if (drogueriaDupli != null)
            {
                drogueriaDupli = drogueria;
                Contexto.Instancia.SaveChanges();
            }
        }

        public void Eliminar(Drogueria drogueria)
        {
            Contexto.Instancia.Droguerias.Remove(drogueria);
            Contexto.Instancia.SaveChanges();

        }
    }
}
