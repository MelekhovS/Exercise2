using Exercise2.Classes;
using System;
using Xunit;

namespace XUnitExercise2
{
    public class UnitTest1
    {
        [Fact]
        public void CirclePerimiterIsWorkTest()
        {
            var c  = new Circle();
            c.Radius = 4;
            Assert.True( Math.Round( c.GetPerimetor() , 2) == 50.27 );

        }

        [Fact]
        public void TriangePerimiterIsWorkTest() {
            var t = new Triangle();
            t.SideA = 3;
            t.SideB = 4;
            t.SideC = 5;
            Assert.True(t.GetPerimetor() == 6); 
        }


        [Fact]
        public void IsSqurerMethodTest() {

            var t = new Triangle();
            t.SideA = 5;
            t.SideB = 12;
            t.SideC = 13;
            Assert.True(t.ISquare());

            var t2 = new Triangle();
            t2.SideA = 2;
            t2.SideB = 5;
            t2.SideC = 5;
            Assert.False(t2.ISquare());
        }
    }
}
