using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEvidencesByVideo : MonoBehaviour
{
    public string NameOfCaseta;
    public GameObject VideoProgress;

    public void SetActivetNecessaryEvidenceSkript()
    {
        switch (NameOfCaseta)
        {
            case "Cam1":
                VideoProgress.GetComponent<EvidenceSpawnForCam1>().enabled = true;
                break;
            case "Cam2":
                VideoProgress.GetComponent<EvidenceSpawnForCam2>().enabled = true;
                break;
            case "Cam5":
                VideoProgress.GetComponent<EvidenceSpawnForCam5>().enabled = true;
                break;
        }
    }
}
