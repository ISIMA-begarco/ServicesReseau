using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    abstract public class EntityObject
    {
        private String test;
        public int ID { get; set; }

        public EntityObject()
        {

        }

        public bool Equals(EntityObject o)
        {
            return ID == o.ID;
        }

        override public abstract int GetHashCode();
    }
}
