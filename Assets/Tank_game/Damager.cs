using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{

    [SerializeField] int damage = 1;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} <--> {other.name}");

        Damagable damagable = other.GetComponent<Damagable>();
        if (damagable != null)
        {
            damagable.DoDamage(damage);
        }
    }
}
