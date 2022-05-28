using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charater : MonoBehaviour
{
    [Range(0, 50)] [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField] float AngularSpeed = 360;


    private void Update()

    {

        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        float xMovement = (right ? 1 : 0) + (left ? -1 : 0);


        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        float zMovement = (up ? 1 : 0) + (down ? -1 : 0);

        bool jump = Input.GetKey(KeyCode.Space);
        float yMovement = (jump ? 1 : 0);

        Vector3 movement = new Vector3(xMovement, yMovement, zMovement);

        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if (movement.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRotation = transform.rotation;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, AngularSpeed * Time.deltaTime);
        }
    }

}
