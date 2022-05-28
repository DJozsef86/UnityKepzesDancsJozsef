using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuggvenyek : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;


    void OnValidate()
    {
        // MathF.clamp
        float value, min, max;

        if (value < min)
            value = min;
        if (value > max)
            value = max;
        return value;


        // Mathf.Lerp
        float a, b, c, eredmeny;

        eredmeny = a + (b - a) * c;
    }
}
}
