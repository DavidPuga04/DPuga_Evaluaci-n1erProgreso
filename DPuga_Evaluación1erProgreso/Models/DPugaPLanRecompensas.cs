namespace DPuga_Evaluación1erProgreso.Models
{
    public class DPugaPLanRecompensas
    {
        public int IdPlanRecompensas { get; set; }
        public string NombrePlan { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal PorcentajeRecompensa { get; set; }
        public int DiasVigencia { get; set; }
        public bool Activo { get; set; }
        // Relación con DPugaClientes
        public virtual ICollection<DPugaClientes> Clientes { get; set; }
    }
}
