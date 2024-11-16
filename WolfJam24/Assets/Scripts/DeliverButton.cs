using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverButton : MonoBehaviour
{

    public float yOffset;

    private SpriteRenderer sp;
    private bool isEnabled = false;
    private Destination destination;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    public void Enable(Destination dest)
    {
        transform.position = dest.transform.position;
        transform.position += new Vector3(0, yOffset);

        sp.enabled = true;
        isEnabled = true;
        destination = dest;
    }

    private void OnMouseDown()
    {
        if (isEnabled)
        {
            destination.DeliverPackage();
        }
    }

    public void Disable()
    {
        sp.enabled = false;
        isEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
