using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        private readonly static Lazy<Contexto> instancia = new(() => new Contexto());
        public static Contexto Instancia = instancia.Value;
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Drogueria> Droguerias { get; set; }
        public DbSet<Monodroga> Monodrogas { get; set; }

        public Contexto()
        {

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=(localdb)\\MssqllocalDb;Initial Catalog=ef;Integrated Security=true;");
    }
}
