using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabObjectInteraction : MonoBehaviour
{
    // define the info screen and splash screen gameobjects
    public GameObject Info;
    public GameObject Splash;


    public void showInfo()
    {
        // when function called, set the info to active and hide the splash screen
        Info.SetActive(true);
        Splash.SetActive(false);
    }

    public void hideInfo()
    {
        // when function called, hide the info and set the splash screen to active
        Info.SetActive(false);
        Splash.SetActive(true);
    }
}
