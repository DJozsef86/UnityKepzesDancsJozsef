using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LNKO : MonoBehaviour
{
    [SerializeField] int Aszam;
    [SerializeField] int Bszam;
    [SerializeField] int lnko;
    int kisebb;

    private void OnValidate()

    {

        if (Aszam < Bszam)
        {
            kisebb = Aszam;
        }
        else
        { 
            kisebb = Bszam;
        }

        for (int i = 1; i <=kisebb; i++)
        {
            if (Aszam % i == 0 && Bszam % i == 0)
            {
                lnko = i;
            }

            else {}
        }

    }
}
