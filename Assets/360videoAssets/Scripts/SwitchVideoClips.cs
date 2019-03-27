using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SwitchVideoClips : MonoBehaviour
{
    public VideoPlayer vidPlayer;

    public List<VideoClip> videoList;

    private int videoListIndex = 0;

    public void NextVideoClip() {

        videoListIndex++;
        if(videoListIndex > (videoList.Count-1))
        {
            videoListIndex = 0;
        }

        vidPlayer.clip = videoList[videoListIndex];
    }


}
