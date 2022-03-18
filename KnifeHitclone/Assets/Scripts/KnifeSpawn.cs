using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KnifeSpawn : MonoBehaviour
{
    public Transform spawnpoint;
    public static int remainedshots = 7;
    public GameObject Gameovermenu;
    



    public Rigidbody rb;
    public float throwforce = 90;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    
    void FixedUpdate()
    {
        rb.AddForce(Vector3.up *throwforce*10);
       // transform.Translate(Vector3.up*100*Time.deltaTime);
    }
    
    public void Knifespawn()
    {
        if (remainedshots > 0) { 
        Instantiate(rb, spawnpoint.transform.position, spawnpoint.transform.rotation);
            remainedshots--;
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        /*
         if (collision.collider.CompareTag("knife")) 
         {
             Gameovermenu.SetActive(true);

             Time.timeScale = 0f;
             Debug.Log(collision.gameObject.name);
         }
        */
        if (collision.collider.CompareTag("Log"))
         {
             rb.velocity = Vector3.zero;
             rb.isKinematic = true;
             this.transform.SetParent(collision.collider.transform);


         }

    }

}



