using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShowSwitch : MonoBehaviour
{
    private bool active;
    public VideoPlayer centerScreenClip;
    public VideoPlayer clusterScreenClip;
    // Start is called before the first frame update
    public void showObject()
    {
        gameObject.SetActive(true);

        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(5);

        gameObject.SetActive(false);

        centerScreenClip.Play();
        clusterScreenClip.Play();
    }

    // Update is called once per frame
   
}
