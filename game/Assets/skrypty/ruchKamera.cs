using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchKamera : MonoBehaviour
{
    public GameObject kula;

    public Vector3 dystans;
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = kula.transform.position + dystans;
    }
}
