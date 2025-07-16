using algorithms_studies.Algorithms.Sorting.BubbleSort;
using algorithms_studies.Algorithms.Sorting.InsertionSort;
using algorithms_studies.Algorithms.Sorting.SelectionSort;

int[] array = [64, 34, 25, 12, 22, 11, 12, 90];

Console.WriteLine("\n___BUBBLE SORT___\n");

Bubble20250625.Sort(array.ToArray()).PrintArray();
Bubble20250626.Sort(array.ToArray()).PrintArray();
Bubble20250626_2.Sort(array.ToArray()).PrintArray();
Bubble20250630.Sort(array.ToArray()).PrintArray();
Bubble20250702.Sort(array.ToArray()).PrintArray();
Bubble20250707.Sort(array.ToArray()).PrintArray();
Bubble20250710.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___SELECTION SORT___\n");

SelectionSort20250630.Sort(array.ToArray()).PrintArray();
SelectionSort20250630_2.Sort(array.ToArray()).PrintArray();
SelectionSort20250702.Sort(array.ToArray()).PrintArray();
SelectionSort20250707.Sort(array.ToArray()).PrintArray();
SelectionSort20250710.Sort(array.ToArray()).PrintArray();

Console.WriteLine("\n___INSERTION SORT___\n");
InsertionSort20250710.Sort(array.ToArray()).PrintArray();