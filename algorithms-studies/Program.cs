using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;
using algorithms_studies.Problems.Arrays;

int[] array = [64, 34, 25, 12, 22, 90, 11, 12];

int[] arrayToRotate = [1, 2, 3, 4, 5, 6, 7];
int rotateK = 3;

Console.WriteLine("\n___BUBBLE SORT___\n");

Bubble20250721.Sort(array.ToArray()).PrintArray();
Bubble20250722.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___SELECTION SORT___\n");

SelectionSort20250721.Sort(array.ToArray()).PrintArray();
SelectionSort20250722.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___INSERTION SORT___\n");

InsertionSort20250721.Sort(array.ToArray()).PrintArray();
InsertionSort20250722.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___ARRAYS - ROTATE AN ARRAY BY K ELEMENTS___\n");

RotateByK_20250720.RorateRight(arrayToRotate, rotateK).PrintArray();
