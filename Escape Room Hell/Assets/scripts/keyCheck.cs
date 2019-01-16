using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCheck : MonoBehaviour {

    public GameObject Player;
    public GameObject key;
    
	
	// Update is called once per frame
	void Update () {
        LevelProgression levelProgression = Player.GetComponent<LevelProgression>();
        if (levelProgression.soulCorrupted == true && levelProgression.died == true && levelProgression.laughedAt == true)
        {
            key.SetActive(true);
        }
    }
}
