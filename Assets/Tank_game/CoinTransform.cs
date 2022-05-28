using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTransform : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    private void Update()
    {
        transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0), Space.World);
    }
}
