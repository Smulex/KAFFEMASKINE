using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    public abstract class CookingAppliance
    {
        private bool isPower;

        public bool IsPower
        {
            get { return isPower; }
            set { isPower = value; }
        }


        // Sætter strømmen til at være fra på maskinen når den bliver instantieret
        public CookingAppliance()
        {
            isPower = false;
        }

        // Skifter mellem om strømmen er til og fra
        public void SetPower()
        {
            if (isPower)
            {
                isPower = false;
            }
            else
            {
                isPower = true;
            }
        }
    }
}
