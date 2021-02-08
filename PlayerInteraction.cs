using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    
    Interactable objectToInteract;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && objectToInteract)
        {
            InteractWithInteractable();
        }
    }

    void InteractWithInteractable()
    {
        if (objectToInteract.CanInteract())
        {
            objectToInteract.Interact();
        }
        
    }

    public void SubscribeInteractable(Interactable obj)
    {
        objectToInteract = obj;
    }

    public void UnsubscribeInteractable()
    {
        objectToInteract = null;
    }

}
