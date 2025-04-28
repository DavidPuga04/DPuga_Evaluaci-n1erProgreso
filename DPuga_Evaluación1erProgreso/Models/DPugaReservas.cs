namespace DPuga_Evaluación1erProgreso.Models
{
    public class DPugaReservas
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public decimal MontoReserva { get; set; }
        public bool Activo { get; set; }
        // Relación con DPugaClientes
        public virtual DPugaClientes Cliente { get; set; }
        // Relación con DPugaPLanRecompensas
        public virtual DPugaPLanRecompensas PlanRecompensas { get; set; }
    }
}
