using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnVerdictButtons : MonoBehaviour
{
    [SerializeField] private GameObject SelectedBoxe;
    [SerializeField] private GameObject ButtOnAsseptVerdict;
    [SerializeField] private GameObject[] SelectedBoxesArray;
 
    public void TornOnGreenBox()
    {
        SelectedBoxe.SetActive(!SelectedBoxe.activeSelf);
        ChekForVerdict();
    }

    private void ChekForVerdict()
    {
        if (SelectedBoxesArray[0].activeSelf==true || SelectedBoxesArray[1].activeSelf == true || SelectedBoxesArray[2].activeSelf == true || SelectedBoxesArray[3].activeSelf == true || SelectedBoxesArray[4].activeSelf == true )
        {
            ButtOnAsseptVerdict.SetActive(true);
        }
        else
        {
            ButtOnAsseptVerdict.SetActive(false);
        }
    }
}
