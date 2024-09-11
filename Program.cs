using System;
using ClassScheduleFactory.product;
using ClassScheduleFactory.Factories;

namespace ClassScheduleFactory
{
    public class Program
    {
        public static void  Main(string[] args)
        {
            string day;
            Console.WriteLine("Enter the Day: ");
            day = Console.ReadLine();
            GetSchedule(day.ToLower());
        }

        public static void GetSchedule(string day)
        {
            AbstractFactory factory = null;
            if(day != "saturday" && day != "sunday")
            {   
                if(day == "monday" || day == "wednesday" || day == "friday")
                {
                    factory = new NetworkingClassFactory();
                    // Console.WriteLine("Networking class ");
                }
                else if(day == "tuesday" || day == "thursday")
                {
                    factory = new RoboticsClassFactory();
                    // Console.WriteLine("Robotics Class");
                }
                if(factory != null)
                {
                    RoomNumber roomNumber = factory.CreateRoomNumber();
                    ClassTiming classTiming = factory.CreateClassTiming();
                    Console.WriteLine($"Class Time: {classTiming.GetTiming()}, Room: {roomNumber.GetRoomNum()}");
                }

            }
            else 
            {
                Console.WriteLine("It's Holiday bud!!!");
            }
        }

    }
}

