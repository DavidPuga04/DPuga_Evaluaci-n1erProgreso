using System.ComponentModel.DataAnnotations;

namespace DPuga_Evaluación1erProgreso.Models
{
    public class DPugaClientes
    {
        [Key]
        public int IdCliente { get; set; }       
        public string Nombre { get; set; }
        public bool TieneMembresia { get; set; }
        public DateTime FechaReserva { get; set; }
        public decimal MontoReserva { get; set; }
    }
}
