using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterSzamolo : MonoBehaviour
{
    [SerializeField] string Text;
    [SerializeField] int Charater;

    private void OnValidate()
    {

        Charater = Text.Length;
    }
}
