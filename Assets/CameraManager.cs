using Cinemachine;
using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject playerState;
    public GameObject computerState;
    public CameraManager camManager;
    public SUPERCharacterAIO controller;

    public float interactRange = 4;
    public LayerMask interactableLayer = -1;

    private CinemachineVirtualCamera playerCam;
    private CinemachineVirtualCamera computerCam;

    private void Start()
    {
        playerCam = playerState.GetComponentInChildren<CinemachineVirtualCamera>();
        camManager = playerState.GetComponent<CameraManager>();
        controller = playerState.GetComponent<SUPERCharacterAIO>();
        computerCam = computerState.GetComponentInChildren<CinemachineVirtualCamera>();
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            CameraSwitching();
        } 
    }
    bool CameraSwitching()
    {
        RaycastHit h;
        if (Physics.SphereCast(playerCam.transform.position, 0.25f, playerCam.transform.forward, out h, interactRange, interactableLayer, QueryTriggerInteraction.Ignore))
        {
            IInteractable i = h.collider.GetComponent<IInteractable>();
            if (i != null)
            {
                (playerCam.Priority, computerCam.Priority) = (computerCam.Priority, playerCam.Priority);
                camManager.enabled = false;
                controller.crosshairImg.gameObject.SetActive(false);
                controller.enableMovementControl = false;
                controller.enableCameraControl = false;

                return false;
            }
        }
        return false;
    }
}
