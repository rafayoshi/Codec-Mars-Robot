using Xunit;

namespace MarsRobot.test
{
    public class RobotTest
    {
        [Theory]
        [InlineData(new char[] { 'F' }, "1,2,North")]
        [InlineData(new char[] { 'F', 'F', 'R', 'F', 'L', 'F', 'L', 'F' }, "1,4,West")]
        public void Test_RobotMovement_IsValid(char[] commandArray, string expectedResult)
        {
            Robot robot = new Robot();
            Plateau plateau = new Plateau(5, 5);
            Assert.Equal(expectedResult, robot.Move(plateau, commandArray));
        }
    }
}