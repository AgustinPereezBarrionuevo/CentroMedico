using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedicoDesktop.models
{
    internal class Turno
    {
        public int Id { get; set; }
        public string PacienteId { get; set; }
        public int ProfesionalId { get; set; }

        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}
