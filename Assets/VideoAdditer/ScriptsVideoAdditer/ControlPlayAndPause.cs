using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayAndPause : MonoBehaviour
{
    [SerializeField] private GameObject PlayButton;
    [SerializeField] private GameObject PauseButton;

    public void SwithPlayAndPauseButtons()
    {
        PlayButton.SetActive(!PlayButton.activeSelf);
        PauseButton.SetActive(!PauseButton.activeSelf);
    }
}
