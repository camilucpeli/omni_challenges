using NUnit.Framework;
using OmniChallenges;

namespace OmniChallengesTests
{
    public class ChallengesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculatorTest()
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("omnidrone", 1)] // We did cut all the required letters to make 1 billboard.
        [TestCase("mnidrone", 0)] // This time we're missing one letter, so not even a single billboard can be made.
        [TestCase("omnidroneomnidrone", 2)] // We cut twice as much as needed.
        [TestCase("oommnniiddrroonnee", 2)] // They are arranged differently, but there are still enough letters to build 2 billboards.
        [TestCase("droneomni", 1)] // Order doesn't matter.
        [TestCase("dowrgmyrwnwretidergrogewrnecdovsdmewfwngregritrewdtwrbfsonvdser", 2)]
        public void TestFoamLetters(string input, int expected)
        {
            Assert.AreEqual(expected, Challenges.HowManyBillboards(input));
        }

        [Test]
        [TestCase(3, 0.66, 1.5, 3)] // The ball will pass during first fall, then will bounce passing one time going upwards and one going downwards.
        [TestCase(3, 1, 1.5, -1)]   // This time the ball bounces infinitely
        public void TestFallingBall(double h, double f, double m, int expected)
        {
            Assert.AreEqual(expected, Challenges.HowManyTimes(h, f, m));
        }

        [Test]
        public void HalfSplitsTest()
        {
            Assert.Pass();
        }

        [Test]
        public void ThemeParkTest()
        {
            Assert.Pass();
        }
    }
}