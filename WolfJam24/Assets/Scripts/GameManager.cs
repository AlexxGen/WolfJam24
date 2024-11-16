using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public float[] correctFrequencies = new float[3];

    public bool deliveredGood = false;

    private int currentPackage = 0;

    public int CurrentPackage => currentPackage;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void NextPackage()
    {
        if (currentPackage == 2)
        {
            // Ending scene
        }
        else currentPackage++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
