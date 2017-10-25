using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {
    public Sprite BlueButton;
    public Sprite RedButton;
    public Sprite GreenButton;
    public Sprite PurpleButton;
    private bool GBool;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
        GBool = true;
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) { 
        
         gameObject.GetComponent<SpriteRenderer>().sprite = RedButton;
        }

        if (GBool == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                gameObject.GetComponent<SpriteRenderer>().sprite = GreenButton;
                GBool = false;
            }
        }
        

        if (gameObject.GetComponent<SpriteRenderer>().sprite == RedButton)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = PurpleButton;
            }
        
        }
    }

}
//this.gameObject.GetComponent<SpriteRenderer>().sprite == BlueButton