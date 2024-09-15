using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;
using Cinemachine;
using Interfaces;
public class OutlineShown : MonoBehaviour
{
    public CinemachineVirtualCamera playerCamera;
    private float interactRange = 4f;
    private int interactableLayer = -1;
    RaycastHit h;
    void CheckCollision()
    {
        if (Physics.SphereCast(playerCamera.transform.position, 0.25f, playerCamera.transform.forward, out h, interactRange, interactableLayer, QueryTriggerInteraction.Ignore))
        {
            IOutlineable i = h.collider.GetComponent<IOutlineable>();
            i?.ShowOutline();
        }
    }

    
}
