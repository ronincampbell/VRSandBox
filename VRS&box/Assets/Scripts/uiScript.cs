using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiScript : MonoBehaviour
{
    public GameObject open;
    public GameObject close;
    public void quit()
    {
        // quit application on call of function | Debug to show in edditor
        Debug.Log("Quitting application...");
        Application.Quit();
        
    }

    public void openmenu()
    {
        // open info menu on call of function
        open.SetActive(true);
        close.SetActive(false);
    }

    public void play()
    {
        // call scene manager and open main scene when play button pressed
        SceneManager.LoadScene("VR_1");
    }
}
