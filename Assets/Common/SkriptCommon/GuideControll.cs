using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideControll : MonoBehaviour
{
    [SerializeField] private GameObject Guide;
    [SerializeField] private GameObject[] Guides;
    public void PlayGuideAgain()
    {
        foreach(GameObject Gud in Guides)
        {
            Gud.SetActive(true);
        }
    }
    public void GuideHide()
    {
        Guide.SetActive(false);
        
    }
}
