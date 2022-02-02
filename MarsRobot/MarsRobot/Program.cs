using System;

namespace MarsRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            string dimensions = Console.ReadLine();
            string[] coordinates = dimensions.Split("x");
            Plateau plateau = new Plateau(coordinates[0], coordinates[1]);
            Robot robot = new Robot();

            char[] commandArray = Console.ReadLine().ToCharArray();

            Console.WriteLine(robot.Move(plateau, commandArray));
        }
    }
}