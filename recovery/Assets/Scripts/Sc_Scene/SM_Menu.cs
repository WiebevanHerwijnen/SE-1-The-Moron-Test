using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SM_Menu : MonoBehaviour {

    public void MenuOpenMoronTest()
    {
        SceneManager.LoadScene("Menu");
    }

    public void MenuContinueMoronTest()
    {
        SceneManager.LoadScene("Main");
    }

    public void ResetMoronTest()
    {
        SceneManager.LoadScene("Opening");
    }
}
