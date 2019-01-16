using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorSound : MonoBehaviour {

    public AudioSource sound;

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown("q"))
        {
            sound.Play();
        }

    }
}
