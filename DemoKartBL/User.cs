using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite
{
        public class User
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public double mobileNo { get; set; }

            public int Login(String UserName, String Password)
            {
                if (UserName == "User" && Password == "pass")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }
    }

