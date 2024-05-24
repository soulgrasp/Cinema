using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Helpers
{
    public static class CustomFunctions
    {

        public static int SwitchAgeCategory(int inAge)
        {
            int calcPrice = 120;
            switch (inAge)
            {
                case < 21:
                    calcPrice = 80;
                    break;

                case > 64:
                    calcPrice = 90;
                    break;

                default:
                    break;

            }

            return calcPrice;
        }
    }
}
