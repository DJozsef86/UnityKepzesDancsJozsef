using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binaris : MonoBehaviour
{
    [SerializeField] int numb;
    [SerializeField] string binary;
    int i;

    private void OnValidate()
    {
        
        while (numb > 0) 
        {

            i = numb % 2;
            numb /= 2;
            binary =i.ToString() + binary;
        
        }


    }

}
