using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColliderDestroyer : MonoBehaviour
{
    private XRBaseInteractable interactable = null;
    void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
        if (interactable == null)
            Debug.Log("WEsh");
            
    }

    // Update is called once per frame
    void OnEnable()
    {
        // interactable.selectEntered.AddListener(disableCollider);
    }

    void enableCollider(XRBaseInteractable interactable)
    {
        foreach (Collider collider in interactable.colliders)
            collider.enabled = true;
    }


    void disableCollider(XRBaseInteractable interactable)
    {
        foreach (Collider collider in interactable.colliders)
            collider.enabled = false;
    }


}
