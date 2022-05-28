using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;

    [SerializeField] Bounds teleport;


    public void Collect()
    {
        float randX = Random.Range(teleport.min.x, teleport.max.x);
        float randY = Random.Range(teleport.min.y, teleport.max.y);
        float randZ = Random.Range(teleport.min.z, teleport.max.z);

        transform.position = new Vector3(randX, randY, randZ);
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(teleport.center, teleport.size);
    }

}
