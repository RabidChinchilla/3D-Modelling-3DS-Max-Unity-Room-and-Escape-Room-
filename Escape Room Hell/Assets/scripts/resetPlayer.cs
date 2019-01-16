using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour {

    public GameObject player;
    public Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        originalPosition = player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        LevelProgression levelProgression = player.GetComponent<LevelProgression>();
        if (other.tag == "Player")
        {
            levelProgression.died = true;
            player.transform.position = originalPosition;
        }
    }



}
