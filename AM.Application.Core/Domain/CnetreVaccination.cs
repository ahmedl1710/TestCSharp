using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class CnetreVaccination
    {
        public int capacite { get; set; }
        [Key]
        public int centreVaccinationId { get; set; }
        public int nbChaises { get; set; }
        public int numTelephone { get; set; }
        public String? responsableCnetre { get; set; }
    }
    public enum TypeVaccin { PFizer, Moderna, jhonson }
}
