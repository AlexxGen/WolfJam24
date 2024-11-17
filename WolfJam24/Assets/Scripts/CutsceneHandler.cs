using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutsceneHandler : MonoBehaviour
{
    public GameObject[] bgImages;
    public GameObject goodPerson;
    public GameObject badPerson;
    public GameObject sadPerson;

    int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject i in bgImages) i.SetActive(false);

        randomIndex = Random.Range(0, bgImages.Length);
        bgImages[randomIndex].SetActive(true);

        sadPerson.SetActive(false);

        if (GameManager.Instance.deliveredGood)
        {
            badPerson.SetActive(false);
            goodPerson.SetActive(true);
        }
        else
        {
            goodPerson.SetActive(false);
            badPerson.SetActive(true);
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
            bgImages[randomIndex].SetActive(false);
            bgImages[newIndex].SetActive(true);
            badPerson.SetActive(false);
            sadPerson.SetActive(true);
            yield return new WaitForSeconds(2f);
        }

        SceneManager.LoadScene("InTruck");
    }
}
