namespace Summator.Tests
{
    public class Tests
    {
        [Test]        // Задължително се пише, иначе не излиза в Test Explorer
        
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 7 }); // Задължително се прави референция към Summator Project

            int expected = 12;

            Assert.That(result == expected);
        }

        [Test]

        public void Test_Sum_ThreePossitiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 7 , 5 });

            int expected = 17;

            Assert.That(result == expected);
        }

        [Test]

        public void Test_Sum_TwoNegativeNumbers()
        {
            long result = Summator.Sum(new int[] { -7,-9 });

            int expected = -16;

            Assert.That(result == expected);
        }

        [Test]

        public void Test_Sum_TwoZeroes()
        {
            long result = Summator.Sum(new int[] { 0,0 });

            int expected = 0;

            Assert.That(result == expected);
        }

        [Test]

        public void Test_Sum_BigValues()
        {
            long result = Summator.Sum(new int[] { 3000000000, 5000000000 });

            long expected = 8000000000;

            Assert.That(result == expected);

        }

        [Test]

        public void Test_Sum_OneZero_and_Number()
        {
            long result = Summator.Sum(new int[] { 0, 5 });

            int expected = 5;

            Assert.That(result == expected);
        }
    }
}