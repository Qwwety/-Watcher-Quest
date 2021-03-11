using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundControll : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSource;
    [SerializeField] private Slider VolumeSlider;
    [SerializeField] private Text CurrentSpeed;

    void Update()
    {
        VolumeControll();
    }

    public void VolumeControll()
    {
        AudioSource.volume = VolumeSlider.value;
        CurrentSpeed.text = VolumeSlider.value.ToString();
    }
}
