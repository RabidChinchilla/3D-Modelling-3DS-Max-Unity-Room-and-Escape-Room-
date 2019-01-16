using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnKeyPress : MonoBehaviour {

    public AudioSource sound;
    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (levelProgression.cakeCollected == true && levelProgression.goldCollected == true && levelProgression.swordCollected == true)
        {
            if (Input.GetKeyDown("q"))
            {
                sound.Play();
            }
        }
    }
}
