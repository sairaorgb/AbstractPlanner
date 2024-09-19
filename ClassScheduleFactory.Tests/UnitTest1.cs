using Xunit;
using ClassScheduleFactory.Product;
using ClassScheduleFactory.Factory;

namespace ClassScheduleFactory.Tests
{
    public class ClassFactoryTests
    {
        [Fact]
        public void NetworkingClassTiming_Test()
        {
            
            var timing = new NetworkingClassTiming();
            var result = timing.GetTiming();
            Assert.Equal("10:00AM-11.00AM", result); // Ensure this matches exactly
        }

        [Fact]
        public void NetWorkingClassRoom_Test()
        {
            
            var room = new NetWorkingClassRoom();
            var result = room.GetRoomNum();
            Assert.Equal("A007", result);
        }

        [Fact]
        public void RoboticsClassTiming_Test()
        {
            
            var timing = new RoboticsClassTiming();
            var result = timing.GetTiming();
             Assert.Equal("10.30AM-12:00PM", result);
        }

        [Fact]
        public void RoboticsClassRoom_Test()
        {
            
            var room = new RoboticsClassRoom();
            var result = room.GetRoomNum();
            Assert.Equal("Drawing Lab", result);
        }

        [Fact]
        public void NetworkingClassFactory_Testn()
        {
            
            var factory = new NetworkingClassFactory();
            var timing = factory.CreateClassTiming();
            Assert.IsType<NetworkingClassTiming>(timing);
            Assert.Equal("10:00AM-11.00AM", timing.GetTiming());
        }

        [Fact]
        public void NetworkingClassFactory_Testx()
        {
            
            var factory = new NetworkingClassFactory();
            var room = factory.CreateRoomNumber();
            Assert.IsType<NetWorkingClassRoom>(room);
            Assert.Equal("A007", room.GetRoomNum());
        }

        [Fact]
        public void RoboticsClassFactory_Testn()
        {
            
            var factory = new RoboticsClassFactory();
            var timing = factory.CreateClassTiming();
            Assert.IsType<RoboticsClassTiming>(timing);
            Assert.Equal("10.30AM-12:00PM", timing.GetTiming());
        }

        [Fact]
        public void RoboticsClassFactory_Testx()
        {
            
            var factory = new RoboticsClassFactory();
            var room = factory.CreateRoomNumber();
            Assert.IsType<RoboticsClassRoom>(room);
            Assert.Equal("Drawing Lab", room.GetRoomNum());
        }
    }
}
