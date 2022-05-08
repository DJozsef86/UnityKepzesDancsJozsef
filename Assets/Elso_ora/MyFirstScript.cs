using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [Header("Kalkulátor")] 
    [SerializeField] int input1;
    [SerializeField] int input2;

    [Space]
    [SerializeField] float summa;
    [SerializeField] float kulonbseg;
    [SerializeField] float szorzat;

    [Space]
    [Header("Mean")]
    [SerializeField] int a = 1;
    [SerializeField] int b = 1;
    [SerializeField] int c = 1;

    [Space]
    [SerializeField] float atlag;

    [Space]
    [Header("Kör")]
    [SerializeField] float radius;
    [Space]
    [SerializeField] float kerulet;
    [SerializeField] float terulet;




    private void OnValidate()
    {

        kerulet = 2 * radius * Mathf.PI;
        terulet = (radius * radius) * Mathf.PI;

    }
}

  

