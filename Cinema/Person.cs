using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Person
    {
        //Todo break out to separate class file
        public int Age { get; set; }

        public Person(int inAge)
        {
            Age = inAge;
        }

        public int CalcPrice()
        {
            int calcPrice = 120;
            switch (Age)
            {
                case < 21:
                    {
                        calcPrice = 80;
                        break;
                    }

                case > 64:
                    calcPrice = 90;
                    break;

                default:
                    break;

            }

            return calcPrice;
        }
        public void PrintToConsole()
        {
            string toPrint = "Standardpris";
            switch (Age)
            {
                case < 21:
                    {
                        toPrint = "Ungdomspris";
                        break;
                    }

                case > 64:
                    toPrint = "Pensionärspris";
                    break;

                default:
                    break;

            }
            Console.WriteLine("{0}: {1}kr", toPrint, this.CalcPrice());
            Console.WriteLine();
        }

    }
}
