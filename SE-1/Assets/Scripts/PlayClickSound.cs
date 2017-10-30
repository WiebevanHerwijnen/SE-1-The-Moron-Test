using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClickSound : MonoBehaviour {

    public AudioClip Gneurshk;

	// Use this for initialization
	void Start () {

        gameObject.AddComponent<AudioSource>();
        GetComponent<AudioSource>().clip = Gneurshk;
        //GetComponent<AudioSource>().Play;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
