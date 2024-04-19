using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Add or remove an InteractionEvent component to this game object.
    private bool useEvents;
    // Message displayed to player when looking at an interactable
    [SerializeField] protected string promptMessage;

    public string GetPromptMessage()
    {
        return promptMessage;
    }

    // This function will be called from our player
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    { 
        // We wont have any code written in this function
        // this is a template funcction to be overriden by our subclasses
    }
}
