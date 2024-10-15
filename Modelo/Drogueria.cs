namespace Modelo
{
    public class Drogueria
    {
        //o CUIT
        //o RAZON_SOCIAL
        //o DIRECCION
        //o EMAIL

        public int DrogueriaId { get; set; }
        public int Cuit { get; set; }
        public string RazonSocial {  get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Cuit.ToString();
        }
    }
}
