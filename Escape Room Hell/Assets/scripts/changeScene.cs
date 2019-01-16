using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            //if the player collides with it change the scene
            SceneManager.LoadScene(2);
        }
    }
}
