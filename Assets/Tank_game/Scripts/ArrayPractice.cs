using System.Collections;
using UnityEngine;


public class ArrayPractice : MonoBehaviour

{
    /*
    [SerializeField] float input1;
    [SerializeField] float input2;
    [SerializeField] float input3;
    [SerializeField] float input4;
    */
    [SerializeField] float[] input;
    [SerializeField] string[] stringArray;
    [SerializeField] KeyCode[] keyCodeArray;
    [SerializeField] Transform[] transforms;
    [SerializeField] Vector3 mainPosition;

    [SerializeField] float mean;
    void OnValidate()
    {
        //mean = (input1 + input2 + input3 + input4) / 4f;


        // int lenght = input.Length; //hossz lekérdezés

        if (input.Length != 0)
        {
            float first = input[0];
            float last = input[input.Length - 1];
        }

        float summa = 0;

        for (int i = 0; i < input.Length; i++)
        {
            summa += input[i];
        }
        mean = summa / input.Length;



        Vector3 summaPosition = Vector3.zero;
        int nonNullElementCount = 0;

        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] != null)
            {
                summaPosition += transforms[i].position;
                nonNullElementCount++;
            }

        }
        mainPosition = summaPosition / nonNullElementCount;


    }


}
