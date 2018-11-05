using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public Animator anim;
    public GameObject Door;
	// Use this for initialization
	void Start () {
        anim = Door.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void OnTriggerStay () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("Door");
        }
	}
}
