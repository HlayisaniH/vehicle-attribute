using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW",98066,2020);
            Car car2 = new Car("AUDI",09866,2019);

            Console.WriteLine(car1.carName + " " + car2.carName);
            Console.WriteLine(Car.carCount);

            Console.ReadLine();
        }
    }
}
