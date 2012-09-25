using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AlgorithmsDemo
{
    [TestFixture]
    public class SetAlgorithms
    {
        private readonly int[] _oddNumbers = new[] { 1, 3, 5, 7, 9 };
        private readonly int[] _primeNumbers = new[] { 1, 2, 3, 5, 7, 11, 13 };
        
        private static void WriteNumbers(IEnumerable<int> numbers)
        {
            numbers.ToList().ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
        }

        [SetUp]
        public void BeforeEach()
        {
            WriteNumbers(_oddNumbers);
            WriteNumbers(_primeNumbers);
            Console.WriteLine();

        }

        [Test]
        public void ShowUnion()
        {
            WriteNumbers(Union(_oddNumbers, _primeNumbers));
        }

        [Test]
        public void ShowSetDifference()
        {
            WriteNumbers(SetDifference(_oddNumbers, _primeNumbers));
        }

        [Test]
        public void ShowIntersection()
        {
            WriteNumbers(Intersection(_oddNumbers, _primeNumbers));
        }

        [Test]
        public void ShowSymmetricDifference()
        {
            WriteNumbers(SymmetricDifference(_oddNumbers, _primeNumbers));
        }

        public IEnumerable<int> Intersection(int[] one, int[] other)
        {
            // Return all items that are only in both.

            foreach (var value in one)
                if (Array.IndexOf(other, value) > -1)
                    yield return value;
        }

        public IEnumerable<int> SetDifference(int[] one, int[] other)
        {
            // Return all items that are only
            // in one and not the other.

            foreach (var value in one)
                if (Array.IndexOf(other, value) == -1)
                    yield return value;
        }

        public List<int> Union(int[] one, int[] other)
        {
            // Return all unique items that are in
            // either one or the other.

            var union = new List<int>(other);
            union.AddRange(SetDifference(one, other));
            return union;
        }

        public IEnumerable<int> SymmetricDifference(int[] one, int[] other)
        {
            // Return all items that are in one or the other,
            // but not both.

            var intersection = Intersection(one, other).ToArray();
            var union = Union(one, other).ToArray();
            return SetDifference(union, intersection);
        }
    }
}