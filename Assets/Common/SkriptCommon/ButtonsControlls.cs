using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControlls : MonoBehaviour
{
    [SerializeField] private GameObject[] VideoControllsButtons;
    public void ButtonsControll()
    {
        VideoControllsButtons[0].SetActive(false);
        VideoControllsButtons[1].SetActive(true);
    }
}
