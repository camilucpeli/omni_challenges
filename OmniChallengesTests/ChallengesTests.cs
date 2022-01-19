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
        [TestCase("Possible", new int[] { 0, 3 })]    // There are 3 half meter square sheets. We can use 2 of them to cover the area.
        [TestCase("Possible", new int[] { 0, 1, 2 })] // This time, we can combine the A[1] sheet with the 2 A[2] sheets and cover one square meter area.
        [TestCase("Impossible", new int[] { 0, 0, 0, 0, 15 })] // We could do it with 16, but only have 15.
        public void TestHalfSplit(string expected, int[] sheets)
        {
            Assert.AreEqual(expected, Challenges.CanBuild(sheets));
        }

        [Test]
        [TestCase(new int[] { 25, 25, 50 }, "YES")] // She can use the first or second 25$ to give change to the third person.
        [TestCase(new int[] { 25, 100 }, "NO")] // Alice won't have enough to give change to the second person.
        [TestCase(new int[] { 25, 25, 50, 50, 100 }, "NO")] // Alice will not have the right bills to give 75 dollars of change (you can't make two bills of 25 from one of 50)
        public void TestThemeParkLine(int[] people, string expected)
        {
            Assert.AreEqual(expected, Challenges.CanSellTickets(people));
        }
    }
}