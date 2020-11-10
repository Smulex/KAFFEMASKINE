using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    public class Department
    {
        private Powder powder;

        public Powder Powder
        {
            get { return powder; }
            set { powder = value; }
        }


        private Filter filter;

        public Filter Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        // Sætter indholdet til at være tomt når den bliver instantieret
        public Department()
        {
            powder = null;
            filter = null;
        }

        // Tjekker om der er filter i
        public bool HasFilter()
        {
            return filter != null;
        }

        // Tjekker om der er pulver i
        public bool HasPowder()
        {
            return powder != null;
        }

        // Indsætter filter
        public string InsertFilter()
        {
            if (!HasFilter() && !HasPowder())
            {
                filter = new Filter();
                return "Filter is inserted";
            }
            else
            {
                return "The Machine is not Empty";
            }
        }

        // Fylder beholderen op med det pulver den har fået i sin parameter
        public string Fill(Powder powder)
        {
            if (HasFilter() && !HasPowder())
            {
                this.powder = powder;
                return "Powder is filled";
            }
            else if(!HasFilter())
            {
                return "The machine has no Filter";
            }
            else
            {
                return "The Machine is not Empty";
            }
        }

        // Tømmer alt indhold
        public string Empty()
        {
            filter = null;
            powder = null;

            return "The machine is now empty";
        }
    }
}
