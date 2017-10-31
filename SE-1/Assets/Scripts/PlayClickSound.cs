using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClickSound : MonoBehaviour {

    public AudioSource GSound;
    

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GSound.Play();   
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GSound.Play();
        }
        
    }
}
