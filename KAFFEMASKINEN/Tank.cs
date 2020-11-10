using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    public class Tank
    {
        private Liquid liquid;

        public Liquid Liquid
        {
            get { return liquid; }
            set { liquid = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        // Sætter tanken til at være tom når den bliver instantieret
        public Tank()
        {
            amount = 0;
        }

        // Fylder tanken op med den væske den har fået i sin parameter
        public string Fill(Liquid liquid)
        {
            this.liquid = liquid;
            amount = 1000;

            return "Liqiud tank is filled with " + liquid.GetType().Name.ToLower();
        }
    }
}
