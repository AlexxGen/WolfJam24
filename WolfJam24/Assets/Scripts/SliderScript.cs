using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            v = Mathf.Round(v * 10);
            sliderText.text = (v / 10).ToString();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
