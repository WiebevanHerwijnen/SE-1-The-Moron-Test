using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SM_Button_FM : MonoBehaviour {

    public void WrongButton()
    {
        SceneManager.LoadScene("FailedMission");
    }

}
