using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Citoyen
    {
        public virtual Adresse? adresse { get; set; }
        public int age { get; set; }
        [Key]
        public String? cin { get; set; }
        public int citoyenId { get; set; }
        public String? nom { get; set; }
        [Required]
        public int numeroEvax { get; set; }
        public String? prenom { get; set; }
        public int telephone { get; set; }
        public virtual List<RendezVous> rendezvous { get; set; }
    }
}
