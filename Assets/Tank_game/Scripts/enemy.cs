using UnityEngine;

public class enemy : MonoBehaviour
{

    [SerializeField] Transform[] targets;
    [SerializeField] AnimationCurve speedOverDistance;


    void Update()
    {

        Vector3 targetPos = transform.position;
        Vector3 enemyPos = transform.position;

        Vector3 movement = targetPos - enemyPos;

        float distance = movement.magnitude;

        float speed = speedOverDistance.Evaluate(distance);

        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if (movement.magnitude != 0)
            transform.rotation = Quaternion.LookRotation(movement);
    }
    /*
    Vector3 ClosestTarget()
    {
        float min = float.MaxValue;
        Vector3 closest = Vector3.zero;
        Vector3 selfPosition = transform.position;

        for (int i = 0; i < targets.Length; i++)
        {
            Transform target = targets[i];
            Vector3 targetPos = target.position;
            float distance = Vector3.Distance(selfPosition, selfPosition);

            if (distance < min);
            {
                min = distance;
                closest = targetPos;
            }
        }
        return closest;
    }
    */
}
