using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFolder : MonoBehaviour
{
    [SerializeField] private GameObject Folder;
    [SerializeField] private GameObject ButtonsForChoseCharacters;

    public void ShowFolder ()
    {
        Folder.SetActive(true);
    }

    public void CloseFolder()
    {
        ButtonsForChoseCharacters.SetActive(false);
        Folder.SetActive(false);
    }
}
