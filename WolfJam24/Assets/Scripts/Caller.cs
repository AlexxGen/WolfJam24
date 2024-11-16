using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caller : MonoBehaviour
{

    public int packageNum;
    private float frequency;

    // Start is called before the first frame update
    void Start()
    {
        frequency = GameManager.Instance.correctFrequencies[packageNum];
    }

    public bool CanCall(float radioFrequency)
    {
        return packageNum == GameManager.Instance.CurrentPackage && frequency == radioFrequency;
    }

    public void Call()
    {

    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
