using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knifecollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("knife"))
        {


            Time.timeScale = 0f;
            Debug.Log(collision.gameObject.name);
        }
    }
}
