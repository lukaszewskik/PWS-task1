using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    PlayerInteraction playerInteraction;
    readonly float maxDistanceToPlayer = 2;

    private void Awake()
    {
        playerInteraction = FindObjectOfType<PlayerInteraction>();
    }

    public virtual void Interact()
    {
        Debug.Log("Interaction");
    }

    public virtual bool CanInteract()
    {
        float distance;
        distance = Vector3.Distance(transform.position, playerInteraction.transform.position);

        if (distance <= maxDistanceToPlayer)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInteraction.SubscribeInteractable(this);
        }      
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInteraction.UnsubscribeInteractable();
        }
    }
}
