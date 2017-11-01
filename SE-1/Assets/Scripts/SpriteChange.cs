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
    public Sprite GoodJob;
    public Sprite Fail;
    private bool GBool;
    public bool B;
    public bool Text;
    public int CountMouse1 = 0;
    public int CountMouse0 = 0;
    public int OBCount = 0;
    public AudioSource GSound;
    public AudioSource SecretSound;
    public void Bevestiging()
    {
     if (gameObject.GetComponent<SpriteRenderer>().sprite == OrangeButton)
        {
            CountMouse1 = 100;
        }
    }
    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
        GBool = true;
        B = false;
        Text = false;

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
                CountMouse1 = 11;
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
                SecretSound.Play();
                OBCount++;
                B = true;
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
       if (CountMouse1 == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
            B = false;
        }
        if (B == true)
        {
            if (OBCount == 1)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                 gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Text = true;
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }

            }
            if (OBCount == 2)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Text = true;
                }
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }

            }
            if (OBCount == 3)
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Text = true;
                }
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
            }
            if (OBCount == 4)
            {
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Text = true;
                }
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }

            }
            if (OBCount == 5)
            {
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Text = true;
                }
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                    B = false;
                }
            }
            if (OBCount == 6)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Fail;
                CountMouse1 = -1;
            }

        }

        // Sets Main scene
        // SceneManager.LoadScene("Main", LoadSceneMode.Additive);

    }

}
//this.gameObject.GetComponent<SpriteRenderer>().sprite == BlueButton
//gameObject.GetComponent<SpriteRenderer>().sprite == RedButton