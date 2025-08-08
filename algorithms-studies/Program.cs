using algorithms_studies.Algorithms.Search.BinarySearch;
using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;
using algorithms_studies.Problems.Arrays;
using algorithms_studies.Problems.Arrays.LongestConsecutiveSequence;

var bubbleSort = new BubbleSort();
bubbleSort.PrintBubbleSort();

var insertionSort = new InsertionSort();
insertionSort.PrintInsertionSort();

var selectionSort = new SelectionSort();
selectionSort.PrintSelectionSort();

var binarySearch = new BinarySearch();
binarySearch.PrintBinarySearches();

// NEEDS TO BE REFACTORED
int[] arrayToRotate = [1, 2, 3, 4, 5, 6, 7];
const int rotateK = 3;

int[] arrayToTwoSum = [11, 15, 2, 4, 3];
const int targetTwoSum = 6;

string[] linkedListWords = { "the", "jumps", "over", "the", "dog" };

// Console.WriteLine("\n___ARRAYS - ROTATE AN ARRAY BY K ELEMENTS___\n");
// RotateByK_20250720.RorateRight(arrayToRotate, rotateK).PrintArray();
//
// var longestConsecutiveSequence = new LongestConsecutiveSequence();
// longestConsecutiveSequence.PrintLongestConsecutiveSequence();

var twoSum = new TwoSum();
twoSum.PrintTwoSum();

var longestConsecutiveSequence = new LongestConsecutiveSequence();
longestConsecutiveSequence.PrintLongestConsecutiveSequence();

var rotateByK = new RotateByK();
rotateByK.PrintRotateByK();
