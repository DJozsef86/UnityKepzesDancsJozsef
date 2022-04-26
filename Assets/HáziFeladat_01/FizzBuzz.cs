using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{

    [SerializeField] int NUMB;

    void Start()
    {
        for (int i = 1; i <= NUMB; i++)

        {
            if (i % 3 == 0 && i % 5 == 0)
                Debug.Log("fizzbuzz");

            else if (i % 3 == 0)
                Debug.Log("fizz");

            else if (i % 5 == 0)
                Debug.Log("buzz");

            else
                Debug.Log(i);
            
            //Ez jó nehéz volt ám;
        }
    }

}
