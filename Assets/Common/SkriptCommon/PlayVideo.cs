using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public string NameOfCaseta;

    [SerializeField] private VideoClip[] VideoClips;
    [SerializeField] private VideoPlayer VideoPlayer;

    public void PlayCurrentVideo() 
    {
        switch (NameOfCaseta)
        {
            case "Cam1":
                FindClip(0);
                break;
            case "Cam2":
                FindClip(1);
                break;
            case "Cam3":
                FindClip(2);
                break;
            case "Cam4":
                FindClip(3);
                break;
            case "Cam5":
                FindClip(4);
                break;
            case "Cam6":
                FindClip(5);
                break;
        }
    }

    private void FindClip(int ClipId)
    {
        VideoPlayer.clip= VideoClips[ClipId];
    }
}
