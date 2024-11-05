using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSortInsertion : MonoBehaviour
{
    List<int> numberList = new List<int> { 10, 7, 4, 5, 8, 9, 3, 1, 0 };
    void Start()
    {
        Debug.Log("Original List: " + ListToString(numberList));

        InsertionSortList(numberList);

        Debug.Log("Sorted List: " + ListToString(numberList));

        string ListToString(List<int> list)
        {
            return string.Join(", ", list);
        }
        void InsertionSortList(List<int> list)
        {
            int n = list.Count;
            for (int i = 1; i < n; i++)
            {
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }
    }
}
