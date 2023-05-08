using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class locomotionCotroller : MonoBehaviour
{
    // set up teleportation ray and set the activation threshold trigger value
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // Set the teleportation ray to active if the ray component can be found (allows modularity)
        if (rightTeleportRay)
            {
                rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
            }
    }

    // check if the teleportation ray is currently active
    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
