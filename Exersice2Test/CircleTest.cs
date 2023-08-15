using Exercise2.Controller;
using Moq;

namespace Exersice2Test
{
    public class CircleTest
    {
        [Fact]
        public void Test1()
        {
            void CircleRadiusShouldNotBeNegative()
            {
                var circle = new Circle(0,0,-1);
                bool result = circle.Radius(-1);
                Assert.False(result);

                Assert.False(result, "1 should not be prime");
            }
        }
    }
}