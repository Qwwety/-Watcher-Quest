using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class ControllVideoScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool IsSliderwork = false;


    private Slider ProgressSlider;


    [SerializeField] private VideoPlayer VideoPlayer;
    [SerializeField] private GameObject PauseBatton;



    private void Start()
    {
        ProgressSlider = GetComponent<Slider>();
    }

    private void FixedUpdate()
    {
        if (VideoPlayer.frameCount > 0)
        {
            if (IsSliderwork==true)
            {
                ProgressSlider.value = (float)VideoPlayer.frame / (float)VideoPlayer.frameCount;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        IsSliderwork = false;
        VideoPlayer.Pause();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        float Frame = (float)ProgressSlider.value * (float)VideoPlayer.frameCount;
        VideoPlayer.frame = (long)Frame;
        IsSliderwork = true;
        if (PauseBatton.activeSelf==true)
        {
            VideoPlayer.Play();
        }
    }

}
