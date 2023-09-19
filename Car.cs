using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Attribute
{
    internal class Car
    {

        public int year;
        public int carId; 
        public string carName;

        public static int carCount;

        public Car(string aCarName, int aCarId, int aYear) 
        {
            year = aYear;
            carName = aCarName; 
            carId = aCarId;
            carCount++;
        
        }    
    }
}
