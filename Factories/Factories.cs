
using ClassScheduleFactory.product;

namespace ClassScheduleFactory.Factories
{
    //Abstract Factory
    public abstract class AbstractFactory
    {
        public abstract ClassTiming CreateClassTiming();
        public abstract RoomNumber CreateRoomNumber();
    }
    
    //Concrete Factories
    public class NetworkingClassFactory : AbstractFactory
    {
        public override ClassTiming CreateClassTiming()
        {
            return new NetworkingClassTiming();
        }

        public override RoomNumber CreateRoomNumber()
        {
            return new NetWorkingClassRoom();
        }
    }

    public class RoboticsClassFactory : AbstractFactory
    {
        public override ClassTiming CreateClassTiming()
        {
            return new RoboticsClassTiming();
        }

        public override RoomNumber CreateRoomNumber()
        {
                return new RoboticsClassRoom();
        }
    }
}
