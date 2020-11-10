using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    abstract class Alcohol : Liquid
    {
        private int percentage;

        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
    }
}
