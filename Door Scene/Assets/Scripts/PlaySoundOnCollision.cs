using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour {

    public AudioClip alien;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = alien;
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
        GetComponent<AudioSource>().Play();
	}
}
