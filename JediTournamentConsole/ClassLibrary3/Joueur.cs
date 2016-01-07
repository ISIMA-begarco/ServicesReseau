using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Joueur : EntityObject
    {
        public String Nom { get; set; }
        public int Score { get; set; }

        public Joueur(String pNom, int pScore, int pID)
        {
            ID = pID;
            Nom = pNom;
            Score = pScore;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
