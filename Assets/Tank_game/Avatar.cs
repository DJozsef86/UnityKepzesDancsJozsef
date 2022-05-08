
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float AngularSpeed =360;

    void Update()

    {
        bool right = Input.GetKey(KeyCode.RightArrow);          // x jobbra balra
        bool left = Input.GetKey(KeyCode.LeftArrow);
        float xMovement = (right ? 1 : 0) + (left ? -1 : 0);

        bool up = Input.GetKey(KeyCode.UpArrow);                //z elõre hátra
        bool down = Input.GetKey(KeyCode.DownArrow);
        float zMovement = (up ? 1 : 0) + (down ? -1 : 0);

        Vector3 movement = new Vector3(xMovement, 0, zMovement);
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement; // transform.Tranlate(movement, Space.World);

        if(movement.magnitude != 0) //forgás a mozgással
        { 
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRotation = transform.rotation;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, AngularSpeed * Time.deltaTime);
        }
    }

    float ToNumb(bool positive, bool negative)
    {
        float positiveValue = positive ? 1 : 0;
        float negativeValue = negative ? 1 : 0;

        return positiveValue + negativeValue;
    }

}
