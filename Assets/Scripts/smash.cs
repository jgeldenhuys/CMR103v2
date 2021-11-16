using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    public GameObject brokenVersion;
    

    //private void OnTriggerEnter(Collider other)
    //{
    //    Instantiate(brokenVersion, transform.position, transform.rotation);
    //    Destroy(gameObject);
    //}

    private void OnCollisionEnter(Collision collision)
    {
                Instantiate(brokenVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    //yhujg
}
