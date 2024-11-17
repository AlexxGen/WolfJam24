using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationManager : MonoBehaviour
{
    public static DestinationManager Instance;

    public DeliverButton deliverButton;

    private Destination[] destinations;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Destination>();
        switch(GameManager.Instance.CurrentPackage) 
        {
            case 0:
                SetNewDestination("Gaiyea");
                break;

            case 1:
                SetNewDestination("Limeleaf");
                break;

            case 2:
                SetNewDestination("Ritny");
                break;
        }
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
