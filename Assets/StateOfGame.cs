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
        this.gameObject.transform.parent.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
