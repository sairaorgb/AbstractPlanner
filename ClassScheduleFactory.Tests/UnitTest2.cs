using Xunit;
using ClassScheduleFactory;

namespace ClassScheduleFactory.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("monday", "Class Time: 10:00AM-11.00AM, Room: A007")]
        [InlineData("wednesday", "Class Time: 10:00AM-11.00AM, Room: A007")]
        [InlineData("friday", "Class Time: 10:00AM-11.00AM, Room: A007")]
        [InlineData("tuesday", "Class Time: 10.30AM-12:00PM, Room: Drawing Lab")]
        [InlineData("thursday", "Class Time: 10.30AM-12:00PM, Room: Drawing Lab")]
        [InlineData("saturday", "It's Holiday bud!!!")]
        [InlineData("sunday", "It's Holiday bud!!!")]
        public void GetSchedule_Test(string day, string expected)
        {
            string result = Program.GetSchedule(day.ToLower());
            Assert.Equal(expected, result);
        }
    }
}
