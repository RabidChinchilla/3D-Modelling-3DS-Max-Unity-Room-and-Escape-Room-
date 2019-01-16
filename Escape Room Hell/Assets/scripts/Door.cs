using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public AudioSource sound;
    public GameObject Player;
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
            interact.SetActive(true);
            if (Input.GetKeyDown("q"))
            {
                Destroy(gameObject, 10.0f);
                interact.SetActive(false);
                sound.Play();
                doorAnim.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interact.SetActive(false);
    }
}
