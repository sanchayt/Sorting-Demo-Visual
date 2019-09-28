using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingDemoVisual.Models
{
    public class SortingAlgorithms
    {
        public static List<String> bubbleSort(int[] arr)
        {
            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;
            // Checking if current element is smaller than next element
            // if not then swapping them and continuing to next element
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        result.Add(String.Join(",", arr));
                    }

                }
            }
            return result;
        }

        public static List<String> insertionSort(int[] arr)
        {
            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Moving elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                result.Add(String.Join(",", arr));
            }

            return result;
        }

        public List<String> heapSort(int[] arr)
        {

            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
                result = heapify(arr, n, i, result);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                result = heapify(arr, i, 0, result);
            }
            result.Add(String.Join(",", arr));
            return result;
        }

        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        List<String> heapify(int[] arr, int n, int i, List<String> list)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                list.Add(String.Join(",", arr));

                // Recursively heapify the affected sub-tree 
                heapify(arr, n, largest, list);
            }
            return list;
        }

        public static List<String> bubbleSortString(String[] arr)
        {
            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;
            // Checking if current element is smaller than next element
            // if not then swapping them and continuing to next element
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        String temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        result.Add(String.Join(",", arr));
                    }

                }
            }
            return result;
        }

        public static List<String> insertionSortString(String[] arr)
        {
            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                String key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j].CompareTo(key) > 0 )
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                result.Add(String.Join(",", arr));
            }

            return result;
        }

        public List<String> heapSortString(String[] arr)
        {

            List<String> result = new List<String>();

            result.Add(String.Join(",", arr));

            int n = arr.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
                result = heapifyString(arr, n, i, result);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                String temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                result = heapifyString(arr, i, 0, result);
            }
            result.Add(String.Join(",", arr));

            return result;
        }

        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        List<String> heapifyString(String[] arr, int n, int i, List<String> list)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && arr[l].CompareTo(arr[largest])>0)
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r].CompareTo(arr[largest])>0)
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                String swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                list.Add(String.Join(",", arr));

                // Recursively heapify the affected sub-tree 
                heapifyString(arr, n, largest, list);
            }
            return list;
        }

    }
}