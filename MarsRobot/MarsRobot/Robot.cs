using System.Drawing;

namespace MarsRobot
{
    public class Robot
    {
        public Robot()
        {
            Coordinates = new Point(1, 1);
            Direction = 'N';
        }

        public Point Coordinates { get; private set; }
        private char Direction { get; set; }

        public string Move(Plateau plateau, char[] movementArray)
        {
            foreach (var command in movementArray)
            {
                SetDirection(command, plateau);
            }

            return GetPositionDescription();
        }

        private void SetDirection(char command, Plateau plateau)
        {
            switch (command)
            {
                case 'L':
                    RotateLeft();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'F':
                    MoveForward(plateau);
                    break;
            }
        }

        private void MoveForward(Plateau plateau)
        {
            Point point = new Point();

            switch (Direction)
            {
                case 'N':
                    point.Offset(0, 1);
                    break;
                case 'S':
                    point.Offset(0, -1);
                    break;
                case 'E':
                    point.Offset(1, 0);
                    break;
                case 'W':
                    point.Offset(-1, 0);
                    break;
            }

            Point currentCoordinates = Coordinates;

            currentCoordinates.Offset(point);

            if (plateau.AreCoordinatesValid(currentCoordinates))
            {
                Coordinates = currentCoordinates;
            }
        }

        private void RotateRight()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'E';
                    break;
                case 'S':
                    Direction = 'W';
                    break;
                case 'E':
                    Direction = 'S';
                    break;
                case 'W':
                    Direction = 'N';
                    break;
            }
        }

        private void RotateLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;
                case 'S':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'N';
                    break;
                case 'W':
                    Direction = 'S';
                    break;
            }
        }

        public string GetPositionDescription()
        {
            string directionDescription = GetDirectionDescription();

            return $"{Coordinates.X},{Coordinates.Y},{directionDescription}";
        }

        private string GetDirectionDescription()
        {
            if (Direction == 'N')
                return "North";
            else if (Direction == 'S')
                return "South";
            else if (Direction == 'E')
                return "East";
            else
                return "West";
        }
    }
}
