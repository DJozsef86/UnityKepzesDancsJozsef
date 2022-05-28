using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binaris : MonoBehaviour
{
    [SerializeField] int szam;
    [SerializeField] string eredmeny;
    int i;

    private void OnValidate()
    {
        
        while (szam > 0) 
        {

            i = szam % 2;
            szam /= 2;
            eredmeny =i.ToString() + eredmeny;
        
        }


    }

}
