using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cake : MonoBehaviour {

    public GameObject Player;
    public GameObject pickUp;
    public GameObject inspect;
    public GameObject clue;

    private void OnTriggerStay(Collider other)
    {
        pickUp.SetActive(true);
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (Input.GetKeyDown("q"))
        {
            levelProgression.cakeCollected = true;
            pickUp.SetActive(false);
            inspect.SetActive(false);
            clue.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inspect.SetActive(false);
        clue.SetActive(false);
        pickUp.SetActive(false);
    }
}
