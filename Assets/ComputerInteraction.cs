using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class ComputerInteraction : MonoBehaviour, IInteractable
{
    public SUPERCharacterAIO interacting;
    //TO DO: Move the camera, have it hit the computer.
    // Set Computer Interaction only when the computer camera is activated

    //Idea. Put a check on position whenever the camera moves near the visible border.
    //When check happens, rotate computer camera.

    //public Texture2D cursor;

    //private void Awake()
    //{
    //    CursorManagement();
    //    Cursor.lockState = CursorLockMode.Locked;
    //}
    //private void CursorManagement()
    //{
    //    Vector2 hotspot = new Vector2(cursor.width / 2, cursor.height / 2);
    //    Cursor.SetCursor(cursor, hotspot, CursorMode.Auto);
    //}
    public bool Interact()
    {
        Debug.Log("Activate Protocol");
        interacting.interactRange = 0;
        return false;
    }
}
