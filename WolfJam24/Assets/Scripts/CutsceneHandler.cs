using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneHandler : MonoBehaviour
{

    public float cutsceneLength;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitThenChangeScene());
    }

    private IEnumerator WaitThenChangeScene()
    {
        yield return new WaitForSeconds(cutsceneLength);
        GameManager.Instance.NextPackage();
        SceneManager.LoadScene("InTruck");
    }
}
