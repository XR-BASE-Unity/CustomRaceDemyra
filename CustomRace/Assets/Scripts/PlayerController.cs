using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float angle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos0ffset=gameObject.transform.position;
        Vector3 rot0ffset = Vector3.zero;
       //Time.deltaTime
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos0ffset += Time.deltaTime * speed* gameObject.transform.forward;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos0ffset -= Time.deltaTime * speed * gameObject.transform.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rot0ffset= new Vector3(0f, -Time.deltaTime * angle, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rot0ffset= new Vector3(0f, Time.deltaTime * angle, 0f);

        }
        gameObject.transform.position = pos0ffset;
        gameObject.transform.Rotate(rot0ffset);
       
    }
}
