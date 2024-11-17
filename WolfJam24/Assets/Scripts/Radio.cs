using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{

    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;
    public GameObject phone;

    private float sliderValue;
    private float timer = 0;

    private float correctFrequency;
    private bool onCorrectFrequency;

    [SerializeField] private AudioSource audioStatic;
    [SerializeField] private float audioStaticDivisor;

    void Start()
    {
        onCorrectFrequency = false;
        correctFrequency = GameManager.Instance.CorrectFrequency;

        slider.onValueChanged.AddListener((val) =>
        {
            sliderValue = Mathf.Round(val * 10f) / 10f; 
            sliderText.text = sliderValue.ToString("0.0");
        });
    }

    private void CorrectFrequencySelected()
    {
        phone.SetActive(true);
    }

    private void Update()
    {
        if (!onCorrectFrequency)
        {
            print(correctFrequency);
            LockSlider(correctFrequency);
        }
    }

    private void LockSlider(float freq)
    {
        if (sliderValue != freq) { timer = 0.0f; }
        else timer += Time.deltaTime;

        if (timer > 0.5f) 
        {
            onCorrectFrequency = true;
            CorrectFrequencySelected();
            slider.interactable = false;
        }
        audioStatic.volume = Mathf.Abs(sliderValue - freq) / audioStaticDivisor;
    }
}

/*if (sliderText.text != "106.7") { timer = 0.0f; }
else timer += Time.deltaTime;

if (timer > 2f) { slider.interactable = false; }
audioStatic.volume = Mathf.Abs(sliderValue - 106.7f) / 100f;
break;*/