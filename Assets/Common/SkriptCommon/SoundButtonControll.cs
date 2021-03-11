using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundButtonControll : MonoBehaviour
{
    [SerializeField] private GameObject SoundOff;
    [SerializeField] private AudioSource AudioSource;

    public void SoundPlay()
    {
        AudioSource.volume = 0.111f;
        SoundOff.SetActive(true);
    }
    public void SoundStop()
    {
        AudioSource.volume = 0;
        SoundOff.SetActive(false);
    }
}
