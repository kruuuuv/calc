using calc.Models;

namespace CalcTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Act
            var angle = new Angle(23, 20, 3);

            Assert.Equal("23° 20' 3\"", angle.ToString());
        }

        [Fact]
        public void Test2()
        {
            // Act
            var angle = Angle.FromString("23° 20' 3\"");

            Assert.Equal((new Angle(23, 20, 3)).ToDecimalDegrees(), angle.ToDecimalDegrees());
        }

        [Fact]
        public void Test3()
        {
            // Act
            var angle = Angle.FromString("23° 20' 3\"");
            var angleFromDecimal = Angle.FromDecimal(angle.ToDecimalDegrees());
            
            Assert.Equal(angle.ToString(), angleFromDecimal.ToString());
        }
    }
}
