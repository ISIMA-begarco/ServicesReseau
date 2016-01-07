using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Tournoi : EntityObject
    {
        public List<Match> Matches { get; set; }
        public String Nom { get; set; }

        public Tournoi(String pnom, int pID)
        {
            ID = pID;
            Nom = pnom;
        }
    }
}
