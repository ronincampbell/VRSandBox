using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitCube : MonoBehaviour
{
    // define a callable function for the grab function on the exit cube
    public void exit()
    {
        // Call the scene manager and load the 'menu' scene
        SceneManager.LoadScene("Menu");
    }   
}
