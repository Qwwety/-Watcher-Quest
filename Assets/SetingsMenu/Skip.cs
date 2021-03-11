using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour
{
    [SerializeField] private GameObject BG;

    public void SkipIt()
    {
        BG.SetActive(false);
    }
}
