using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        public List<Caracteristiques> GetAllCaracteristiques()
        {
            List<Caracteristiques> res = new List<Caracteristiques>();
            res.Add(new Caracteristiques(EDefCaracteristique.Chance, "Utilisation de la force", ETypeCaracteristique.Jedi, 18,1));
            res.Add(new Caracteristiques(EDefCaracteristique.Defense, "Agilite", ETypeCaracteristique.Jedi, 5,1));
            res.Add(new Caracteristiques(EDefCaracteristique.Sante, "Armure", ETypeCaracteristique.Jedi, 42,2));
            res.Add(new Caracteristiques(EDefCaracteristique.Force, "Badassitude", ETypeCaracteristique.Jedi, 7,2));
            res.Add(new Caracteristiques(EDefCaracteristique.Force, "Lave", ETypeCaracteristique.Stade, 12, 5));
            return res;
        }
        
        
        public List<Jedi> GetAllJedis(){
            List<Caracteristiques> CaractBenjamen = GetAllCaracteristiques().Where(c => c.ID == 1 || c.ID == 2).ToList();
            List<Caracteristiques> CaractCat = GetAllCaracteristiques().Where(c => c.ID == 1).ToList();


            List<Jedi> res = new List<Jedi>();
            res.Add(new Jedi(CaractBenjamen, true, "Benjamin",1));
            res.Add(new Jedi(CaractCat, false, "Cataracte",2));

            return res;

        }

        public List<Stade> GetAllStades()
        {
            List<Stade> res = new List<Stade>();

            List<Caracteristiques> caractStade = GetAllCaracteristiques().Where(c => c.ID == 5).ToList();

            res.Add(new Stade(caractStade, 300, "Jakku", 1));

            return res;
        }

        public List<Match> GetAllMatches()
        {
            List<Match> res = new List<Match>();

            List<Caracteristiques> caractStade = GetAllCaracteristiques().Where(c => c.ID == 5).ToList();
            List<Jedi> jedis = GetAllJedis();
            List<Stade> stades = GetAllStades();



            res.Add(new Match(2,jedis[0], jedis[1], EPhaseTournoi.Finale, stades[0], 1 ));

            return res;
        }

    }
}
