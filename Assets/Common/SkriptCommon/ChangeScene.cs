using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject VideoPlayerGameObject;
    [SerializeField] private GameObject WorkPlace;
    [SerializeField] private PlayVideo PlayVideoScript;
    


    public void ChangeScenes()
    {
        if (PlayVideoScript.NameOfCaseta != null)
        {
            VideoPlayerGameObject.SetActive(!VideoPlayerGameObject.activeSelf);
            WorkPlace.SetActive(!WorkPlace.activeSelf);
        }
    }

}
