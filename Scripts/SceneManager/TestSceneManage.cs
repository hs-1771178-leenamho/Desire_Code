using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene("F3");
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("F2");
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene("F4");
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            SceneManager.LoadScene("Normal_Ending");
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            SceneManager.LoadScene("True_Ending");
        }

    }
}
