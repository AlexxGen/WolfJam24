using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

using CallerPair = System.Collections.Generic.KeyValuePair<float, System.Collections.Generic.List<Caller>>;

public class Radio : MonoBehaviour
{

    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;
    private float sliderValue;

    public Caller[] callers;
    private CallerPair[] callerList = new CallerPair[3];

    private float timer;
    [SerializeField] private AudioSource audioStatic;

    void Start()
    {
        /*for (int i = 0; i < 2; i++)
        {
            callerList[i] = new(GameManager.Instance.correctFrequencies[i], new());
        }

        foreach (Caller c in callers)
        {
            callerList[c.packageNum].Value.Add(c);
        }*/

        slider.onValueChanged.AddListener((val) =>
        {
            sliderValue = Mathf.Round(val * 10f) / 10f; 
            sliderText.text = sliderValue.ToString("0.0");
        });
    }

    private void Update()
    {
        //currently hard coded for testing
        if (sliderText.text != "106.7") { timer = 0.0f; }
        else timer += Time.deltaTime;

        if (timer > 2f) { slider.interactable = false; }
        audioStatic.volume = Mathf.Abs(sliderValue - 106.7f)/100f;

    }
}
