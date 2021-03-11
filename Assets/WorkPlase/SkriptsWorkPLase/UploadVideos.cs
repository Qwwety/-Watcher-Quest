using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
public class UploadVideos : MonoBehaviour, IEndDragHandler
{
    public string NumberOfCaseta;


    [SerializeField] private VideoClip[] VideoClips;

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
