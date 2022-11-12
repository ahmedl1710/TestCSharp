using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Adresse
    {
        public int codePostal { get; set; }
        public int rue { get; set; }
        public String? ville { get; set; }
    }
}
