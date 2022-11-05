using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_Electricity_Bill
{
    public class Electrity_Service_Type_Info
    {
        public int Units { get; set; }
        public int MeterNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? ServiceType { get; set; }

        double bill;

        public void ServiceTypeBill()
        {
            if (ServiceType == "d" || ServiceType == "D")
            {
                if (Units < 100)
                {
                    bill = Units * 0.35;
                    Console.WriteLine(bill);
                }
                else if (Units > 100 && Units <= 200)
                {
                    bill = Units * 0.85;
                    Console.WriteLine(bill);
                }
                else if (Units > 200 && Units <= 400)
                {
                    bill = Units * 1.15;
                    Console.WriteLine(bill);
                }
                else if (Units > 400 && Units <= 700)
                {
                    bill = Units * 1.15;
                    Console.WriteLine(bill);
                }
                else
                {
                    bill = Units * 2.80;
                    Console.WriteLine(bill);
                }

            }
            else if(ServiceType == "c" || ServiceType == "C")
            {

                if (Units < 100)
                {
                    bill = Units * 0.90;
                    Console.WriteLine(bill);
                }
                else if (Units > 100 && Units <= 200)
                {
                    bill = Units * 1.35;
                    Console.WriteLine(bill);
                }
                else if (Units > 200 && Units <= 400)
                {
                    bill = Units * 1.95;
                    Console.WriteLine(bill);
                }
                else if (Units > 400 && Units <= 700)
                {
                    bill = Units * 2.45;
                    Console.WriteLine(bill);
                }
                else
                {
                    bill = Units * 3.25;
                    Console.WriteLine(bill);
                }
            }

        }

    }
}
