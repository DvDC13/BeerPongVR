using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine;
using UnityEngine.UIElements;

public class StateOfGame : MonoBehaviour
{
    public static int redCupsLeft = 13;
    public static int yellowCupsLeft = 13;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawnBall(Collider ball, int cup)
    {
        // 1 is for red bin and 2 is for yellow bin
        if (cup == 1)
        {
            ball.gameObject.transform.position = new Vector3(1.6f, 0.6f, 8.9f);
        }
        else if (cup == 2)
        {
            ball.gameObject.transform.position = new Vector3(1.6f, 0.5f, 0.7f);
        }
        ball.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SphereCollider>())
        {
            this.gameObject.transform.parent.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false); // or make it back in the bucket

            if (this.gameObject.transform.position.z <= 2.96) // yellow cups
            {
                yellowCupsLeft--; // to update score
                spawnBall(other, 1);
            }

            if (this.gameObject.transform.position.z >= 6.941) // red cups
            {
                redCupsLeft--; // to update score
                spawnBall(other, 2);
            }
            UIManager.instance.UpdateUI(redCupsLeft, yellowCupsLeft);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
