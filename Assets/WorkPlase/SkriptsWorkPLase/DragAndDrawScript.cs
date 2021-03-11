using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragAndDrawScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public PlayVideo PlayVideoScript;
    public GetEvidencesByVideo GetEvidencesByVideoScript;


    [SerializeField] private Canvas WorkPlase;
    [SerializeField] private GameObject CassetaSlot;


    private RectTransform RectangleTransform;
    private CanvasGroup CanvasGroup;


    private void Awake()
    {
        RectangleTransform = GetComponent<RectTransform>();
        CanvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
        CanvasGroup.alpha = .6f;
        CanvasGroup.blocksRaycasts = false; 
        ControlLocalScale(CanvasGroup);
        ControlCasetaName(null);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        CanvasGroup.alpha = 1f;
        CanvasGroup.blocksRaycasts = true;
        ControlLocalScale(CanvasGroup);
        ControlCasetaName(gameObject.name);
    }

    public void OnDrag(PointerEventData eventData)
    {
        RectangleTransform.anchoredPosition += eventData.delta / WorkPlase.scaleFactor;
    }

    private void ControlLocalScale(CanvasGroup CanvasGroup)
    {
        if (CanvasGroup.alpha == .6f && CassetaSlot.transform.position != transform.position)
        {
            transform.localScale = new Vector2(transform.localScale.x * 2, transform.localScale.y * 2);
        }
        else if (CanvasGroup.alpha == 1f && CassetaSlot.transform.position != transform.position)
        {
            transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        }
    }

    private void ControlCasetaName(string Name)
    {
        if (CassetaSlot.transform.position == gameObject.transform.position)
        {
            PlayVideoScript.NameOfCaseta = Name;
            GetEvidencesByVideoScript.NameOfCaseta = Name;
        }
    }
}