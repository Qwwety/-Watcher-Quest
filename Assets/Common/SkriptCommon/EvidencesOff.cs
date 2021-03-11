using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidencesOff : MonoBehaviour
{

    [SerializeField] private GameObject VideoProgress;
    public void TurnOffAllNecessaryEvidence()
    {
        VideoProgress.GetComponent<EvidenceSpawnForCam1>().enabled = false;
        VideoProgress.GetComponent<EvidenceSpawnForCam2>().enabled = false;
    }
}
