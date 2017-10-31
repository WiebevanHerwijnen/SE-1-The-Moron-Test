using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteChange : MonoBehaviour {
    public Sprite BlueButton;
    public Sprite RedButton;
    public Sprite GreenButton;
    public Sprite PurpleButton;
    public Sprite OrangeButton;
    private bool GBool;
    public int CountMouse1 = 0;
    public int CountMouse0 = 0;
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
                CountMouse1++;
            }
        }
        

        if (CountMouse1 == 2)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = PurpleButton;
                CountMouse1++;
            }
        
        }

        if (CountMouse1 == 10)
        {
            
            // Set counter for Orange Button; Reset Mouse Counter
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                CountMouse0 = 9000;
                gameObject.GetComponent<SpriteRenderer>().sprite = OrangeButton;
                CountMouse1 = 0;
            } 
        }
        if (CountMouse1 == 11)
        {
            CountMouse1 = 0;
        }

         //Switch Scenes as Orange Button appears
       if (CountMouse0 == 9000)
       {
            Debug.Log("That's Indeed Orange"); // Print so OrangeButton can be seen in Console


        }

        // Sets Main scene
        // SceneManager.LoadScene("Main", LoadSceneMode.Additive);

    }

}
//this.gameObject.GetComponent<SpriteRenderer>().sprite == BlueButton
//gameObject.GetComponent<SpriteRenderer>().sprite == RedButton