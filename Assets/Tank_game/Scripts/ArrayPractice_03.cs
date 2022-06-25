using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice_03 : MonoBehaviour
{
    [SerializeField] float[] inputArray;
    [SerializeField] float summa;

    void OnValidate()
    {
        summa = 0;
        foreach (float item in inputArray) //minden elemen végigmegy for ciklus egyszerû formája
        {
            summa += item;
        }
        //Stringek
        string st = "Bear";
        char[] charArray = st.ToCharArray();
        charArray[2] = 'e';
        string newSt = new string(charArray);


    }


}
