using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPro
{
    class Payment
    {
        enum Mode
        {
            Card = 1,
            Cash = 2
        }
        public double CGSTTax(int Number, double price)
        {
            if (Number == (int)Mode.Card)
            {
                double Price = 0;
                Price = price * 0.18;
                return Price;

            }
            else
            {
                double Price = 0;
                Price = Price * 0.035 * 0.18;
                return Price;
            }
        }
        public double SGSTTax(int Number, double price)
        {
            if (Number == (int)Mode.Cash)
            {
                double Price = 0;
                Price = Price + 0;
                return Price;

            }
            else
            {
                double Price = 0;
                Price = price + (price * 0.035);
                return Price;
            }

        }
    }
}



