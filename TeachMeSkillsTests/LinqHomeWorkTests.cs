using TeachMeSkills;

namespace TeachMeSkillsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPositiveTwoDigitNumbers_MethodReturnedPositiveDigitsOnly()
        {
            var res = LinqHomeWork.GetPositiveTwoDigitNumbers();

            Assert.IsTrue(res.Min() >= 0);
        }

        [Test]
        public void GetPositiveTwoDigitNumbers_MethodReturnedNumbersFrom10To99()
        {
            var res = LinqHomeWork.GetPositiveTwoDigitNumbers();

            Assert.IsTrue(res.Any(n => n >= 10 && n <= 99));
        }

        [Test]
        public void GetEvenNumbers_MethodReturnedEvenNumbersOnly()
        {
            var res = LinqHomeWork.GetEvenNumbers();

            Assert.IsTrue(res.Any(n => n % 2 == 0));
        }

        [Test]
        public void Reverse_FirstLetterIsN()
        {
            var res = LinqHomeWork.Reverse();

            Assert.IsTrue(res[0] == 'n');
        }

        [Test]
        public void Reverse_LastLetterIsA()
        {
            var res = LinqHomeWork.Reverse();

            Assert.IsTrue(res[^1] == 'a');
        }

        [Test]
        public void ChangeFirstLetter_FirstLetterIsI()
        {
            var res = LinqHomeWork.ChangeFirstLetter();

            Assert.IsTrue(res.Any(n => n.StartsWith("I")));
        }

        [Test]
        public void ChangeFirstLetter_FirstLetterIsNotA()
        {
            var res = LinqHomeWork.ChangeFirstLetter();

            Assert.IsFalse(res.Any(n => n.StartsWith("A")));
        }

        [Test]
        public void UnionListsOfNames_ListDoesNotContainNamesEndingWithA()
        {
            var res = LinqHomeWork.UnionListsOfNames();

            Assert.IsTrue(res.Any(n => n.ElementAt(n.Length-1) != 'a'));
        }

        [Test]
        public void UnionListsOfNames_ActualResultIsEqualToExpected()
        {
            var expectedResult = new List<string>() { "Sergey", "Alex", "Igor"};

            var res = LinqHomeWork.UnionListsOfNames();

            Assert.AreEqual(expectedResult, res);
        }

        [Test]
        public void SortNamesByLength_LengthOfFirstElementLessThanLengthOfLastName()
        {
            var res = LinqHomeWork.SortNamesByLength();

            if (res.Any())
                Assert.IsTrue(res.First() <= res.Last());
        }

        [Test]
        public void SortNamesByLength_MethodReturnedListOfInt()
        {
            var res = LinqHomeWork.SortNamesByLength();

            Assert.That(res.GetType(), Is.EqualTo(typeof(List<int>)));
        }

        [Test]
        public void FilterProductsListByPrice_ActualResultIsEqualToExpectedResult()
        {
            var expectedResult = new List<string> {"Milk", "Bread"};
            var res = LinqHomeWork.FilterProductsListByPrice();

            Assert.AreEqual(res, expectedResult);
        }
    }
}