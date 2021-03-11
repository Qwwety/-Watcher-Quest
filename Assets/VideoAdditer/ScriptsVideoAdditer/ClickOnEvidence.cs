using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnEvidence : MonoBehaviour
{
    [SerializeField] private GameObject Hint;

    public void GetHint()
    {
        Hint.SetActive(true);
    }
}
