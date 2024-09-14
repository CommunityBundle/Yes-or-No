using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using SUPERCharacter;
using UnityEngine;

public class LaptopController : MonoBehaviour, IInteractable
{
    public SUPERCharacterAIO playerController;
    public GameObject player;
    public GameObject laptopCameraInteraction;
    
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
        laptopViewCamera.Priority = 40;
        yield return new WaitForSeconds(1.2f);
        Debug.Log("Change state to Computer movement");
        player.SetActive(false);
        laptopCameraInteraction.SetActive(true);
    }
}
