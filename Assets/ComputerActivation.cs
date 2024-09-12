using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class ComputerActivation : MonoBehaviour, IInteractable
{
    bool setActivateComputer;
    public bool Interact()
    {
        if (!setActivateComputer)
        {
            Debug.Log("Use Computer");
            setActivateComputer = true;
            return true;
        }
        return false;
    }

    
}
