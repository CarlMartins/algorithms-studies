﻿using algorithms_studies.Algorithms.Search;
using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;
using algorithms_studies.Problems.Arrays;

int[] array = [64, 34, 25, 12, 22, 90, 11, 12];

int[] arrayToRotate = [1, 2, 3, 4, 5, 6, 7];
const int rotateK = 3;

int[] arrayToGetLongestConsecutiveSequence = [1, 2, 3, 4, 5];
int[] arrayToGetLongestConsecutiveSequence2 = [100, 4, 20, 1, 3, 2];
int[] arrayToGetLongestConsecutiveSequence3 = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

int[] arrayToTwoSum = [11, 15, 2, 4, 3];
const int targetTwoSum = 6;

string[] linkedListWords = { "the", "jumps", "over", "the", "dog" };

int[] binarySearchArray = [2, 6, 23, 45, 99, 150, 152];
var binarySearchTarget = 150;

Console.WriteLine("\n___BUBBLE SORT___\n");
Bubble20250721.Sort(array.ToArray()).PrintArray();
Bubble20250722.Sort(array.ToArray()).PrintArray();
Bubble20250723.Sort(array.ToArray()).PrintArray();
Bubble20250724.Sort(array.ToArray()).PrintArray();
Bubble20250728.Sort(array.ToArray()).PrintArray();
Bubble20250729.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___SELECTION SORT___\n");
SelectionSort20250721.Sort(array.ToArray()).PrintArray();
SelectionSort20250722.Sort(array.ToArray()).PrintArray();
SelectionSort20250723.Sort(array.ToArray()).PrintArray();
SelectionSort20250724.Sort(array.ToArray()).PrintArray();
SelectionSort20250728.Sort(array.ToArray()).PrintArray();
SelectionSort20250729.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___INSERTION SORT___\n");
InsertionSort20250721.Sort(array.ToArray()).PrintArray();
InsertionSort20250722.Sort(array.ToArray()).PrintArray();
InsertionSort20250723.Sort(array.ToArray()).PrintArray();
InsertionSort20250724.Sort(array.ToArray()).PrintArray();
InsertionSort20250728.Sort(array.ToArray()).PrintArray();
InsertionSort20250729.Sort(array.ToArray()).PrintArray();

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

Console.WriteLine("\n___SEARCH - BINARY SEARCH___\n");
BinarySearch_20250729.BinarySearch(binarySearchArray, binarySearchTarget).PrintInteger();
BinarySearch_20250731.BinarySearch(binarySearchArray, binarySearchTarget).PrintInteger();