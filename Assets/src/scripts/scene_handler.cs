using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_handler : MonoBehaviour
{
    public string sceneid;
    public void GoToScene()
    {
        SceneManager.LoadScene(sceneid);
    }
}
