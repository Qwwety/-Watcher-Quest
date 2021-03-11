using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyForVerdict : MonoBehaviour
{ 
    [SerializeField] private GameObject[] Hints;
    [SerializeField] private GameObject GoToVerdictButton;

    public void CheckHints()
    {
        if (Hints[0].activeSelf==true && Hints[1].activeSelf == true && Hints[2].activeSelf == true && Hints[3].activeSelf == true)
        {
            PreparedToVerdict();
        }
    }

    private void PreparedToVerdict()
    {
        GoToVerdictButton.SetActive(true);
    }
}
