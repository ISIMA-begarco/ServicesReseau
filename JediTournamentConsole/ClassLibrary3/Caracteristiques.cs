using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Caracteristiques : EntityObject
    {
        public EDefCaracteristique Definition { get; set; }
        public String Nom { get; set; }
        public ETypeCaracteristique Type { get; set; }
        public int Valeur { get; set; }

        public Caracteristiques(EDefCaracteristique pDefinition, String pNom, ETypeCaracteristique pType, int pValeur, int pID)
        {
            ID = pID;
            Definition = pDefinition;
            Nom = pNom;
            Type = pType;
            Valeur = pValeur;
        }
    }
}
