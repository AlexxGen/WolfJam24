using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destination : MonoBehaviour
{

    private TextMeshPro text;

    private string destName;
    private bool isCorrect = false;
    public string Name => destName;

    private void Awake()
    {
        destName = gameObject.name;
    }

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshPro>();
        text.enabled = false;
        text.text = destName;
    }

    public void SetCorrect(bool correct) 
    {
        if (correct) print(destName);
        isCorrect = correct; 
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestinationManager.Instance.deliverButton.Enable(this);
        text.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DestinationManager.Instance.deliverButton.Disable();
        text.enabled = false;
    }

    public void DeliverPackage()
    {
        print("Delivery success");
        GameManager.Instance.deliveredGood = isCorrect;
        print(GameManager.Instance.deliveredGood);
        SceneManager.LoadScene("cutScenes");
    }

    // Update is called once per frame
    void Update()
    {

    }
}