using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour {

    public GameObject clue;
    public GameObject inspect;

    private void OnTriggerStay(Collider other)
    {
        inspect.gameObject.SetActive(true);

        if (Input.GetKeyDown("e"))
        {
            clue.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inspect.gameObject.SetActive(false);
        clue.gameObject.SetActive(false);
    }
}
