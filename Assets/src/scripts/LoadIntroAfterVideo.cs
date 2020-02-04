using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadIntroAfterVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public Transform Introduction;
    public Transform achivment;
    public Transform markerfound;
    public Transform marker;
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += LoadIntro;
    }

    // Update is called once per frame
    void LoadIntro(VideoPlayer vp)
    {
        Introduction.gameObject.SetActive(true);
        achivment.gameObject.SetActive(false);
        markerfound.gameObject.SetActive(false);
        marker.gameObject.SetActive(false);
    }
}
