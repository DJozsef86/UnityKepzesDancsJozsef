using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LKKT : MonoBehaviour
{
    [SerializeField] int Aszam;
    [SerializeField] int Bszam;
    [SerializeField] int lkkt;
    int kisebb;
    int lnko;

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

        for (int i = 1; i <= kisebb; i++)
        {
            if (Aszam % i == 0 && Bszam % i == 0)
            {
                lnko = i;
            }

            else { }
        }

        lkkt = ((Aszam * Bszam) / lnko);

    }
}
