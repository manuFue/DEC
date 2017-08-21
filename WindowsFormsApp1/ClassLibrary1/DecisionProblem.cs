using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DecisionProblem
    {
        public int? IdProblem { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Standard[] StandardList;
        public Alternatives[] AlternativesList;

        public DecisionProblem() { }

        public DecisionProblem(int ID, string NAME, DateTime DATE, Standard[] SList, Alternatives[] AList)
        {
            this.IdProblem = ID;
            this.Name = NAME;
            this.Date = DATE;
            this.StandardList = SList;
            this.AlternativesList = AList;
        }
    }
}
