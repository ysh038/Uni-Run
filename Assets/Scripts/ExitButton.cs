using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject optionCanvas;
    // Start is called before the first frame update
    public void closeWindow()
    {
        optionCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
