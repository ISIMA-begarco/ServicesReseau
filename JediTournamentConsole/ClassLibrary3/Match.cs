using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Match : EntityObject
    {
        public int IdJediVainqueur { get; set; }
        public Jedi Jedi1 { get; set; }
        public Jedi Jedi2 { get; set; }
        public EPhaseTournoi PhaseTournoi { get; set; }
        public Stade Stade { get; set; }

        public Match(int pIdJediVainqueur, Jedi pJedi1, Jedi pJedi2, EPhaseTournoi pPhaseTournoi, Stade pStade, int pID)
        {
            ID = pID;
            IdJediVainqueur = pIdJediVainqueur;
            Jedi1 = pJedi1;
            Jedi2 = pJedi2;
            PhaseTournoi = pPhaseTournoi;
            Stade = pStade;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
