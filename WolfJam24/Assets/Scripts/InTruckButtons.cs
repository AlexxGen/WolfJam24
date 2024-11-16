using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InTruckButtons : MonoBehaviour
{
    public GameObject[] envelopes;

    public void envelope1_b()
    {
        Debug.Log(envelopes[0].name); 
        envelopes[1].SetActive(true);
        envelopes[0].SetActive(false);
    }

    public void envelope1_2_b()
    {
        envelopes[1].SetActive(false);
        envelopes[2].SetActive(true);
    }

    public void letter1_b()
    {
        envelopes[2].SetActive(false);
        envelopes[0].SetActive(true);
    }

    public void envelope2_b()
    {
        envelopes[3].SetActive(false);
        envelopes[4].SetActive(true);
    }

    public void envelope2_2_b()
    {
        envelopes[4].SetActive(false);
        envelopes[5].SetActive(true);
    }

    public void letter2_b()
    {
        envelopes[5].SetActive(false);
        envelopes[3].SetActive(true);
    }

    public void envelope3_b()
    {
        envelopes[6].SetActive(false);
        envelopes[7].SetActive(true);
    }

    public void envelope3_2_b()
    {
        envelopes[7].SetActive(false);
        envelopes[8].SetActive(true);
    }

    public void letter3_b()
    {
        envelopes[8].SetActive(false);
        envelopes[6].SetActive(true);
    }
}
