using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{
    public GameObject optionCanvas;

    public void OptionEnable()
    {
        optionCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
