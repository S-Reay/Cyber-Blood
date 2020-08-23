using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debug_Controls : MonoBehaviour
{
    private bool slowMo = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            if (slowMo)
            {
                Time.timeScale = 1;
                slowMo = false;
            }
            else
            {
                Time.timeScale = 0.1f;
                slowMo = true;
            }
        }
    }
}
