using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void gameStart()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
