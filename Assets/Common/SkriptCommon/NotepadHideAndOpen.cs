using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotepadHideAndOpen : MonoBehaviour
{
   [SerializeField] private GameObject Notepad;

    public void HideNotepad()
    {
        Notepad.SetActive(false);
    }
    public void OpenNotepad()
    {
        Notepad.SetActive(true);
    }
}
