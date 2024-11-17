using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{

    public static Radio Instance;

    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;
    public GameObject phone;

    private float sliderValue;
    private float timer = 0;

    private float correctFrequency;
    private bool onCorrectFrequency;

    [SerializeField] private AudioSource audioStatic;
    [SerializeField] private float audioStaticDivisor;
    [SerializeField] private AudioSource audioPhone;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        onCorrectFrequency = false;
        correctFrequency = GameManager.Instance.CorrectFrequency;

        slider.onValueChanged.AddListener((val) =>
        {
            sliderValue = Mathf.Round(val * 10f) / 10f; 
            sliderText.text = sliderValue.ToString("0.0");
        });
        sliderValue = slider.minValue;
        audioStatic.volume = Mathf.Abs(sliderValue - correctFrequency) / audioStaticDivisor;
    }

    private void CorrectFrequencySelected()
    {
        phone.SetActive(true);
    }

    private void Update()
    {
        if (!onCorrectFrequency)
        {
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
            audioPhone.Play();
        }
        audioStatic.volume = Mathf.Abs(sliderValue - freq) / audioStaticDivisor;
    }

    public void ToggleAudio(bool on)
    {
        if (on) audioStatic.Play();
        else audioStatic.Stop();
    }
}