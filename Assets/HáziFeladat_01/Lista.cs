using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{ 
    [SerializeField] string Text01;
    [SerializeField] string Text02;
    [SerializeField] string Text03;

    [Space]
    [SerializeField] string Eredmeny;

    private void OnValidate()
    {

        Eredmeny = (Text01 + ", " + Text02 + ", " + Text03 + ", ");
        Eredmeny = $"{Text01}, {Text02}, {Text03},";  //EZ IS HELYES!!!

    }
}