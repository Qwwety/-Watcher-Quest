using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuiteGame()
    {
        Application.Quit();
    }
}
