using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DemoKartBL
    {
        public class Payment
        {
            enum Mode { PayByCash = 1, PayByCard }
            public double CGSTTax(int num, double price)
            {
                if (num == (int)Mode.PayByCash)
                {
                    double Price = 0;
                    Price = price;
                    return Price;
                }
                else
                {
                    double Price = 0;
                    Price = price + (price * 0.035);
                    return Price;
                }
            }
            public double SGSTTax(int num, double price)
            {
                if (num == (int)Mode.PayByCash)
                {
                    double Price = 0;
                    Price = price;
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
}
  



