using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float move = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 900)
        {
            transform.Translate(transform.position.x, 700, transform.position.z);
        }
        else
        {
            transform.Translate(transform.position.x, move * Time.deltaTime, transform.position.z);
        }        
    }
}
