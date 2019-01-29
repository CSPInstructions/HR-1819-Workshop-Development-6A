using System;

namespace SortingAlgorithm {
    class Program {
        static void Main( string[] args ) {
            LinkedList<int> firstList = new LinkedList<int>();
            LinkedList<int> secondList = new LinkedList<int>();
            LinkedList<int> thirdList = new LinkedList<int>();

            firstList.AddRange( new int[] { 6, 3, 8, 1, 9 } );
            secondList.AddRange( new int[] { 8, 4, 6, 5, 9 } );
            thirdList.AddRange( new int[] { 1, 7, 4, 5, 3 } );

            //firstList.Print();
            //firstList.InsertionSort();
            //firstList.Print();

            //secondList.Print();
            //secondList.BubbleSort();
            //secondList.Print();

            thirdList.Print();
            thirdList.MergeSort( 0, thirdList.Length() - 1);
            thirdList.Print();
        }
    }
}
