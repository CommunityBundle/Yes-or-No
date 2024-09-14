using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using SUPERCharacter;
using UnityEngine;

public class LaptopController : MonoBehaviour, IInteractable
{
    public SUPERCharacterAIO playerController;
    
    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera laptopViewCamera;
    public bool Interact()
    {
        StartCoroutine(TransitioningStates());
        return false;
    }

    IEnumerator TransitioningStates()
    {
        playerController.crosshairImg.gameObject.SetActive(false);
        laptopViewCamera.Priority += playerCamera.Priority;
        yield return new WaitForSeconds(1.2f);
        Debug.Log("Change state to Computer movement");
        playerController.enabled = false;
    }
}
