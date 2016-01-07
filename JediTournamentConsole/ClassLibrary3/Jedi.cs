using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Jedi : EntityObject
    {
        public List<Caracteristiques> Caracteristiques { get; set; }
        public bool IsSith { get; set; }
        public String Nom { get; set; }

        public Jedi(List<Caracteristiques> pCaracteristiques, bool pIsSith, String pNom, int pID)
        {
            ID = pID;
            Caracteristiques = pCaracteristiques;
            IsSith = pIsSith;
            Nom = pNom;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
