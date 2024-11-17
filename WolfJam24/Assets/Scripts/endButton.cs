using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endButton : MonoBehaviour
{
    public void quit()
    {
        SceneManager.LoadScene(0);
    }
}
