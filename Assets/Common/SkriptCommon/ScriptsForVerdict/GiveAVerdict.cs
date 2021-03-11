using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAVerdict : MonoBehaviour
{
    [SerializeField] private GameObject[] SelectedBoxesArray;
    [SerializeField] private GameObject WinScreen;
    [SerializeField] private GameObject LoseScreen;

    public void GiveVerdict()
    {
        if (SelectedBoxesArray[0].activeSelf == true && SelectedBoxesArray[1].activeSelf == true && SelectedBoxesArray[4].activeSelf == true && SelectedBoxesArray[3].activeSelf == false && SelectedBoxesArray[2].activeSelf == false)
        {
            WinScreen.SetActive(true);
        }
        else
        {
            LoseScreen.SetActive(true);
        }
    }
}
