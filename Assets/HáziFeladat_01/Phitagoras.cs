using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phitagoras : MonoBehaviour
{

    [SerializeField] int A;
    [SerializeField] int B;
    [SerializeField] int C;

    [Space]
    [SerializeField] bool Phit;

    void OnValidate()


    {

        bool egyenlet = (A*A)+(B*B) == C*C;

        Phit = egyenlet;
    }
}
