using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyakorlas : MonoBehaviour
{

    [SerializeField] int num;
    [SerializeField] int count;

    // Update is called once per frame
    void Start()
    {
        count = 0;
        for (int i = 1; i<num; i++)
        {
            if (num % 3 == 0)
                count++;
        }
    }
}
