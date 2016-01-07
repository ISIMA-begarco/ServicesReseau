using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Stade : EntityObject
    {
        public List<Caracteristiques> Caracteristiques { get; set; }
        public uint NbPlaces { get; set; }
        public String Planete { get; set; }

        public Stade(List<Caracteristiques> pCaracteristiques, uint pNbPlaces, String pPlanete, int pID)
        {
            Caracteristiques = pCaracteristiques;
            ID = pID;
            NbPlaces = pNbPlaces;
            Planete = pPlanete;
        }
    }
}
