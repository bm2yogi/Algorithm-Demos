using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AlgorithmsDemo
{
    [TestFixture]
    public class SortingAlgorithms
    {
        private int[] numbers;
        private int swaps;
        private int comparisons;

        [SetUp]
        public void BeforeEach()
        {
            swaps = comparisons = 0;
            numbers = new[] { 9, 2, 4, 3, 1, 5, 8, 7 };
            WriteNumbers(numbers);
            Console.WriteLine();
        }

        [TearDown]
        public void AfterEach()
        {
            WriteNumbers(numbers);
            Console.WriteLine("Swaps:{0} Comparisons:{1}", swaps, comparisons);
        }

        [Test]
        public void BubbleSort()
        {
            bool swap;

            do
            {
                swap = false;
                for (var i = 0; i < numbers.Length - 1; i++)
                {
                    comparisons++;
                    if (numbers[i] <= numbers[i + 1]) continue;

                    swaps++;
                    var temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swap = true;
                }
            } while (swap);


        }

        [Test]
        public void InsertSort()
        {
            for (var index = 1; index < numbers.Length - 1; index++)
                Sort(numbers, index);
        }

        private void Sort(int[] array, int currentIndex)
        {
            var currentValue = array[currentIndex];
            var sortedIndex = currentIndex - 1;

            comparisons++;
            while (sortedIndex >= 0 && array[sortedIndex] > currentValue)
            {
                swaps++;
                array[sortedIndex + 1] = array[sortedIndex];
                sortedIndex--;
            }

            array[sortedIndex + 1] = currentValue;

        }

        [Test]
        public void SelectSort()
        {

        }

        [Test]
        public void MergeSort()
        {

        }

        [Test]
        public void QuickSort()
        {

        }
        private static void WriteNumbers(IEnumerable<int> numbers)
        {
            numbers.ToList().ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
        }
    }
}