using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1f, 0, 0);
            transform.Rotate(new Vector3(0f, 0f, -1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
           rb.AddForce(-1f, 0, 0);
            transform.Rotate(new Vector3(0f, 0f, 1f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, 1f);
            transform.Rotate(new Vector3(1f, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -1f);
            transform.Rotate(new Vector3(-1f, 0f, 0f));
        }

    }
}
