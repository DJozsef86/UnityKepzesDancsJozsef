using UnityEngine;

public class Vector_test : MonoBehaviour
{
    [SerializeField] Vector3 v3a;
    [SerializeField] Vector3 v3b;
    [SerializeField] float multiplier = 1;

    [Space]
    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 multiplid;
    [SerializeField] float lenght;
    [SerializeField] Vector3 normal;

    void OnValidate()
    {

        summa = v3a + v3b;
        multiplid = summa * multiplier;
        lenght = multiplid.magnitude; // hossz  
        normal = multiplid.normalized; // normalizált érték

    }
}