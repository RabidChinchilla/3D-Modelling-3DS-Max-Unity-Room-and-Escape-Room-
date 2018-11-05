using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public Animator anim;
    public GameObject Door;

    public AudioClip DoorSound;
	// Use this for initialization
	void Start () {
        anim = Door.GetComponent<Animator>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = DoorSound;
    }
	
	// Update is called once per frame
	void OnTriggerStay () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("Door");
            GetComponent<AudioSource>().Play();
        }
	}
}
