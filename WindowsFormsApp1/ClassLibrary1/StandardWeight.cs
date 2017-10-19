using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StandardWeight
    {
        public Entidades.Standard standard;
        public double weight { get; set; }

        public StandardWeight(Entidades.Standard Standard, double weightValue)
        {
            this.standard = Standard;
            this.weight = weightValue;
        }
    }
}
