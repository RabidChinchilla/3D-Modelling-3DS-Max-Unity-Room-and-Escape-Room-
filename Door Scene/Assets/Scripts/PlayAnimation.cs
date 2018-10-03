using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

    public bool hasBeenOpened;

    private Animator doorOpening;
	// Use this for initialization
	void Start () {
        hasBeenOpened = true;

        doorOpening = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
