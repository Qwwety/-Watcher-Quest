using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class EvidenceSpawnForCam5 : MonoBehaviour
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
        if (ProgressSlider.value >= 0.7584541 && ProgressSlider.value <= 1)
        {
            GetEvedence(0);
        }
        else
        {
            HideAllEvidence();
        }
    }


    private void GetEvedence(int IdHint)
    {
        Evidences1[IdHint].SetActive(true);
    }

    private void HideAllEvidence()
    {
        foreach (GameObject NumOfEvidence in Evidences1)
        {
            NumOfEvidence.SetActive(false);
        }
    }
}
