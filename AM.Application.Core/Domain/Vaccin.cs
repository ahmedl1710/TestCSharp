using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Vaccin
    {
        [DataType(DataType.DateTime)]
        public DateTime dateValidite { get; set; }
        public String? fournisseur { get; set; }
        public int quantite { get; set; }
        public TypeVaccin typevaccin { get; set; }
        public int vaccinId { get; set; }

        public virtual List<RendezVous> rendezvous { get; set; }
    }
}
