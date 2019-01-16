using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corruptSoul : MonoBehaviour {

    public GameObject Player;
    public GameObject corruptInstruction;
    public GameObject pickUp;
    public GameObject inspect;
    public GameObject clue;

    public GameObject corruptSoulPrefab;
    public GameObject position;


    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (levelProgression.cakeCollected == true && levelProgression.goldCollected == true && levelProgression.swordCollected == true)
        {
            corruptInstruction.SetActive(true);
            if (Input.GetKeyDown("q"))
            {
                levelProgression.soulCorrupted = true;
                pickUp.SetActive(false);
                inspect.SetActive(false);
                clue.SetActive(false);
                corruptInstruction.SetActive(false);
                Instantiate(corruptSoulPrefab, position.transform.position, position.transform.rotation);
                Destroy(gameObject);
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        inspect.SetActive(false);
        clue.SetActive(false);
        pickUp.SetActive(false);
        corruptInstruction.SetActive(false);
    }
}
