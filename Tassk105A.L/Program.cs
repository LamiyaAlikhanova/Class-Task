using System.Xml.Schema;

namespace Tassk105A.L 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Brand = "BMW",
                Model = "M8",
                Mile = 128000,
                DoorsNum = 4
            };

            MotorCycle motorCycle = new MotorCycle 
            {
                Brand = "Kawasaki",
                Model = "Zx-10r",
                Mile = 22100,
                WheelNum = 2
            };

            car.ShowFullInfo();
            motorCycle.ShowFullInfo();
        }
    }
    //Task-1
     public class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;
    }
    public class Car : Vehicle
    {
        public int DoorsNum;

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile},DoorsNum:{DoorsNum}");

        }
    }
    public class MotorCycle: Vehicle
    {
        public int WheelNum;

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile},WheelNum:{WheelNum}");
        }
    }

   

}    



