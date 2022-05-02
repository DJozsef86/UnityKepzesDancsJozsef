using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felcsereles : MonoBehaviour
{

    [SerializeField] int valtozo1; //2 a
    [SerializeField] int valtozo2; //3 b
    [Space]
    [SerializeField] int eredmeny1;
    [SerializeField] int eredmeny2;


    // Update is called once per frame

    private void OnValidate()

    

    {

        // a=2+3 a=5
        // b=5-3 b=2
        // a = 5-2 b=3

        valtozo1 = valtozo1 + valtozo2;
        valtozo2 = valtozo1 - valtozo2;
        valtozo1 = valtozo1 - valtozo2;

        eredmeny1 = valtozo1;
        eredmeny2 = valtozo2;


    }


}
