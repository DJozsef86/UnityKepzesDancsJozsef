
using System;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Damagable damagable;
    [SerializeField] Space movemantSpace = Space.World;

    [SerializeField] GameObject projectilePrototype;
    [SerializeField] GameObject projectileStartPosition;

    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode jumpKey;


    private void Update()
    {
        if(damagable.health > 0)
        {
            Move();
            TryShoot();
        }

    }

    private void TryShoot()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectileStartPosition.transform.position;
            p.Shoot(forward);
        }
    }

    void Move()

    {
        bool right = Input.GetKey(rightKey);          // x jobbra balra
        bool left = Input.GetKey(leftKey);
        float xMovement = (right ? 1 : 0) + (left ? -1 : 0);

        bool up = Input.GetKey(upKey);                //z elõre hátra
        bool down = Input.GetKey(downKey);
        float zMovement = (up ? 1 : 0) + (down ? -1 : 0);

        Vector3 movement = new Vector3(xMovement, 0, zMovement);

        if (movemantSpace == Space.Self)
            movement = transform.TransformVector(movement);

        transform.TransformVector(movement);
        movement.y = 0;
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement; // transform.Tranlate(movement, Space.World);

        if(movement.magnitude != 0) //forgás a mozgással
        { 
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRotation = transform.rotation;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angularSpeed * Time.deltaTime);
        }
    }



    float ToNumb(bool positive, bool negative)
    {
        float positiveValue = positive ? 1 : 0;
        float negativeValue = negative ? 1 : 0;

        return positiveValue + negativeValue;
    }


    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }


}
