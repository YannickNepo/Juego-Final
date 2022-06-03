using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = originalPosition;
        originalPosition = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            gameObject.transform.position = originalPosition;
        }
    }

    void OnCollisionExit(Collision col2)
    {
        if (col2.gameObject.name == "Ground")
        {
            transform.position = originalPosition;
        }
    }

}
