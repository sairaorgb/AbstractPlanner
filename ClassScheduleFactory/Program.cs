using System;
using ClassScheduleFactory.Factory;
using ClassScheduleFactory.Product;

namespace ClassScheduleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string day;
            Console.WriteLine("Enter the Day: ");
            day = Console.ReadLine();
            string schedule = GetSchedule(day.ToLower());
            Console.WriteLine(schedule);
        }

        public static string GetSchedule(string day)
        {
            AbstractFactory factory = null;
            if (day != "saturday" && day != "sunday")
            {
                if (day == "monday" || day == "wednesday" || day == "friday")
                {
                    factory = new NetworkingClassFactory();
                    // Console.WriteLine("Networking class ");
                }
                else if (day == "tuesday" || day == "thursday")
                {
                    factory = new RoboticsClassFactory();
                    // Console.WriteLine("Robotics Class");
                }
                if (factory != null)
                {
                    RoomNumber roomNumber = factory.CreateRoomNumber();
                    ClassTiming classTiming = factory.CreateClassTiming();
                    return $"Class Time: {classTiming.GetTiming()}, Room: {roomNumber.GetRoomNum()}";
                }

            }
                return "It's Holiday bud!!!";
        }

    }
}





