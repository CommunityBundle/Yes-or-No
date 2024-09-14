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
    public GameObject laptop;
    private Collider laptopCollider;
    public InputRelaySource laptopControls;
    public InputRelaySource laptopControlsEverything;

    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera laptopViewCamera;

    private void Start()
    {
        laptopCollider = laptop.GetComponent<Collider>();
    }
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
        playerController.enabled = false;
        laptopCameraInteraction.SetActive(true);
        laptopControls.enabled = true;
        laptopControlsEverything.enabled = true;
        laptopCollider.enabled = false;

    }
}
