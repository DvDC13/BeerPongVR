using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.isTrigger = true;
        Debug.Log("Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        other.isTrigger= false;
        Debug.Log("exit");
    }
}
