using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DPuga_Evaluación1erProgreso.Models
{
    public class DPugaClientes
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del cliente")]
        public string Nombre { get; set; }
        [DisplayName("Tiene Membresía? S/N")]
        public bool TieneMembresia { get; set; }
        [Range(0,100)]
        public DateTime FechaNacimiento { get; set; }
        [Range(0, 100)]
        public decimal MontoReserva { get; set; }        
    }
}
