using System.Collections.ObjectModel;
using System.Net.Http.Headers;

namespace Modelo
{
    public class Medicamento
    {
        //        o NOMBRE_COMERCIAL
        //o ES_VENTA_LIBRE
        //o PRECIO_VENTA
        //o STOCK
        //o STOCK_MINIMO
        //o NOMBRE_MONODROGA

        public int MedicamentoId {  get; set; }
        public string NombreComercial {  get; set; }
        public bool EsVentaLibre { get; set; }
        public int PrecioVenta {  get; set; }
        public int Stock { get; set; }
        public int StockMinimo {  get; set; }
        public Monodroga Monodroga { get; set; }
        
        private List<Drogueria> Droguerias;

        public Medicamento()
        {
            Droguerias = new List<Drogueria>();
        }

        public bool AgregarDrogueria(Drogueria nuevaDrogueria)
        {
            var dDupl = Droguerias.FirstOrDefault(z => z.DrogueriaId == nuevaDrogueria.DrogueriaId);
            if(dDupl == null)
            {
                Droguerias.Add(nuevaDrogueria);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarDrogueria(Drogueria DrogueriaAEliminar)
        {
            var dDupl = Droguerias.FirstOrDefault(z => z.DrogueriaId == DrogueriaAEliminar.DrogueriaId);
            if (dDupl != null)
            {
                Droguerias.Remove(DrogueriaAEliminar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public ReadOnlyCollection<Drogueria> ListarDroguerias()
        {
            return Droguerias.AsReadOnly();
        }
    }
}
