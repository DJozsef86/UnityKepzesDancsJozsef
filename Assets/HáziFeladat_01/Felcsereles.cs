using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felcsereles : MonoBehaviour
{

    [SerializeField] int valtozo1;
    [SerializeField] int valtozo2;


    // Update is called once per frame
    void Start()
    

    {

        // 9=9+6 (15)
        // 6=15-6 (9)
        // 15= 15-9 (6)

        valtozo1 = valtozo1 + valtozo2;
        valtozo2 = valtozo1 - valtozo2;
        valtozo1 = valtozo1 - valtozo2;

        Debug.Log(valtozo1);
        Debug.Log(valtozo2);

    }


}
