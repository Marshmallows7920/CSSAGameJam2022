using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour
{
    //Right = forward for the driver
    Rigidbody2D rb;  

    [SerializeField]
    float accelerationPower = 50f;
    
    [SerializeField]
    float steeringPower = 50f;

    [SerializeField]
    float driftFactor = .9f;

    float steeringAmount, speed, direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = Input.GetAxis("Vertical");
        rb.velocity = RightVelocity() + ForwardVelocity() * driftFactor;
        if (speed != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * accelerationPower * speed);
            Debug.Log(speed);
            rb.angularVelocity = (-Input.GetAxis("Horizontal") * steeringPower);
        }
    }

    //Velocity Left/right
    Vector2 ForwardVelocity()
    {
        return transform.up *(Vector2.Dot(rb.velocity, transform.up));
    }

    //Velocity forward
    Vector2 RightVelocity()
    {
        return transform.right * (Vector2.Dot(rb.velocity, transform.right));
    }
    
}
