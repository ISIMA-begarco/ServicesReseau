using EntitiesLayer;
using StubDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Afficheur
    {
        static public void displayAllStades()
        {
            DalManager dm = new DalManager();
            List<Stade> l = dm.GetAllStades();
            foreach(Stade s in l)
            {
                Console.Out.WriteLine(s);
            }

        }
        static public void displayAllSiths()
        {

        }
        static public void displayJedi()
        {

        }
        static public void displayMatch()
        {

        }
    }
}
