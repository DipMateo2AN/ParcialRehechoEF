using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DrogueriaDeMonodroga
    {
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }

        public int DrogueriaId { get; set; }
        public Drogueria Drogueria { get; set; }
    }
}
