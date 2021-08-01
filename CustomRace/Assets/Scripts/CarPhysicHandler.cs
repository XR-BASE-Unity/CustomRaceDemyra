using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPhysicHandler : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.useGravity=false;
        rb.AddForce(new Vector3(0f, 1000f, 0f));
        rb.AddTorque(new Vector3(0f, 10f, 0f), ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {

    }
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("wall"))
        { 
            Debug.Log("It's wall");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("The end!");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("It's wall");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}


