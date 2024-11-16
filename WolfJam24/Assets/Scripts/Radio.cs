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

    public Caller[] callers;
    private CallerPair[] callerList = new CallerPair[3];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            callerList[i] = new(GameManager.Instance.correctFrequencies[i], new());
        }

        foreach (Caller c in callers)
        {
            callerList[c.packageNum].Value.Add(c);
        }

        slider.onValueChanged.AddListener((val) =>
        {
            val = Mathf.Round(val * 10) / 10;
            sliderText.text = val.ToString();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
