using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetMoronTest : MonoBehaviour {

    public void ResetToOpening()
    {
        SceneManager.LoadScene("Opening");
    }
}
