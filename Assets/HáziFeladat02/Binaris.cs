using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binaris : MonoBehaviour
{

    [SerializeField] int szam;
    [SerializeField] string eredmeny;
    string maradek;
    private void OnValidate()
    {

        while (szam > 0) ;
        {
            maradek = szam % 2;
            szam = szam / 2;

        }

        eredmeny = maradek.ToString;
    }
}
