using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int MinOfArray(int[] arr)
            //{
            //    int min = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if(arr[i]<min)
            //        {
            //            min = arr[i];
            //        }
            //    }
            //    return min;
            //}
            #endregion
            #region Task 2
            //int MaxOfArray(int[] arr)
            //{
            //    int max = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            max = arr[i];
            //        }
            //    }
            //    return max;
            //}
            #endregion
            #region Task 3
            //int IndexOfMinOfArray(int[] arr)
            //{
            //    int min = arr[0];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //        {
            //            min = arr[i];
            //            index = i;
            //        }
            //    }
            //    return index;
            //}
            #endregion
            #region Task 4
            //int IndexOfMaxOfArray(int[] arr)
            //{
            //    int max = arr[0];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            max = arr[i];
            //            index = i;
            //        }
            //    }
            //    return index;
            //}
            #endregion
            #region Task 5
            //int SumOfOddIndexes(int[] arr)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if(i%2==1)
            //        {
            //            sum = sum + arr[i];
            //        }
            //    }
            //    return sum;
            //}
            #endregion
            #region Task 6
            //void ReverseArray(int[] arr)
            //{
            //    Console.Write(arr[arr.Length-1]);
            //    for (int i = arr.Length-2; i >= 0; i--)
            //    {
            //        Console.Write($", {arr[i]}");
            //    }
            //}
            #endregion
            #region Task 7
            //int CountOfOddNumbers(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if(arr[i]%2==1)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            #endregion
            #region Task 8
            //8.Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            //int[] ReplaceSecondHalfOfArray(ref int[] arr)
            //{
            //    int[] newArr = new int[arr.Length];
            //    int n = arr.Length / 2;
            //    int temp = 0;
            //    int middleOfArray = arr[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        temp = arr[i];
            //        newArr[i] = arr[i + n + 1];
            //        newArr[i + n + 1] = temp;
            //    }
            //    arr = newArr;
            //    arr[n] = middleOfArray;
            //    return arr;
            //}           
            #endregion
            #region Task 9
            //9.Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble)
            //int[] BubbleSort(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        for (int j = 1; j < arr.Length - i; j++)
            //        {
            //            if (arr[j] < arr[j - 1])
            //            {
            //                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
            //            }
            //        }
            //    }
            //    return arr;
            //}
            #endregion
            #region Task 10
            //10.Отсортировать массив по убыванию
            //int[] BubbleSortReverse(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        for (int j = 1; j < arr.Length - i; j++)
            //        {
            //            if (arr[j] > arr[j - 1])
            //            {
            //                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
            //            }
            //        }
            //    }
            //    return arr;
            //}           
            #endregion
        }
    }
}
