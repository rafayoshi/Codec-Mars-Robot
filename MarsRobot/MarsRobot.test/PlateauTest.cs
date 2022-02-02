using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace MarsRobot.test
{
    public class PlateauTest
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Test_PlateauCoordinates_Valid(int x, int y, Point coordinates, bool expected)
        {
            Plateau plateau = new Plateau(x, y);
            Assert.Equal(expected, plateau.AreCoordinatesValid(coordinates));
        }
    }

    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
             new object[] {5, 5,new Point(1, 1), true},
             new object[] { 5, 5, new Point(5, 5), true },
             new object[] { 5, 5, new Point(1, 6), false },
             new object[] { 5, 5, new Point(2, 7), false }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}