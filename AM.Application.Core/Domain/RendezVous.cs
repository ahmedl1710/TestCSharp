using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class RendezVous
    {
        public String? CodeInfermerie { get; set; }
        public DateTime dateVaccination { get; set; }
        public int nbeDoses { get; set; }
        public int citoyenId { get; set; }
        public virtual Citoyen citoyen { get; set; }
        public int vaccinId { get; set; }
        public virtual Vaccin vaccin { get; set; }
    }
}
