using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateOfGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SphereCollider>())
        {
            this.gameObject.transform.parent.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false); // or make it back in the bucket
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
