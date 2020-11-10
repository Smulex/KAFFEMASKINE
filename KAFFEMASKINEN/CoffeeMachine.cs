using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    public class CoffeeMachine : CookingAppliance
    {
        private Tank tank;

        public Tank Tank
        {
            get { return tank; }
            set { tank = value; }
        }

        private Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        // Giver maskinen en tank og en beholder når den bliver instantieret
        public CoffeeMachine()
        {
            tank = new Tank();
            department = new Department();
        }

        // Laver det antal kopper den har fået i sin parameter, hvis der er væske nok
        public string MakeCoffee(int cups)
        {
            string s = "";

            for (int i = 0; i < cups; i++)
            {
                if (tank.Amount >= 330 && department.HasFilter() && department.HasPowder())
                {
                    tank.Amount -= 330;
                    s = $"{i + 1} cups brewed. ";
                }
                else if (tank.Amount < 330)
                {
                    return s + "Refill liquid tank";
                }
                else
                {
                    return "Department is not ready";
                }

            }
            return s;
        }
    }
}
