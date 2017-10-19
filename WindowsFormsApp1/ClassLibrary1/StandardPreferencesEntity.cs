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
        public List<Preferences> preferences { get; set; }

        public StandardPreferencesEntity() { }

        public StandardPreferencesEntity(Entidades.Standard STANDARD)
        {
            this.mainStandard = STANDARD;
            this.preferences = new List<Preferences>();
        }

        public void addPreference(Preferences preference)
        {
            preferences.Add(preference);
        }

        public void removePreference(int standardId)
        {
            int listIndex;
            listIndex = preferences.FindIndex(x => x.comparedStandard.IdStandard == standardId);
            preferences.RemoveAt(listIndex);
        }

        public bool existsPreference(int standardId)
        {
            return preferences.Exists(x => x.comparedStandard.IdStandard == standardId);
        }

        public void setNormalValue(Entidades.Standard standard, double Value)
        {
            int listIndex;
            listIndex = preferences.FindIndex(x => x.comparedStandard.IdStandard == standard.IdStandard);
            preferences[listIndex].setNormalValue(Value);
        }

        public double getNormalValue(Entidades.Standard standard)
        {
            int listIndex;
            listIndex = preferences.FindIndex(x => x.comparedStandard.IdStandard == standard.IdStandard);
            return preferences[listIndex].getNormalValue();
        }
    }
}
