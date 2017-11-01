using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEdit : MonoBehaviour {
    public GameObject ButtonObject;
    private SpriteChange OtherScript;
    private int CountMouse1;
    private bool TextE;



	// Use this for initialization
	void Start () {
        OtherScript = ButtonObject.GetComponent<SpriteChange>();
        CountMouse1 = OtherScript.CountMouse1;
        TextE = OtherScript.Text;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (TextE == true)
        {

        }
		
	}
}
