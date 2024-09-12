using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject playerState;
    public GameObject computerState;

    public float interactRange = 4;
    public LayerMask interactableLayer = -1;

    private Camera playerCam;
    private Camera computerCam;

    private void Start()
    {
        playerCam = playerState.GetComponentInChildren<Camera>();
        computerCam = computerState.GetComponentInChildren<Camera>();
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
                playerState.SetActive(false);
                computerState.SetActive(true);
            }
        }
        return false;
    }
}
