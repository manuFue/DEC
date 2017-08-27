using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Preferences
    {
        public Entidades.Standard comparedStandard { get; set; }
        public int value { get; set; }

        public Preferences() {}

        public Preferences(Entidades.Standard STANDARD, int VALUE)
        {
            this.comparedStandard = STANDARD;
            this.value = VALUE;
        }
    }
}
