using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penz : MonoBehaviour
{
    [SerializeField] int Osszeg;
     int total;

    void Start()
    {
        total = Osszeg / 20000;
        Debug.Log("20.000 Ft" + total);

        Osszeg = Osszeg - (total * 20000);
        total = Osszeg / 10000;
        Debug.Log("10.000 Ft" + total);

        Osszeg = Osszeg - (total * 10000);
        total = Osszeg / 5000;
        Debug.Log("5.000 Ft" + total);

        Osszeg = Osszeg - (total * 5000);
        total = Osszeg / 2000;
        Debug.Log("2.000 Ft" + total);

        Osszeg = Osszeg - (total * 2000);
        total = Osszeg / 1000;
        Debug.Log("1.000 Ft" + total);

        Osszeg = Osszeg - (total * 1000);
        total = Osszeg / 500;
        Debug.Log("500 Ft" + total);

        Osszeg = Osszeg - (total * 500);
        total = Osszeg / 200;
        Debug.Log("200 Ft" + total);

        Osszeg = Osszeg - (total * 200);
        total = Osszeg / 100;
        Debug.Log("100 Ft" + total);

        Osszeg = Osszeg - (total * 100);
        total = Osszeg / 50;
        Debug.Log("50 Ft" + total);

        Osszeg = Osszeg - (total * 50);
        total = Osszeg / 20;
        Debug.Log("20 Ft" + total);

        Osszeg = Osszeg - (total * 20);
        total = Osszeg / 10;
        Debug.Log("10 Ft" + total);

        Osszeg = Osszeg - (total * 10);
        total = Osszeg / 5;
        Debug.Log("5 Ft" + total);

        Osszeg = Osszeg - (total * 5);
        total = Osszeg / 2;
        Debug.Log("2 Ft" + total);

        Osszeg = Osszeg - (total * 2);
        total = Osszeg / 1;
        Debug.Log("1 Ft" + total);

    }

}
