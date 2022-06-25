using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice_02 : MonoBehaviour
{
    private void OnValidate()
    {
        int[] array = { 2, 5, 7 };
        int[] array2 = { 2, 5, 7 };

        int[] array3 = array2;
        array[1] = 9;
        array3[1] = 4;

        Debug.Log(array[1] + array2[1]);

        //14
    }
}

