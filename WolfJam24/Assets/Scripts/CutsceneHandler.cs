using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutsceneHandler : MonoBehaviour
{
    public Image[] bgImages;
    public Image goodPerson;
    public Image badPerson;
    public Image sadPerson;

    int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Image i in bgImages) i.enabled = false;

        randomIndex = Random.Range(0, bgImages.Length);
        bgImages[randomIndex].enabled = true;

        sadPerson.enabled = false;

        if (GameManager.Instance.deliveredGood)
        {
            badPerson.enabled = false;
            goodPerson.enabled = true;
        }
        else
        {
            goodPerson.enabled = false;
            badPerson.enabled = true;
        }

        StartCoroutine(WaitThenChangeScene());
    }

    private IEnumerator WaitThenChangeScene()
    {
        yield return new WaitForSeconds(5f);
        GameManager.Instance.NextPackage();

        if (!GameManager.Instance.deliveredGood)
        {
            int newIndex = randomIndex;
            while (newIndex == randomIndex) newIndex = Random.Range(0, bgImages.Length);
            bgImages[randomIndex].enabled = false;
            bgImages[newIndex].enabled = true;
            badPerson.enabled = false;
            sadPerson.enabled = true;
            yield return new WaitForSeconds(2f);
        }

        SceneManager.LoadScene("InTruck");
    }
}
