using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TruckController : MonoBehaviour
{

    // Constants
    public float speed;
    public float turnSpeed;

    // Components
    private Rigidbody2D rb;

   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int movement = 0;

        if (Input.GetKey(KeyCode.W))
        {
            movement++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement--;
        }
        if (movement != 0)
        {
            rb.velocity = movement * speed * transform.up;
        }
        else rb.angularVelocity = 0;

        int angular = 0;

        if (Input.GetKey(KeyCode.D))
        {
            angular--;
        }
        if (Input.GetKey(KeyCode.A))
        {
            angular++;
        }
        rb.angularVelocity = angular * turnSpeed;
    }
}
