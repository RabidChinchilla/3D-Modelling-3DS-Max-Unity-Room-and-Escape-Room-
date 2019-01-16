using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public AudioSource sound;
    public GameObject Player;
    public GameObject openDoor;
    public GameObject interact;

    public Animator doorAnim;

    void Start()
    {
        doorAnim = gameObject.GetComponent<Animator>();
        doorAnim.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (levelProgression.keyCollected == true)
        {
            openDoor.SetActive(true);
            interact.SetActive(true);
            if (Input.GetKeyDown("q"))
            {
                openDoor.SetActive(false);
                interact.SetActive(false);
                sound.Play();
                doorAnim.enabled = true;
            }
        }
    }
}
