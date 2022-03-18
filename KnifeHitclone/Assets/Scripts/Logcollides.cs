using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logcollides : MonoBehaviour
{
    public Rigidbody bcak;
    void Start()
    {
        bcak = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Log"))
        {
            bcak.velocity = Vector3.zero;
            bcak.isKinematic = true;
            this.transform.SetParent(collision.collider.transform);


        }
        
    }
}
