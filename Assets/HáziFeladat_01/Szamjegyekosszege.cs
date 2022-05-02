using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Szamjegyekosszege : MonoBehaviour
{

    
    [SerializeField] int szam;
    [SerializeField] int eredmeny;
    int maradek;


    private void OnValidate()

    {

        for (eredmeny = 0; szam > 0; szam = szam / 10)
        {

            maradek = szam % 10;
            eredmeny = eredmeny + maradek;

        }



    }

}
