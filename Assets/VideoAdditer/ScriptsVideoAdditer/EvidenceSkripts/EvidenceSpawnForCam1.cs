using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class EvidenceSpawnForCam1: MonoBehaviour
{ 
   [SerializeField] private GameObject[] Evidences1;

    private Slider ProgressSlider;


    private void Start()
    {
        ProgressSlider = GetComponent<Slider>();
    }

    private void FixedUpdate()
    {
        MakeEvedenceVisible(ProgressSlider);
    }

    private void MakeEvedenceVisible(Slider ProgressSlider)
    {
        if (ProgressSlider.value >= 0.647343f  && ProgressSlider.value <= 1)
        {
            GetEvedence(0);
            GetEvedence(1);
        }
    }

    private void GetEvedence(int IdHint)
    {
        Evidences1[IdHint].SetActive(true);
    }
    
}
