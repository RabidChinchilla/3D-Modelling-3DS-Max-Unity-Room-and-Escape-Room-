using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (Input.GetKeyDown("e"))
        {
            levelProgression.goldCollected = true;
            Destroy(gameObject);
        }
    }
}
