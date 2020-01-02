using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock_time : MonoBehaviour
{

    // Start is called before the first frame update
    public Text TxtTime;

    private string time;

    // Update is called once per frame
    void Update()
    {
        time = System.DateTime.Now.ToString("hh:mm");

        TxtTime.text = time;
    }
}
