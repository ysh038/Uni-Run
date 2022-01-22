using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    public void ReturnToTitle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}
