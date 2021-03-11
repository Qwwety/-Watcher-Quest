using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerdictButtons : MonoBehaviour
{
    [SerializeField] private GameObject ButtonsForChoseCharacters;

    public void GoToVerdictMode()
    {
        ButtonsForChoseCharacters.SetActive(true);
    }
}
