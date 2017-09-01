using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Standard
    {
        public int? IdStandard { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Optimization { get; set; }

        public Standard() { }

        public Standard(int? ID, string NAME, string DESCRIPTION, bool OPTIMIZATION)
        {
            this.IdStandard = ID;
            this.Name = NAME;
            this.Description = DESCRIPTION;
            this.Optimization = OPTIMIZATION;
        }

    }
}
