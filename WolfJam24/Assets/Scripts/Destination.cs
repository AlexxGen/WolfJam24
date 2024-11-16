using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{

    private string destName;
    private bool isCorrect = false;
    private bool inside = false;
    public string Name => destName;

    private void Awake()
    {
        destName = gameObject.name;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetCorrect(bool correct) {  isCorrect = correct; } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Delivery stuff
        print("Now arriving at " + destName);   
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        inside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
    }

    public void DeliverPackage()
    {
        if (isCorrect) print("You did it!");
        else print("You failed");
    }

    // Update is called once per frame
    void Update()
    {
        if (inside && Input.GetKeyDown(KeyCode.E))
        {
            DeliverPackage();
        }
    }
}