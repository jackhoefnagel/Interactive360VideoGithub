using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ObjectSwitchVideo : MonoBehaviour
{
    public VideoPlayer targetVideoPlayer;
    public VideoClip targetVideoClip;

    public void SwitchVideoClip()
    {
        targetVideoPlayer.clip = targetVideoClip;
    }
}
