using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockable : MonoBehaviour
{
    [SerializeField] MonoBehaviour blockedSript;
    [SerializeField] Collider blockedCollider;

    float unBlockingTime;
    bool isBlocked;

    public void Block(float blockingTime)
    {
        SetEnable(false);
        this.unBlockingTime = Time.time + blockingTime;
        isBlocked = true;

        Debug.Log("sasasa");
    }
    void SetEnable(bool enable)
    {
        blockedSript.enabled = enable;
        blockedCollider.enabled = enable;
    }

    void Update()
    {
        if (isBlocked)
            if (Time.time >= unBlockingTime)
            {
                SetEnable(true);
                isBlocked = false;
            }
    }
}
