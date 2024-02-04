using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionDisabler : MonoBehaviour
{   

    private XRGrabInteractable interactor = null;


    private void OnEnable()
    {
        interactor = GetComponent<XRGrabInteractable>();
        if (interactor == null)
            Debug.Log("NULL PUTEEEE");
        //interactor.onSelectEntered.AddListener(DisableCollision);
        //interactor.onSelectExited.AddListener(EnableCollision);

    }

    private void OnDisable()
    {
        interactor = GetComponent<XRGrabInteractable>();
        //interactor.onSelectEntered.RemoveListener(DisableCollision);
        //interactor.onSelectExited.RemoveListener(EnableCollision);
    }

    private void DisableCollision(XRBaseInteractable interactable) 
    { 

        if (interactor != null)
        {
            foreach (Collider collider in interactable.colliders)
            {
                Debug.Log("DISABLE COLLISION");
                collider.enabled = false;
            }
        }
    }

    private void EnableCollision(XRBaseInteractable interactable)
    {
        if (interactor != null)
        {
            foreach (Collider collider in interactable.colliders)
            {
                Debug.Log("ENABLE COLLISION");
                collider.enabled = true;
            }
        }
    }
}
