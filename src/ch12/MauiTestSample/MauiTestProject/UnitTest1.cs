using MauiTestSample;

namespace MauiTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calc();

            Assert.Equal(0, calc.Count);
            calc.CountUp();
            Assert.Equal(1, calc.Count);
            for (int i = 0; i < 10; i++) calc.CountUp();
            Assert.Equal(11, calc.Count);
        }
        [Fact]
        public void Test2()
        {
            var calc = new Calc();
            Assert.Equal(30, calc.Add(10, 20));
        }
        [Fact]
        public void Test3()
        {
            var calc = new Calc();
            Assert.Equal("10 and 20", calc.Add("10", "20"));
        }
    }
}