﻿using System.Collections;
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
    public bool GBool;
    public bool RBool;
    public bool Nextmissionbool;
    public bool B;
    public int CountMouse1 = 0;
    public int CountMouse0 = 0;
    public int OBCount;
    public AudioSource Legend;
    
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
        GBool = true;
        RBool = true;
        B = false;
        Nextmissionbool = false;
        
        }
    public void LoadMission2()
    {
      if(this.gameObject.GetComponent<SpriteRenderer>().sprite == GoodJob)
        {
            Debug.Log("Good Job");
            SceneManager.LoadScene("Einde");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if(RBool == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                gameObject.GetComponent<SpriteRenderer>().sprite = RedButton;
                B = false;

            }
        }
       
        if (GBool == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                
                gameObject.GetComponent<SpriteRenderer>().sprite = GreenButton;
                CountMouse1++;
            }
        }
        if (CountMouse1 == 1)
        {
            B = false;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                gameObject.GetComponent<SpriteRenderer>().sprite = BlueButton;
                
            }

        }
        if (CountMouse1 == 6)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                CountMouse1 = 5;
            }
        }
        
        if(CountMouse1 == 4)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                CountMouse1 = 3;
            }
            
        }
        if (CountMouse1 == 3)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                CountMouse1 = 4;
            }
        }

        if (CountMouse1 == 8)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = PurpleButton;
                RBool = false;
                CountMouse1 = 0;
            }
        
        }

        if (CountMouse1 == 11)
        {
            
            
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                CountMouse0 = 9000;
                gameObject.GetComponent<SpriteRenderer>().sprite = OrangeButton;
                CountMouse1 = 0;
                OBCount++;
                Legend.Play();
                B = true;
            } 
        }
        
        if (CountMouse1 == 12)
        {
            CountMouse1 = 0;
            
        }
        if (B == true)
        {
            if (OBCount == 1)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Nextmissionbool = true;
                    CountMouse1 = -1;
                    RBool = false;
                    GBool = false;
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
                if (Input.GetKeyDown(KeyCode.Alpha2 ))
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = GoodJob;
                    Nextmissionbool = true;
                    CountMouse1 = -1;
                    RBool = false;
                    GBool = false;
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
                    Nextmissionbool = true;
                    CountMouse1 = -1;
                    RBool = true;
                    GBool = false;
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
                    Nextmissionbool = true;
                    CountMouse1 = -1;
                    RBool = false;
                    GBool = false;
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
                    Nextmissionbool = true;
                    CountMouse1 = -1;
                    RBool = false;
                    GBool = false;
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
                RBool = false;
                Nextmissionbool = true;
                GBool = false;
            }

        }
    }

}
//this.gameObject.GetComponent<SpriteRenderer>().sprite == BlueButton
//gameObject.GetComponent<SpriteRenderer>().sprite == RedButton