using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class LaptopCamScript : MonoBehaviour, IInteractable
{
    bool isTriggered;
    public Camera computerCam;
    public bool Interact()
    {
        computerCam.enabled = true;
        return true;
    }

    public void Test()
    {
        Debug.Log("Camera activated");
    }
}
