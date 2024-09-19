using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduleFactory.Product
{
    // Abstract Products

    public abstract class ClassTiming
    {
        public abstract string GetTiming();
    }

    public abstract class RoomNumber
    {
        public abstract string GetRoomNum();
    }

    // Concrete Products

    public class NetworkingClassTiming : ClassTiming
    {
        public override string GetTiming()
        {
            return "10:00AM-11.00AM";
        }
    }

    public class NetWorkingClassRoom : RoomNumber
    {
        public override string GetRoomNum()
        {
            return "A007";
        }
    }

    public class RoboticsClassTiming : ClassTiming
    {
        public override string GetTiming()
        {
            return "10.30AM-12:00PM";
        }
    }

    public class RoboticsClassRoom : RoomNumber
    {
        public override string GetRoomNum()
        {
            return "Drawing Lab";
        }
    }
}



