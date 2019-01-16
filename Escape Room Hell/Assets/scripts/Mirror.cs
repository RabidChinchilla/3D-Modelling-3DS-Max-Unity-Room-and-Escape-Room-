using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public GameObject Player;
    public GameObject clue;
    public GameObject inspect;
    public GameObject pickUp;

    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        pickUp.SetActive(true);
        if (Input.GetKeyDown("q"))
        {
            levelProgression.laughedAt = true;
            pickUp.SetActive(false);
            inspect.SetActive(false);
            clue.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inspect.SetActive(false);
        clue.SetActive(false);
        pickUp.SetActive(false);
    }
}
