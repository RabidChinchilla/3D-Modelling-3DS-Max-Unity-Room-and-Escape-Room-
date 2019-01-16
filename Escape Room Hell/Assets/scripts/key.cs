using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

    public GameObject Player;
    public GameObject pickUp;

    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        pickUp.SetActive(true);
        if (Input.GetKeyDown("q"))
        {
            pickUp.SetActive(false);
            levelProgression.keyCollected = true;
            Destroy(gameObject);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        pickUp.SetActive(false);
    }
}
