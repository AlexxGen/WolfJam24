using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationManager : MonoBehaviour
{

    private Destination[] destinations;

    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Destination>();
        SetNewDestination("New York");
    }

    public void SetNewDestination(string nameOfCorrectDestination) 
    {
        bool found = false;
        foreach (Destination dest in destinations)
        {
            if (!found && dest.Name.Equals(nameOfCorrectDestination))
            {
                dest.SetCorrect(true);
                found = true;
            }
            else dest.SetCorrect(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
