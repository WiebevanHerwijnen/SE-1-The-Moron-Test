using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Library voor SceneManagement

public class SM_OS_S1 : MonoBehaviour {

    public void MissionCompleted()
    {
        Debug.Log("Invisible Button is clicked"); // print of de Invisible Button gebruikt wordt

        SceneManager.LoadScene("Main"); // Laad de scene Main in
    }

}
