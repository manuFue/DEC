using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StandardPreferencesEntity
    {
        public Entidades.Standard mainStandard { get; set; }
        public Preferences[] preferences { get; set; }

        public StandardPreferencesEntity() { }

        public StandardPreferencesEntity(Entidades.Standard STANDAR, Preferences[] PREFERENCES)
        {
            this.mainStandard = STANDAR;
            this.preferences = PREFERENCES;
        }
    }
}
