using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{

    private string destName;

    // Start is called before the first frame update
    void Start()
    {
        destName = gameObject.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Delivery stuff
            print("Now arriving at " + destName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}