using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float angle;
    public ParticleSystem part1;
    public ParticleSystem part2;
    private AudioSource AvtoSound;
    public GameObject car;
    void Start()
    {
        AvtoSound = car.GetComponent<AudioSource>();
    }
    void AvtoSoundPlay()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            AvtoSound.Play();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            AvtoSound.Pause();
        }

    }
    void CarEffectPlay()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            part1.Play();
            part2.Play();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            part1.Stop();
            part2.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        WASDController();
        CarEffectPlay();
        AvtoSoundPlay(); 
    }
    void WASDController()
    {
        Vector3 pos0ffset = gameObject.transform.position;
        Vector3 rot0ffset = Vector3.zero;
        //Time.deltaTime
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos0ffset += Time.deltaTime * speed * gameObject.transform.forward;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos0ffset -= Time.deltaTime * speed * gameObject.transform.forward;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rot0ffset = new Vector3(0f, -Time.deltaTime * angle, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rot0ffset = new Vector3(0f, Time.deltaTime * angle, 0f);

        }
        gameObject.transform.position = pos0ffset;
        gameObject.transform.Rotate(rot0ffset);

    }
}

