using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenButtons : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject creditsPanel;
    public AudioMixer mixer;
    public Slider master;
    public Slider music;
    public Slider sfx;

    public void Start()
    {
        master.value = 0.5f;
        music.value = 0.5f;
        sfx.value = 0.5f;
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        settingsPanel.SetActive(true);
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void BackSettings()
    {
        settingsPanel.SetActive(false);
    }

    public void BackCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void masterVolume()
    {
        Debug.Log(master.value);
        mixer.SetFloat("Master", (master.value * 10)-10);
    }

    public void musicVolume()
    {
        mixer.SetFloat("Bgm", (music.value * 10)-10);
    }

    public void SfxVolume()
    {
        mixer.SetFloat("SFX", (sfx.value * 10)-10);
    }


}
