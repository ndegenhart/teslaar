using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadIntro : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public Transform Introduction;
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += LoadIntroduction;
    }

    // Update is called once per frame
    void LoadIntroduction(VideoPlayer vp)
    {
        Introduction.gameObject.SetActive(true);
    }
}
