using algorithms_studies.Algorithms.Search.BinarySearch;
using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;
using algorithms_studies.Problems.Arrays;

var bubbleSort = new BubbleSort([4, 21, 1, 6, 29, 100, 0]);
bubbleSort.PrintBubbleSort();

var insertionSort = new InsertionSort([154, 123, 0, 2, 900]);
insertionSort.PrintInsertionSort();

var selectionSort = new SelectionSort([700, 1, 25, 8, 20]);
selectionSort.PrintSelectionSort();

var binarySearch = new BinarySearch([10, 20, 30, 40], 30);
binarySearch.PrintBinarySearches();

// NEEDS TO BE REFACTORED
int[] arrayToRotate = [1, 2, 3, 4, 5, 6, 7];
const int rotateK = 3;

int[] arrayToGetLongestConsecutiveSequence = [1, 2, 3, 4, 5];
int[] arrayToGetLongestConsecutiveSequence2 = [100, 4, 20, 1, 3, 2];
int[] arrayToGetLongestConsecutiveSequence3 = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

int[] arrayToTwoSum = [11, 15, 2, 4, 3];
const int targetTwoSum = 6;

string[] linkedListWords = { "the", "jumps", "over", "the", "dog" };

Console.WriteLine("\n___DATA STRUCTURES - LINKED LIST___\n");

Console.WriteLine("\n___ARRAYS - ROTATE AN ARRAY BY K ELEMENTS___\n");
RotateByK_20250720.RorateRight(arrayToRotate, rotateK).PrintArray();

Console.WriteLine("\n___ARRAYS - LONGEST CONSECUTIVE SEQUENCE___\n");
LongestConsecutiveSequence_20250722.LongestConsecutive(arrayToGetLongestConsecutiveSequence3.ToArray()).PrintInteger();
LongestConsecutiveSequence_20250723.LongestConsecutive(arrayToGetLongestConsecutiveSequence3.ToArray()).PrintInteger();
LongestConsecutiveSequence_20250726.LongestConsecutive(arrayToGetLongestConsecutiveSequence3.ToArray()).PrintInteger();

Console.WriteLine("\n___ARRAYS - TWO SUM___\n");
TwoSum_20250723.TwoSum(arrayToTwoSum.ToArray(), targetTwoSum).PrintArray();
TwoSum_20250723_2.TwoSum(arrayToTwoSum.ToArray(), targetTwoSum).PrintArray();
TwoSum_20250723_3.TwoSum(arrayToTwoSum.ToArray(), targetTwoSum).PrintArray();
TwoSum_20250728.TwoSum(arrayToTwoSum.ToArray(), targetTwoSum).PrintArray();
