using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverButton : MonoBehaviour
{
    public float xOffset;
    public float yOffset;

    private SpriteRenderer sp;
    private Transform[] children;
    private bool isEnabled = false;
    private Destination destination;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        children = GetComponentsInChildren<Transform>();
        Disable();
    }

    public void Enable(Destination dest)
    {
        transform.position = dest.transform.position;
        transform.position += new Vector3(xOffset, yOffset);

        sp.enabled = true;
        isEnabled = true;
        destination = dest;

        foreach (Transform t in children)
        {
            t.gameObject.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (isEnabled)
        {
            print("Deliver");
            destination.DeliverPackage();
        }
    }

    public void Disable()
    {
        sp.enabled = false;
        isEnabled = false;

        foreach (Transform t in children)
        {
            t.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
