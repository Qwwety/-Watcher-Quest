using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class EvidenceSpawnForCam2 : MonoBehaviour
{
    [SerializeField] private GameObject[] Evidences2;

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
        if (ProgressSlider.value >= 0 && ProgressSlider.value <= 0.3855073f)
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
        Evidences2[IdHint].SetActive(true);
    }


    private void HideAllEvidence()
    {
        foreach (GameObject NumOfEvidence in Evidences2)
        {
            NumOfEvidence.SetActive(false);
        }
    }
}

