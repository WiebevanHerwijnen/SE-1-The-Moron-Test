using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClickSound : MonoBehaviour {

    public AudioClip gneurshk;

	// Use this for initialization
	void Start () {

        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = gneurshk;
        //GetComponent<AudioSource>().Play;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
