namespace DPuga_Evaluación1erProgreso.Models
{
    public class EquipoRepository
    {
        public static List<DPugaClientes> Equipos { get; set; } = new List<DPugaClientes>();
        public static void AddEquipo(DPugaClientes equipo)
        {
            Equipos.Add(equipo);
        }
    }
}
