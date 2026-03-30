using calc.Models;

namespace CalcTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            // Act
            var angle = new Angle(23, 20, 3);

            // Assert
            Assert.Equal("23° 20' 3\"", angle.ToString());
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            // Act
            var angle = Angle.FromString("23° 20' 3\"");

            // Assert
            Assert.Equal((new Angle(23, 20, 3)).ToDecimalDegrees(), angle.ToDecimalDegrees());
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var angle = Angle.FromString("23° 20' 3\"");

            // Act
            var angleFromDecimal = Angle.FromDecimal(angle.ToDecimalDegrees());

            Assert.Equal(angle.ToString(), angleFromDecimal.ToString());
        }

        [Theory]
        [MemberData(nameof(GetAngleForAdditionTests))]
        public void AdditionTest(Angle left, Angle right, Angle result)
        {
            // Arrange
            // Act            
            var testResult = left + right;

            // Assert
            Assert.Equal(result.ToString(), testResult.ToString());
        }

        [Theory]
        [MemberData(nameof(GetAngleForSubtractionTests))]
        public void SubtractionTest(Angle left, Angle right, Angle result)
        {
            // Arrange
            // Act            
            var testResult = left - right;

            // Assert
            Assert.Equal(result.ToString(), testResult.ToString());
        }

        public static IEnumerable<object[]> GetAngleForAdditionTests()
        {
            yield return new object[] { Angle.FromString("23° 20' 3\""), Angle.FromString("23° 20' 3\""), Angle.FromString("46° 40' 6\"") };
            yield return new object[] { Angle.FromString("3° 34' 3\""), Angle.FromString("45° 50' 3\""), Angle.FromString("49° 24' 6\"") };
            yield return new object[] { Angle.FromString("3° 34' 59\""), Angle.FromString("45° 50' 3\""), Angle.FromString("49° 25' 2\"") };
        }

        public static IEnumerable<object[]> GetAngleForSubtractionTests()
        {
            yield return new object[] { Angle.FromString("23° 20' 3\""), Angle.FromString("23° 20' 3\""), Angle.FromString("0° 0' 0\"") };
            yield return new object[] { Angle.FromString("3° 34' 3\""), Angle.FromString("45° 50' 3\""), Angle.FromString("-43° 16' 0\"") };
            yield return new object[] { Angle.FromString("3° 34' 59\""), Angle.FromString("45° 50' 3\""), Angle.FromString("-43° 16' 56\"") };
        }
    }   
}
