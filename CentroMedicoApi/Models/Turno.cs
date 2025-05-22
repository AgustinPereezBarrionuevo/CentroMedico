namespace CentroMedicoApi.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public string PacienteId { get; set; }
        public int ProfesionalId { get; set; }

        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}
