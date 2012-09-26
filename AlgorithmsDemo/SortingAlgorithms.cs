using System;
using NUnit.Framework;

namespace AlgorithmsDemo
{
    [TestFixture]
    public class SortingAlgorithms
    {
        readonly int[] numbers = new[] { 9, 2, 4, 3, 1, 5, 8, 7 };

        [Test]
        public void BubbleSort()
        {
            var swaps = 0;
            var comparisons = 0;
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


            Console.WriteLine("Swaps:{0} Comparisons:{1}", swaps, comparisons);
        }

        [Test]
        public void InsertSort()
        {
            
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
    }
}