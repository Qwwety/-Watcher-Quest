using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideEvidences : MonoBehaviour
{
    [SerializeField] private GameObject[] Evidences;
    public void HideAllEvidences()
    {
        foreach(GameObject eved in Evidences)
        {
            eved.SetActive(false);
        }
    }
}
