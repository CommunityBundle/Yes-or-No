using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using UnityEngine;

public class LaptopController : MonoBehaviour, IInteractable
{
    public SUPERCharacterAIO playerController;
    public bool Interact()
    {
        Debug.Log("Activate Computer");
        return false;
    }
}
