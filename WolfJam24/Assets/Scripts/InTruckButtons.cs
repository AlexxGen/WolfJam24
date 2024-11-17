using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InTruckButtons : MonoBehaviour
{
    public GameObject[] envelopes;
    public GameManager manager;
    public GameObject settingsPanel;
    public GameObject radio;
    public GameObject clipBoard;
    public GameObject clipBoard_1;


    [SerializeField] private AudioSource[] envelopeNoises;

    public void Start()
    {
        for(int i = 0;  i < envelopes.Length; i++)
        {
            envelopes[i].SetActive(false);
        }

        if(manager.CurrentPackage == 0)
        {
            envelopes[0].SetActive(true);
        } else if (manager.CurrentPackage == 1)
        {
            envelopes[3].SetActive(true);
        } else if(manager.CurrentPackage == 2)
        {
            envelopes[6].SetActive(true);
        }
    }

    public void envelope1_b()
    {
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

    public void settingsOn()
    {
        settingsPanel.SetActive(true);
    }
    public void settingsOff()
    {
        settingsPanel.SetActive(false);
    }

    public void clipBoardOn()
    {
        clipBoard_1.SetActive(true);
        clipBoard.SetActive(false);
    }

    public void clipBoardOff()
    {
        clipBoard.SetActive(true);
        clipBoard_1.SetActive(false);
    }

    public void radioToggle()
    {
        if(radio.activeSelf == true)
        {
            radio.SetActive(false);
        }
        else
        {
            radio.SetActive(true);
        }
    }
    public void quit()
    {
        SceneManager.LoadScene(0);
    }

}
