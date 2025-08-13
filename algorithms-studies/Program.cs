using algorithms_studies.Algorithms.Search.BinarySearch;
using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;
using algorithms_studies.Problems.Arrays;
using algorithms_studies.Problems.Arrays.LongestConsecutiveSequence;
using algorithms_studies.Problems.Arrays.MajorityElement;
using algorithms_studies.Problems.Arrays.MoveZeroes;

var bubbleSort = new BubbleSort([1, 54, 12, 3, 1, 99, 20, 2, 5]);
bubbleSort.PrintBubbleSort();

var insertionSort = new InsertionSort();
insertionSort.PrintInsertionSort();

var selectionSort = new SelectionSort();
selectionSort.PrintSelectionSort();

var binarySearch = new BinarySearch(2);
binarySearch.PrintBinarySearches();

var twoSum = new TwoSum();
twoSum.PrintTwoSum();

var longestConsecutiveSequence = new LongestConsecutiveSequence([6, 4, 12, 13, 22, 15, 11, 14]);
longestConsecutiveSequence.PrintLongestConsecutiveSequence();

var rotateByK = new RotateByK();
rotateByK.PrintRotateByK();

var majorityElement = new MajorityElement();
majorityElement.PrintMajorityElement();

var moveZeroes = new MoveZeroes([0, 0, 1]);
moveZeroes.PrintMoveZeroes();