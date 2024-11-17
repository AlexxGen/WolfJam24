using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutsceneHandler : MonoBehaviour
{
    public Image[] goodImages;
    public Image[] badImages; 
    public float cutsceneLength;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < goodImages.Length; i++)
        {
            goodImages[i].enabled = false;
            badImages[i].enabled = false;
        }

        if (GameManager.Instance.deliveredGood) goodImages[GameManager.Instance.CurrentPackage].enabled = true;
        else badImages[GameManager.Instance.CurrentPackage].enabled = true;
        StartCoroutine(WaitThenChangeScene());
    }

    private IEnumerator WaitThenChangeScene()
    {
        yield return new WaitForSeconds(cutsceneLength);
        GameManager.Instance.NextPackage();
        SceneManager.LoadScene("InTruck");
    }
}
