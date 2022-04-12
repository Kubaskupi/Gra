using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniec : MonoBehaviour
{
    public GameObject sciana;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("koniec");
    }
}
